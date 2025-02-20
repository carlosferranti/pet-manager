using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricoes.Domain.Inscricoes;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.CriarIntegracaoInscricaoCandidato;

public class CriarIntegracaoInscricaoCandidatoCommandValidator : ApplicationRequestValidator<CriarIntegracaoInscricaoCandidatoCommand, EntityKeyDto?>
{
    private const int LimiteMaximoCodigoOrigem = 100;
    private const int LimiteMaximoNome = 100;

    private readonly IIntegracaoSistemaRepository _integracaoSistemasRepository;
    private readonly IInscricaoRepository _inscricaoRepository;

    public CriarIntegracaoInscricaoCandidatoCommandValidator(
        INotificationContext notificationContext,
        IIntegracaoSistemaRepository integracaoSistemaRepository,
        IInscricaoRepository inscricaoRepository)
        : base(notificationContext)
    {
        _integracaoSistemasRepository = integracaoSistemaRepository;
        _inscricaoRepository = inscricaoRepository;

        RuleFor(x => x.InscricaoCandidatoKey)
        .NotEmpty().WithMessage("A chave da inscrição é obrigatória.")
        .MustAsync(ValidarInscricaoExistenteAsync).WithMessage("A chave da inscrição não foi encontrada.");

        RuleFor(x => x.Integracao)
        .NotNull().WithMessage("Os dados de integração da inscrição são obrigatórios.");

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

    private async Task<bool> ValidarInscricaoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _inscricaoRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarNomeSistemaIntegracaoExistenteAsync(string nome, CancellationToken token = default)
    {
        return await _integracaoSistemasRepository.GetAsync(x => x.Nome.ToUpper() == nome.ToUpper()) != null;
    }
}