using Anima.Inscricao.Domain.Etapas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class EtapaTemplateConfiguration : AuditoriaTypeConfiguration<EtapaTemplate>
{
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresDescricao = 200;

    public override void Configure(EntityTypeBuilder<EtapaTemplate> builder)
    {
        builder.ToTable("EtapaTemplate")
            .HasKey(c => c.Id);

        builder
           .Property(c => c.Id)
           .HasConversion(o => o.Id, value => new EtapaTemplateId(value))
           .ValueGeneratedOnAdd()
           .IsRequired();

        builder
            .Property(c => c.Key)
            .HasColumnName("Key")
            .IsRequired();

        builder
            .Property(c => c.Nome)
            .HasColumnName("Nome")
            .HasMaxLength(LimiteCaracteresNome)
            .IsRequired();

        builder
           .Property(c => c.Descricao)
           .HasColumnName("Descricao")
           .HasMaxLength(LimiteCaracteresDescricao)
           .IsRequired();

        builder
           .Property(c => c.NomeArquivo)
           .HasColumnName("NomeArquivo")
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