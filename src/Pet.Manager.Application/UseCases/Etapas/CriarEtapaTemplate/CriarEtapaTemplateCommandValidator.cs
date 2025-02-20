using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Etapas.CriarEtapa;

public class CriarEtapaTemplateCommandValidator : ApplicationRequestValidator<CriarEtapaTemplateCommand, EntityKeyDto?>
{
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresDescricao = 200;

    public CriarEtapaTemplateCommandValidator(INotificationContext notificationContext)
        : base(notificationContext)
    {
        RuleFor(x => x.Nome)
            .NotEmpty()
            .WithMessage("O nome da etapa é obrigatório.")
            .MaximumLength(LimiteCaracteresNome)
            .WithMessage("O nome da etapa deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.Descricao)
            .NotEmpty()
            .WithMessage("A descrição da etapa é obrigatória.")
            .MaximumLength(LimiteCaracteresDescricao)
            .WithMessage("A descrição da etapa deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.NomeArquivo)
            .NotEmpty()
            .WithMessage("O nome do arquivo do template é obrigatório.")
            .MaximumLength(LimiteCaracteresNome)
            .WithMessage("O nome do arquivo do template deve ter no máximo {MaxLength} caracteres.");
    }
}
