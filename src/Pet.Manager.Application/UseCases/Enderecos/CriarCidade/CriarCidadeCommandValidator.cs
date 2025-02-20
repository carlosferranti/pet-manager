using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Enderecos.CriarCidade;

public class CriarCidadeCommandValidator : ApplicationRequestValidator<CriarCidadeCommand, EntityKeyDto?>
{
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresOrigemId = 100;

    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;
    private readonly IEstadoRepository _estadoRepository;

    public CriarCidadeCommandValidator(
        INotificationContext notificationContext,
        IIntegracaoSistemaRepository integracaoSistemaRepository,
        IEstadoRepository estadoRepository)
        : base(notificationContext)
    {
        _sistemasIntegracaoRepository = integracaoSistemaRepository;
        _estadoRepository = estadoRepository;

        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O nome da cidade é obrigatório.")
            .MaximumLength(LimiteCaracteresNome)
            .WithMessage("O nome da cidade deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.EstadoKey)
            .NotEmpty().WithMessage("A chave do estado é obrigatória.")
            .MustAsync(ValidarEstadoExistenteAsync).WithMessage("A chave do estado não foi encontrada.");

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

    private async Task<bool> ValidarEstadoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _estadoRepository.ExistsAsync(key, token);
    }
}
