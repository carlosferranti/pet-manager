using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.TiposFormacao;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.TiposFormacao.RemoverTipoFormacao;

public class RemoverTipoFormacaoCommandValidator : ApplicationRequestValidator<RemoverTipoFormacaoCommand>
{
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;

    public RemoverTipoFormacaoCommandValidator(
        ITipoFormacaoRepository tipoFormacaoRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _tipoFormacaoRepository = tipoFormacaoRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave do tipo de formação é obrigatório.")
            .MustAsync(ValidarTipoFormacaoExistenteAsync).WithMessage("A chave do tipo de formação não foi encontrado.");
    }

    private async Task<bool> ValidarTipoFormacaoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _tipoFormacaoRepository.ExistsAsync(key, token);
    }
}
