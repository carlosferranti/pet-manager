using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Concursos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Concursos.ObterConcurso;

public class ObterConcursoQueryValidator : ApplicationRequestValidator<ObterConcursoQuery, ConcursoDto>
{
    private readonly IConcursoRepository _concursoRepository;

    public ObterConcursoQueryValidator(
        IConcursoRepository concursoRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _concursoRepository = concursoRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave do concurso é obrigatória.")
            .MustAsync(ValidarConcursoExistenteAsync).WithMessage("A chave do concurso não foi encontrada.");
    }

    private async Task<bool> ValidarConcursoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _concursoRepository.ExistsAsync(key, token);
    }
}
