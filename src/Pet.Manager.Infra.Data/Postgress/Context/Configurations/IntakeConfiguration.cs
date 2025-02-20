using Anima.Inscricao.Domain.Intakes.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;
using Anima.Inscricao.Infra.Data.Utils;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class IntakeConfiguration : AuditoriaTypeConfiguration<Intake>
{
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresOrigemId = 100;

    public override void Configure(EntityTypeBuilder<Intake> builder)
    {
        builder.ToTable("Intake")
            .HasKey(c => c.Id);

        builder
           .Property(pf => pf.Id)
           .HasConversion(o => o.Id, value => new IntakeId(value))
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

        builder.OwnsOne(c => c.Vigencia, vigencia =>
        {
            vigencia
                .Property(p => p.Inicio)
                .HasColumnName("VigenciaInicio")
                .HasConversion(src => src.ConverterParaUtcDate(), dst => dst.ConverterParaLocalDate());

            vigencia
                .Property(p => p.Termino)
                .HasColumnName("VigenciaTermino")
                .HasConversion(src => src.ConverterParaUtcDate(), dst => dst.ConverterParaLocalDate());
        });

        builder
            .OwnsOne(i => i.IntegracaoIntake, integracao =>
            {
                integracao
                .ToTable("IntegracaoIntake")
                .HasKey(i => i.Id);

                integracao
                .Property(i => i.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(i => i.Id, value => new IntegracaoIntakeId(value))
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