using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Campos.RemoverCampo;

public class RemoverCampoCommandValidator : ApplicationRequestValidator<RemoverCampoCommand>
{
    private readonly ICampoRepository _campoRepository;

    public RemoverCampoCommandValidator(
        ICampoRepository campoRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _campoRepository = campoRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave do campo é obrigatória.")
            .MustAsync(ValidarCampusExistenteAsync).WithMessage("A chave do campo não foi encontrada.");
    }

    private async Task<bool> ValidarCampusExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _campoRepository.ExistsAsync(key, token);
    }
}
