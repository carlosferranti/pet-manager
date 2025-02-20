using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Enderecos;
using Anima.Inscricao.Domain.Enderecos;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Enderecos.PesquisarCidade;

public class PesquisarCidadeQueryHandler : IQueryHandler<PesquisarCidadeQuery, ResultadoPaginadoDto<CidadeDto>>
{
    private readonly ICidadeRepository _cidadeRepository;
    private readonly IEstadoRepository _estadoRepository;

    public PesquisarCidadeQueryHandler(ICidadeRepository cidadeRepository, IEstadoRepository estadoRepository)
    {
        _cidadeRepository = cidadeRepository;
        _estadoRepository = estadoRepository;
    }

    public async Task<ResultadoPaginadoDto<CidadeDto>> Handle(PesquisarCidadeQuery request, CancellationToken cancellationToken)
    {
        var query = from cidade in _cidadeRepository.GetQueryable()
                    join estado in _estadoRepository.GetQueryable()
                        on cidade.EstadoId equals estado.Id
                    select new CidadeDto()
                    {
                        Key = cidade.Key,
                        Nome = cidade.Nome,
                        EstadoKey = estado.Key,
                        CodigoMunicipio = cidade.CodigoMunicipio,
                        Ddd = cidade.Ddd,
                    };

        if (request.Filtros?.EstadoKey.HasValue == true)
        {
            query = query.Where(o => o.EstadoKey.Equals(request.Filtros!.EstadoKey));
        }

        int totalRegistros = await query.CountAsync();

        var queryResult = query
            .OrderBy(o => o.Nome)
            .Skip(request.Paginacao.QuantidadeRegistros * (request.Paginacao.NumeroPagina - 1))
            .Take(request.Paginacao.QuantidadeRegistros);

        return new ResultadoPaginadoDto<CidadeDto>(
            await queryResult.ToListAsync(cancellationToken),
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros
        );
    }
}