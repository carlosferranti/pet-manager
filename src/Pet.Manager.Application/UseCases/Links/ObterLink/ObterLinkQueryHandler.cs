using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Links;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Links;
using Anima.Inscricao.Domain.Links.Entities;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Links.ObterLink;

public class ObterLinkQueryHandler : IQueryHandler<ObterLinkQuery, LinkDto>
{
    private readonly ILinkRepository _linkRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;

    public ObterLinkQueryHandler(
        ILinkRepository linkRepository,
        IFormaEntradaRepository formaEntradaRepository)
    {
        _linkRepository = linkRepository;
        _formaEntradaRepository = formaEntradaRepository;
    }

    public async Task<LinkDto> Handle(ObterLinkQuery request, CancellationToken cancellationToken)
    {
        var linkQuery = from link in _linkRepository.GetQueryable()
                        where link.Key == request.Key
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
        
        return await linkQuery.SingleAsync(cancellationToken);
    }
}