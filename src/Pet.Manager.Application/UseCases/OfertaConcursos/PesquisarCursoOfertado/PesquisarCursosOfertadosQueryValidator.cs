using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.OfertaConcursos;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Links;
using Anima.Inscricao.Domain.Marcas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.OfertaConcursos.PesquisarCursosOfertados;

public class PesquisarCursosOfertadosQueryValidator : ApplicationRequestValidator<PesquisarCursosOfertadosQuery, List<CursoOfertadoDto>>
{
    private readonly IMarcaRepository _marcaRepository;
    private readonly ILinkRepository _linkRepository;

    public PesquisarCursosOfertadosQueryValidator(
        INotificationContext notificationContext,
        IMarcaRepository marcaRepository,
        ILinkRepository linkRepository)
        : base(notificationContext)
    {
        _marcaRepository = marcaRepository;
        _linkRepository = linkRepository;

        RuleFor(x => x.Filtros)
            .NotEmpty().WithMessage("Os filtros da requisição são obrigatórios.");

        When(x => x.Filtros != null, () =>
        {
            RuleFor(x => x.Filtros!.MarcaKey)
                .NotEmpty().WithMessage("A chave da marca é obrigatória.");

            RuleFor(x => x.Filtros!.MarcaKey!.Value)
            .MustAsync(ValidarMarcaExistenteAsync).WithMessage("A chave da marca não foi encontrada.")
            .When(x => x.Filtros!.MarcaKey.HasValue);

            RuleFor(x => x.Filtros!.LinkKey)
                .NotEmpty().WithMessage("A chave do link é obrigatória.");

            RuleFor(x => x.Filtros!.LinkKey!.Value)
            .MustAsync(ValidarLinkExistenteAsync).WithMessage("A chave do link não foi encontrada.")
            .When(x => x.Filtros!.LinkKey.HasValue);
        });
    }

    private async Task<bool> ValidarMarcaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _marcaRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarLinkExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _linkRepository.ExistsAsync(key, token);
    }
}
