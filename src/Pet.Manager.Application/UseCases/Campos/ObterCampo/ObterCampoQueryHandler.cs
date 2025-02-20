using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Campos;
using Anima.Inscricao.Domain.Campos;

namespace Anima.Inscricao.Application.UseCases.Campos.ObterCampo;

public class ObterCampoQueryHandler : IQueryHandler<ObterCampoQuery, CampoDto>
{
    private readonly ICampoRepository _campoRepository;

    public ObterCampoQueryHandler(ICampoRepository campoRepository)
    {
        _campoRepository = campoRepository;
    }

    public async Task<CampoDto> Handle(ObterCampoQuery request, CancellationToken cancellationToken)
    {
        var campo = await _campoRepository.GetAsync(request.Key);

        return new CampoDto()
        {
            Key = campo.Key,
            Nome = campo.Nome,
        };
    }
}
