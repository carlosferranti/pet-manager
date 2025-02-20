using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.NiveisCurso;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.NiveisCurso;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.NiveisCurso.ObterNivelCurso;

public class ObterNivelCursoQueryValidator : ApplicationRequestValidator<ObterNivelCursoQuery, NivelCursoDto>
{
    private readonly INivelCursoRepository _nivelCursoRepository;
    public ObterNivelCursoQueryValidator(
        INotificationContext notificationContext,
        INivelCursoRepository nivelCursoRepository) 
        : base(notificationContext)
    {
        _nivelCursoRepository = nivelCursoRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave do nível do curso é obrigatória.")
            .MustAsync(ValidarNivelCursoExistenteAsync).WithMessage("A chave do nível do curso não foi encontrada.");
    }

    private async Task<bool> ValidarNivelCursoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _nivelCursoRepository.ExistsAsync(key, token);
    }
}
