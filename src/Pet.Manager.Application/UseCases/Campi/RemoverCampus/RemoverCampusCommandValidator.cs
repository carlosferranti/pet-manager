using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campi;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Campi.RemoverCampus;

public class RemoverCampusCommandValidator : ApplicationRequestValidator<RemoverCampusCommand>
{
    private readonly ICampusRepository _campusRepository;

    public RemoverCampusCommandValidator(
        ICampusRepository campusRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _campusRepository = campusRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave do campus é obrigatória.")
            .MustAsync(ValidarCampusExistenteAsync).WithMessage("A chave do campus não foi encontrada.");
    }

    private async Task<bool> ValidarCampusExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _campusRepository.ExistsAsync(key, token);
    }
}
