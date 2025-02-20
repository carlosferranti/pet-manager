using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.FormasEntrada;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Links.CriarLink;

public class CriarLinkCommandValidator : ApplicationRequestValidator<CriarLinkCommand, EntityKeyDto?>
{
    private const int LimiteMaximoNome = 250;

    private readonly IFormaEntradaRepository _formaEntradaRepository;

    public CriarLinkCommandValidator(
        INotificationContext notificationContext,
        IFormaEntradaRepository formaEntradaRepository)
        : base(notificationContext)
    {
        _formaEntradaRepository = formaEntradaRepository;

        RuleFor(x => x.Nome)
            .NotEmpty()
            .WithMessage("O nome do link é obrigatório.")
            .MaximumLength(LimiteMaximoNome)
            .WithMessage("O nome do link deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.FormasEntrada)
           .NotEmpty()
           .WithMessage("As chaves das formas de entrada são obrigatórias.");

        When(x => x.FormasEntrada != null, () =>
        {
            RuleForEach(x => x.FormasEntrada).ChildRules(formaEntrada =>
            {
                formaEntrada.RuleFor(x => x.Key)
                .NotEmpty().WithMessage("A chave da forma de entrada é obrigatória.")
                .MustAsync(ValidarFormaEntradaExistenteAsync).WithMessage("A chave da forma de entrada não foi encontrada.");
            });
        });
    }

    private async Task<bool> ValidarFormaEntradaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _formaEntradaRepository.ExistsAsync(key, token);
    }
}