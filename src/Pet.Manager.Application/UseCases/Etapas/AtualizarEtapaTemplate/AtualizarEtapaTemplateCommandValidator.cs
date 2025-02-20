using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Etapas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Etapas.AtualizarEtapaTemplate;

public class AtualizarEtapaTemplateCommandValidator : ApplicationRequestValidator<AtualizarEtapaTemplateCommand>
{
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresDescricao = 200;

    public AtualizarEtapaTemplateCommandValidator(
        INotificationContext notificationContext,
        IEtapaTemplateRepository etapaTemplateRepository)
        : base(notificationContext)
    {
        _etapaTemplateRepository = etapaTemplateRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave da etapa é obrigatória.")
           .MustAsync(ValidarEtapaExistenteAsync).WithMessage("A chave da etapa não foi encontrada.");

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

    private async Task<bool> ValidarEtapaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _etapaTemplateRepository.ExistsAsync(key, token);
    }
}