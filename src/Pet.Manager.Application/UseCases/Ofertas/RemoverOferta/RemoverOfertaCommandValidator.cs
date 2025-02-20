using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Ofertas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Ofertas.RemoverOferta;

public class RemoverOfertaCommandValidator : ApplicationRequestValidator<RemoverOfertaCommand>
{
    private readonly IOfertaRepository _ofertaRepository;

    public RemoverOfertaCommandValidator(
        IOfertaRepository ofertaRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _ofertaRepository = ofertaRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave da oferta é obrigatória.")
            .MustAsync(ValidarOfertaExistenteAsync).WithMessage("A chave da oferta não foi encontrada.");
    }

    private async Task<bool> ValidarOfertaExistenteAsync(Guid key, CancellationToken token)
    {
        return await _ofertaRepository.ExistsAsync(key, token);
    }
}
