using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Cursos;
using Anima.Inscricao.Domain._Shared.Notifications;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Cursos.PesquisarCurso;

public class PesquisarCursoQueryValidator : ApplicationRequestValidator<PesquisarCursoQuery, ResultadoPaginadoDto<CursoDto>>
{
    public PesquisarCursoQueryValidator(INotificationContext notificationContext)
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

