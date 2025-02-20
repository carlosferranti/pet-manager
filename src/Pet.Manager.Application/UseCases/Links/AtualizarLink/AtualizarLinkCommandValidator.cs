using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Links;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Links.AtualizarLink;

public class AtualizarLinkCommandValidator : ApplicationRequestValidator<AtualizarLinkCommand>
{
    private const int LimiteMaximoNome = 250;

    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly ILinkRepository _linkRepository;

    public AtualizarLinkCommandValidator(
        INotificationContext notificationContext,
        IFormaEntradaRepository formaEntradaRepository,
        ILinkRepository linkRepository)
        : base(notificationContext)
    {
        _formaEntradaRepository = formaEntradaRepository;
        _linkRepository = linkRepository;

        RuleFor(x => x.Key)
            .NotEmpty()
            .WithMessage("A chave do link é obrigatória.")
            .MustAsync(ValidarLinkExistenteAsync)
            .WithMessage("A chave do link não foi encontrada.");

        RuleFor(x => x.Nome)
            .NotEmpty()
            .WithMessage("O nome do link é obrigatório.")
            .MaximumLength(LimiteMaximoNome)
            .WithMessage("O nome do link deve ter no máximo {MaxLength} caracteres.");

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

    private async Task<bool> ValidarLinkExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _linkRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarFormaEntradaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _formaEntradaRepository.ExistsAsync(key, token);
    }
}