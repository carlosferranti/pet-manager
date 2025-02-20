using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.OfertaConcursos;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.OfertaConcursos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.OfertaConcursos.ObterOfertaConcurso;

public class ObterOfertaConcursoQueryValidator : ApplicationRequestValidator<ObterOfertaConcursoQuery, OfertaConcursoDto>
{
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;

    public ObterOfertaConcursoQueryValidator(
        IOfertaConcursoRepository ofertaConcursoRepository,
         INotificationContext notificationContext)
        : base(notificationContext)
    {
        _ofertaConcursoRepository = ofertaConcursoRepository;

        RuleFor(x => x.Key)
           .NotEmpty().WithMessage("A chave da ofertaConcurso é obrigatória.")
           .MustAsync(ValidarOfertaConcursoExistenteAsync).WithMessage("A chave da ofertaConcurso não foi encontrada.");
    }

    private async Task<bool> ValidarOfertaConcursoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _ofertaConcursoRepository.ExistsAsync(key, token);
    }
}
