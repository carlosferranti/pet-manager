using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Campos;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Campos.ObterCampo;

public class ObterCampoQueryValidator : ApplicationRequestValidator<ObterCampoQuery, CampoDto>
{
    private readonly ICampoRepository _campoRepository;

    public ObterCampoQueryValidator(
        ICampoRepository campoRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _campoRepository = campoRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave do campo é obrigatória.")
            .MustAsync(ValidarCampoExistenteAsync).WithMessage("A chave do campo não foi encontrada.");
    }

    private async Task<bool> ValidarCampoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _campoRepository.ExistsAsync(key, token);
    }
}