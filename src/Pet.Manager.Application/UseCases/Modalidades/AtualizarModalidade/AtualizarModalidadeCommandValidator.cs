using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Modalidades;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Modalidades.AtualizarModalidade;

public class AtualizarModalidadeCommandValidator : ApplicationRequestValidator<AtualizarModalidadeCommand>
{
    private const int LimiteMaximoNome = 100;
    private const int LimiteMaximoDescricao = 255;

    private readonly IModalidadeRepository _modalidadeRepository;

    public AtualizarModalidadeCommandValidator(
        IModalidadeRepository modalidadeRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _modalidadeRepository = modalidadeRepository;

        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O nome da modalidade é obrigatório.")
            .MaximumLength(LimiteMaximoNome).WithMessage("O nome da modalidade deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave da modalidade é obrigatória.")
            .MustAsync(ValidarModalidadeExistenteAsync).WithMessage("A chave da modalidade não foi encontrada.");

        When(x => x.Descricao is not null, () =>
        {
            RuleFor(x => x.Descricao)
                .MaximumLength(LimiteMaximoDescricao).WithMessage("A descrição da modalidade deve ter no máximo {MaxLength} caracteres.");
        });
    }

    private async Task<bool> ValidarModalidadeExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _modalidadeRepository.ExistsAsync(key, token);
    }
}
