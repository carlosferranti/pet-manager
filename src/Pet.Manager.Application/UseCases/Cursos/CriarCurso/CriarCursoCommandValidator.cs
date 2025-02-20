using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.TiposFormacao;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Cursos.CriarCurso;

public class CriarCursoCommandValidator : ApplicationRequestValidator<CriarCursoCommand, EntityKeyDto?>
{
    private const int LimiteMaximoNome = 100;
    private const int LimiteMaximoCodigoOrigem = 100;
    private const int LimiteMaximoNomeComercial = 200;

    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemasRepository;
    private readonly INivelCursoRepository _nivelCursoRepository;
    private readonly IInstituicaoRepository _instituicaoRepository;

    public CriarCursoCommandValidator(
        IModalidadeRepository modalidadeRepository,
        ITipoFormacaoRepository tipoFormacaoRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository,
        INivelCursoRepository nivelCursoRepository,
        IInstituicaoRepository instituicaoRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _modalidadeRepository = modalidadeRepository;
        _tipoFormacaoRepository = tipoFormacaoRepository;
        _integracaoSistemasRepository = integracaoSistemaRepository;
        _nivelCursoRepository = nivelCursoRepository;
        _instituicaoRepository = instituicaoRepository;

        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("O nome do curso é obrigatório.")
            .MaximumLength(LimiteMaximoNome).WithMessage("O nome do curso deve ter no máximo {MaxLength} caracteres.");

        When(x => !string.IsNullOrEmpty(x.NomeComercial), () =>
        {
            RuleFor(x => x.NomeComercial)
                .MaximumLength(LimiteMaximoNomeComercial)
                .WithMessage("O nome comercial do campus deve ter no máximo {MaxLength} caracteres.");
        });

        RuleFor(x => x.ModalidadeKey)
            .NotEmpty().WithMessage("A chave da modalidade é obrigatória.")
            .MustAsync(ValidarModalidadeExistenteAsync).WithMessage("A chave da modalidade não foi encontrada.");

        RuleFor(x => x.TipoFormacaoKey)
            .NotEmpty().WithMessage("A chave do tipo de formação é obrigatória.")
            .MustAsync(ValidarTipoFormacaoExistenteAsync).WithMessage("A chave do tipo de formação não foi encontrada.");
        
        RuleFor(x => x.InstituicaoKey)
            .NotEmpty().WithMessage("A chave da instituição é obrigatória.")
            .MustAsync(ValidarInstituicaoExistenteAsync).WithMessage("A chave da instituição não foi encontrada.");

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

        RuleFor(x => x.NivelCursoKey)
            .NotEmpty().WithMessage("A chave do nível do curso é obrigatória.")
            .MustAsync(ValidarNivelCursoExisteAsync).WithMessage("A chave do nível do curso não foi encontrada.");
    }

    private async Task<bool> ValidarModalidadeExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _modalidadeRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarTipoFormacaoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _tipoFormacaoRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarNomeSistemaIntegracaoExistenteAsync(string nome, CancellationToken token = default)
    {
        return await _integracaoSistemasRepository.GetAsync(x => x.Nome.ToUpper() == nome.ToUpper()) != null;
    }

    private async Task<bool> ValidarNivelCursoExisteAsync(Guid key, CancellationToken token = default)
    {
        return await _nivelCursoRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarInstituicaoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _instituicaoRepository.ExistsAsync(key, token);
    }
}