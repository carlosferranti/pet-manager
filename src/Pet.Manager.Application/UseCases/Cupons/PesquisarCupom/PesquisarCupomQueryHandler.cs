using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Cupons;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.Enums;
using Anima.Inscricao.Application.Extensions;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Cupons;
using Anima.Inscricao.Domain.Cupons.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Cupons.PesquisarCupom;

public class PesquisarCupomQueryHandler : IQueryHandler<PesquisarCupomQuery, ResultadoPaginadoDto<CupomDto>>
{
    private readonly ICupomRepository _cupomRepository;
    private readonly IConcursoRepository _concursoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public PesquisarCupomQueryHandler(
        ICupomRepository cupomRepository,
        IConcursoRepository concursoRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository)
    {
        _cupomRepository = cupomRepository;
        _concursoRepository = concursoRepository;
        _integracaoSistemaRepository = integracaoSistemaRepository;
    }

    public async Task<ResultadoPaginadoDto<CupomDto>> Handle(PesquisarCupomQuery request, CancellationToken cancellationToken)
    {
        var query = from cupom in _cupomRepository.GetQueryable()
                    join concurso in _concursoRepository.GetQueryable()
                        on cupom.ConcursoId equals concurso.Id
                    from integracao in _integracaoSistemaRepository.GetQueryable()
                         .Where(x => x.Id == cupom.IntegracaoCupom!.IntegracaoSistemaId).DefaultIfEmpty()
                    select new CupomDto()
                    {
                        Key = cupom.Key,
                        ConcursoKey = concurso.Key,
                        Codigo = cupom.Codigo,
                        Descricao = cupom.Descricao,
                        TipoDesconto = cupom.TipoDesconto,
                        DescricaoTipoDesconto = ((TipoDesconto)cupom.TipoDesconto).Description(),
                        ValorDesconto = cupom.ValorDesconto,
                        DataValidade = cupom.DataValidade,
                        ConcursoPeriodoLetivo = concurso.PeriodoLetivo,
                        Integracao = integracao != null ? new SistemaIntegracaoDto()
                        {
                            CodigoOrigem = cupom.IntegracaoCupom!.CodigoOrigem,
                            NomeSistema = integracao.Nome,
                        } : null
                    };

        if (!string.IsNullOrEmpty(request.Filtros?.Codigo))
        {
            query = query.Where(o => o.Codigo.Trim().ToUpper().Contains(request.Filtros.Codigo.Trim().ToUpper()));
        }

        if (request.Filtros?.ConcursoKey.HasValue == true)
        {
            query = query.Where(o => o.ConcursoKey.Equals(request.Filtros.ConcursoKey));
        }

        if (!string.IsNullOrEmpty(request.Filtros?.CodigoOrigem))
        {
            query = query.Where(o => o.Integracao!.CodigoOrigem == request.Filtros.CodigoOrigem);
        }

        if (!string.IsNullOrEmpty(request.Filtros?.PeriodoLetivo))
        {
            query = query.Where(o => o.ConcursoPeriodoLetivo == request.Filtros.PeriodoLetivo);
        }

        int totalRegistros = await query.CountAsync();

        var queryResult = query
            .OrderBy(o => o.Codigo)
            .Skip(request.Paginacao.QuantidadeRegistros * (request.Paginacao.NumeroPagina - 1))
            .Take(request.Paginacao.QuantidadeRegistros);

        return new ResultadoPaginadoDto<CupomDto>(
            await queryResult.ToListAsync(cancellationToken),
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros
        );
    }
}
