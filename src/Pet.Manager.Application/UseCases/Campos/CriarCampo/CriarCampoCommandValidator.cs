using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Campos.CriarCampo;

public class CriarCampoCommandValidator : ApplicationRequestValidator<CriarCampoCommand, EntityKeyDto?>
{
    private const int LimiteMaximoNome = 100;

    public CriarCampoCommandValidator(INotificationContext notificationContext)
        : base(notificationContext)
    {
        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O nome do campo é obrigatório.")
            .MaximumLength(LimiteMaximoNome)
            .WithMessage("O nome do campo deve ter no máximo {MaxLength} caracteres.");
    }
}