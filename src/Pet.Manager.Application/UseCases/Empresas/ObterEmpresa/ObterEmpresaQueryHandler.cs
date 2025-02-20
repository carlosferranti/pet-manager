using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Empresas;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Domain.Empresas;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Empresas.ObterEmpresa;

public class ObterEmpresaQueryHandler : IQueryHandler<ObterEmpresaQuery, EmpresaDto>
{
    private readonly IEmpresaRepository _empresaRepository;
    private readonly ICidadeRepository _cidadeRepository;
    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;

    public ObterEmpresaQueryHandler(
        IEmpresaRepository empresaRepository,
        ICidadeRepository cidadeRepository,
        IIntegracaoSistemaRepository sistemasIntegracaoRepository)
    {
        _empresaRepository = empresaRepository;
        _cidadeRepository = cidadeRepository;
        _sistemasIntegracaoRepository = sistemasIntegracaoRepository;
    }

    public async Task<EmpresaDto> Handle(ObterEmpresaQuery request, CancellationToken cancellationToken)
    {
        var query = from empresa in _empresaRepository.GetQueryable()
                    join integracao in _sistemasIntegracaoRepository.GetQueryable()
                        on empresa.IntegracaoEmpresa!.IntegracaoSistemaId equals integracao.Id into integracaoJoin
                    from integracaoSistema in integracaoJoin.DefaultIfEmpty()
                    from empresaEndereco in empresa.Enderecos.DefaultIfEmpty()
                    join cidade in _cidadeRepository.GetQueryable()
                        on empresaEndereco.CidadeId equals cidade.Id into cidadeJoin
                    from cidade in cidadeJoin.DefaultIfEmpty()
                    where empresa.Key == request.Key
                    select new EmpresaDto()
                    {
                        Key = empresa.Key,
                        Cnpj = empresa.Cnpj,
                        NomeFantasia = empresa.NomeFantasia,
                        RazaoSocial = empresa.RazaoSocial,
                        Integracao = integracaoSistema != null ? new SistemaIntegracaoDto()
                        {
                            CodigoOrigem = empresa.IntegracaoEmpresa!.CodigoOrigem,
                            NomeSistema = integracaoSistema.Nome
                        } : null,
                        Enderecos = empresa.Enderecos.Any() ? empresa.Enderecos.Select(e => new EmpresaEnderecoDto()
                        {
                            Key = e.Key,
                            Logradouro = e.Logradouro,
                            Cep = e.Cep,
                            Numero = e.Numero,
                            Complemento = e.Complemento,
                            Bairro = e.Bairro
                        }).ToList() : null,
                    };

        return await query.SingleAsync(cancellationToken);
    }
}
