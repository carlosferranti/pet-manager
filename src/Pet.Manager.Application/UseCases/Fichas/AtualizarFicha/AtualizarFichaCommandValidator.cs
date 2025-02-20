using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Etapas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Fichas.AtualizarFicha;

public class AtualizarFichaCommandValidator : ApplicationRequestValidator<AtualizarFichaCommand>
{
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;

    private const int LimiteMaximoNome = 100;
    private const int LimiteMaximoDescricao = 200;

    public AtualizarFichaCommandValidator(
        INotificationContext notificationContext,
        IEtapaTemplateRepository etapaTemplateRepository)
        : base(notificationContext)
    {
        _etapaTemplateRepository = etapaTemplateRepository;

        RuleFor(x => x.Nome)
            .NotEmpty()
            .WithMessage("O nome da ficha é obrigatório.")
            .MaximumLength(LimiteMaximoNome)
            .WithMessage("O nome da ficha deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.Descricao)
             .NotEmpty()
             .WithMessage("A descrição da ficha é obrigatória.")
             .MaximumLength(LimiteMaximoDescricao)
             .WithMessage("A descrição da ficha deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.Etapas)
            .NotEmpty()
            .WithMessage("As etapas da ficha são obrigatórias.");

        When(x => x.Etapas != null, () =>
        {
            RuleForEach(x => x.Etapas).ChildRules(etapa =>
            {
                etapa.RuleFor(x => x.Sequencia)
                .NotEmpty()
                .WithMessage("A sequencia da etapa é obrigatória.");

                etapa.RuleFor(x => x.EtapaKey)
                .NotEmpty()
                .WithMessage("A chave da etapa é obrigatória.")
                .MustAsync(ValidarEtapaExistenteAsync)
                .WithMessage("Chave da etapa não encontrada.");
            });
        });
    }

    private async Task<bool> ValidarEtapaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _etapaTemplateRepository.ExistsAsync(key, token);
    }
}