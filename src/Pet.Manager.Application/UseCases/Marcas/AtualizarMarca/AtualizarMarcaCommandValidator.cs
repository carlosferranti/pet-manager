using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Marcas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Marcas.AtualizarMarca;

public class AtualizarMarcaCommandValidator : ApplicationRequestValidator<AtualizarMarcaCommand>
{
    private const int LimiteMaximoNome = 100;
    private const int LimiteMaximoSigla = 50;

    private readonly IMarcaRepository _marcaRepository;

    public AtualizarMarcaCommandValidator(
        INotificationContext notificationContext,
        IMarcaRepository marcaRepository) 
        : base(notificationContext)
    {
        _marcaRepository = marcaRepository;

        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O nome da marca é obrigatório.")
            .MaximumLength(LimiteMaximoNome).WithMessage("O nome da marca deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave da marca é obrigatória.")
            .MustAsync(ValidarMarcaExistenteAsync).WithMessage("A chave da marca não foi encontrada.");

        When(x => x.Sigla != null, () =>
        {
            RuleFor(x => x.Sigla)
                .NotEmpty().WithMessage("A sigla da marca deve conter um valor valido.")
                .MaximumLength(LimiteMaximoSigla).WithMessage("A sigla da marca deve ter no máximo {MaxLength} caracteres.");
        });
    }

    private async Task<bool> ValidarMarcaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _marcaRepository.ExistsAsync(key, token);
    }
}
