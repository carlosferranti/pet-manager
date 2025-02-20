using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricoes.Domain.Inscricoes;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.ConcluirInscricaoCandidato;

public class ConcluirInscricaoCandidatoCommandValidator : ApplicationRequestValidator<ConcluirInscricaoCandidatoCommand>
{
    private readonly IInscricaoRepository _inscricaoRepository;

    public ConcluirInscricaoCandidatoCommandValidator(
        IInscricaoRepository inscricaoRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _inscricaoRepository = inscricaoRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave da inscrição é obrigatória.")
            .MustAsync(ValidarInscricaoExistenteAsync).WithMessage("A chave da inscrição não foi encontrada.");
    }

    private async Task<bool> ValidarInscricaoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _inscricaoRepository.ExistsAsync(key, token);
    }
}