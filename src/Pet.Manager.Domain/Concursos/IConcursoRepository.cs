using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain.Concursos.Entities;

namespace Anima.Inscricao.Domain.Concursos;

public interface IConcursoRepository : IRepository<Concurso, ConcursoId>
{
}