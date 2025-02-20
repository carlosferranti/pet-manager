using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Modalidades;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.DTOs.TiposFormacao;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.TiposFormacao;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.TiposFormacao.PesquisarTipoFormacao;

public class PesquisarTipoFormacaoQueryHandler : IQueryHandler<PesquisarTipoFormacaoQuery, ResultadoPaginadoDto<TipoFormacaoDto>>
{
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public PesquisarTipoFormacaoQueryHandler(
        ITipoFormacaoRepository tipoFormacaoRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository)
    {
        _tipoFormacaoRepository = tipoFormacaoRepository;
        _integracaoSistemaRepository = integracaoSistemaRepository;
    }

    public async Task<ResultadoPaginadoDto<TipoFormacaoDto>> Handle(PesquisarTipoFormacaoQuery request, CancellationToken cancellationToken)
    {
        var query = from tipo in _tipoFormacaoRepository.GetQueryable()
                    join integracao in _integracaoSistemaRepository.GetQueryable()
                        on tipo.IntegracaoTipoFormacao!.IntegracaoSistemaId equals integracao.Id into integracaoJoin
                    from integracaoSistema in integracaoJoin.DefaultIfEmpty()
                    select new TipoFormacaoDto()
                    {
                        Key = tipo.Key,
                        Nome = tipo.Nome,
                        Integracao = integracaoSistema != null ? new SistemaIntegracaoDto()
                        {
                            CodigoOrigem = tipo.IntegracaoTipoFormacao!.CodigoOrigem,
                            NomeSistema = integracaoSistema.Nome
                        } : null
                    };

        if (!string.IsNullOrEmpty(request.Filtros?.Nome))
        {
            query = query.Where(o => o.Nome.ToUpper().Contains(request.Filtros.Nome.ToUpper()));
        }

        int totalRegistros = await query.CountAsync();

        var queryResult = query
            .OrderBy(o => o.Nome)
            .Skip(request.Paginacao.QuantidadeRegistros * (request.Paginacao.NumeroPagina - 1))
            .Take(request.Paginacao.QuantidadeRegistros);

        return new ResultadoPaginadoDto<TipoFormacaoDto>(
            await queryResult.ToListAsync(cancellationToken),
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros
        );
    }
}