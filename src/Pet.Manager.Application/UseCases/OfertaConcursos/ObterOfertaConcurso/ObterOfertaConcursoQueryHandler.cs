using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.OfertaConcursos;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.OfertaConcursos.ObterOfertaConcurso;

public class ObterOfertaConcursoQueryHandler : IQueryHandler<ObterOfertaConcursoQuery, OfertaConcursoDto>
{
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IConcursoRepository _concursoRepository;

    public ObterOfertaConcursoQueryHandler(
        IOfertaConcursoRepository ofertaConcursoRepository, 
        IOfertaRepository ofertaRepository, 
        IConcursoRepository concursoRepository)
    {
        _ofertaConcursoRepository = ofertaConcursoRepository;
        _ofertaRepository = ofertaRepository;
        _concursoRepository = concursoRepository;
    }

    public async Task<OfertaConcursoDto> Handle(ObterOfertaConcursoQuery request, CancellationToken cancellationToken)
    {
        var query = from ofertaConcurso in _ofertaConcursoRepository.GetQueryable()
                    join oferta in _ofertaRepository.GetQueryable()
                        on ofertaConcurso.OfertaId equals oferta.Id
                    join concurso in _concursoRepository.GetQueryable()
                        on ofertaConcurso.ConcursoId equals concurso.Id
                    where ofertaConcurso.Key == request.Key
                    select new OfertaConcursoDto
                    {
                        Key = ofertaConcurso.Key,
                        OfertaKey = oferta.Key,
                        ConcursoKey = concurso.Key,
                    };

        return await query.SingleAsync();
    }
}
