using Anima.Inscricao.Domain.Intakes.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Domain.Ofertas.Entities;
using Anima.Inscricao.Domain.Produtos.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class OfertaConfiguration : AuditoriaTypeConfiguration<Oferta>
{
    private const int LimiteCaracteresOrigemId = 100;

    public override void Configure(EntityTypeBuilder<Oferta> builder)
    {
        builder.ToTable("Oferta")
            .HasKey(o => o.Id);

        builder
            .Property(o => o.Id)
            .HasConversion(o => o.Id, value => new OfertaId(value))
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder
            .Property(o => o.Key)
            .HasColumnName("Key")
            .IsRequired();

        builder
            .Property(o => o.ProdutoId)
            .HasConversion(o => o.Id, value => new ProdutoId(value))
            .HasColumnName("ProdutoId")
            .IsRequired();

        builder
            .HasOne<Produto>()
            .WithMany()
            .HasForeignKey(o => o.ProdutoId);

        builder
            .Property(o => o.IntakeId)
            .HasConversion(o => o.Id, value => new IntakeId(value))
            .HasColumnName("IntakeId")
            .IsRequired();

        builder
            .HasOne<Intake>()
            .WithMany()
            .HasForeignKey(o => o.IntakeId);

        builder.OwnsOne(p => p.Status, status =>
        {
            status
                .Property(p => p.Ativo)
                .HasColumnName("Ativo");
        });

        builder
            .OwnsOne(i => i.IntegracaoOferta, integracao =>
            {
                integracao
                .ToTable("IntegracaoOferta")
                .HasKey(i => i.Id);

                integracao
                .Property(i => i.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(i => i.Id, value => new IntegracaoOfertaId(value))
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
