using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.OfertaConcursos.AtualizarOfertaConcurso;

public class AtualizarOfertaConcursoCommandValidator : ApplicationRequestValidator<AtualizarOfertaConcursoCommand>
{
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IConcursoRepository _concursoRepository;

    public AtualizarOfertaConcursoCommandValidator(
        IOfertaConcursoRepository ofertaConcursoRepository, 
        IOfertaRepository ofertaRepository, 
        IConcursoRepository concursoRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _ofertaConcursoRepository = ofertaConcursoRepository;
        _ofertaRepository = ofertaRepository;
        _concursoRepository = concursoRepository;

        RuleFor(x => x.Key)
          .NotEmpty().WithMessage("A chave da ofertaConcurso é obrigatória.")
          .MustAsync(ValidarOfertaConcursoExistenteAsync).WithMessage("A chave da ofertaConcurso não foi encontrada.");

        RuleFor(x => x.OfertaKey)
            .NotEmpty().WithMessage("A chave da oferta é obrigatória.")
            .MustAsync(ValidarOfertaExistenteAsync).WithMessage("A chave da oferta não foi encontrada.");

        RuleFor(x => x.ConcursoKey)
            .NotEmpty().WithMessage("A chave do concurso é obrigatória.")
            .MustAsync(ValidarConcursoExistenteAsync).WithMessage("A chave do concurso não foi encontrada.");
    }

    private async Task<bool> ValidarOfertaConcursoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _ofertaConcursoRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarOfertaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _ofertaRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarConcursoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _concursoRepository.ExistsAsync(key, token);
    }
}
