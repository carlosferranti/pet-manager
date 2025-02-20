using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Application.Utils;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Links;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Ofertas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Concursos.PesquisarConcursoPorOferta;

public class PesquisarConcursoPorOfertaQueryValidator : ApplicationRequestValidator<PesquisarConcursoPorOfertaQuery, List<ConcursosPorOfertaDto>>
{
    private readonly IOfertaRepository _ofertaRepository;
    private readonly ILinkRepository _linkRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;

    public PesquisarConcursoPorOfertaQueryValidator(
        IOfertaRepository ofertaRepository,
        ILinkRepository linkRepository,
        IFormaEntradaRepository formaEntradaRepository,
        INotificationContext notificationContext) 
        : base(notificationContext)
    {
        _ofertaRepository = ofertaRepository;
        _linkRepository = linkRepository;
        _formaEntradaRepository = formaEntradaRepository;

        RuleFor(x => x.Cpf)
             .NotEmpty().WithMessage("O CPF é obrigatório.")
             .Must(CpfUtils.ValidarCpf).WithMessage("CPF inválido.");

        RuleFor(x => x.OfertaKey)
            .NotEmpty().WithMessage("A chave da oferta é obrigatória.")
            .MustAsync(ValidarOfertaExistenteAsync).WithMessage("A chave da oferta não foi encontrada.");
        
        RuleFor(x => x.LinkKey)
            .NotEmpty().WithMessage("A chave do link é obrigatória.")
            .MustAsync(ValidarLinkExistenteAsync).WithMessage("A chave do link não foi encontrada.");

        When(x => x.FormaEntradaKey.HasValue, () =>
        {
            RuleFor(x => x.FormaEntradaKey!.Value)
                .MustAsync(ValidaFormaEntradaExistenteAsync).WithMessage("A chave da forma de entrada não foi encontrada.");
        });
    }

    private async Task<bool> ValidarOfertaExistenteAsync(Guid ofertaKey, CancellationToken token = default)
    {
        return await _ofertaRepository.ExistsAsync(ofertaKey, token);
    }

    private async Task<bool> ValidarLinkExistenteAsync(Guid linkKey, CancellationToken token = default)
    {
        return await _linkRepository.ExistsAsync(linkKey, token);
    }

    private async Task<bool> ValidaFormaEntradaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _formaEntradaRepository.ExistsAsync(key, token);
    }
}
