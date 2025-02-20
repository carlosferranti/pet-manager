using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.OfertaConcursos;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.Links;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.Ofertas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.OfertaConcursos.PesquisarCursoOfertadoDetalhe;

public class PesquisarCursoOfertadoDetalheQueryValidator : ApplicationRequestValidator<PesquisarCursoOfertadoDetalheQuery, List<CursoOfertadoDetalheDto>>
{
    private readonly IMarcaRepository _marcaRepository;
    private readonly IIntakeRepository _intakeRepository;
    private readonly INivelCursoRepository _nivelCursoRepository;
    private readonly ILinkRepository _linkRepository;
    private readonly IOfertaRepository _ofertaRepository;

    public PesquisarCursoOfertadoDetalheQueryValidator(
        INotificationContext notificationContext,
        IMarcaRepository marcaRepository,
        IIntakeRepository intakeRepository,
        INivelCursoRepository nivelCursoRepository,
        ILinkRepository linkRepository,
        IOfertaRepository ofertaRepository)
        : base(notificationContext)
    {
        _marcaRepository = marcaRepository;
        _intakeRepository = intakeRepository;
        _nivelCursoRepository = nivelCursoRepository;
        _linkRepository = linkRepository;
        _ofertaRepository = ofertaRepository;

        RuleFor(x => x.Filtros)
            .NotEmpty().WithMessage("Os filtros da requisição são obrigatórios.");

        When(x => x.Filtros != null, () =>
        {
            When(x => !x.Filtros!.OfertaKey.HasValue, () =>
            {
                RuleFor(x => x.Filtros!.MarcaKey)
                    .NotEmpty().WithMessage("A chave da marca é obrigatória.");

                RuleFor(x => x.Filtros!.MarcaKey!.Value)
                    .MustAsync(ValidarMarcaExistenteAsync).WithMessage("A chave da marca não foi encontrada.")
                .When(x => x.Filtros!.MarcaKey.HasValue);

                RuleFor(x => x.Filtros!.NivelCursoKey)
                    .NotEmpty().WithMessage("A chave do nível é obrigatória.");

                RuleFor(x => x.Filtros!.NivelCursoKey!.Value)
                    .MustAsync(ValidarNivelExistenteAsync).WithMessage("A chave do nível não foi encontrada.")
                .When(x => x.Filtros!.NivelCursoKey.HasValue);

                RuleFor(x => x.Filtros!.IntakeKey)
                    .NotEmpty().WithMessage("A chave do intake é obrigatória.");

                RuleFor(x => x.Filtros!.IntakeKey!.Value)
                    .MustAsync(ValidarIntakeExistenteAsync).WithMessage("A chave do intake não foi encontrada.")
                .When(x => x.Filtros!.IntakeKey.HasValue);

                RuleFor(x => x.Filtros!.CursoNome)
                    .NotEmpty().WithMessage("O nome do curso é obrigatório.");

                RuleFor(x => x.Filtros!.LinkKey)
                .NotEmpty().WithMessage("A chave do link é obrigatória.");

                RuleFor(x => x.Filtros!.LinkKey!.Value)
                .MustAsync(ValidarLinkExistenteAsync).WithMessage("A chave do link não foi encontrada.")
                .When(x => x.Filtros!.LinkKey.HasValue);
            });

            When(x => x.Filtros!.OfertaKey.HasValue, () =>
            {
                RuleFor(x => x.Filtros!.OfertaKey!.Value)
                .MustAsync(ValidarOfertaExistenteAsync).WithMessage("A chave da oferta não foi encontrada.");
            });
        });
    }

    private async Task<bool> ValidarMarcaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _marcaRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarIntakeExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _intakeRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarNivelExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _nivelCursoRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarLinkExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _linkRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarOfertaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _ofertaRepository.ExistsAsync(key, token);
    }
}
