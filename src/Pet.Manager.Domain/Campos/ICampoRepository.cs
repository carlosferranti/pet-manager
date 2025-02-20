using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain.Campos.Entities;
using Anima.Inscricao.Domain.Fichas.Entities;

namespace Anima.Inscricao.Domain.Campos;

public interface ICampoRepository : IRepository<Campo, CampoId>
{
}