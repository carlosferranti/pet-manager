using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.CursosExternos;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.CursosExternos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.CursosExternos.ObterCursoExterno;

public class ObterCursoExternoQueryValidator : ApplicationRequestValidator<ObterCursoExternoQuery, CursoExternoDto>
{
    private readonly ICursoExternoRepository _cursoExternoRepository;

    public ObterCursoExternoQueryValidator(
        INotificationContext notificationContext, 
        ICursoExternoRepository cursoExternoRepository) 
        : base(notificationContext)
    {
        _cursoExternoRepository = cursoExternoRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave do curso externo é obrigatória.")
            .MustAsync(ValidarCursoExternoExistenteAsync)
            .WithMessage("A chave do curso externo não foi encontrada.");
    }

    private async Task<bool> ValidarCursoExternoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _cursoExternoRepository.ExistsAsync(key, token);
    }
}
