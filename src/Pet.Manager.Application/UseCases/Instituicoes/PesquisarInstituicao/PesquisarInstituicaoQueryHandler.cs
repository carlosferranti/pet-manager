using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Instituicao;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Domain.Campi.Entities;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Instituicoes.PesquisarInstituicao;

public class PesquisarInstituicaoQueryHandler : IQueryHandler<PesquisarInstituicaoQuery, ResultadoPaginadoDto<InstituicaoDto>>
{
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly IMarcaRepository _marcaRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public PesquisarInstituicaoQueryHandler(
        IInstituicaoRepository instituicaoRepository,
        IMarcaRepository marcaRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository)
    {
        _instituicaoRepository = instituicaoRepository;
        _marcaRepository = marcaRepository;
        _integracaoSistemaRepository = integracaoSistemaRepository;
    }

    public async Task<ResultadoPaginadoDto<InstituicaoDto>> Handle(PesquisarInstituicaoQuery request, CancellationToken cancellationToken)
    {
        var query = from ies in _instituicaoRepository.GetQueryable()
                    join marca in _marcaRepository.GetQueryable()
                        on ies.MarcaId equals marca.Id
                    from integracao in ies.IntegracaoInstituicao.DefaultIfEmpty()
                    join sistemaIntegracao in _integracaoSistemaRepository.GetQueryable()
                        on integracao.IntegracaoSistemaId equals sistemaIntegracao.Id into sistemaJoin
                    from sistema in sistemaJoin.DefaultIfEmpty()
                    group new { integracao, sistema } by new
                    {
                        ies.Key,
                        ies.Nome,
                        ies.Sigla,
                        MarcaKey = marca.Key
                    }
                    into g
                    select new InstituicaoDto
                    {
                        Key = g.Key.Key,
                        Nome = g.Key.Nome,
                        Sigla = g.Key.Sigla,
                        MarcaKey = g.Key.MarcaKey,
                        Integracoes = g
                            .Where(x => x.integracao != null && x.sistema != null)
                            .Select(x => new SistemaIntegracaoDto
                            {
                                CodigoOrigem = x.integracao.CodigoOrigem,
                                NomeSistema = x.sistema.Nome
                            })
                            .ToList()
                    };


        if (!string.IsNullOrEmpty(request.Filtros?.Nome))
        {
            query = query.Where(o => o.Nome.ToUpper().Contains(request.Filtros.Nome.ToUpper()));
        }

        if(request.Filtros?.MarcaKey != null)
        {
            query = query.Where(o => o.MarcaKey == request.Filtros!.MarcaKey.Value);
        }

        int totalRegistros = await query.CountAsync();

        var queryResult = query
            .OrderBy(o => o.Nome)
            .ThenBy(o => o.Key)
            .Skip(request.Paginacao.QuantidadeRegistros * (request.Paginacao.NumeroPagina - 1))
            .Take(request.Paginacao.QuantidadeRegistros);

        return new ResultadoPaginadoDto<InstituicaoDto>(
            await queryResult.ToListAsync(cancellationToken),
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros
        );
    }
}
