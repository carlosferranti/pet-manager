using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Intakes.CriarIntake;

public class CriarIntakeCommandValidator : ApplicationRequestValidator<CriarIntakeCommand, EntityKeyDto?>
{
    private const int LimiteMaximoNome = 100;
    private const int LimiteMaximoCodigoOrigem = 100;

    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;

    public CriarIntakeCommandValidator(
        INotificationContext notificationContext,
        IIntegracaoSistemaRepository sistemasIntegracaoRepository)
        : base(notificationContext)
    {
        _sistemasIntegracaoRepository = sistemasIntegracaoRepository;

        RuleFor(x => x.Nome)
            .NotEmpty()
            .WithMessage("O nome do intake é obrigatório.")
            .MaximumLength(LimiteMaximoNome)
            .WithMessage("O nome do intake deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.VigenciaInicio)
           .NotEmpty()
           .WithMessage("Data de inicio da vigência inválida.");

        RuleFor(x => x.VigenciaTermino)
          .NotEmpty()
          .WithMessage("Data de término da vigência inválida.");

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