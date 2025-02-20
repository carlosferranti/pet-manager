using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Marcas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Instituicoes.AtualizarInstituicao;

public class AtualizarInstituicaoCommandValidator : ApplicationRequestValidator<AtualizarInstituicaoCommand>
{
    private const int LimiteMaximoNome = 100;
    private const int LimiteMaximoSigla = 50;

    private readonly IInstituicaoRepository _instituicaoRepository;

    private readonly IMarcaRepository _marcaRepository;

    public AtualizarInstituicaoCommandValidator(
        INotificationContext notificationContext,
        IInstituicaoRepository instituicaoRepository,
        IMarcaRepository marcaRepository)
        : base(notificationContext)
    {
        _instituicaoRepository = instituicaoRepository;
        _marcaRepository = marcaRepository;

        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O nome da instituição é obrigatório.")
            .MaximumLength(LimiteMaximoNome).WithMessage("O nome da instituição deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave da instituição é obrigatória.")
            .MustAsync(ValidarInstituicaoExistenteAsync).WithMessage("A chave da instituição não foi encontrada.");

        RuleFor(x => x.MarcaKey)
            .NotEmpty().WithMessage("A chave da marca é obrigatória.")
            .MustAsync(ValidarMarcaExistenteAsync).WithMessage("A chave da marca não foi encontrada.");

        When(x => x.Sigla != null, () =>
        {
            RuleFor(x => x.Sigla)
                .NotEmpty().WithMessage("A sigla da instituição deve conter um valor valido.")
                .MaximumLength(LimiteMaximoSigla).WithMessage("A sigla da instituição deve ter no máximo {MaxLength} caracteres.");
        });
        
    }

    private async Task<bool> ValidarInstituicaoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _instituicaoRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarMarcaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _marcaRepository.ExistsAsync(key, token);
    }
}
