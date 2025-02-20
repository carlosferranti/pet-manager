using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Links;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Links;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Links.PesquisarLink;

public class PesquisarLinkQueryHandler : IQueryHandler<PesquisarLinkQuery, ResultadoPaginadoDto<LinkDto>>
{
    private readonly ILinkRepository _linkRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;

    public PesquisarLinkQueryHandler(
        ILinkRepository linkRepository,
        IFormaEntradaRepository formaEntradaRepository)
    {
        _linkRepository = linkRepository;
        _formaEntradaRepository = formaEntradaRepository;
    }

    public async Task<ResultadoPaginadoDto<LinkDto>> Handle(PesquisarLinkQuery request, CancellationToken cancellationToken)
    {
        var linkQuery = from link in _linkRepository.GetQueryable()
                        select new LinkDto()
                        {
                            Key = link.Key,
                            Nome = link.Nome,
                            FormasEntrada = (from LinkFormaEntrada in link.FormasEntrada.DefaultIfEmpty()
                                             join formaEntrada in _formaEntradaRepository.GetQueryable().DefaultIfEmpty()
                                                 on LinkFormaEntrada.FormaEntradaId equals formaEntrada.Id into formaEntradaGroup
                                             from formaEntrada in formaEntradaGroup.DefaultIfEmpty()
                                             select new EntityKeyDto()
                                             {
                                                 Key = formaEntrada.Key,
                                             }).ToList(),
                        };

        if (request.Filtros?.FormaEntradaKey.HasValue == true)
        {
            linkQuery = linkQuery.Where(l => l.FormasEntrada.Any(x => x.Key == request.Filtros.FormaEntradaKey.Value));
        }

        int totalRegistros = await linkQuery.CountAsync();

        var queryResult = linkQuery
            .OrderBy(o => o.Nome)
            .Skip(request.Paginacao.QuantidadeRegistros * (request.Paginacao.NumeroPagina - 1))
            .Take(request.Paginacao.QuantidadeRegistros);

        return new ResultadoPaginadoDto<LinkDto>(
            await queryResult.ToListAsync(cancellationToken),
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros
        );
    }
}