using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Deficiencias;
using Anima.Inscricao.Application.DTOs.Empresas;
using Anima.Inscricao.Application.UseCases.Deficiencias.PesquisarDeficiencia;
using Anima.Inscricao.Domain._Shared.Notifications;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Empresas.PesquisarEmpresa;

public class PesquisarEmpresaQueryValidator : ApplicationRequestValidator<PesquisarEmpresaQuery, ResultadoPaginadoDto<EmpresaDto>>
{
    public PesquisarEmpresaQueryValidator(INotificationContext notificationContext)
        : base(notificationContext)
    {
        RuleFor(p => p.Paginacao)
            .NotNull()
            .WithMessage("A paginação precisa ser informada.");

        When(p => p.Paginacao is not null, () =>
        {
            RuleFor(p => p.Paginacao).SetValidator(new PaginacaoApplicationRequestValidator());
        });
    }
}
