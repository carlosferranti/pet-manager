using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Cupons;

namespace Anima.Inscricao.Application.UseCases.Cupons.ObterCupom;

public class ObterCupomQuery : IQuery<CupomDto>
{
    public Guid Key { get; set; }
}
