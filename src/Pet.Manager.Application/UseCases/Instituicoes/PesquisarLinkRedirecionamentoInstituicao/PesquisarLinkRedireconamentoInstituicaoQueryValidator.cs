using Amazon.S3.Model;

using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Inscricoes;
using Anima.Inscricao.Application.DTOs.Instituicao;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricoes.Domain.Inscricoes;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Instituicoes.PesquisarLinkRedirecionamentoCandidato;

public class PesquisarLinkRedireconamentoInstituicaoQueryValidator : ApplicationRequestValidator<PesquisarLinkRedireconamentoInstituicaoQuery, InstituicaoLinkDto>
{
    public readonly IInscricaoRepository _inscricaoRepository;

    public PesquisarLinkRedireconamentoInstituicaoQueryValidator(INotificationContext notificationContext, IInscricaoRepository inscricaoRepository)
    : base(notificationContext)
    {
        _inscricaoRepository = inscricaoRepository;


        RuleFor(x => x.key)
            .NotEmpty().WithMessage("A chave da inscrição é obrigatória.")
            .MustAsync(ValidarInscricaoKeyExistenteAsync).WithMessage("A chave da inscrição não foi encontrada.");
    }

    private async Task<bool> ValidarInscricaoKeyExistenteAsync(Guid key, CancellationToken token = default)
    {
        var retorno = await _inscricaoRepository.ExistsAsync(key, token);

        return retorno;
    }
}

