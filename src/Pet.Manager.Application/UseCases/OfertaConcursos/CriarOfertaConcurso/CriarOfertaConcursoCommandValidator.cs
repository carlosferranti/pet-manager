using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.OfertaConcursos.CriarOfertaConcurso;

public class CriarOfertaConcursoCommandValidator : ApplicationRequestValidator<CriarOfertaConcursoCommand, EntityKeyDto>
{
    private const int LimiteMaximoNome = 100;
    private const int LimiteMaximoCodigoOrigem = 100;

    private readonly IOfertaRepository _ofertaRepository;
    private readonly IConcursoRepository _concursoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemasRepository;

    public CriarOfertaConcursoCommandValidator(
        IOfertaRepository ofertaRepository, 
        IConcursoRepository concursoRepository, 
        IIntegracaoSistemaRepository integracaoSistemasRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _ofertaRepository = ofertaRepository;
        _concursoRepository = concursoRepository;
        _integracaoSistemasRepository = integracaoSistemasRepository;

        RuleFor(x => x.OfertaKey)
            .NotEmpty().WithMessage("A chave da oferta é obrigatória.")
            .MustAsync(ValidarOfertaExistenteAsync).WithMessage("A chave da oferta não foi encontrada.");

        RuleFor(x => x.ConcursoKey)
            .NotEmpty().WithMessage("A chave do concurso é obrigatória.")
            .MustAsync(ValidarConcursoExistenteAsync).WithMessage("A chave do concurso não foi encontrada.");

        When(x => x.Integracao != null, () =>
        {
            RuleFor(x => x.Integracao!.NomeSistema)
            .MaximumLength(LimiteMaximoNome)
                .WithMessage("O nome do sistema de integração deve ter no máximo {MaxLength} caracteres.")
            .MustAsync(ValidarNomeSistemaIntegracaoExistenteAsync)
                .WithMessage("Nome do sistema de integração não encontrado.");

            RuleFor(x => x.Integracao!.CodigoOrigem)
            .MaximumLength(LimiteMaximoCodigoOrigem)
            .WithMessage("O código de origem da integração deve ter no máximo {MaxLength} caracteres.");
        });
    }

    private async Task<bool> ValidarOfertaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _ofertaRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarConcursoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _concursoRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarNomeSistemaIntegracaoExistenteAsync(string nome, CancellationToken token = default)
    {
        return await _integracaoSistemasRepository.GetAsync(x => x.Nome.ToUpper() == nome.ToUpper()) != null;
    }
}
