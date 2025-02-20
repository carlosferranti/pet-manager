using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Escolas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Escolas.AtualizarEscola;

public class AtualizarEscolaCommandValidator : ApplicationRequestValidator<AtualizarEscolaCommand>
{
    private const int LimiteMinimoCaracteresNome = 3;
    private const int LimiteMaximoCaracteresNome = 200;

    private readonly IEscolaRepository _escolaRepository;
    private readonly ICidadeRepository _cidadeRepository;

    public AtualizarEscolaCommandValidator(
        INotificationContext notificationContext,
        IEscolaRepository escolaRepository,
        ICidadeRepository cidadeRepository) 
        : base(notificationContext)
    {
        _escolaRepository = escolaRepository;
        _cidadeRepository = cidadeRepository;

        RuleFor(x => x.Key)
            .NotEmpty()
            .WithMessage("A chave da escola é obrigatória.")
            .MustAsync(ExistirEscola)
            .WithMessage("A chave da Escola não foi encontrada");

        RuleFor(x => x.Nome)
            .NotEmpty()
            .WithMessage("O nome da escola é obrigatório.")
            .Length(LimiteMinimoCaracteresNome, LimiteMaximoCaracteresNome)
            .WithMessage("O nome da escola deve ter entre {MinLength} e {MaxLength} caracteres.");

        RuleFor(x => x.CidadeKey!.Value)
            .MustAsync(ExistirCidade)
            .WithMessage("A chave da Cidade não foi encontrada.")
            .When(x => x.CidadeKey.HasValue);
    }

    private async Task<bool> ExistirEscola(Guid key, CancellationToken cancellationToken)
    {
        return await _escolaRepository.ExistsAsync(key, cancellationToken);
    }

    private async Task<bool> ExistirCidade(Guid key, CancellationToken cancellationToken)
    {
       return await _cidadeRepository.ExistsAsync(key, cancellationToken);
    }
}
