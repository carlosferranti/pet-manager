using Anima.Inscricao.Domain.Campos.Entities;
using Anima.Inscricao.Domain.Etapas.Entities;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class FichaConfiguration : AuditoriaTypeConfiguration<Ficha>
{
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresDescricao = 200;

    public override void Configure(EntityTypeBuilder<Ficha> builder)
    {
        builder.ToTable("Ficha")
            .HasKey(p => p.Id);

        builder
           .Property(p => p.Id)
           .HasConversion(p => p.Id, value => new FichaId(value))
           .ValueGeneratedOnAdd()
           .IsRequired();

        builder
            .Property(p => p.Key)
            .HasColumnName("Key")
            .IsRequired();

        builder
            .Property(p => p.Nome)
            .HasColumnName("Nome")
            .HasMaxLength(LimiteCaracteresNome)
            .IsRequired();

        builder
            .Property(p => p.Descricao)
            .HasColumnName("Descricao")
            .HasMaxLength(LimiteCaracteresDescricao)
            .IsRequired();

        builder
            .OwnsOne(p => p.Status, status =>
            {
                status
                    .Property(p => p.Ativo)
                    .HasColumnName("Ativo");
            });

        builder
            .OwnsMany(p => p.Etapas, etapaFicha =>
            {
                etapaFicha
                .ToTable("EtapaFicha")
                .HasKey(p => p.Id);

                etapaFicha
                .Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(p => p.Id, value => new EtapaFichaId(value))
                .HasColumnName("Id")
                .IsRequired();

                etapaFicha
                .Property(p => p.EtapaTemplateId)
                .HasConversion(p => p.Id, value => new EtapaTemplateId(value))
                .HasColumnName("EtapaTemplateId")
                .IsRequired();

                etapaFicha
                .Property(p => p.Sequencia)
                .HasColumnName("Sequencia")
                .IsRequired();

                etapaFicha
                .HasOne<EtapaTemplate>()
                .WithMany()
                .HasForeignKey(p => p.EtapaTemplateId);
            });

        builder
            .OwnsMany(p => p.Campos, campoFicha =>
            {
                campoFicha
                .ToTable("CampoFicha")
                .HasKey(p => p.Id);
                
                campoFicha
                .Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(p => p.Id, value => new CampoFichaId(value))
                .HasColumnName("Id")
                .IsRequired();

                campoFicha
                .Property(p => p.CampoId)
                .HasColumnName("CampoId")
                .IsRequired();
        
                campoFicha
                .Property(p => p.ObrigatorioNaFicha)
                .HasColumnName("ObrigatorioNaFicha")
                .IsRequired();

                campoFicha
                .Property(p => p.ObrigatorioNoComplemento)
                .HasColumnName("ObrigatorioNoComplemento")
                .IsRequired();

                campoFicha
                .HasOne<Campo>()
                .WithMany()
                .HasForeignKey(p => p.CampoId);
            });

        base.Configure(builder);
    }
}
