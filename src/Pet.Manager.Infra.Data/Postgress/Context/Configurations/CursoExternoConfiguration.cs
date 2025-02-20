using Anima.Inscricao.Domain.CursosExternos.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class CursoExternoConfiguration : AuditoriaTypeConfiguration<CursoExterno>
{
    private const int LimiteCaracteresNome = 120;
    private const int LimiteCaracteresOrigemId = 100;

    public override void Configure(EntityTypeBuilder<CursoExterno> builder)
    {
        builder
            .ToTable("CursoExterno")
            .HasKey(ce => ce.Id);

        builder
            .Property(ce => ce.Id)
            .HasConversion(o => o.Id, value => new CursoExternoId(value))
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder
            .Property(ce => ce.Key)
            .HasColumnName("Key")
            .IsRequired();

        builder
            .Property(ce => ce.Nome)
            .HasColumnName("Nome")
            .HasMaxLength(LimiteCaracteresNome)
            .IsRequired();

        builder.OwnsOne(p => p.Status, status =>
        {
            status
                .Property(p => p.Ativo)
                .HasColumnName("Ativo");
        });

        builder
            .OwnsMany(i => i.IntegracoesCursoExterno, integracao =>
            {
                integracao
                .ToTable("IntegracaoCursoExterno")
                .HasKey(i => i.Id);

                integracao
                .Property(i => i.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(i => i.Id, value => new IntegracaoCursoExternoId(value))
                .HasColumnName("Id")
                .IsRequired();

                integracao
                .Property(i => i.IntegracaoSistemaId)
                .HasConversion(o => o.Id, value => new IntegracaoSistemaId(value))
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
