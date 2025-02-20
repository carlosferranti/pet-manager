using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Marcas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Instituicoes.CriarInstituicao;

public class CriarInstituicaoCommandValidator : ApplicationRequestValidator<CriarInstituicaoCommand, EntityKeyDto?>
{
    private const int LimiteMaximoNome = 100;
    private const int LimiteMaximoSigla = 50;
    private const int LimiteMaximoCodigoOrigem = 100;

    private readonly IMarcaRepository _marcaRepository;
    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;

    public CriarInstituicaoCommandValidator(
        IMarcaRepository marcaRepository,
        INotificationContext notificationContext, 
        IIntegracaoSistemaRepository integracaoSistemaRepository) 
        : base(notificationContext)
    {
        _marcaRepository = marcaRepository;
        _sistemasIntegracaoRepository = integracaoSistemaRepository;

        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O nome da instituição é obrigatório.")
            .MaximumLength(LimiteMaximoNome)
            .WithMessage("O nome da instituição deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.Sigla)
            .NotEmpty().WithMessage("A sigla da instituição é obrigatória.")
            .MaximumLength(LimiteMaximoSigla)
            .WithMessage("A sigla da instituição deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.MarcaKey)
            .NotEmpty().WithMessage("A chave da marca é obrigatória.")
            .MustAsync(ValidarMarcaExistenteAsync).WithMessage("A chave da marca não foi encontrada.");

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

    private async Task<bool> ValidarMarcaExistenteAsync(Guid guid, CancellationToken token)
    {
        return await _marcaRepository.ExistsAsync(guid, token);
    }

    private async Task<bool> ValidarNomeSistemaIntegracaoExistenteAsync(string nome, CancellationToken token = default)
    {
        return await _sistemasIntegracaoRepository.GetAsync(x => x.Nome.ToUpper() == nome.ToUpper()) != null;
    }
}
