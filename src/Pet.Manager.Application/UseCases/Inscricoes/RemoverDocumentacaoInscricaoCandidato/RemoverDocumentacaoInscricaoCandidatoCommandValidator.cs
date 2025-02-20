using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Inscricoes;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.RemoverDocumentacaoInscricaoCandidato;

public class RemoverDocumentacaoInscricaoCandidatoCommandValidator : ApplicationRequestValidator<RemoverDocumentacaoInscricaoCandidatoCommand>
{
    private readonly IInscricaoDocumentacaoRepository _inscricaoDocumentacaoRepository;

    public RemoverDocumentacaoInscricaoCandidatoCommandValidator(
        INotificationContext notificationContext,
        IInscricaoDocumentacaoRepository inscricaoDocumentacaoRepository)
        : base(notificationContext)
    {
        _inscricaoDocumentacaoRepository = inscricaoDocumentacaoRepository;

        RuleFor(x => x.InscricaoDocumentacaoKey)
            .NotEmpty()
                .WithMessage("A chave da inscrição documentacao é obrigatória.")
            .MustAsync(ValidarInscricaoDocumentacaoExistenteAsync)
                .WithMessage("A chave da inscrição documentacao não foi encontrada.");
    }

    private async Task<bool> ValidarInscricaoDocumentacaoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _inscricaoDocumentacaoRepository.ExistsAsync(key, token);
    }
}