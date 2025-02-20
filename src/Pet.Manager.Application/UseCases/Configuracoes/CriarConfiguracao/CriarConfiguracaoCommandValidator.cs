using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Configuracoes.CriarConfiguracao;

public class CriarConfiguracaoCommandValidator : ApplicationRequestValidator<CriarConfiguracaoCommand, EntityKeyDto?>
{
    const int MinLengthChave = 3;
    const int MaxLengthChave = 150;

    const int MinLengthValor = 1;
    const int MaxLengthValor = 500;

    public CriarConfiguracaoCommandValidator(INotificationContext notificationContext) 
        : base(notificationContext)
    {
        RuleFor(x => x.ChaveGenerica)
            .NotEmpty().WithMessage("A chave genérica da configuração é obrigatória.")
            .Length(MinLengthChave, MaxLengthChave)
            .WithMessage("A chave genérica da configuração deve ter entre {MinLength} e {MaxLength} caracteres.");

        RuleFor(x => x.Valor)
            .NotEmpty().WithMessage("O valor da configuração é obrigatório.")
            .Length(MinLengthValor, MaxLengthValor)
            .WithMessage("O valor da configuração deve ter entre {MinLength} e {MaxLength} caracteres.");
    }
}
