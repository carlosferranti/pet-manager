using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Instituicao;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Instituicoes;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Instituicoes.ObterInstituicao;

public class ObterInstituicaoQueryValidator : ApplicationRequestValidator<ObterInstituicaoQuery, InstituicaoDto>
{
    private readonly IInstituicaoRepository _instituicaoRepository;

    public ObterInstituicaoQueryValidator(
        IInstituicaoRepository instituicaoRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _instituicaoRepository = instituicaoRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave da instituição é obrigatória.")
            .MustAsync(ValidarInstituicaoExistenteAsync).WithMessage("A chave da instituição não foi encontrada.");
    }

    private async Task<bool> ValidarInstituicaoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _instituicaoRepository.ExistsAsync(key, token);
    }
}
