using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.TiposFormacao;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.TiposFormacao;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.TiposFormacao.ObterTipoFormacao;

public class ObterTipoFormacaoQueryValidator : ApplicationRequestValidator<ObterTipoFormacaoQuery, TipoFormacaoDto>
{
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;

    public ObterTipoFormacaoQueryValidator(
        ITipoFormacaoRepository tipoFormacaoRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _tipoFormacaoRepository = tipoFormacaoRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave do tipo de formação é obrigatória.")
            .MustAsync(ValidarTipoFormacaoExistenteAsync).WithMessage("A chave do tipo de formação não foi encontrada.");
    }

    private async Task<bool> ValidarTipoFormacaoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _tipoFormacaoRepository.ExistsAsync(key, token);
    }
}