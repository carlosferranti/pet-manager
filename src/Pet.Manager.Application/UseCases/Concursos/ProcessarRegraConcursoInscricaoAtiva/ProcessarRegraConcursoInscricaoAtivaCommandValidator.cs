using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Domain._Shared.Notifications;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoInscricaoAtiva;

public class ProcessarRegraConcursoInscricaoAtivaCommandValidator : ApplicationRequestValidator<ProcessarRegraConcursoInscricaoAtivaCommand, List<ConcursosPorOfertaDto>>
{
    public ProcessarRegraConcursoInscricaoAtivaCommandValidator(INotificationContext notificationContext)
        : base(notificationContext)
    {
        RuleFor(x => x.FormasEntrada)
            .NotEmpty()
            .WithMessage("As formas de entrada precisam ser informadas.");

        RuleFor(x => x.IntakeKey)
            .NotEmpty()
            .WithMessage("A chave do intake é obrigatória.");
        
        RuleFor(x => x.MarcaKey)
            .NotEmpty()
            .WithMessage("A chave da marca é obrigatória.");
        
        RuleFor(x => x.Cpf)
            .NotEmpty()
            .WithMessage("O cpf é obrigatório.");
    }
}