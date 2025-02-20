using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Acessibilidades;
using Anima.Inscricao.Domain.Acessibilidades;

namespace Anima.Inscricao.Application.UseCases.Acessibilidades.ObterAcessibilidade;

public class ObterAcessibilidadeQueryHandler : IQueryHandler<ObterAcessibilidadeQuery, AcessibilidadeDto>
{
    private readonly IAcessibilidadeRepository _acessibilidadeRepository;

    public ObterAcessibilidadeQueryHandler(IAcessibilidadeRepository acessibilidadeRepository)
    {
        _acessibilidadeRepository = acessibilidadeRepository;
    }

    public async Task<AcessibilidadeDto> Handle(ObterAcessibilidadeQuery request, CancellationToken cancellationToken)
    {
        var acessibilidade = await _acessibilidadeRepository.GetAsync(request.Key);

        return new AcessibilidadeDto()
        {
            Key = acessibilidade.Key,
            Nome = acessibilidade.Nome,
        };
    }
}
