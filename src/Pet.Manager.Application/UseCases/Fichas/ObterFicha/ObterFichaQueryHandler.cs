using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Fichas;
using Anima.Inscricao.Domain.Campos;
using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Domain.Fichas;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Fichas.ObterFicha;

public class ObterFichaQueryHandler : IQueryHandler<ObterFichaQuery, FichaDto>
{
    private readonly IFichaRepository _fichaRepository;
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;
    private readonly ICampoRepository _campoRepository;

    public ObterFichaQueryHandler(
        IFichaRepository fichaRepository,
        IEtapaTemplateRepository etapaTemplateRepository,
        ICampoRepository campoRepository)
    {
        _fichaRepository = fichaRepository;
        _etapaTemplateRepository = etapaTemplateRepository;
        _campoRepository = campoRepository;
    }

    public async Task<FichaDto> Handle(ObterFichaQuery request, CancellationToken cancellationToken)
    {
        var query = from ficha in _fichaRepository.GetQueryable()
                    from etapaFicha in ficha.Etapas.DefaultIfEmpty()
                    join etapaTemplate in _etapaTemplateRepository.GetQueryable().DefaultIfEmpty()
                        on etapaFicha.EtapaTemplateId equals etapaTemplate.Id into etapaTemplateGroup
                    from etapa in etapaTemplateGroup.DefaultIfEmpty()
                    from campoFicha in ficha.Campos.DefaultIfEmpty()
                    join campo in _campoRepository.GetQueryable().DefaultIfEmpty()
                        on campoFicha.CampoId equals campo.Id into campoGroup
                    from campo in campoGroup.DefaultIfEmpty()
                    where ficha.Key == request.Key
                    select new
                    {
                        Key = ficha.Key,
                        Nome = ficha.Nome,
                        Descricao = ficha.Descricao,
                        Padrao = ficha.Padrao,
                        Etapas = ficha.Etapas,
                        EtapaId = etapa.Id,
                        EtapaKey = etapa.Key,
                        EtapaNome = etapa.Nome,
                        CampoId = campo.Id,
                        CampoKey = campo.Key,
                        CampoNome = campo.Nome,
                        Campos = ficha.Campos,
                    };

        return await query
            .GroupBy(x => new { x.Key, x.Nome, x.Descricao, x.Padrao })
            .Select(x => new FichaDto()
            {
                Key = x.Key.Key,
                Nome = x.Key.Nome,
                Descricao = x.Key.Descricao,
                Padrao = x.Key.Padrao,
                Etapas = x.Any(f => f.Etapas.Any()) ?
                x.GroupBy(ge => new { ge.EtapaKey, ge.EtapaNome, ge.Etapas.FirstOrDefault(e => e.EtapaTemplateId == ge.EtapaId)!.Sequencia })
                .Select(e => new EtapaFichaDto()
                {
                    Key = e.Key.EtapaKey,
                    Nome = e.Key.EtapaNome,
                    Sequencia = e.Key.Sequencia,
                }).OrderBy(o => o.Sequencia).ToList() : null,
                Campos = x.Any(f => f.Campos.Any()) ?
                x.GroupBy(gc => new { gc.CampoKey, gc.CampoNome, gc.Campos.FirstOrDefault(c => c.CampoId == gc.CampoId)!.ObrigatorioNaFicha, gc.Campos.FirstOrDefault(c => c.CampoId == gc.CampoId)!.ObrigatorioNoComplemento })
                .Select(c => new CampoFichaDto()
                {
                    Key = c.Key.CampoKey,
                    Nome = c.Key.CampoNome,
                    ObrigatorioNaFicha = c.Key.ObrigatorioNaFicha,
                    ObrigatorioNoComplemento = c.Key.ObrigatorioNoComplemento,
                }).OrderBy(o => o.Nome).ToList() : null,
            })
            .SingleAsync();
    }
}

