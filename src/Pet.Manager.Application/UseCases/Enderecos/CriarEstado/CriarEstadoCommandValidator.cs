using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Enderecos.CriarEstado;

public class CriarEstadoCommandValidator : ApplicationRequestValidator<CriarEstadoCommand, EntityKeyDto?>
{
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresSigla = 10;
    private const int LimiteCaracteresOrigemId = 100;

    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;
    private readonly IPaisRepository _paisRepository;

    public CriarEstadoCommandValidator(
        INotificationContext notificationContext,
        IIntegracaoSistemaRepository integracaoSistemaRepository,
        IPaisRepository paisRepository)
        : base(notificationContext)
    {
        _sistemasIntegracaoRepository = integracaoSistemaRepository;
        _paisRepository = paisRepository;

        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O nome do estado é obrigatório.")
            .MaximumLength(LimiteCaracteresNome)
            .WithMessage("O nome do estado deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.Sigla)
            .NotEmpty().WithMessage("A sigla do estado é obrigatória.")
            .MaximumLength(LimiteCaracteresSigla)
            .WithMessage("A sigla do estado deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.PaisKey)
            .NotEmpty().WithMessage("A chave do país é obrigatória.")
            .MustAsync(ValidarPaisExistenteAsync).WithMessage("A chave do país não foi encontrada.");

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

    private async Task<bool> ValidarPaisExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _paisRepository.ExistsAsync(key, token);
    }
}
