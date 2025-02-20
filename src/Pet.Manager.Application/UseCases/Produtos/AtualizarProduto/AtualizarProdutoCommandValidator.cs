using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Domain.Turnos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Produtos.AtualizarProduto;

public class AtualizarProdutoCommandValidator : ApplicationRequestValidator<AtualizarProdutoCommand>
{
    private const int LimiteMaximoSku = 255;

    private readonly IProdutoRepository _produtoRepository;
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly ICampusRepository _campusRepository;
    private readonly ICursoRepository _cursoRepository;
    private readonly ITurnoRepository _turnoRepository;

    public AtualizarProdutoCommandValidator(
        IProdutoRepository produtoRepository, 
        IInstituicaoRepository instituicaoRepository, 
        ICampusRepository campusRepository, 
        ICursoRepository cursoRepository, 
        ITurnoRepository turnoRepository,
        INotificationContext notificationContext) : base(notificationContext)
    {
        _produtoRepository = produtoRepository;
        _instituicaoRepository = instituicaoRepository;
        _campusRepository = campusRepository;
        _cursoRepository = cursoRepository;
        _turnoRepository = turnoRepository;

        RuleFor( x => x.Key)
            .NotEmpty().WithMessage("A chave do produto é obrigatória.")
            .MustAsync(ValidarProdutoExistenteAsync).WithMessage("A chave do produto não foi encontrada.");

        RuleFor(x => x.InstituicaoKey)
        .NotEmpty().WithMessage("A chave da instituição é obrigatória.")
        .MustAsync(ValidarInstituicaoExistenteAsync).WithMessage("A chave da instituição não foi encontrada.");

        RuleFor(x => x.CampusKey)
        .NotEmpty().WithMessage("A chave da campus é obrigatória.")
        .MustAsync(ValidarCampusExistenteAsync).WithMessage("A chave da campus não foi encontrada.");

        RuleFor(x => x.CursoKey)
        .NotEmpty().WithMessage("A chave da curso é obrigatória.")
        .MustAsync(ValidarCursoExistenteAsync).WithMessage("A chave da curso não foi encontrada.");

        RuleFor(x => x.TurnoKey)
        .NotEmpty().WithMessage("A chave da turno é obrigatória.")
        .MustAsync(ValidarTurnoExistenteAsync).WithMessage("A chave da turno não foi encontrada.");

        RuleFor(x => x.Sku)
        .NotEmpty().WithMessage("O sku é obrigatório.")
        .MaximumLength(LimiteMaximoSku).WithMessage("O sku deve ter no máximo {MaxLength} caracteres.");
    }


    private async Task<bool> ValidarProdutoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _produtoRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarInstituicaoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _instituicaoRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarCampusExistenteAsync(Guid key, CancellationToken token)
    {
        return await _campusRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarCursoExistenteAsync(Guid key, CancellationToken token)
    {
        return await _cursoRepository.ExistsAsync(key,token);
    }

    private async Task<bool> ValidarTurnoExistenteAsync(Guid key, CancellationToken token)
    {
        return await _turnoRepository.ExistsAsync(key, token);
    }
}
