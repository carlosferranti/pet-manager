using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Campi.CriarCampus;

public class CriarCampusCommandValidator : ApplicationRequestValidator<CriarCampusCommand, EntityKeyDto?>
{
    private const int LimiteMaximoNome = 100;
    private const int LimiteMaximoCodigoOrigem = 100;
    private const int LimiteMaximoNomeComercial = 200;

    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;

    public CriarCampusCommandValidator(
        INotificationContext notificationContext,
        IIntegracaoSistemaRepository integracaoSistemaRepository) 
        : base(notificationContext)
    {
        _sistemasIntegracaoRepository = integracaoSistemaRepository;

        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O nome do campus é obrigatório.")
            .MaximumLength(LimiteMaximoNome)
            .WithMessage("O nome do campus deve ter no máximo {MaxLength} caracteres.");

        When(x => !string.IsNullOrEmpty(x.NomeComercial), () =>
        {
            RuleFor(x => x.NomeComercial)
                .MaximumLength(LimiteMaximoNomeComercial)
                .WithMessage("O nome comercial do campus deve ter no máximo {MaxLength} caracteres.");
        });

        When(x => x.Integracao != null, () =>
        {
            RuleFor(x => x.Integracao!.NomeSistema)
                .MaximumLength(LimiteMaximoNome)
                .WithMessage("O nome do sistema de integração deve ter no máximo {MaxLength} caracteres.")
                .MustAsync(ValidarNomeSistemaIntegracaoExistenteAsync)
                .WithMessage("Nome do sistema de integração não encontrado.");

            RuleFor(x => x.Integracao!.CodigoOrigem)
                .MaximumLength(LimiteMaximoCodigoOrigem)
                .WithMessage("O código de origem da integração deve ter no máximo {MaxLength} caracteres.");
        });
    }

    private async Task<bool> ValidarNomeSistemaIntegracaoExistenteAsync(string nome, CancellationToken token = default)
    {
        return await _sistemasIntegracaoRepository.GetAsync(x => x.Nome.ToUpper() == nome.ToUpper()) != null;
    }

}
