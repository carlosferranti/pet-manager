using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Escolas.CriarEscola;

public class CriarEscolaCommandValidator : ApplicationRequestValidator<CriarEscolaCommand, EntityKeyDto?>
{
    private const int LimiteMinimoCaracteresNome = 3;
    private const int LimiteMaximoCaracteresNome = 200;
    private const int LimiteCaracteresNomeSistema = 100;
    private const int LimiteCaracteresOrigemId = 100;

    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;
    private readonly ICidadeRepository _cidadeRepository;

    public CriarEscolaCommandValidator(
        ICidadeRepository cidadeRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository,
        INotificationContext notificationContext) 
        : base(notificationContext)
    {
        _cidadeRepository = cidadeRepository;
        _sistemasIntegracaoRepository = integracaoSistemaRepository;

        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O nome da escola é obrigatório.")
            .Length(LimiteMinimoCaracteresNome, LimiteMaximoCaracteresNome)
            .WithMessage("O nome da escola deve ter entre {MinLength} e {MaxLength} caracteres.");

        RuleFor(x => x.CidadeKey!.Value)
            .NotEmpty()
                .WithMessage("A chave da cidade é obrigatória.")
            .MustAsync(ValidarCidadeExistenteAsync)
                .WithMessage("A chave da cidade não foi encontrada.")
            .When(x => x.CidadeKey.HasValue);

        When(x => x.Integracao != null, () =>
        {
            RuleFor(x => x.Integracao!.NomeSistema)
                .MaximumLength(LimiteCaracteresNomeSistema)
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

    private async Task<bool> ValidarCidadeExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _cidadeRepository.ExistsAsync(key, token);
    }
}
