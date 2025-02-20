using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Application._Shared.DTOs;

public class EntityIdDto
{
    public int Id { get; set; }

    public static implicit operator EntityIdDto?(EntityId? id)
        => id == null ? null : new EntityIdDto() { Id = id.Id };
}

public class EntityKeyDto
{
    public EntityKeyDto()
    {
    }

    public EntityKeyDto(Guid key)
    {
        Key = key;
    }

    public Guid Key { get; set; }

    public static implicit operator EntityKeyDto(Guid value)
    {
        return new EntityKeyDto { Key = value };
    }
}

public class EntityIdentificacaoDto
{
    public int Id { get; set; }
    public Guid Key { get; set; }
}

public record AuditDto
{
    public DateTimeOffset? CriadoEm { get; init; }
    public DateTimeOffset? AlteradoEm { get; init; }

    public static AuditDto FromEntity(Audit audit)
    {
        return new AuditDto
        {
            CriadoEm = audit.CriadoEm,
            AlteradoEm = audit.AlteradoEm
        };
    }
}

public record StatusDto
{
    public bool Ativo { get; init; }
}
