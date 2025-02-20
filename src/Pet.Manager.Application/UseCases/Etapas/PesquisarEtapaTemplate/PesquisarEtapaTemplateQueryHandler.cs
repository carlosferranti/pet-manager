using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Etapas;
using Anima.Inscricao.Domain.Etapas;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Etapas.PesquisarEtapa;

public class PesquisarEtapaTemplateQueryHandler : IQueryHandler<PesquisarEtapaTemplateQuery, ResultadoPaginadoDto<EtapaTemplateDto>>
{
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;

    public PesquisarEtapaTemplateQueryHandler(IEtapaTemplateRepository etapaTemplateRepository)
    {
        _etapaTemplateRepository = etapaTemplateRepository;
    }

    public async Task<ResultadoPaginadoDto<EtapaTemplateDto>> Handle(PesquisarEtapaTemplateQuery request, CancellationToken cancellationToken)
    {
        var query = _etapaTemplateRepository.GetQueryable();

        if (!string.IsNullOrEmpty(request.Filtros?.Nome))
        {
            query = query.Where(o => o.Nome.ToUpper().Contains(request.Filtros.Nome.ToUpper()));
        }

        int totalRegistros = await query.CountAsync();

        var queryResult = query
            .Where(m => m.Status.Ativo)
            .OrderBy(o => o.Nome)
            .Skip(request.Paginacao.QuantidadeRegistros * (request.Paginacao.NumeroPagina - 1))
            .Take(request.Paginacao.QuantidadeRegistros)
            .Select(o => new EtapaTemplateDto()
            {
                Key = o.Key,
                Nome = o.Nome,
                Descricao = o.Descricao,
                NomeArquivo = o.NomeArquivo,
            });

        return new ResultadoPaginadoDto<EtapaTemplateDto>(
            await queryResult.ToListAsync(cancellationToken),
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros
        );
    }
}
