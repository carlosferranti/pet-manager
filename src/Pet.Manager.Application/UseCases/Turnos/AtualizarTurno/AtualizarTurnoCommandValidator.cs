using System.ComponentModel;

using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Turnos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Turnos.AtualizarTurno;

public class AtualizarTurnoCommandValidator : ApplicationRequestValidator<AtualizarTurnoCommand>
{
    const int LimiteMaximoNome = 100;

    private readonly ITurnoRepository _turnoRepository;

    public AtualizarTurnoCommandValidator(
        INotificationContext notificationContext,
        ITurnoRepository turno) 
        : base(notificationContext)
    {
        _turnoRepository = turno;

        RuleFor(x => x.Nome)
            .NotEmpty()
            .WithMessage("O nome do turno é obrigatório.")
            .MaximumLength(LimiteMaximoNome).WithMessage("O nome do turno deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.Key)
            .NotEmpty()
            .WithMessage("A chave do turno é obrigatória.")
            .MustAsync(ValidarTurnoExisteAsync).WithMessage("A chave do turno não foi encontrada.");

    }

    private async Task<bool> ValidarTurnoExisteAsync(Guid key, CancellationToken token = default)
    {
        return await _turnoRepository.ExistsAsync(key, token);
    }
}
