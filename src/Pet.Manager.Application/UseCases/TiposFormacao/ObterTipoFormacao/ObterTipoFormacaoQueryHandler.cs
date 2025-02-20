using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.TiposFormacao;
using Anima.Inscricao.Domain.TiposFormacao;

namespace Anima.Inscricao.Application.UseCases.TiposFormacao.ObterTipoFormacao;

public class ObterTipoFormacaoQueryHandler : IQueryHandler<ObterTipoFormacaoQuery, TipoFormacaoDto>
{
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;

    public ObterTipoFormacaoQueryHandler(ITipoFormacaoRepository tipoFormacaoRepository)
    {
        _tipoFormacaoRepository = tipoFormacaoRepository;
    }

    public async Task<TipoFormacaoDto> Handle(ObterTipoFormacaoQuery request, CancellationToken cancellationToken)
    {
        var tipoFormacao = await _tipoFormacaoRepository.GetAsync(request.Key);

        return new TipoFormacaoDto()
        {
            Key = tipoFormacao.Key,
            Nome = tipoFormacao.Nome,
        };
    }
}