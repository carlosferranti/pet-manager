using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Intakes;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Intakes.AtualizarIntake;

public class AtualizarIntakeCommandValidator : ApplicationRequestValidator<AtualizarIntakeCommand>
{
    private const int LimiteMaximoNome = 100;

    private readonly IIntakeRepository _intakeRepository;

    public AtualizarIntakeCommandValidator(
        IIntakeRepository intakeRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _intakeRepository = intakeRepository;

        RuleFor(x => x.Nome)
            .NotEmpty()
            .WithMessage("O nome do intake é obrigatório.")
            .MaximumLength(LimiteMaximoNome)
            .WithMessage("O nome do intake deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.VigenciaInicio)
            .NotEmpty()
            .WithMessage("Data de inicio da vigência inválida.");

        RuleFor(x => x.VigenciaTermino)
            .NotEmpty()
            .WithMessage("Data de término da vigência inválida.");

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave do intake é obrigatória.")
            .MustAsync(ValidarIntakeExistenteAsync).WithMessage("A chave do intake não foi encontrada.");
    }

    private async Task<bool> ValidarIntakeExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _intakeRepository.ExistsAsync(key, token);
    }
}