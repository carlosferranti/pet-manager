using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Deficiencias;
using Anima.Inscricao.Domain.Deficiencias;

namespace Anima.Inscricao.Application.UseCases.Deficiencias.ObterDeficiencia;

public class ObterDeficienciaQueryHandler : IQueryHandler<ObterDeficienciaQuery, DeficienciaDto>
{
    private readonly IDeficienciaRepository _deficienciaRepository;

    public ObterDeficienciaQueryHandler(IDeficienciaRepository deficienciaRepository)
    {
        _deficienciaRepository = deficienciaRepository;
    }

    public async Task<DeficienciaDto> Handle(ObterDeficienciaQuery request, CancellationToken cancellationToken)
    {
        var deficiencia = await _deficienciaRepository.GetAsync(request.Key);

        return new DeficienciaDto()
        {
            Key = deficiencia.Key,
            Nome = deficiencia.Nome,
            OrdemExibicao = deficiencia.OrdemExibicao,
        };
    }
}
