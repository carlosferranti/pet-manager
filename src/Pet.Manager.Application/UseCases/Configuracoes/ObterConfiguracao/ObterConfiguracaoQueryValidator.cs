using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Cofiguracao;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Configuracoes;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Configuracoes.ObterConfiguracao;

public class ObterConfiguracaoQueryValidator : ApplicationRequestValidator<ObterConfiguracaoQuery, ConfiguracaoDto>
{
    private readonly IConfiguracaoRepository _configuracaoRepository;

    public ObterConfiguracaoQueryValidator(
        INotificationContext notificationContext,
        IConfiguracaoRepository configuracaoRepository) 
        : base(notificationContext)
    {
        _configuracaoRepository = configuracaoRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave da configuração é obrigatória.")
            .MustAsync(ValidarConfiguracaoExistenteAsync).WithMessage("A chave da configuração não foi encontrada.");
    }

    private async Task<bool> ValidarConfiguracaoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _configuracaoRepository.ExistsAsync(key, token);
    }
}
