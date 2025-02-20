using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Marcas;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Marcas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Marcas.ObterMarca;

public class ObterMarcaQueryValidator : ApplicationRequestValidator<ObterMarcaQuery, MarcaDto>
{
    private readonly IMarcaRepository _marcaRepository;

    public ObterMarcaQueryValidator(
        IMarcaRepository marcaRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _marcaRepository = marcaRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave da marca é obrigatória.")
            .MustAsync(ValidarMarcaExistenteAsync).WithMessage("A chave da marca não foi encontrada.");
    }

    private async Task<bool> ValidarMarcaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _marcaRepository.ExistsAsync(key, token);
    }
}
