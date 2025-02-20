using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Enderecos.AtualizarCidade;

public class AtualizarCidadeCommandValidator : ApplicationRequestValidator<AtualizarCidadeCommand>
{
    private const int LimiteCaracteresNome = 100;

    private readonly ICidadeRepository _cidadeRepository;
    private readonly IEstadoRepository _estadoRepository;

    public AtualizarCidadeCommandValidator(
        INotificationContext notificationContext,
        ICidadeRepository cidadeRepository,
        IEstadoRepository estadoRepository)
        : base(notificationContext)
    {
        _cidadeRepository = cidadeRepository;
        _estadoRepository = estadoRepository;

        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O nome da cidade é obrigatório.")
            .MaximumLength(LimiteCaracteresNome)
            .WithMessage("O nome da cidade deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.EstadoKey)
            .NotEmpty().WithMessage("A chave do estado é obrigatória.")
            .MustAsync(ValidarEstadoExistenteAsync).WithMessage("A chave do estado não foi encontrada.");
        
        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave da cidade é obrigatória.")
            .MustAsync(ValidarCidadeExistenteAsync).WithMessage("A chave da cidade não foi encontrada.");
    }

    private async Task<bool> ValidarEstadoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _estadoRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarCidadeExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _cidadeRepository.ExistsAsync(key, token);
    }
}
