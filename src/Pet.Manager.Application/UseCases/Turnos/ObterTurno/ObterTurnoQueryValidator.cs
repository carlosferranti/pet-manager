using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Turnos;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Turnos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Turnos.ObterTurno;

public class ObterTurnoQueryValidator : ApplicationRequestValidator<ObterTurnoQuery, TurnoDto>
{
    private readonly ITurnoRepository _turnoRepository;

    public ObterTurnoQueryValidator(
        INotificationContext notificationContext,
        ITurnoRepository turnoRepository) 
        : base(notificationContext)
    {
        _turnoRepository = turnoRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave do turno é obrigatória.")
            .MustAsync(ValidarTurnoExistenteAsync).WithMessage("A chave do turno não foi encontrada.");
    }

    private async Task<bool> ValidarTurnoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _turnoRepository.ExistsAsync(key, token);
    }
}
