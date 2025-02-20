using Anima.Inscricao.Domain.FormasEntrada.Entities;
using Anima.Inscricao.Domain.Links.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class LinkConfiguration : AuditoriaTypeConfiguration<Link>
{
    private const int LimiteCaracteresNome = 250;

    public override void Configure(EntityTypeBuilder<Link> builder)
    {
        builder.ToTable("Link")
            .HasKey(c => c.Id);

        builder
           .Property(pf => pf.Id)
           .HasConversion(o => o.Id, value => new LinkId(value))
           .ValueGeneratedOnAdd()
           .IsRequired();

        builder
            .Property(pf => pf.Key)
            .HasColumnName("Key")
            .IsRequired();

        builder
            .Property(pf => pf.Nome)
            .HasColumnName("Nome")
            .HasMaxLength(LimiteCaracteresNome)
            .IsRequired();

        builder.OwnsOne(p => p.Status, status =>
        {
            status
                .Property(p => p.Ativo)
                .HasColumnName("Ativo");
        });

        builder.OwnsMany(c => c.FormasEntrada, formasEntrada =>
        {
            formasEntrada
                .ToTable("LinkFormaEntrada")
                .HasKey(f => f.Id);

            formasEntrada
                .Property(f => f.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(f => f.Id, value => new LinkFormaEntradaId(value))
                .HasColumnName("Id")
                .IsRequired();

            formasEntrada
                .Property(f => f.FormaEntradaId)
                .HasColumnName("FormaEntradaId")
                .HasConversion(f => f.Id, value => new FormaEntradaId(value))
                .IsRequired();

            formasEntrada.OwnsOne(p => p.Status, status =>
            {
                status
                    .Property(p => p.Ativo)
                    .HasColumnName("Ativo");
            });

            formasEntrada.OwnsOne(f => f.Auditoria, auditoria =>
            {
                auditoria
                    .Property(a => a.CriadoEm)
                    .HasColumnName("CriadoEm");

                auditoria
                    .Property(a => a.AlteradoEm)
                    .HasColumnName("AlteradoEm");
            });

            formasEntrada
                .HasOne<FormaEntrada>()
                .WithMany()
                .HasForeignKey(f => f.FormaEntradaId);
        });

        base.Configure(builder);
    }
}
