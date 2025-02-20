using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Cupons;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Cupons;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Cupons.ObterCupom;

public class ObterCupomQueryValidator : ApplicationRequestValidator<ObterCupomQuery, CupomDto>
{
    private readonly ICupomRepository _cupomRepository;

    public ObterCupomQueryValidator(
        ICupomRepository cupomRepository,
        INotificationContext notificationContext) 
        : base(notificationContext)
    {
        _cupomRepository = cupomRepository;

        RuleFor(x => x.Key)
            .NotEmpty()
            .WithMessage("A chave do cupom é obrigatória.")
            .MustAsync(ValidarCupomExisteAsync)
            .WithMessage("A chave do cupom não foi encontrada.");

    }

    public async Task<bool> ValidarCupomExisteAsync(Guid key, CancellationToken token = default)
    {
        return await _cupomRepository.ExistsAsync(key, token);
    }
}
