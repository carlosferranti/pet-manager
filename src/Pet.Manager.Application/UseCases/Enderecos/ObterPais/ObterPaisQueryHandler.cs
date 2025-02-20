using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Enderecos;
using Anima.Inscricao.Domain.Enderecos;

namespace Anima.Inscricao.Application.UseCases.Enderecos.ObterPais;

public class ObterPaisQueryHandler : IQueryHandler<ObterPaisQuery, PaisDto>
{
    private readonly IPaisRepository _paisRepository;

    public ObterPaisQueryHandler(IPaisRepository paisRepository)
    {
        _paisRepository = paisRepository;
    }

    public async Task<PaisDto> Handle(ObterPaisQuery request, CancellationToken cancellationToken)
    {
        var pais = await _paisRepository.GetAsync(request.Key);

        return new PaisDto()
        {
            Key = pais.Key,
            Nome = pais.Nome,
            Sigla = pais.Sigla,
            SiglaAbreviada = pais.SiglaAbreviada,
            Tipo = pais.Tipo,
        };
    }
}
