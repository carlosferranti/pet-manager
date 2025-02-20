using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Fichas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Fichas.RemoverFicha;

public class RemoverFichaCommandValidator : ApplicationRequestValidator<RemoverFichaCommand>
{
    private readonly IFichaRepository _fichaRepository;

    public RemoverFichaCommandValidator(
        IFichaRepository fichaRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _fichaRepository = fichaRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave da ficha é obrigatória.")
            .MustAsync(ValidarFichaExistenteAsync).WithMessage("A chave da ficha não foi encontrada.");
    }

    private async Task<bool> ValidarFichaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _fichaRepository.ExistsAsync(key, token);
    }
}