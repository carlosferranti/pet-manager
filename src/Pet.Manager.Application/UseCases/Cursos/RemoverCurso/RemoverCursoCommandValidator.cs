using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Cursos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Cursos.RemoverCurso;

public class RemoverCursoCommandValidator : ApplicationRequestValidator<RemoverCursoCommand>
{
    private readonly ICursoRepository _cursoRepository;

    public RemoverCursoCommandValidator(
        ICursoRepository cursoRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _cursoRepository = cursoRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave do curso é obrigatória.")
            .MustAsync(ValidarCursoExistenteAsync).WithMessage("A chave do curso não foi encontrada.");
    }

    private async Task<bool> ValidarCursoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _cursoRepository.ExistsAsync(key, token);
    }
}
