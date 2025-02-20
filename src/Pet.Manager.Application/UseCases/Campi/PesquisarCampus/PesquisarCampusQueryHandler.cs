using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Campi;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Campi.PesquisarCampus;

public class PesquisarCampusQueryHandler : IQueryHandler<PesquisarCampusQuery, ResultadoPaginadoDto<CampusDto>>
{
    private readonly ICampusRepository _campusRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public PesquisarCampusQueryHandler(
        ICampusRepository campusRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository)
    {
        _campusRepository = campusRepository;
        _integracaoSistemaRepository = integracaoSistemaRepository;
    }

    public async Task<ResultadoPaginadoDto<CampusDto>> Handle(PesquisarCampusQuery request, CancellationToken cancellationToken)
    {
        var query = from campus in _campusRepository.GetQueryable()
                    join integracao in _integracaoSistemaRepository.GetQueryable()
                        on campus.IntegracaoCampus!.IntegracaoSistemaId equals integracao.Id into integracaoJoin
                    from integracaoSistema in integracaoJoin.DefaultIfEmpty()
                    select new CampusDto()
                    {
                        Key = campus.Key,
                        Nome = campus.Nome,
                        NomeComercial = campus.NomeComercial,
                        Integracao = integracaoSistema != null ? new SistemaIntegracaoDto()
                        {
                            CodigoOrigem = campus.IntegracaoCampus!.CodigoOrigem,
                            NomeSistema = integracaoSistema.Nome
                        } : null
                    };
    
        if (!string.IsNullOrEmpty(request.Filtros?.Nome))
        {
            query = query.Where(o => o.Nome.ToUpper().Contains(request.Filtros.Nome.ToUpper()));
        }

        int totalRegistros = await query.CountAsync();

        var queryResult = query
            .OrderBy(o => o.Nome)
            .ThenBy(o => o.Key)
            .Skip(request.Paginacao.QuantidadeRegistros * (request.Paginacao.NumeroPagina - 1))
            .Take(request.Paginacao.QuantidadeRegistros);

        return new ResultadoPaginadoDto<CampusDto>(
            await queryResult.ToListAsync(cancellationToken),
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros
        );
    }
}
