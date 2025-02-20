using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Cursos;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Cursos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Cursos.ObterCurso;

public class ObterCursoQueryValidator : ApplicationRequestValidator<ObterCursoQuery, CursoDto>
{
    private readonly ICursoRepository _cursoRepository;

    public ObterCursoQueryValidator(
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


