using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Modalidades;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Modalidades.RemoverModalidade;

public class RemoverModalidadeCommandValidator : ApplicationRequestValidator<RemoverModalidadeCommand>
{
    private readonly IModalidadeRepository _modalidadeRepository;

    public RemoverModalidadeCommandValidator(
        IModalidadeRepository modalidadeRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _modalidadeRepository = modalidadeRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave da modalidade é obrigatória.")
            .MustAsync(ValidarModalidadeExistenteAsync).WithMessage("A chave da modalidade não foi encontrada.");
    }

    private async Task<bool> ValidarModalidadeExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _modalidadeRepository.ExistsAsync(key, token);
    }
}
