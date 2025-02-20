using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.Enums;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Cupons.CriarCupom;

public class CriarCupomCommandValidator : ApplicationRequestValidator<CriarCupomCommand, EntityKeyDto?>
{
    private const int LimiteMaximoNome = 100;
    private const int LimiteCaracteresCodigo = 100;
    private const int LimiteMaximoCodigoOrigem = 100;
    private const int LimiteCaracteresDescricao = 500;
    private const float ValorMinimoDescontoPorcentagem = 0;
    private const float ValorMaximoDescontoPorcentagem = 100;

    private readonly IConcursoRepository _concursoRepository;
    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;

    public CriarCupomCommandValidator(
        INotificationContext notificationContext,
        IConcursoRepository concursoRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository) 
        : base(notificationContext)
    {
        _concursoRepository = concursoRepository;
        _sistemasIntegracaoRepository = integracaoSistemaRepository;

        RuleFor(x => x.Codigo)
            .NotEmpty().WithMessage("O código do cupom é obrigatório.")
            .MaximumLength(LimiteCaracteresCodigo)
            .WithMessage("O código do cupom deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.Descricao)
            .NotEmpty().WithMessage("A descrição do cupom é obrigatória.")
            .MaximumLength(LimiteCaracteresDescricao)
            .WithMessage("A descrição do cupom deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.ConcursoKey)
            .NotEmpty().WithMessage("A chave do concurso é obrigatória.")
            .MustAsync(ValidarConcursoExisteAsync)
            .WithMessage("Concurso não encontrado.");

        RuleFor(x => x.TipoDesconto)
            .Must(value => Enum.IsDefined(typeof(TipoDesconto), value))
            .WithMessage("Tipo de desconto inválido.");

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

        When(x => x.TipoDesconto == (int)TipoDesconto.Porcentagem, () =>
        {
            RuleFor(x => x.ValorDesconto)
                .InclusiveBetween(ValorMinimoDescontoPorcentagem, ValorMaximoDescontoPorcentagem)
                .WithMessage("O valor do desconto deve ser entre {From} e {To}.");
        });

        When(x => x.TipoDesconto == (int)TipoDesconto.Valor, () =>
        {
            RuleFor(x => x.ValorDesconto)
                .GreaterThanOrEqualTo(0)
                .WithMessage("O valor do desconto deve ser maior ou igual a zero.");
        });
    }

    private async Task<bool> ValidarConcursoExisteAsync(Guid concursoKey, CancellationToken token = default)
    {
        return await _concursoRepository.GetAsync(concursoKey) != null;
    }

    private async Task<bool> ValidarNomeSistemaIntegracaoExistenteAsync(string nome, CancellationToken token = default)
    {
        return await _sistemasIntegracaoRepository.GetAsync(x => x.Nome.ToUpper() == nome.ToUpper()) != null;
    }
}
