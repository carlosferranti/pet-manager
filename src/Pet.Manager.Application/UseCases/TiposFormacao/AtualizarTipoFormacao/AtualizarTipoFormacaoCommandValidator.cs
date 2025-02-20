using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.TiposFormacao;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.TiposFormacao.AtualizarTipoFormacao;

public class AtualizarTipoFormacaoCommandValidator : ApplicationRequestValidator<AtualizarTipoFormacaoCommand>
{
    private const int LimiteMaximoNome = 100;

    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;

    public AtualizarTipoFormacaoCommandValidator(
        ITipoFormacaoRepository tipoFormacaoRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _tipoFormacaoRepository = tipoFormacaoRepository;

        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O nome do tipo de formação é obrigatório.")
            .MaximumLength(LimiteMaximoNome).WithMessage("O nome do tipo de formação deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave do tipo de formação é obrigatória.")
            .MustAsync(ValidarTipoFormacaoExistenteAsync).WithMessage("A chave do tipo de formação não foi encontrada.");
    }

    private async Task<bool> ValidarTipoFormacaoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _tipoFormacaoRepository.ExistsAsync(key, token);
    }
}