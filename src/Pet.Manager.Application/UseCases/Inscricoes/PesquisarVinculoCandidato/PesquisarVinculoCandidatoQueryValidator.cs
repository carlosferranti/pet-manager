using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Candidatos;
using Anima.Inscricao.Application.Utils;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Marcas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.PesquisarVinculoCandidato;

public class PesquisarVinculoCandidatoQueryValidator : ApplicationRequestValidator<PesquisarVinculoCandidatoQuery, IEnumerable<CandidatoVinculoDto>>
{
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly IMarcaRepository _marcaRepository;

    public PesquisarVinculoCandidatoQueryValidator(
        IFormaEntradaRepository formaEntradaRepository,
        IMarcaRepository marcaRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _formaEntradaRepository = formaEntradaRepository;
        _marcaRepository = marcaRepository;

        RuleFor(x => x.Cpf)
            .NotEmpty()
                .WithMessage("O CPF precisa ser informado.")
            .Must(CpfUtils.ValidarCpf)
                .WithMessage("CPF inválido.");

        When(x => x.MarcaKey.HasValue, () =>
        {
            RuleFor(x => x.MarcaKey!.Value)
            .MustAsync(ValidarMarcaExistenteAsync)
                .WithMessage("Marca não encontrada.");

            RuleFor(x => x.FormaEntradaKey)
                .NotEmpty().WithMessage("A chave da forma de entrada precisa ser informada.");
        });

        When(x => x.FormaEntradaKey.HasValue, () =>
        {
            RuleFor(x => x.FormaEntradaKey!.Value)
                .MustAsync(ValidarFormaEntradaExistenteAsync)
                    .WithMessage("Forma de entrada não encontrada.");

            RuleFor(x => x.MarcaKey)
                .NotEmpty().WithMessage("A chave da marca precisa ser informada.");
        });
    }

    private async Task<bool> ValidarMarcaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _marcaRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarFormaEntradaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _formaEntradaRepository.ExistsAsync(key, token);
    }
}
