using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Enderecos;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Enderecos.ObterEstado;

public class ObterEstadoQueryValidator : ApplicationRequestValidator<ObterEstadoQuery, EstadoDto>
{
    private readonly IEstadoRepository _estadoRepository;

    public ObterEstadoQueryValidator(
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