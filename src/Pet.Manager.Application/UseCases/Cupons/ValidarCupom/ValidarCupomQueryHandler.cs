using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Cupons;
using Anima.Inscricao.Domain.Cupons;
using Anima.Inscricao.Domain.OfertaConcursos;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Cupons.ValidarCupom;

public class ValidarCupomQueryHandler : IQueryHandler<ValidarCupomQuery, ValidarCupomResultadoDto>
{
    private readonly ICupomRepository _cupomRepository;
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;

    public ValidarCupomQueryHandler(ICupomRepository cupomRepository, IOfertaConcursoRepository ofertaConcursoRepository)
    {
        _cupomRepository = cupomRepository;
        _ofertaConcursoRepository = ofertaConcursoRepository;
    }

    public async Task<ValidarCupomResultadoDto> Handle(ValidarCupomQuery request, CancellationToken cancellationToken)
    {

        var query = from ofertaconcurso in _ofertaConcursoRepository.GetQueryable()
                    join cupom in _cupomRepository.GetQueryable()
                        on ofertaconcurso.ConcursoId equals cupom.ConcursoId
                    where cupom.Codigo == request.CodigoCupom
                          && ofertaconcurso.Key == request.OfertaConcursoKey
                          && cupom.ConcursoId == ofertaconcurso.ConcursoId
                    select cupom;


        var cupons = await query.ToListAsync(cancellationToken);

        if (!cupons.Any())
        {
            return ValidarCupomResultadoDto.Fail("Cupom não encontrado.");
        }

        var cupomValido = cupons.Exists(c => !c.DataValidade.HasValue || DateTime.UtcNow <= c.DataValidade);

        if (!cupomValido)
        {
            return ValidarCupomResultadoDto.Fail("O cupom está expirado.");
        }

        return ValidarCupomResultadoDto.Success();
    }
}
