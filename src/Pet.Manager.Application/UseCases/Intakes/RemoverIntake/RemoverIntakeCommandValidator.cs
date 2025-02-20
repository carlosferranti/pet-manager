using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Intakes;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Intakes.RemoverIntake;

public class RemoverIntakeCommandValidator : ApplicationRequestValidator<RemoverIntakeCommand>
{
    private readonly IIntakeRepository _intakeRepository;

    public RemoverIntakeCommandValidator(
        IIntakeRepository intakeRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _intakeRepository = intakeRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave do intake é obrigatória.")
            .MustAsync(ValidarIntakeExistenteAsync).WithMessage("A chave do intake não foi encontrada.");
    }

    private async Task<bool> ValidarIntakeExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _intakeRepository.ExistsAsync(key, token);
    }
}
