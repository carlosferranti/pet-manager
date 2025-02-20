namespace Anima.Inscricao.Domain._Shared.Entities;

/// <summary>
/// Interface que representa uma entidade que suporta exclusão lógica.
/// </summary>
public interface ISoftDelete
{
    Status Status { get; }
}
