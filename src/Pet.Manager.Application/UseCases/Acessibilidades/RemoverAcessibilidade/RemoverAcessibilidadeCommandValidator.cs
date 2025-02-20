using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Acessibilidades;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Acessibilidades.RemoverAcessibilidade;

public class RemoverAcessibilidadeCommandValidator : ApplicationRequestValidator<RemoverAcessibilidadeCommand>
{
    private readonly IAcessibilidadeRepository _acessibilidadeRepository;

    public RemoverAcessibilidadeCommandValidator(
        INotificationContext notificationContext,
        IAcessibilidadeRepository acessibilidadeRepository) 
        : base(notificationContext)
    {
        _acessibilidadeRepository = acessibilidadeRepository;

        RuleFor(x => x.Key)
            .NotEmpty()
            .WithMessage("A chave da acessibilidade é obrigatória.")
            .MustAsync(AcessibilidadeExiste)
            .WithMessage("Acessibilidade não encontrada.");
    }

    private async Task<bool> AcessibilidadeExiste(Guid key, CancellationToken token = default)
    {
        return await _acessibilidadeRepository.ExistsAsync(key, token);
    }
}
