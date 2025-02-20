namespace Anima.Inscricao.Domain._Shared.Entities.ExternalKeys;

public interface IHasExternalKeys
{
    IReadOnlyList<ExternalKey> ExternalKeys { get; }

    void InsertExternalKey(ExternalKey externalKey);

    void RemoveExternalKey(ExternalKey externalKey);
}
