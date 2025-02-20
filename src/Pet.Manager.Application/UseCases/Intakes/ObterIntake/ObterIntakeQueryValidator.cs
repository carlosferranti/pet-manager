using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Intakes;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Intakes;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Intakes.ObterIntake;

public class ObterIntakeQueryValidator : ApplicationRequestValidator<ObterIntakeQuery, IntakeDto>
{
    private readonly IIntakeRepository _intakeRepository;

    public ObterIntakeQueryValidator(
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