using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Enderecos.RemoverEstado;

public class RemoverEstadoCommandValidator : ApplicationRequestValidator<RemoverEstadoCommand>
{
    private readonly IEstadoRepository _estadoRepository;

    public RemoverEstadoCommandValidator(
        IEstadoRepository estadoRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _estadoRepository = estadoRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave do estado é obrigatória.")
            .MustAsync(ValidarEstadoExistenteAsync).WithMessage("A chave do estado não foi encontrada.");
    }

    private async Task<bool> ValidarEstadoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _estadoRepository.ExistsAsync(key, token);
    }
}