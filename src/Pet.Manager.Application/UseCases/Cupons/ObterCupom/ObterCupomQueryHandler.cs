using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Cupons;
using Anima.Inscricao.Application.Enums;
using Anima.Inscricao.Application.Extensions;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Cupons;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Cupons.ObterCupom;

public class ObterCupomQueryHandler : IQueryHandler<ObterCupomQuery, CupomDto>
{
    private readonly ICupomRepository _cupomRepository;
    private readonly IConcursoRepository _concursoRepository;

    public ObterCupomQueryHandler(
        ICupomRepository cupomRepository, 
        IConcursoRepository concursoRepository)
    {
        _cupomRepository = cupomRepository;
        _concursoRepository = concursoRepository;
    }

    public async Task<CupomDto?> Handle(ObterCupomQuery request, CancellationToken cancellationToken)
    {
        var result = from cupom in _cupomRepository.GetQueryable()
                     join concurso in _concursoRepository.GetQueryable()
                        on cupom.ConcursoId equals concurso.Id
                    where cupom.Key == request.Key
                    select new CupomDto() 
                    {
                        Key = cupom.Key,
                        ConcursoKey = concurso.Key,
                        Codigo = cupom.Codigo,
                        Descricao = cupom.Descricao,
                        ValorDesconto = cupom.ValorDesconto,
                        TipoDesconto = cupom.TipoDesconto,
                        DescricaoTipoDesconto = ((TipoDesconto)cupom.TipoDesconto).Description(),
                        DataValidade = cupom.DataValidade,
                    };

        return await result.SingleAsync();
    }
}
