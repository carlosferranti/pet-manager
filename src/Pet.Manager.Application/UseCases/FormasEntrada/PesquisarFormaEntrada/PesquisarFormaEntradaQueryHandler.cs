using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.FormasEntrada;
using Anima.Inscricao.Application.DTOs.Modalidades;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.FormasEntrada.PesquisarFormaEntrada;

public class PesquisarFormaEntradaQueryHandler : IQueryHandler<PesquisarFormaEntradaQuery, ResultadoPaginadoDto<FormaEntradaDto>>
{
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public PesquisarFormaEntradaQueryHandler(
        IFormaEntradaRepository formaEntradaRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository)
    {
        _formaEntradaRepository = formaEntradaRepository;
        _integracaoSistemaRepository = integracaoSistemaRepository;
    }

    public async Task<ResultadoPaginadoDto<FormaEntradaDto>> Handle(PesquisarFormaEntradaQuery request, CancellationToken cancellationToken)
    {
        var query = from forma in _formaEntradaRepository.GetQueryable()
                    
                    select new FormaEntradaDto()
                    {
                        Key = forma.Key,
                        Nome = forma.Nome,
                        Descricao = forma.Descricao,
                        OrdemExibicao = forma.OrdemExibicao,
                        Integracao = (from integracao in forma.IntegracoesFormaEntrada.DefaultIfEmpty()
                                      join sistema in _integracaoSistemaRepository.GetQueryable().DefaultIfEmpty()
                                          on integracao!.IntegracaoSistemaId equals sistema.Id into integracaoJoin
                                      from integracaoSistema in integracaoJoin.DefaultIfEmpty()
                                      select new SistemaIntegracaoDto()
                                      {
                                          CodigoOrigem = integracao!.CodigoOrigem,
                                          NomeSistema = integracaoSistema!.Nome
                                      }).ToList()
                    };
        
        if (!string.IsNullOrEmpty(request.Filtros?.Nome))
        {
            query = query.Where(o => o.Nome.ToUpper().Contains(request.Filtros.Nome.ToUpper()));
        }

        int totalRegistros = await query.CountAsync();

        var queryResult = query
            .OrderBy(o => o.Nome)
            .Skip(request.Paginacao.QuantidadeRegistros * (request.Paginacao.NumeroPagina - 1))
            .Take(request.Paginacao.QuantidadeRegistros);

        return new ResultadoPaginadoDto<FormaEntradaDto>(
            await queryResult.ToListAsync(cancellationToken),
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros
        );
    }
}
