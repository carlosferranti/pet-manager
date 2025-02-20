using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campi;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Campi.AtualizarCampus;

public class AtualizarCampusCommandValidator : ApplicationRequestValidator<AtualizarCampusCommand>
{
    private const int LimiteMaximoNome = 100;
    private const int LimiteMaximoNomeComercial = 200;

    private readonly ICampusRepository _campusRepository;

    public AtualizarCampusCommandValidator(
        INotificationContext notificationContext, 
        ICampusRepository campusRepository) 
        : base(notificationContext)
    {
        _campusRepository = campusRepository;

        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O nome do campus é obrigatório.")
            .MaximumLength(LimiteMaximoNome).WithMessage("O nome do campus deve ter no máximo {MaxLength} caracteres.");

        When(x => !string.IsNullOrEmpty(x.NomeComercial), () =>
        {
            RuleFor(x => x.NomeComercial)
                .MaximumLength(LimiteMaximoNomeComercial)
                .WithMessage("O nome comercial do campus deve ter no máximo {MaxLength} caracteres.");
        });

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave do campus é obrigatória.")
            .MustAsync(ValidarCampusExistenteAsync).WithMessage("A chave do campus não foi encontrada.");
    }

    private async Task<bool> ValidarCampusExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _campusRepository.ExistsAsync(key, token);
    }
}
