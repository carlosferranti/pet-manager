using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Modalidades.CriarModalidade;

public class CriarModalidadeCommandValidator : ApplicationRequestValidator<CriarModalidadeCommand, EntityKeyDto?>
{
    private const int LimiteMaximoNome = 100;
    private const int LimiteMaximoCodigoOrigem = 100;
    private const int LimiteMaximoDescricao = 255;

    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;

    public CriarModalidadeCommandValidator(
        INotificationContext notificationContext,
        IIntegracaoSistemaRepository sistemasIntegracaoRepository)
        : base(notificationContext)
    {
        _sistemasIntegracaoRepository = sistemasIntegracaoRepository;

        RuleFor(x => x.Nome)
            .NotEmpty()
            .WithMessage("O nome da modalidade é obrigatório.")
            .MaximumLength(LimiteMaximoNome)
            .WithMessage("O nome da modalidade deve ter no máximo {MaxLength} caracteres.");

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

        When(x => x.Descricao is not null, () =>
        {
            RuleFor(x => x.Descricao)
                .MaximumLength(LimiteMaximoDescricao)
                .WithMessage("A descrição da modalidade deve ter no máximo {MaxLength} caracteres.");
        });
    }

    private async Task<bool> ValidarNomeSistemaIntegracaoExistenteAsync(string nome, CancellationToken token = default)
    {
        return await _sistemasIntegracaoRepository.GetAsync(x => x.Nome.ToUpper() == nome.ToUpper()) != null;
    }
}
