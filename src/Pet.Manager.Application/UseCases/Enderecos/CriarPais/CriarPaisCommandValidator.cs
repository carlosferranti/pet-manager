using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Enderecos.CriarPais;

public class CriarPaisCommandValidator : ApplicationRequestValidator<CriarPaisCommand, EntityKeyDto?>
{
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresSigla = 10;
    private const int LimiteCaracteresTipo = 1;
    private const int LimiteCaracteresOrigemId = 100;

    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;

    public CriarPaisCommandValidator(
        INotificationContext notificationContext,
        IIntegracaoSistemaRepository integracaoSistemaRepository)
        : base(notificationContext)
    {
        _sistemasIntegracaoRepository = integracaoSistemaRepository;

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

        When(x => x.Integracao != null, () =>
        {
            RuleFor(x => x.Integracao!.NomeSistema)
                .MaximumLength(LimiteCaracteresNome)
                .WithMessage("O nome do sistema de integração deve ter no máximo {MaxLength} caracteres.")
                .MustAsync(ValidarNomeSistemaIntegracaoExistenteAsync)
                .WithMessage("Nome do sistema de integração não encontrado.");

            RuleFor(x => x.Integracao!.CodigoOrigem)
                .MaximumLength(LimiteCaracteresOrigemId)
                .WithMessage("O código de origem da integração deve ter no máximo {MaxLength} caracteres.");
        });
    }

    private async Task<bool> ValidarNomeSistemaIntegracaoExistenteAsync(string nome, CancellationToken token = default)
    {
        return await _sistemasIntegracaoRepository.GetAsync(x => x.Nome.ToUpper() == nome.ToUpper()) != null;
    }
}
