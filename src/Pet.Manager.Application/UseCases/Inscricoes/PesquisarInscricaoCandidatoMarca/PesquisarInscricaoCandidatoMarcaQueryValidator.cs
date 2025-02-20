using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Inscricoes;
using Anima.Inscricao.Application.UseCases.Inscricoes.PesquisarInscricaoAnteriorCandidato;
using Anima.Inscricao.Application.Utils;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Marcas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.PesquisarInscricaoCandidatoMarca;

public class PesquisarInscricaoCandidatoMarcaQueryValidator : ApplicationRequestValidator<PesquisarInscricaoCandidatoMarcaQuery, List<InscricaoDto>>
{
    private readonly IMarcaRepository _marcaRepository;

    public PesquisarInscricaoCandidatoMarcaQueryValidator(
        INotificationContext notificationContext,
        IMarcaRepository marcaRepository) 
        : base(notificationContext)
    {
        _marcaRepository = marcaRepository;

        RuleFor(x => x.MarcaKey)
            .MustAsync(ValidarMarcaExistenteAsync)
                .WithMessage("Marca da inscrição não encontrada.");

        RuleFor(x => x.Cpf)
            .NotEmpty()
                .WithMessage("O CPF precisa ser informado.")
            .Must(CpfUtils.ValidarCpf)
                .WithMessage("CPF inválido.");
    }

    private async Task<bool> ValidarMarcaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _marcaRepository.ExistsAsync(key, token);
    }
}