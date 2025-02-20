using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class SistemasIntegracaoConfiguration : AuditoriaTypeConfiguration<IntegracaoSistema>
{
    private const int LimiteCaracteresNome = 100;

    public override void Configure(EntityTypeBuilder<IntegracaoSistema> builder)
    {
        builder.ToTable("SistemaIntegracao")
            .HasKey(c => c.Id);

        builder
           .Property(pf => pf.Id)
           .HasConversion(o => o.Id, value => new IntegracaoSistemaId(value))
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

        base.Configure(builder);
    }
}
