using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Deficiencias;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Deficiencias;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Deficiencias.ObterDeficiencia;

public class ObterDeficienciaQueryValidator : ApplicationRequestValidator<ObterDeficienciaQuery, DeficienciaDto>
{
    private readonly IDeficienciaRepository _deficienciaRepository;

    public ObterDeficienciaQueryValidator(
        IDeficienciaRepository deficienciaRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _deficienciaRepository = deficienciaRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave da deficiência é obrigatória.")
            .MustAsync(ValidarDeficienciaExistenteAsync).WithMessage("A chave da deficiência não foi encontrada.");
    }

    private async Task<bool> ValidarDeficienciaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _deficienciaRepository.ExistsAsync(key, token);
    }
}
