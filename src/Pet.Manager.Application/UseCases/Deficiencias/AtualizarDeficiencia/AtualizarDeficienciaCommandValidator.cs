using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Deficiencias;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Deficiencias.AtualizarDeficiencia;

public class AtualizarDeficienciaCommandValidator : ApplicationRequestValidator<AtualizarDeficienciaCommand>
{
    private const int LimiteMaximoNome = 100;

    private readonly IDeficienciaRepository _deficienciaRepository;

    public AtualizarDeficienciaCommandValidator(
        INotificationContext notificationContext,
        IDeficienciaRepository deficienciaRepository)
        : base(notificationContext)
    {
        _deficienciaRepository = deficienciaRepository;

        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O nome da deficiência é obrigatório.")
            .MaximumLength(LimiteMaximoNome)
            .WithMessage("O nome da deficiência deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.Key)
          .NotEmpty().WithMessage("A chave da deficiência é obrigatória.")
          .MustAsync(ValidarDeficienciaExistenteAsync).WithMessage("A chave da deficiência não foi encontrada.");
    }

    private async Task<bool> ValidarDeficienciaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _deficienciaRepository.ExistsAsync(key, token);
    }
}
