using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.NiveisCurso;
using Anima.Inscricao.Domain.NiveisCurso;

namespace Anima.Inscricao.Application.UseCases.NiveisCurso.ObterNivelCurso;

public class ObterNivelCursoQueryHandler : IQueryHandler<ObterNivelCursoQuery, NivelCursoDto>
{
    private readonly INivelCursoRepository _nivelCursoRepository;

    public ObterNivelCursoQueryHandler(INivelCursoRepository nivelCursoRepository)
    {
        _nivelCursoRepository = nivelCursoRepository;
    }

    public async Task<NivelCursoDto> Handle(ObterNivelCursoQuery request, CancellationToken cancellationToken)
    {
        var nivelCurso = await _nivelCursoRepository.GetAsync(request.Key);

        return new NivelCursoDto()
        {
            Key = nivelCurso.Key,
            Nome = nivelCurso.Nome,
        };
    }
}
