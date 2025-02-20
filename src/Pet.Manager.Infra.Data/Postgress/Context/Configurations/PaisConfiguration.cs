using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class PaisConfiguration : AuditoriaTypeConfiguration<Pais>
{
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresSigla = 10;
    private const int LimiteCaracteresTipo = 1;
    private const int LimiteCaracteresOrigemId = 100;

    public override void Configure(EntityTypeBuilder<Pais> builder)
    {
        builder.ToTable("Pais")
            .HasKey(c => c.Id);

        builder
           .Property(pf => pf.Id)
           .HasConversion(o => o.Id, value => new PaisId(value))
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
            .Property(pf => pf.Sigla)
            .HasColumnName("Sigla")
            .HasMaxLength(LimiteCaracteresSigla)
            .IsRequired();

        builder
            .Property(pf => pf.SiglaAbreviada)
            .HasColumnName("SiglaAbreviada")
            .HasMaxLength(LimiteCaracteresSigla)
            .IsRequired();

        builder
            .Property(pf => pf.Tipo)
            .HasColumnName("Tipo")
            .HasMaxLength(LimiteCaracteresTipo);

        builder
            .OwnsOne(p => p.Status, status =>
            {
                status
                    .Property(p => p.Ativo)
                    .HasColumnName("Ativo");
            });

        builder
            .OwnsOne(i => i.IntegracaoPais, integracao =>
            {
                integracao
                .ToTable("IntegracaoPais")
                .HasKey(x => x.Id);

                integracao
                .Property(i => i.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(i => i.Id, value => new IntegracaoPaisId(value))
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
