using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.NiveisCurso.CriarNivelCurso;

public class CriarNivelCursoCommandValidator : ApplicationRequestValidator<CriarNivelCursoCommand, EntityKeyDto?>
{
    private const int LimiteMaximoNome = 255;
    private const int LimiteMaximoNomsistemaIntegracao = 100;
    private const int LimiteMaximoCodigoOrigem = 100;

    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;

    public CriarNivelCursoCommandValidator(
        INotificationContext notificationContext, 
        IIntegracaoSistemaRepository integracaoSistemaRepository) 
        : base(notificationContext)
    {

        _sistemasIntegracaoRepository = integracaoSistemaRepository;

        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O nome do nível do curso é obrigatório.")
            .MaximumLength(LimiteMaximoNome)
            .WithMessage("O nome do nível do curso deve ter no máximo {MaxLength} caracteres.");

        When(x => x.Integracao != null, () =>
        {
            RuleFor(x => x.Integracao!.NomeSistema)
                .MaximumLength(LimiteMaximoNomsistemaIntegracao)
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
