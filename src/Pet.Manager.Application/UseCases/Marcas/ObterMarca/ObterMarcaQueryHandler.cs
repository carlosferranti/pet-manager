using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Marcas;
using Anima.Inscricao.Domain.Marcas;

namespace Anima.Inscricao.Application.UseCases.Marcas.ObterMarca;

public class ObterMarcaQueryHandler : IQueryHandler<ObterMarcaQuery, MarcaDto>
{
    private readonly IMarcaRepository _marcaRepository;

    public ObterMarcaQueryHandler(IMarcaRepository marcaRepository)
    {
        _marcaRepository = marcaRepository;
    }

    public async Task<MarcaDto> Handle(ObterMarcaQuery request, CancellationToken cancellationToken)
    {
        var marca = await _marcaRepository.GetAsync(request.Key);

        return new MarcaDto()
        {
            Key = marca.Key,
            Nome = marca.Nome,
            Sigla = marca.Sigla,
        };
    }
}
