using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Escola;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Escolas;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Escolas.PesquisarEscola;

public class PesquisarEscolaQueryHandler : IQueryHandler<PesquisarEscolaQuery, ResultadoPaginadoDto<EscolaDto>>
{
    private readonly IEscolaRepository _escolaRepository;
    private readonly ICidadeRepository _cidadeRepository;

    public PesquisarEscolaQueryHandler(
        IEscolaRepository escolaRepository, 
        ICidadeRepository cidadeRepository)
    {
        _escolaRepository = escolaRepository;
        _cidadeRepository = cidadeRepository;
    }

    public async Task<ResultadoPaginadoDto<EscolaDto>> Handle(PesquisarEscolaQuery request, CancellationToken cancellationToken)
    {
        var query = from escola in _escolaRepository.GetQueryable()
                    join cidade in _cidadeRepository.GetQueryable().DefaultIfEmpty()
                        on escola.CidadeId equals cidade.Id into cidadeJoin
                    from cidadeEscola in cidadeJoin.DefaultIfEmpty()
                    select new EscolaDto()
                    {
                        Key = escola.Key,
                        Nome = escola.Nome,
                        CidadeKey = cidadeEscola.Key,
                        CodigoInep = escola.CodigoInep,
                        TipoCategoria = escola.TipoCategoria,
                    };

        if(request.Filtros?.CidadeKey.HasValue == true)
        {
            query = query.Where(o => o.CidadeKey.Equals(request.Filtros!.CidadeKey));
        }

        if (request.Filtros?.TipoCategoria.HasValue == true)
        {
            query = query.Where(o => o.TipoCategoria.Equals(request.Filtros!.TipoCategoria));
        }

        int totalRegistros = await query.CountAsync();

        var queryResult = query
            .OrderBy(o => o.Nome)
            .Skip(request.Paginacao.QuantidadeRegistros * (request.Paginacao.NumeroPagina - 1))
            .Take(request.Paginacao.QuantidadeRegistros);

        return new ResultadoPaginadoDto<EscolaDto>(
            await queryResult.ToListAsync(), 
            request.Paginacao.NumeroPagina, 
            request.Paginacao.QuantidadeRegistros, 
            totalRegistros);
    }
}
