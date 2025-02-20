using Anima.Inscricao.Domain.Campi.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class CampusConfiguration : AuditoriaTypeConfiguration<Campus>
{
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresOrigemId = 100;
    private const int LimiteCaracteresNomeComercial = 200;

    public override void Configure(EntityTypeBuilder<Campus> builder)
    {
        builder.ToTable("Campus")
            .HasKey(c => c.Id);

        builder
           .Property(pf => pf.Id)
           .HasConversion(o => o.Id, value => new CampusId(value))
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

        builder
            .Property(pf => pf.NomeComercial)
            .HasColumnName("NomeComercial")
            .HasMaxLength(LimiteCaracteresNomeComercial);

        builder
            .OwnsOne(p => p.Status, status =>
            {
                status
                    .Property(p => p.Ativo)
                    .HasColumnName("Ativo");
            });

        builder
            .OwnsOne(i => i.IntegracaoCampus, integracao =>
            {
                integracao
                .ToTable("IntegracaoCampus")
                .HasKey(x => x.Id);

                integracao
                .Property(i => i.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(i => i.Id, value => new IntegracaoCampusId(value))
                .HasColumnName("Id")
                .IsRequired();

                integracao
                .Property(i => i.IntegracaoSistemaId)
                .HasColumnName("IntegracaoSistemaId")
                .IsRequired();

                integracao
                .Property(i => i.CodigoOrigem)
                .HasColumnName("CodigoOrigem")
                .HasMaxLength(LimiteCaracteresOrigemId)
                .IsRequired();

                integracao
                .HasOne<IntegracaoSistema>()
                .WithMany()
                .HasForeignKey(o => o.IntegracaoSistemaId);
            });

        base.Configure(builder);
    }
}
