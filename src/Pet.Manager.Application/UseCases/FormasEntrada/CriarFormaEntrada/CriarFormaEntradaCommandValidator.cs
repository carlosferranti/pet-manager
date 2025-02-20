using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.FormasEntrada.CriarFormaEntrada;

public class CriarFormaEntradaCommandValidator : ApplicationRequestValidator<CriarFormaEntradaCommand, EntityKeyDto?>
{
    private const int LimiteMaximoNome = 100;
    private const int LimiteMaximoCodigoOrigem = 100;
    private const int LimiteMaximoDescricao = 255;

    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;

    public CriarFormaEntradaCommandValidator(
        INotificationContext notificationContext,
        IIntegracaoSistemaRepository integracaoSistemaRepository)
        : base(notificationContext)
    {
        _sistemasIntegracaoRepository = integracaoSistemaRepository;

        RuleFor(x => x.Nome)
            .NotEmpty()
            .WithMessage("O nome da forma de entrada é obrigatório.")
            .MaximumLength(LimiteMaximoNome)
            .WithMessage("O nome da forma de entrada deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.ExibeCard)
            .NotEmpty().WithMessage("É obrigatório informar se a forma de entrada exibe card ou não.");

        When(x => x.Integracao != null, () =>
        {
            RuleForEach(x => x.Integracao).ChildRules(integracao =>
            {
                integracao.RuleFor(x => x!.NomeSistema)
                .MaximumLength(LimiteMaximoNome)
                    .WithMessage("O nome do sistema de integração deve ter no máximo {MaxLength} caracteres.")
                .MustAsync(ValidarNomeSistemaIntegracaoExistenteAsync)
                    .WithMessage("Nome do sistema de integração não encontrado.");

                integracao.RuleFor(x => x!.CodigoOrigem)
                .MaximumLength(LimiteMaximoCodigoOrigem)
                    .WithMessage("O código de origem da integração deve ter no máximo {MaxLength} caracteres.");
            });
        });

        When(x => x.Descricao != null, () =>
        {
            RuleFor(x => x.Descricao)
                .MaximumLength(LimiteMaximoDescricao)
                .WithMessage("A descrição da forma de entrada deve ter no máximo {MaxLength} caracteres.");
        });
    }

    private async Task<bool> ValidarNomeSistemaIntegracaoExistenteAsync(string nome, CancellationToken token = default)
    {
        return await _sistemasIntegracaoRepository.GetAsync(x => x.Nome.ToUpper() == nome.ToUpper()) != null;
    }
}
