using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Campos.AtualizarCampo;

public class AtualizarCampoCommandValidator : ApplicationRequestValidator<AtualizarCampoCommand>
{
    private const int LimiteMaximoNome = 100;

    private readonly ICampoRepository _campoRepository;

    public AtualizarCampoCommandValidator(
        INotificationContext notificationContext,
        ICampoRepository campoRepository)
        : base(notificationContext)
    {
        _campoRepository = campoRepository;

        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O nome do campo é obrigatório.")
            .MaximumLength(LimiteMaximoNome).WithMessage("O nome do campo deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave do campo é obrigatória.")
            .MustAsync(ValidarCampoExistenteAsync).WithMessage("A chave do campo não foi encontrada.");
    }

    private async Task<bool> ValidarCampoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _campoRepository.ExistsAsync(key, token);
    }
}
