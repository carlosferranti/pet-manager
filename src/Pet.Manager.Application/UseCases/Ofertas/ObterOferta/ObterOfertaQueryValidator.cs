using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Ofertas;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Ofertas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Ofertas.ObterOferta;

public class ObterOfertaQueryValidator : ApplicationRequestValidator<ObterOfertaQuery, OfertaDto>
{
    private readonly IOfertaRepository _ofertaRepository;

    public ObterOfertaQueryValidator(
        IOfertaRepository ofertaRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _ofertaRepository = ofertaRepository;

        RuleFor(x => x.Key)
           .NotEmpty().WithMessage("A chave da oferta é obrigatória.")
           .MustAsync(ValidarOfertaExistenteAsync).WithMessage("A chave da oferta não foi encontrada.");
    }

    private async Task<bool> ValidarOfertaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _ofertaRepository.ExistsAsync(key, token);
    }
}
