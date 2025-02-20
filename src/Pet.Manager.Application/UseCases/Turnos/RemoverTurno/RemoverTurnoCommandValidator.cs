using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Turnos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Turnos.RemoverTurno;

public class RemoverTurnoCommandValidator : ApplicationRequestValidator<RemoverTurnoCommand>
{
    private readonly ITurnoRepository _turnoRepository;

    public RemoverTurnoCommandValidator(
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
