using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Etapas.Entities;

public interface IEtapa : ISoftDelete
{
    string Nome { get; }

    string Descricao { get; }
}