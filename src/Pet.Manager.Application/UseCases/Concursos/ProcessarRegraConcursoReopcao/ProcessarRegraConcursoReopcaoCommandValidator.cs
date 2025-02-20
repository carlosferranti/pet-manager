using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Domain._Shared.Notifications;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoReopcao;

public class ProcessarRegraConcursoReopcaoCommandValidator : ApplicationRequestValidator<ProcessarRegraConcursoReopcaoCommand, List<ConcursosPorOfertaDto>>
{
    public ProcessarRegraConcursoReopcaoCommandValidator(INotificationContext notificationContext)
        : base(notificationContext)
    {
        RuleFor(x => x.Concursos)
            .NotEmpty()
            .WithMessage("Os concursos precisam ser informados.");

        RuleFor(x => x.VigenciaIntake)
            .NotEmpty()
            .WithMessage("A vigência do intake precisa ser informada.");
    }
}