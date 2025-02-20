using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Domain._Shared.Notifications;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoDestrancamentoReopcao;

public class ProcessarRegraConcursoDestrancamentoRetornoCommandValidator : ApplicationRequestValidator<ProcessarRegraConcursoDestrancamentoRetornoCommand, List<ConcursosPorOfertaDto>>
{
    public ProcessarRegraConcursoDestrancamentoRetornoCommandValidator(INotificationContext notificationContext)
        : base(notificationContext)
    {
        RuleFor(x => x.Concursos)
            .NotEmpty()
            .WithMessage("Os concursos precisam ser informados.");

        RuleFor(x => x.Instituicao)
            .NotNull()
            .WithMessage("A instituição precisa ser informada.");
    }
}