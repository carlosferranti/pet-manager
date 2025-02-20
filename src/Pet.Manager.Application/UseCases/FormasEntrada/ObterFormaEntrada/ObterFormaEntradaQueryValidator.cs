using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.FormasEntrada;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.FormasEntrada;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.FormasEntrada.ObterFormaEntrada;

public class ObterFormaEntradaQueryValidator : ApplicationRequestValidator<ObterFormaEntradaQuery, FormaEntradaDto>
{
    private readonly IFormaEntradaRepository _formaEntradaRepository; 

    public ObterFormaEntradaQueryValidator(
        IFormaEntradaRepository formaEntradaRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _formaEntradaRepository = formaEntradaRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave da forma de entrada é obrigatória.")
            .MustAsync(ValidarFormaEntradaExistenteAsync).WithMessage("A chave da forma de entrada não foi encontrada.");
    }

    private async Task<bool> ValidarFormaEntradaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _formaEntradaRepository.ExistsAsync(key, token);
    }
}