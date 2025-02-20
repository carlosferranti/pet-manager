using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.TiposStatusInscricao;
using Anima.Inscricao.Application.Extensions;
using Anima.Inscricao.Domain.Inscricoes.Enums;

namespace Anima.Inscricao.Application.UseCases.TiposStatusInscricao.PesquisarTiposStatusInscricao;

public class PesquisarTiposStatusInscricaoQueryHandler : IQueryHandler<PesquisarTiposStatusInscricaoQuery, List<TipoStatusInscricaoDto>>
{
    public async Task<List<TipoStatusInscricaoDto>> Handle(PesquisarTiposStatusInscricaoQuery request, CancellationToken cancellationToken)
    {
        List<TipoStatusInscricaoDto> enumValues = Enum.GetValues(typeof(TipoStatusInscricao))
            .Cast<TipoStatusInscricao>()
            .Select(value => new TipoStatusInscricaoDto()
            {
                Id = (int)value,
                Nome = EnumExtensions.Description(value)
            }).ToList();

        return await Task.FromResult(enumValues);
    }
}

