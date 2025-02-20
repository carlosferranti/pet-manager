using Anima.Inscricao.Domain._Shared.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

public abstract class AuditoriaTypeConfiguration<T> : IEntityTypeConfiguration<T> where T : class, IAuditable
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.OwnsOne(p => p.Auditoria, auditoria =>
        {
            auditoria
                .Property(p => p.CriadoEm)
                .HasColumnName("CriadoEm");

            auditoria
                .Property(p => p.AlteradoEm)
                .HasColumnName("AlteradoEm");
        });
    }
}
