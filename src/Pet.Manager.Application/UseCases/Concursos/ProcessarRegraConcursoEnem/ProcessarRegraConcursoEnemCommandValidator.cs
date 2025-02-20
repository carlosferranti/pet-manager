using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Domain._Shared.Notifications;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoEnem;

public class ProcessarRegraConcursoEnemCommandValidator : ApplicationRequestValidator<ProcessarRegraConcursoEnemCommand, List<ConcursosPorOfertaDto>>
{
    public ProcessarRegraConcursoEnemCommandValidator(INotificationContext notificationContext)
        : base(notificationContext)
    {
        RuleFor(x => x.Concursos)
            .NotEmpty()
            .WithMessage("Os concursos precisam ser informados.");

        RuleFor(x => x.Cpf)
            .NotEmpty()
            .WithMessage("O cpf não pode ser vazio.");
    }
}