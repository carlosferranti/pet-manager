using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Campi;
using Anima.Inscricao.Domain.Campi;

namespace Anima.Inscricao.Application.UseCases.Campi.ObterCampus;

public class ObterCampusQueryHandler : IQueryHandler<ObterCampusQuery, CampusDto>
{
    private readonly ICampusRepository _campusRepository;

    public ObterCampusQueryHandler(ICampusRepository campusRepository)
    {
        _campusRepository = campusRepository;
    }

    public async Task<CampusDto> Handle(ObterCampusQuery request, CancellationToken cancellationToken)
    {
        var campus = await _campusRepository.GetAsync(request.Key);

        return new CampusDto()
        {
            Key = campus.Key,
            Nome = campus.Nome,
            NomeComercial = campus.NomeComercial,
        };
    }
}
