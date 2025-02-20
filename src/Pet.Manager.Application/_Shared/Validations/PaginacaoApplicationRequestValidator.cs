using Anima.Inscricao.Application._Shared.DTOs.Paginacao;

using FluentValidation;

namespace Anima.Inscricao.Application._Shared.Validations;

public class PaginacaoApplicationRequestValidator : AbstractValidator<PaginacaoDto>
{
    public PaginacaoApplicationRequestValidator()
    {
        RuleFor(p => p.QuantidadeRegistros)
            .GreaterThan(0).WithMessage("A quantidade de registros precisa ser maior que zero.");

        RuleFor(p => p.NumeroPagina)
            .GreaterThan(0).WithMessage("A página de pesquisa precisa ser maior que zero.");
    }
}