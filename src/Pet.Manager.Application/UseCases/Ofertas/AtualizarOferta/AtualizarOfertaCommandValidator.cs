using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Produtos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Ofertas.AtualizarOferta;

public class AtualizarOfertaCommandValidator : ApplicationRequestValidator<AtualizarOfertaCommand>
{
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IProdutoRepository _produtoRepository;
    private readonly IIntakeRepository _intakeRepository;

    public AtualizarOfertaCommandValidator(
        IOfertaRepository ofertaRepository, 
        IProdutoRepository produtoRepository, 
        IIntakeRepository intakeRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _ofertaRepository = ofertaRepository;
        _produtoRepository = produtoRepository;
        _intakeRepository = intakeRepository;

        RuleFor(x => x.Key)
           .NotEmpty().WithMessage("A chave da oferta é obrigatória.")
           .MustAsync(ValidarOfertaExistenteAsync).WithMessage("A chave da oferta não foi encontrada.");

        RuleFor(x => x.ProdutoKey)
            .NotEmpty().WithMessage("A chave do produto é obrigatória.")
            .MustAsync(ValidarProdutoExistenteAsync).WithMessage("A chave do produto não foi encontrada.");

        RuleFor(x => x.IntakeKey)
            .NotEmpty().WithMessage("A chave do intake é obrigatória.")
            .MustAsync(ValidarIntakeExistenteAsync).WithMessage("A chave do intake não foi encontrada.");
    }

    private async Task<bool> ValidarOfertaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _ofertaRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarProdutoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _produtoRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarIntakeExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _intakeRepository.ExistsAsync(key, token);
    }
}
