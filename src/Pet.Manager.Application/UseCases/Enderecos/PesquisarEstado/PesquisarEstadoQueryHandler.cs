using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Enderecos;
using Anima.Inscricao.Domain.Enderecos;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Enderecos.PesquisarEstado;

public class PesquisarEstadoQueryHandler : IQueryHandler<PesquisarEstadoQuery, ResultadoPaginadoDto<EstadoDto>>
{
    private readonly IPaisRepository _paisRepository;
    private readonly IEstadoRepository _estadoRepository;

    public PesquisarEstadoQueryHandler(IPaisRepository paisRepository, IEstadoRepository estadoRepository)
    {
        _paisRepository = paisRepository;
        _estadoRepository = estadoRepository;
    }

    public async Task<ResultadoPaginadoDto<EstadoDto>> Handle(PesquisarEstadoQuery request, CancellationToken cancellationToken)
    {
        var query = from estado in _estadoRepository.GetQueryable()
                    join pais in _paisRepository.GetQueryable()
                        on estado.PaisId equals pais.Id
                    select new EstadoDto()
                    {
                        Key = estado.Key,
                        Nome = estado.Nome,
                        Sigla = estado.Sigla,
                        PaisKey = pais.Key,
                    };

        if (request.Filtros?.PaisKey.HasValue == true)
        {
            query = query.Where(o => o.PaisKey.Equals(request.Filtros!.PaisKey));
        }

        int totalRegistros = await query.CountAsync();

        var queryResult = query
            .OrderBy(o => o.Nome)
            .Skip(request.Paginacao.QuantidadeRegistros * (request.Paginacao.NumeroPagina - 1))
            .Take(request.Paginacao.QuantidadeRegistros);

        return new ResultadoPaginadoDto<EstadoDto>(
            await queryResult.ToListAsync(cancellationToken),
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros
        );
    }
}