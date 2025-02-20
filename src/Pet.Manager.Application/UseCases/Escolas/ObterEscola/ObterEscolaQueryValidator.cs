using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Escola;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Escolas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Escolas.ObterEscola;

public class ObterEscolaQueryValidator : ApplicationRequestValidator<ObterEscolaQuery, EscolaDto>
{
    private readonly IEscolaRepository _escolaRepository;

    public ObterEscolaQueryValidator(
        INotificationContext notificationContext,
        IEscolaRepository escolaRepository) 
        : base(notificationContext)
    {
        _escolaRepository = escolaRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave da escola é obrigatória.")
            .MustAsync(ValidarEscolaExistenteAsync).WithMessage("A chave da escola não foi encontrada.");
    }

    private async Task<bool> ValidarEscolaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _escolaRepository.ExistsAsync(key, token);
    }
}
