using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Cupons;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Cupons.RemoverCupom;

public class RemoverCupomCommandValidator : ApplicationRequestValidator<RemoverCupomCommand>
{
    private readonly ICupomRepository _cupomRepository;

    public RemoverCupomCommandValidator(
        ICupomRepository cupomRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _cupomRepository = cupomRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave do cupom é obrigatória.")
            .MustAsync(ValidarCupomExistenteAsync).WithMessage("A chave do cupom não foi encontrada.");
    }

    private async Task<bool> ValidarCupomExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _cupomRepository.ExistsAsync(key, token);
    }
}
