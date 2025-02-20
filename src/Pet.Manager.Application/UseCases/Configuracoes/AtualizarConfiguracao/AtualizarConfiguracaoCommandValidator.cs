using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Configuracoes;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Configuracoes.AtualizarConfiguracao;

public class AtualizarConfiguracaoCommandValidator : ApplicationRequestValidator<AtualizarConfiguracaoCommand>
{
    const int MinLengthChave = 3;
    const int MaxLengthChave = 150;

    const int MinLengthValor = 1;
    const int MaxLengthValor = 500;

    private readonly IConfiguracaoRepository _configuracaoRepository;

    public AtualizarConfiguracaoCommandValidator(
        INotificationContext notificationContext,
        IConfiguracaoRepository configuracaoRepository) 
        : base(notificationContext)
    {
        _configuracaoRepository = configuracaoRepository;
        
        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave da configuração é obrigatória.")
            .MustAsync(ValidarConfiguracaoExistenteAsync).WithMessage("A chave da configuração não foi encontrada.");

        RuleFor(x => x.ChaveGenerica)
            .NotEmpty().WithMessage("A chave genérica da configuração é obrigatória.")
            .Length(MinLengthChave, MaxLengthChave)
            .WithMessage("A chave genérica da configuração deve ter entre {MinLength} e {MaxLength} caracteres.");

        RuleFor(x => x.Valor)
            .NotEmpty().WithMessage("O valor da configuração é obrigatório.")
            .Length(MinLengthValor, MaxLengthValor)
            .WithMessage("O valor da configuração deve ter entre {MinLength} e {MaxLength} caracteres.");
    }

    private async Task<bool> ValidarConfiguracaoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _configuracaoRepository.ExistsAsync(key, token);
    }
}
