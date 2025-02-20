using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.FormasEntrada;
using Anima.Inscricao.Domain.FormasEntrada;

namespace Anima.Inscricao.Application.UseCases.FormasEntrada.ObterFormaEntrada;

public class ObterFormaEntradaQueryHandler : IQueryHandler<ObterFormaEntradaQuery, FormaEntradaDto>
{
    private readonly IFormaEntradaRepository _formaEntradaRepository;

    public ObterFormaEntradaQueryHandler(IFormaEntradaRepository formaEntradaRepository)
    {
        _formaEntradaRepository = formaEntradaRepository;
    }

    public async Task<FormaEntradaDto> Handle(ObterFormaEntradaQuery request, CancellationToken cancellationToken)
    {
        var formaEntrada = await _formaEntradaRepository.GetAsync(request.Key);

        return new FormaEntradaDto()
        {
            Key = formaEntrada.Key,
            Nome = formaEntrada.Nome,
            Descricao = formaEntrada.Descricao,
            OrdemExibicao = formaEntrada.OrdemExibicao,
        };
    }
}
