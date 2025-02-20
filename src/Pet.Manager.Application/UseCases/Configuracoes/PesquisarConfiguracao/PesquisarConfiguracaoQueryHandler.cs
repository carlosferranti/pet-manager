using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Cofiguracao;
using Anima.Inscricao.Domain.Configuracoes;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Configuracoes.PesquisarConfiguracao;

public class PesquisarConfiguracaoQueryHandler : IQueryHandler<PesquisarConfiguracaoQuery, ResultadoPaginadoDto<ConfiguracaoDto>>
{
    private readonly IConfiguracaoRepository _configuracaoRepository;

    public PesquisarConfiguracaoQueryHandler(IConfiguracaoRepository configuracaoRepository)
    {
        _configuracaoRepository = configuracaoRepository;
    }

    public async Task<ResultadoPaginadoDto<ConfiguracaoDto>> Handle(PesquisarConfiguracaoQuery request, CancellationToken cancellationToken)
    {
        var query = _configuracaoRepository.GetQueryable();

        if (!string.IsNullOrEmpty(request.Filtros?.ChaveGenerica))
        {
            query = query.Where(o => o.ChaveGenerica.ToUpper().Contains(request.Filtros.ChaveGenerica.ToUpper()));
        }

        if (!string.IsNullOrEmpty(request.Filtros?.Valor))
        {
            query = query.Where(o => o.Valor.ToUpper().Contains(request.Filtros.Valor.ToUpper()));
        }

        int totalRegistros = await query.CountAsync();

        var queryResult = query
            .Where(m => m.Status.Ativo)
            .OrderBy(o => o.ChaveGenerica)
            .Skip(request.Paginacao.QuantidadeRegistros * (request.Paginacao.NumeroPagina - 1))
            .Take(request.Paginacao.QuantidadeRegistros)
            .Select(o => new ConfiguracaoDto()
            {
                Key = o.Key,
                ChaveGenerica = o.ChaveGenerica,
                Valor = o.Valor,
                DataAlteracao = o.Auditoria.AlteradoEm,
                DataCriacao = o.Auditoria.CriadoEm,
            });

        return new ResultadoPaginadoDto<ConfiguracaoDto>(
            await queryResult.ToListAsync(cancellationToken),
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros);
    }
}
