using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.DTOs.Turnos;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Turnos;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Turnos.PesquisarTurno;

public class PesquisarTurnoQueryHandler : IQueryHandler<PesquisarTurnoQuery, ResultadoPaginadoDto<TurnoDto>>
{
    private readonly ITurnoRepository _turnoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public PesquisarTurnoQueryHandler(
        ITurnoRepository turnoRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository)
    {
        _turnoRepository = turnoRepository;
        _integracaoSistemaRepository = integracaoSistemaRepository;
    }

    public async Task<ResultadoPaginadoDto<TurnoDto>> Handle(PesquisarTurnoQuery request, CancellationToken cancellationToken)
    {
        var query = from turno in _turnoRepository.GetQueryable()
                    join integracao in _integracaoSistemaRepository.GetQueryable()
                        on turno.IntegracaoTurno!.IntegracaoSistemaId equals integracao.Id into integracaoJoin
                    from integracaoSistema in integracaoJoin.DefaultIfEmpty()
                    select new TurnoDto()
                    {
                        Key = turno.Key,
                        Nome = turno.Nome,
                        Integracao = integracaoSistema != null ? new SistemaIntegracaoDto()
                        {
                            CodigoOrigem = turno.IntegracaoTurno!.CodigoOrigem,
                            NomeSistema = integracaoSistema.Nome
                        } : null
                    };

        if(!string.IsNullOrEmpty(request.Filtros?.Nome))
        {
            query = query.Where(o => o.Nome.ToUpper().Contains(request.Filtros.Nome.ToUpper()));
        }

        int totalRegistros = await query.CountAsync();

        var queryResult = query
            .OrderBy(o => o.Nome)
            .ThenBy(o => o.Key)
            .Skip(request.Paginacao.QuantidadeRegistros * (request.Paginacao.NumeroPagina - 1))
            .Take(request.Paginacao.QuantidadeRegistros);

        return new ResultadoPaginadoDto<TurnoDto>(
            await queryResult.ToListAsync(cancellationToken),
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros
        );
    }
}
