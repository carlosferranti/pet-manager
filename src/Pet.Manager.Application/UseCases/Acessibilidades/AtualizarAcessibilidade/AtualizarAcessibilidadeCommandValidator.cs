using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Acessibilidades;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Acessibilidades.AtualizarAcessibilidade;

public class AtualizarAcessibilidadeCommandValidator : ApplicationRequestValidator<AtualizarAcessibilidadeCommand>
{
    private const int LimiteMaximoNome = 100;

    private readonly IAcessibilidadeRepository _acessibilidadeRepository;

    public AtualizarAcessibilidadeCommandValidator(INotificationContext notificationContext, IAcessibilidadeRepository acessibilidadeRepository) 
        : base(notificationContext)
    {
        _acessibilidadeRepository = acessibilidadeRepository;

        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O nome da acessibilidade é obrigatório.")
            .MaximumLength(LimiteMaximoNome).WithMessage("O nome da acessibilidade deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave da acessibilidade é obrigatória.")
            .MustAsync(ValidarAcessibilidadeExistenteAsync).WithMessage("A acessibilidade não foi encontrada.");
    }

    private async Task<bool> ValidarAcessibilidadeExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _acessibilidadeRepository.ExistsAsync(key, token);
    }
}
