using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Campi;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campi;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Campi.ObterCampus;

public class ObterCampusQueryValidator : ApplicationRequestValidator<ObterCampusQuery, CampusDto>
{
    private readonly ICampusRepository _campusRepository;

    public ObterCampusQueryValidator(
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
