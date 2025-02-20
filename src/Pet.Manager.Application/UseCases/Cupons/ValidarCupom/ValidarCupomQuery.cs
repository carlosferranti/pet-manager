using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Cupons;

namespace Anima.Inscricao.Application.UseCases.Cupons.ValidarCupom;

public class ValidarCupomQuery : IQuery<ValidarCupomResultadoDto>
{
    public string CodigoCupom { get; }

    public Guid OfertaConcursoKey { get; }

    public ValidarCupomQuery(string codigoCupom, Guid ofertaConcursoKey)
    {
        CodigoCupom = codigoCupom;
        OfertaConcursoKey = ofertaConcursoKey;
    }
}

