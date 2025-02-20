using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Ofertas;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Produtos;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Ofertas.PesquisarOferta;

public class PesquisarOfertaQueryHandler : IQueryHandler<PesquisarOfertaQuery, ResultadoPaginadoDto<OfertaDto>>
{
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IProdutoRepository _produtoRepository;
    private readonly IIntakeRepository _intakeRepository;

    public PesquisarOfertaQueryHandler(
        IOfertaRepository ofertaRepository, 
        IProdutoRepository produtoRepository, 
        IIntakeRepository intakeRepository)
    {
        _ofertaRepository = ofertaRepository;
        _produtoRepository = produtoRepository;
        _intakeRepository = intakeRepository;
    }

    public async Task<ResultadoPaginadoDto<OfertaDto>> Handle(PesquisarOfertaQuery request, CancellationToken cancellationToken)
    {
        var query = from oferta in _ofertaRepository.GetQueryable()
                    join produto in _produtoRepository.GetQueryable()
                        on oferta.ProdutoId equals produto.Id
                    join intake in _intakeRepository.GetQueryable()
                        on oferta.IntakeId equals intake.Id
                    select new OfertaDto
                    {
                        Key = oferta.Key,
                        ProdutoKey = produto.Key,
                        IntakeKey = intake.Key,
                    };

        if (request.Filtros?.ProdutoKey != null)
        {
            query = query.Where(o => o.ProdutoKey == request.Filtros!.ProdutoKey.Value);
        }

        if (request.Filtros?.IntakeKey != null)
        {
            query = query.Where(o => o.IntakeKey == request.Filtros!.IntakeKey.Value);
        }

        int totalRegistros = await query.CountAsync();

        var queryResult = query
            .OrderBy(o => o.Key)
            .Skip(request.Paginacao.QuantidadeRegistros * (request.Paginacao.NumeroPagina - 1))
            .Take(request.Paginacao.QuantidadeRegistros);

        return new ResultadoPaginadoDto<OfertaDto>(
            await queryResult.ToListAsync(cancellationToken),
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros
        );
    }
}
