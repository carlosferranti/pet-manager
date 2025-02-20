using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.NiveisCurso;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.NiveisCurso.AtualizarNivelCurso;

public class AtualizarNivelCursoCommandValidator : ApplicationRequestValidator<AtualizarNivelCursoCommand>
{
    private const int LimiteMaximoNome = 255;

    private readonly INivelCursoRepository _nicelCursoRepository;

    public AtualizarNivelCursoCommandValidator(
        INotificationContext notificationContext,
        INivelCursoRepository nivelCursoRepository) 
        : base(notificationContext)
    {
        _nicelCursoRepository = nivelCursoRepository;

        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O nome do nível do curso é obrigatório.")
            .MaximumLength(LimiteMaximoNome).WithMessage("O nome do nível do curso deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave do nível do curso é obrigatória.")
            .MustAsync(ValidarNivelCursoExistenteAsync).WithMessage("A chave do nível do curso não foi encontrada.");

    }

    private async Task<bool> ValidarNivelCursoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _nicelCursoRepository.ExistsAsync(key, token);
    }
}
