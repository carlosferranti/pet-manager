using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Domain.Turnos.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class TurnoConfiguration : AuditoriaTypeConfiguration<Turno>
{
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresOrigemId = 100;

    public override void Configure(EntityTypeBuilder<Turno> builder)
    {
        builder.ToTable("Turno")
            .HasKey(t => t.Id);

        builder.Property(x => x.Id)
            .HasConversion(i => i.Id, value => new TurnoId(value))
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.Nome)
            .HasColumnName("Nome")
            .HasMaxLength(LimiteCaracteresNome)
            .IsRequired();

        builder.Property(x => x.Key)
            .HasColumnName("Key")
            .IsRequired();

        builder.OwnsOne(x => x.Status, status =>
        {
            status
            .Property(p => p.Ativo)
            .HasColumnName("Ativo");
        });

        builder
            .OwnsOne(x => x.IntegracaoTurno, integracao =>
            {
                integracao
                .ToTable("IntegracaoTurno")
                .HasKey(i => i.Id);

                integracao
                .Property(i => i.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(i => i.Id, value => new IntegracaoTurnoId(value))
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
