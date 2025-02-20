using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Acessibilidades;
using Anima.Inscricao.Application.DTOs.Deficiencias;
using Anima.Inscricao.Domain.Acessibilidades;
using Anima.Inscricao.Domain.Deficiencias;
using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Deficiencias.ObterDeficienciaAcessibilidade;


public class BuscarDeficienciaAcessibilidadeHandler : IQueryHandler<BuscarDeficienciaAcessibilidadeQuery, List<DeficienciaAcessibilidadeDto>>
{
    private readonly IDeficienciaRepository _deficienciaRepository;
    private readonly IAcessibilidadeRepository _acessibilidadeRepository;

    public BuscarDeficienciaAcessibilidadeHandler(IDeficienciaRepository deficienciaRepository, IAcessibilidadeRepository acessibilidadeRepository)
    {
        _deficienciaRepository = deficienciaRepository;
        _acessibilidadeRepository = acessibilidadeRepository;
    }

    public async Task<List<DeficienciaAcessibilidadeDto>> Handle(BuscarDeficienciaAcessibilidadeQuery request, CancellationToken cancellationToken)
    {
            var query = (from deficiencia in _deficienciaRepository.GetQueryable()
                          from deficienciaAcessibilidade in deficiencia.DeficienciaAcessibilidades.DefaultIfEmpty()
                          join acessibilidade in _acessibilidadeRepository.GetQueryable() on deficienciaAcessibilidade.AcessibilidadeId equals acessibilidade.Id
                          where deficienciaAcessibilidade.AcessibilidadeId == acessibilidade.Id
                          select new
                          {
                              Key = deficiencia.Key,
                              Nome = deficiencia.Nome,
                              acessibilidadeKey = acessibilidade.Key,
                              acessibilidadeNome = acessibilidade.Nome,
                          });

            var result = await query.GroupBy(g => new
            {
                g.Key,
                g.Nome
            }).Select(da => new DeficienciaAcessibilidadeDto()
            {
                Key = da.Key.Key,
                Nome= da.Key.Nome,
                Acessibilidades = da.GroupBy(a => new
                {
                    a.acessibilidadeKey,
                    a.acessibilidadeNome
                }).Select(ac => new AcessibilidadeDto(){
                    Key = ac.Key.acessibilidadeKey,
                    Nome = ac.Key.acessibilidadeNome
                }).OrderBy(n => n.Nome).ToList()
            }).OrderBy(x => x.Nome).ToListAsync();
                       

            return result;  
    }
}
