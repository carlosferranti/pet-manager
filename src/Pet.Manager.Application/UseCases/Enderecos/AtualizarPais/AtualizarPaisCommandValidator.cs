using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Enderecos.AtualizarPais;

public class AtualizarPaisCommandValidator : ApplicationRequestValidator<AtualizarPaisCommand>
{
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresSigla = 10;
    private const int LimiteCaracteresTipo = 1;

    private readonly IPaisRepository _paisRepository;

    public AtualizarPaisCommandValidator(
        INotificationContext notificationContext,
        IPaisRepository paisRepository)
        : base(notificationContext)
    {
        _paisRepository = paisRepository;

        RuleFor(x => x.Key)
           .NotEmpty().WithMessage("A chave do país é obrigatória.")
           .MustAsync(ValidarPaisExistenteAsync).WithMessage("A chave do país não foi encontrada.");

        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O nome do país é obrigatório.")
            .MaximumLength(LimiteCaracteresNome)
            .WithMessage("O nome do país deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.Sigla)
            .NotEmpty().WithMessage("A sigla do país é obrigatório.")
            .MaximumLength(LimiteCaracteresSigla)
            .WithMessage("A sigla do país deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.SiglaAbreviada)
            .NotEmpty().WithMessage("A sigla abreviada do país é obrigatório.")
            .MaximumLength(LimiteCaracteresSigla)
            .WithMessage("A sigla abreviada do país deve ter no máximo {MaxLength} caracteres.");

        When(x => x.Tipo != null, () =>
        {
            RuleFor(x => x.Tipo)
                .MaximumLength(LimiteCaracteresTipo)
                .WithMessage("O tipo do país deve ter no máximo {MaxLength} caracter.");
        });
    }

    private async Task<bool> ValidarPaisExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _paisRepository.ExistsAsync(key, token);
    }
}
