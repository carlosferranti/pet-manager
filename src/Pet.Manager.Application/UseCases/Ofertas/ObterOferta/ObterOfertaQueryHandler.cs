using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Ofertas;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Produtos;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Ofertas.ObterOferta;

public class ObterOfertaQueryHandler : IQueryHandler<ObterOfertaQuery, OfertaDto>
{
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IProdutoRepository _produtoRepository;
    private readonly IIntakeRepository _intakeRepository;

    public ObterOfertaQueryHandler(
        IOfertaRepository ofertaRepository, 
        IProdutoRepository produtoRepository, 
        IIntakeRepository intakeRepository)
    {
        _ofertaRepository = ofertaRepository;
        _produtoRepository = produtoRepository;
        _intakeRepository = intakeRepository;
    }

    public async Task<OfertaDto> Handle(ObterOfertaQuery request, CancellationToken cancellationToken)
    {
        var query = from oferta in _ofertaRepository.GetQueryable()
                    join produto in _produtoRepository.GetQueryable()
                        on oferta.ProdutoId equals produto.Id
                    join intake in _intakeRepository.GetQueryable()
                        on oferta.IntakeId equals intake.Id
                    where oferta.Key == request.Key
                    select new OfertaDto
                    {
                        Key = oferta.Key,
                        ProdutoKey = produto.Key,
                        IntakeKey = intake.Key,
                    };

        return await query.SingleAsync();  
    }
}
