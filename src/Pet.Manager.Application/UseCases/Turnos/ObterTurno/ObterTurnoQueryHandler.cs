using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Turnos;
using Anima.Inscricao.Domain.Turnos;

namespace Anima.Inscricao.Application.UseCases.Turnos.ObterTurno;

public class ObterTurnoQueryHandler : IQueryHandler<ObterTurnoQuery, TurnoDto>
{
    private readonly ITurnoRepository _turnoRepository;

    public ObterTurnoQueryHandler(ITurnoRepository turnoRepository)
    {
        _turnoRepository = turnoRepository;
    }

    public async Task<TurnoDto> Handle(ObterTurnoQuery request, CancellationToken cancellationToken)
    {
        var turno = await _turnoRepository.GetAsync(request.Key);

        return new TurnoDto 
        { 
            Key = turno.Key, 
            Nome = turno.Nome, 
        };
    }
}
