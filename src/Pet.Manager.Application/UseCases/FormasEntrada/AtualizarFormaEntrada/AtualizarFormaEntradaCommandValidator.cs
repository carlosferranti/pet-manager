using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.FormasEntrada;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.FormasEntrada.AtualizarFormaEntrada;

public class AtualizarFormaEntradaCommandValidator : ApplicationRequestValidator<AtualizarFormaEntradaCommand>
{
    private const int LimiteMaximoNome = 100;
    private const int LimiteMaximoDescricao = 255;

    private readonly IFormaEntradaRepository _formaEntradaRepository;

    public AtualizarFormaEntradaCommandValidator(
        IFormaEntradaRepository formaEntradaRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _formaEntradaRepository = formaEntradaRepository;

        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O nome da forma de entrada é obrigatório.")
            .MaximumLength(LimiteMaximoNome).WithMessage("O nome da forma de entrada deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave da forma de entrada é obrigatória.")
            .MustAsync(ValidarFormeEntradaExistenteAsync).WithMessage("A chave da forma de entrada não foi encontrada.");

        RuleFor(x => x.ExibeCard)
           .NotEmpty().WithMessage("É obrigatório informar se a forma de entrada exibe card ou não.");

        When(x => x.Descricao != null, () =>
        {
            RuleFor(x => x.Descricao)
                .MaximumLength(LimiteMaximoDescricao).WithMessage("A descrição da forma de entrada deve ter no máximo {MaxLength} caracteres.");
        });
    }

    private async Task<bool> ValidarFormeEntradaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _formaEntradaRepository.ExistsAsync(key, token);
    }
}
