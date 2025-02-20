using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Links;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Links.RemoverLink;

public class RemoverLinkCommandValidator : ApplicationRequestValidator<RemoverLinkCommand>
{
    private readonly ILinkRepository _linkRepository;

    public RemoverLinkCommandValidator(
        ILinkRepository linkRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _linkRepository = linkRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave do link é obrigatória.")
            .MustAsync(ValidarLinkExistenteAsync).WithMessage("A chave do link não foi encontrada.");
    }

    private async Task<bool> ValidarLinkExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _linkRepository.ExistsAsync(key, token);
    }
}