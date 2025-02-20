using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Domain.Marcas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class MarcaConfiguration : AuditoriaTypeConfiguration<Marca>
{
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresSigla = 50;
    private const int LimiteCaracteresOrigemId = 100;

    public override void Configure(EntityTypeBuilder<Marca> builder)
    {
        builder.ToTable("Marca")
            .HasKey(m => m.Id);

        builder
           .Property(m => m.Id)
           .HasConversion(m => m.Id, value => new MarcaId(value))
           .ValueGeneratedOnAdd()
           .IsRequired();

        builder
            .Property(m =>m.Key)
            .HasColumnName("Key")
            .IsRequired();

        builder
            .Property(m => m.Nome)
            .HasColumnName("Nome")
            .HasMaxLength(LimiteCaracteresNome)
            .IsRequired();

        builder
            .Property(pf => pf.Sigla)
            .HasColumnName("Sigla")
            .HasMaxLength(LimiteCaracteresSigla)
            .IsRequired();

        builder
            .OwnsOne(m => m.Status, status =>
            {
                status
                    .Property(p => p.Ativo)
                    .HasColumnName("Ativo");
            });

        builder
            .OwnsMany(i => i.IntegracoesMarcas, integracao =>
            {
                integracao
                .ToTable("IntegracaoMarca")
                .HasKey(x => x.Id);

                integracao
                .Property(i => i.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(i => i.Id, value => new IntegracaoMarcaId(value))
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
                .HasForeignKey(i => i.IntegracaoSistemaId);
            });

        base.Configure(builder);
    }
}
