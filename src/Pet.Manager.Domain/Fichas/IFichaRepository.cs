using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain.Fichas.Entities;

namespace Anima.Inscricao.Domain.Fichas;

public interface IFichaRepository : IRepository<Ficha, FichaId>
{
}