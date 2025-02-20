using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Marcas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Marcas.RemoverMarca;

public class RemoverMarcaCommandValidator : ApplicationRequestValidator<RemoverMarcaCommand>
{
    private readonly IMarcaRepository _marcaRepository;

    public RemoverMarcaCommandValidator(
         IMarcaRepository marcaRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _marcaRepository = marcaRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave da marca é obrigatória.")
            .MustAsync(ValidarMarcaExistenteAsync).WithMessage("A chave da marca não foi encontrada.");
    }

    private async Task<bool> ValidarMarcaExistenteAsync(Guid key, CancellationToken token)
    {
        return await _marcaRepository.ExistsAsync(key, token);
    }
}
