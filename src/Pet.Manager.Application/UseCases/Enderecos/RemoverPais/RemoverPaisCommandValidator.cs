using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Enderecos.RemoverPais;

public class RemoverPaisCommandValidator : ApplicationRequestValidator<RemoverPaisCommand>
{
    private readonly IPaisRepository _paisRepository;

    public RemoverPaisCommandValidator(
        IPaisRepository paisRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _paisRepository = paisRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave do país é obrigatória.")
            .MustAsync(ValidarPaisExistenteAsync).WithMessage("A chave do país não foi encontrada.");
    }

    private async Task<bool> ValidarPaisExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _paisRepository.ExistsAsync(key, token);
    }
}
