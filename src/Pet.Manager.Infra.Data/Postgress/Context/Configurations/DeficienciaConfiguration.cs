using Anima.Inscricao.Domain.Acessibilidades.Entities;
using Anima.Inscricao.Domain.Deficiencias.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class DeficienciaConfiguration : AuditoriaTypeConfiguration<Deficiencia>
{
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresOrigemId = 100;

    public override void Configure(EntityTypeBuilder<Deficiencia> builder)
    {
        builder.ToTable("Deficiencia")
            .HasKey(c => c.Id);

        builder
           .Property(pf => pf.Id)
           .HasConversion(o => o.Id, value => new DeficienciaId(value))
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
            .Property(pf => pf.OrdemExibicao)
            .HasColumnName("OrdemExibicao");

        builder
            .OwnsOne(p => p.Status, status =>
            {
                status
                    .Property(p => p.Ativo)
                    .HasColumnName("Ativo");
            });

        builder
            .OwnsOne(i => i.IntegracaoDeficiencia, integracao =>
            {
                integracao
                .ToTable("IntegracaoDeficiencia")
                .HasKey(x => x.Id);

                integracao
                .Property(i => i.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(i => i.Id, value => new IntegracaoDeficienciaId(value))
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

        builder.
            OwnsMany(da => da.DeficienciaAcessibilidades,
                    acessibilidade =>
                    {
                        acessibilidade.ToTable("DeficienciaAcessibilidade").HasKey(x => x.Id);

                        acessibilidade.Property(da => da.Id)
                           .HasConversion(
                               id => (int)id,
                               value => new DeficienciaAcessibilidadeId(value))  
                           .HasColumnName("Id")
                           .ValueGeneratedOnAdd()
                           .IsRequired();

                        acessibilidade.Property(da => da.AcessibilidadeId)
                           .HasColumnName("AcessibilidadeId")
                           .HasConversion(
                               id => id.Id,
                               value => new AcessibilidadeId(value))
                           .IsRequired();
                    }
            );

        base.Configure(builder);
    }
}
