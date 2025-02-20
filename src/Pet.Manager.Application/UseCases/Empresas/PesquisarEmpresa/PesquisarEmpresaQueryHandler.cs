using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Empresas;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Domain._Shared.Formaters;
using Anima.Inscricao.Domain.Empresas;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using MediatR;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Empresas.PesquisarEmpresa;

public class PesquisarEmpresaQueryHandler : IQueryHandler<PesquisarEmpresaQuery, ResultadoPaginadoDto<EmpresaDto>>
{
    private readonly IEmpresaRepository _empresaRepository;
    private readonly ICidadeRepository _cidadeRepository;
    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;

    public PesquisarEmpresaQueryHandler(
        IEmpresaRepository empresaRepository,
        ICidadeRepository cidadeRepository,
        IIntegracaoSistemaRepository sistemasIntegracaoRepository)
    {
        _empresaRepository = empresaRepository;
        _cidadeRepository = cidadeRepository;
        _sistemasIntegracaoRepository = sistemasIntegracaoRepository;
    }

    public async Task<ResultadoPaginadoDto<EmpresaDto>> Handle(PesquisarEmpresaQuery request, CancellationToken cancellationToken)
    {
        var query = from empresa in _empresaRepository.GetQueryable()
                    join integracao in _sistemasIntegracaoRepository.GetQueryable()
                        on empresa.IntegracaoEmpresa!.IntegracaoSistemaId equals integracao.Id into integracaoJoin
                    from integracaoSistema in integracaoJoin.DefaultIfEmpty()
                    from empresaEndereco in empresa.Enderecos.DefaultIfEmpty()
                    join cidade in _cidadeRepository.GetQueryable()
                        on empresaEndereco.CidadeId equals cidade.Id into cidadeJoin
                    from cidade in cidadeJoin.DefaultIfEmpty()
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

        if (!string.IsNullOrWhiteSpace(request.Filtros?.Cnpj))
        {
            var cnpjNormalize = CnpjFormater.RemoverFormatacao(request.Filtros.Cnpj);
            query = query.Where(w => w.Cnpj.Equals(cnpjNormalize));
        }

        int totalRegistros = await query.CountAsync();

        var queryResult = query
            .OrderBy(o => o.NomeFantasia)
            .ThenBy(o => o.Key)
            .Skip(request.Paginacao.QuantidadeRegistros * (request.Paginacao.NumeroPagina - 1))
            .Take(request.Paginacao.QuantidadeRegistros);

        return new ResultadoPaginadoDto<EmpresaDto>(
                   await queryResult.ToListAsync(cancellationToken),
                   request.Paginacao.NumeroPagina,
                   request.Paginacao.QuantidadeRegistros,
                   totalRegistros);
    }
}