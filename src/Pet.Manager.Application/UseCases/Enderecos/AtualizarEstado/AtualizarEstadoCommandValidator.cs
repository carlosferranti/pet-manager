using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Enderecos.AtualizarEstado;

public class AtualizarEstadoCommandValidator : ApplicationRequestValidator<AtualizarEstadoCommand>
{
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresSigla = 10;

    private readonly IPaisRepository _paisRepository;
    private readonly IEstadoRepository _estadoRepository;

    public AtualizarEstadoCommandValidator(
        INotificationContext notificationContext,
        IPaisRepository paisRepository,
        IEstadoRepository estadoRepository)
        : base(notificationContext)
    {
        _paisRepository = paisRepository;
        _estadoRepository = estadoRepository;

        RuleFor(x => x.Key)
           .NotEmpty().WithMessage("A chave do estado é obrigatória.")
           .MustAsync(ValidarEstadoExistenteAsync).WithMessage("A chave do estado não foi encontrada.");

        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O nome do estado é obrigatório.")
            .MaximumLength(LimiteCaracteresNome)
            .WithMessage("O nome do estado deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.Sigla)
            .NotEmpty().WithMessage("A sigla do estado é obrigatória.")
            .MaximumLength(LimiteCaracteresSigla)
            .WithMessage("A sigla do estado deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.PaisKey)
            .NotEmpty().WithMessage("A chave do país é obrigatória.")
            .MustAsync(ValidarPaisExistenteAsync).WithMessage("A chave do país não foi encontrada.");
    }

    private async Task<bool> ValidarPaisExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _paisRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarEstadoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _estadoRepository.ExistsAsync(key, token);
    }
}
