using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.ModalidadesAvaliacao;
using Anima.Inscricao.Domain.TiposFormacao;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Concursos.CriarConcurso;

public class CriarConcursoCommandValidator : ApplicationRequestValidator<CriarConcursoCommand, EntityKeyDto?>
{
    private const int LimiteMaximoNome = 100;
    private const int LimiteMaximoPeriodoLetivo = 10;
    private const int LimiteMaximoCodigoOrigem = 100;

    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemasRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly IModalidadeAvaliacaoRepository _modalidadeAvaliacaoRepository;

    public CriarConcursoCommandValidator(
        IFormaEntradaRepository formaEntradaRepository,
        ITipoFormacaoRepository tipoFormacaoRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository,
        IModalidadeRepository modalidadeRepository,
        IModalidadeAvaliacaoRepository modalidadeAvaliacaoRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _formaEntradaRepository = formaEntradaRepository;
        _tipoFormacaoRepository = tipoFormacaoRepository;
        _integracaoSistemasRepository = integracaoSistemaRepository;
        _modalidadeRepository = modalidadeRepository;
        _modalidadeAvaliacaoRepository = modalidadeAvaliacaoRepository;

        RuleFor(x => x.Nome)
            .NotNull().WithMessage("O nome do concurso é obrigatório.")
            .MaximumLength(LimiteMaximoNome).WithMessage("O nome do concurso deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.PeriodoLetivo)
           .NotNull().WithMessage("O período letivo é obrigatório.")
           .MaximumLength(LimiteMaximoPeriodoLetivo).WithMessage("O período letivo deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.InicioInscricao)
            .NotEmpty()
            .WithMessage("Data de inicio da incrição inválida.");

        RuleFor(x => x.TerminoInscricao)
            .NotEmpty()
            .WithMessage("Data de término da inscrição inválida.");

        RuleFor(x => x.FormasEntrada)
            .NotEmpty().WithMessage("As chaves das formas de entrada são obrigatórias.");

        When(x => x.FormasEntrada != null, () =>
        {
            RuleForEach(x => x.FormasEntrada).ChildRules(formaEntrada =>
            {
                formaEntrada.RuleFor(x => x.Key)
                .NotEmpty().WithMessage("A chave da forma de entrada é obrigatória.")
                .MustAsync(ValidarFormaEntradaExistenteAsync).WithMessage("A chave da forma de entrada não foi encontrada.");
            });
        });
    
        RuleFor(x => x.TipoFormacaoKey)
            .NotEmpty().WithMessage("A chave do tipo de formação é obrigatória.")
            .MustAsync(ValidarTipoFormacaoExistenteAsync).WithMessage("A chave do tipo de formação não foi encontrada.");

        RuleFor(x => x.ModalidadeKey)
            .NotEmpty().WithMessage("A chave da modalidade é obrigatória.")
            .MustAsync(ValidarModalidadeExistenteAsync).WithMessage("A chave da modalidade não foi encontrada.");

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

        When(x => x.IntegracaoFormaProva != null, () =>
        {
            RuleForEach(x => x.IntegracaoFormaProva).ChildRules(integracoesFormaProva =>
            {
                integracoesFormaProva.RuleFor(x => x.NomeSistema)
                .MustAsync(ValidarNomeSistemaIntegracaoExistenteAsync)
                .WithMessage("Nome do sistema de integração não encontrado.");
            });
        });

        When(x => x.ModalidadeAvaliacaoKey.HasValue, () =>
        {
            RuleFor(x => x.ModalidadeAvaliacaoKey!.Value)
                .MustAsync(ValidarModalidadeAvaliacaoExistenteAsync)
                    .WithMessage("A chave da modalidade de avaiação não foi encontrada.");
        });
    }

    private async Task<bool> ValidarFormaEntradaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _formaEntradaRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarTipoFormacaoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _tipoFormacaoRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarNomeSistemaIntegracaoExistenteAsync(string nome, CancellationToken token = default)
    {
        return await _integracaoSistemasRepository.GetAsync(x => x.Nome.ToUpper() == nome.ToUpper()) != null;
    }

    private async Task<bool> ValidarModalidadeExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _modalidadeRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarModalidadeAvaliacaoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _modalidadeAvaliacaoRepository.ExistsAsync(key, token);
    }
}
