using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.TiposFormacao;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Cursos.AtualizarCurso;

public class AtualizarCursoCommandValidator : ApplicationRequestValidator<AtualizarCursoCommand>
{
    private const int LimiteMaximoNome = 100;
    private const int LimiteMaximoNomeComercial = 200;

    private readonly ICursoRepository _cursoRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly INivelCursoRepository _nivelCursoRepository;
    private readonly IInstituicaoRepository _instituicaoRepository;

    public AtualizarCursoCommandValidator(
        ICursoRepository cursoRepository,
        IModalidadeRepository modalidadeRepository,
        ITipoFormacaoRepository tipoFormacaoRepository,
        INivelCursoRepository nivelCursoRepository,
        IInstituicaoRepository instituicaoRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _cursoRepository = cursoRepository;
        _modalidadeRepository = modalidadeRepository;
        _tipoFormacaoRepository = tipoFormacaoRepository;
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

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave do curso é obrigatória.")
            .MustAsync(ValidarCursoExistenteAsync).WithMessage("A chave do curso não foi encontrada.");

        RuleFor(x => x.ModalidadeKey)
            .NotEmpty().WithMessage("A chave da modalidade é obrigatória.")
            .MustAsync(ValidarModalidadeExistenteAsync).WithMessage("A chave da modalidade não foi encontrada.");

        RuleFor(x => x.TipoFormacaoKey)
            .NotEmpty().WithMessage("A chave do tipo de formação é obrigatória.")
            .MustAsync(ValidarTipoFormacaoExistenteAsync).WithMessage("A chave do tipo de formação não foi encontrada.");

        RuleFor(x => x.NivelCursoKey)
            .NotEmpty().WithMessage("A chave do nível do curso é obrigatória.")
            .MustAsync(ValidarNivelCursoExistenteAsync).WithMessage("A chave do nível do curso não foi encontrada.");
        
        RuleFor(x => x.InstituicaoKey)
            .NotEmpty().WithMessage("A chave da instituição é obrigatória.")
            .MustAsync(ValidarInstituicaoExistenteAsync).WithMessage("A chave da instituição não foi encontrada.");
    }

    private async Task<bool> ValidarCursoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _cursoRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarModalidadeExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _modalidadeRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarTipoFormacaoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _tipoFormacaoRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarNivelCursoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _nivelCursoRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarInstituicaoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _instituicaoRepository.ExistsAsync(key, token);
    }
}