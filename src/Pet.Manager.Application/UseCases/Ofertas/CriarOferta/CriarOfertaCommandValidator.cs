using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Produtos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Ofertas.CriarOferta;

public class CriarOfertaCommandValidator : ApplicationRequestValidator<CriarOfertaCommand, EntityKeyDto?>
{
    private const int LimiteMaximoNome = 100;
    private const int LimiteMaximoCodigoOrigem = 100;

    private readonly IProdutoRepository _produtoRepository;
    private readonly IIntakeRepository _intakeRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemasRepository;

    public CriarOfertaCommandValidator(
        IProdutoRepository produtoRepository,
        IIntakeRepository intakeRepository,
        IIntegracaoSistemaRepository integracaoSistemasRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _produtoRepository = produtoRepository;
        _intakeRepository = intakeRepository;
        _integracaoSistemasRepository = integracaoSistemasRepository;

        RuleFor(x => x.ProdutoKey)
            .NotEmpty().WithMessage("A chave do produto é obrigatória.")
            .MustAsync(ValidarProdutoExistenteAsync).WithMessage("A chave do produto não foi encontrada.");

        RuleFor(x => x.IntakeKey)
            .NotEmpty().WithMessage("A chave do intake é obrigatória.")
            .MustAsync(ValidarIntakeExistenteAsync).WithMessage("A chave do intake não foi encontrada.");

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

    private async Task<bool> ValidarProdutoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _produtoRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarIntakeExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _intakeRepository.ExistsAsync(key, token);

    }

    private async Task<bool> ValidarNomeSistemaIntegracaoExistenteAsync(string nome, CancellationToken token = default)
    {
        return await _integracaoSistemasRepository.GetAsync(x => x.Nome.ToUpper() == nome.ToUpper()) != null;
    }
}
