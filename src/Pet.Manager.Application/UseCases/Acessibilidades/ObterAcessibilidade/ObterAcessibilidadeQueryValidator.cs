using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Acessibilidades;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Acessibilidades;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Acessibilidades.ObterAcessibilidade;

public class ObterAcessibilidadeQueryValidator : ApplicationRequestValidator<ObterAcessibilidadeQuery, AcessibilidadeDto>
{
    private readonly IAcessibilidadeRepository _acessibilidadeRepository;

    public ObterAcessibilidadeQueryValidator(
        IAcessibilidadeRepository acessibilidadeRepository,
        INotificationContext notificationContext) 
        : base(notificationContext)
    {
        _acessibilidadeRepository = acessibilidadeRepository;

        RuleFor(x => x.Key)
            .NotEmpty()
            .WithMessage("A chave da acessibilidade é obrigatória.")
            .MustAsync(AcessibilidadeExiste)
            .WithMessage("A acessibilidade não foi encontrada.");
    }

    private Task<bool> AcessibilidadeExiste(Guid key, CancellationToken token = default)
    {
        return _acessibilidadeRepository.ExistsAsync(key, token);
    }
}
