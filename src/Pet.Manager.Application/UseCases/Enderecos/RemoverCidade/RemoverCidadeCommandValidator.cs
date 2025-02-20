using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Enderecos.RemoverCidade;

public class RemoverCidadeCommandValidator : ApplicationRequestValidator<RemoverCidadeCommand>
{
    private readonly ICidadeRepository _cidadeRepository;

    public RemoverCidadeCommandValidator(
        ICidadeRepository cidadeRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _cidadeRepository = cidadeRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave da cidade é obrigatória.")
            .MustAsync(ValidarCidadeExistenteAsync).WithMessage("A chave da cidade não foi encontrada.");
    }

    private async Task<bool> ValidarCidadeExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _cidadeRepository.ExistsAsync(key, token);
    }
}
