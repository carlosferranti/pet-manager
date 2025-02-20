using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.Enums;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Cupons;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Cupons.AtualizarCupom;

public class AtualizarCupomCommandValidator : ApplicationRequestValidator<AtualizarCupomCommand>
{
    private const int LimiteCaracteresCodigo = 100;
    private const int LimiteCaracteresDescricao = 500;
    private const float ValorMinimoDescontoPorcentagem = 0;
    private const float ValorMaximoDescontoPorcentagem = 100;

    private readonly ICupomRepository _cupomRepository;
    private readonly IConcursoRepository _concursoRepository;

    public AtualizarCupomCommandValidator(
        INotificationContext notificationContext,
        ICupomRepository cupomRepository,
        IConcursoRepository concursoRepository) 
        : base(notificationContext)
    {
        _cupomRepository = cupomRepository;
        _concursoRepository = concursoRepository;

        RuleFor(x => x.Key)
            .NotEmpty()
            .WithMessage("A chave do cupom é obrigatória.")
            .MustAsync(ValidarCupomExisteAsync)
            .WithMessage("Cupom não encontrado.");

        RuleFor(x => x.ConcursoKey)
            .NotEmpty()
            .WithMessage("A chave do concurso é obrigatória.")
            .MustAsync(ValidarConcursoExisteAsync)
            .WithMessage("Concurso não encontrado.");

        RuleFor(x => x.Codigo)
            .NotEmpty()
            .WithMessage("O código do cupom é obrigatório.")
            .MaximumLength(LimiteCaracteresCodigo)
            .WithMessage("O código do cupom deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.Descricao)
            .NotEmpty()
            .WithMessage("A descrição do cupom é obrigatória.")
            .MaximumLength(LimiteCaracteresDescricao)
            .WithMessage("A descrição do cupom deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.TipoDesconto)
            .NotEmpty()
            .WithMessage("O tipo de desconto é obrigatório.")
            .Must(value => Enum.IsDefined(typeof(TipoDesconto), value))
            .WithMessage("Tipo de desconto inválido.");

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

    private async Task<bool> ValidarCupomExisteAsync(Guid cupomKey, CancellationToken token = default)
    {
        return  await _cupomRepository.GetAsync(cupomKey) != null;
    }

    private async Task<bool> ValidarConcursoExisteAsync(Guid concursoKey, CancellationToken token = default)
    {
        return await _concursoRepository.GetAsync(concursoKey) != null;
    }
}
