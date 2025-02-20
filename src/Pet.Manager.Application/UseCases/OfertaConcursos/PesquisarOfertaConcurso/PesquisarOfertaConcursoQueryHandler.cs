using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.OfertaConcursos;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.OfertaConcursos.PesquisarOfertaConcurso;

public class PesquisarOfertaConcursoQueryHandler : IQueryHandler<PesquisarOfertaConcursoQuery, ResultadoPaginadoDto<OfertaConcursoDto>>
{
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IConcursoRepository _concursoRepository;

    public PesquisarOfertaConcursoQueryHandler(
        IOfertaConcursoRepository ofertaConcursoRepository, 
        IOfertaRepository ofertaRepository, 
        IConcursoRepository concursoRepository)
    {
        _ofertaConcursoRepository = ofertaConcursoRepository;
        _ofertaRepository = ofertaRepository;
        _concursoRepository = concursoRepository;
    }

    public async Task<ResultadoPaginadoDto<OfertaConcursoDto>> Handle(PesquisarOfertaConcursoQuery request, CancellationToken cancellationToken)
    {
        var query = from ofertaConcurso in _ofertaConcursoRepository.GetQueryable().Include(x => x.OpcaoAcessos)
                    join oferta in _ofertaRepository.GetQueryable()
                        on ofertaConcurso.OfertaId equals oferta.Id
                    join concurso in _concursoRepository.GetQueryable()
                        on ofertaConcurso.ConcursoId equals concurso.Id
                    select new OfertaConcursoDto
                    {
                        Key = ofertaConcurso.Key,
                        OfertaKey = oferta.Key,
                        ConcursoKey = concurso.Key,
                        OpcaoAcesso = ofertaConcurso.OpcaoAcessos.Any() ?
                            ofertaConcurso.OpcaoAcessos.Select(x => x.TipoOpcaoAcesso).ToList()
                            : null,
                    };

        if (request.Filtros?.OfertaKey != null)
        {
            query = query.Where(o => o.OfertaKey == request.Filtros!.OfertaKey.Value);
        }

        if (request.Filtros?.ConcursoKey != null)
        {
            query = query.Where(o => o.ConcursoKey == request.Filtros!.ConcursoKey.Value);
        }

        int totalRegistros = await query.CountAsync();

        var queryResult = query
            .OrderBy(o => o.Key)
            .Skip(request.Paginacao.QuantidadeRegistros * (request.Paginacao.NumeroPagina - 1))
            .Take(request.Paginacao.QuantidadeRegistros);

        return new ResultadoPaginadoDto<OfertaConcursoDto>(
            await queryResult.ToListAsync(cancellationToken),
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros
            );
    }
}
