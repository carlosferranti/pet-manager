using Anima.Inscricao.Domain.FormasEntrada.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class FormaEntradaConfiguration : AuditoriaTypeConfiguration<FormaEntrada>
{
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresOrigemId = 100;
    private const int LimiteCaracteresDescricao = 255;

    public override void Configure(EntityTypeBuilder<FormaEntrada> builder)
    {
        builder.ToTable("FormaEntrada")
            .HasKey(c => c.Id);

        builder
           .Property(pf => pf.Id)
           .HasConversion(o => o.Id, value => new FormaEntradaId(value))
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
            .Property(pf => pf.Descricao)
            .HasColumnName("Descricao")
            .HasMaxLength(LimiteCaracteresDescricao);

        builder
            .Property(pf => pf.OrdemExibicao)
            .HasColumnName("OrdemExibicao")
            .IsRequired();

        builder
            .Property(pf => pf.ExibeCard)
            .HasColumnName("ExibeCard")
            .IsRequired();

        builder
            .Property(pf => pf.FormaEntradaPaiId)
            .HasConversion(pf => pf!.Id, value => new FormaEntradaId(value))
            .HasColumnName("FormaEntradaPaiId");

        builder
            .HasOne<FormaEntrada>()
            .WithMany()
            .HasForeignKey(p => p.FormaEntradaPaiId);

        builder
            .Property(pf => pf.UltimoNivel)
            .HasColumnName("UltimoNivel");

        builder.OwnsOne(p => p.Status, status =>
        {
            status
                .Property(p => p.Ativo)
                .HasColumnName("Ativo");
        });

        builder
            .OwnsMany(i => i.IntegracoesFormaEntrada, integracao =>
            {
                integracao
                .ToTable("IntegracaoFormaEntrada")
                .HasKey(i => i.Id);

                integracao
                .Property(i => i.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(i => i.Id, value => new IntegracaoFormaEntradaId(value))
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