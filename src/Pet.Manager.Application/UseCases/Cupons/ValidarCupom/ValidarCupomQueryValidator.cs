using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Cupons;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.OfertaConcursos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Cupons.ValidarCupom;

public class ValidarCupomQueryValidator : ApplicationRequestValidator<ValidarCupomQuery, ValidarCupomResultadoDto>
{
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;

    public ValidarCupomQueryValidator(IOfertaConcursoRepository ofertaConcursoRepository, INotificationContext notificationContext)
     : base(notificationContext)
    {
        _ofertaConcursoRepository = ofertaConcursoRepository;

        RuleFor(query => query.CodigoCupom)
             .NotEmpty()
             .WithMessage("A chave do cupom é obrigatória.");

        RuleFor(query => query.OfertaConcursoKey)
               .NotEmpty()
               .WithMessage("A chave da ofertaConcurso é obrigatória.")
               .MustAsync(ValidarOfertaConcursoExistenteAsync)
               .WithMessage("A chave da ofertaConcurso não foi encontrada.");
    }

    private async Task<bool> ValidarOfertaConcursoExistenteAsync(Guid key, CancellationToken token)
    {
        return await _ofertaConcursoRepository.ExistsAsync(key, token);
    }
}