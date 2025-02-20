using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class CidadeConfiguration : AuditoriaTypeConfiguration<Cidade>
{
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresOrigemId = 100;

    public override void Configure(EntityTypeBuilder<Cidade> builder)
    {
        builder.ToTable("Cidade")
            .HasKey(c => c.Id);

        builder
           .Property(pf => pf.Id)
           .HasConversion(o => o.Id, value => new CidadeId(value))
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
            .Property(pf => pf.CodigoMunicipio)
            .HasColumnName("CodigoMunicipio");

        builder
            .Property(pf => pf.Ddd)
            .HasColumnName("Ddd");

        builder
            .Property(pf => pf.EstadoId)
            .HasColumnName("EstadoId")
            .IsRequired();

        builder
            .HasOne<Estado>()
            .WithMany()
            .HasForeignKey(o => o.EstadoId);

        builder
            .OwnsOne(p => p.Status, status =>
            {
                status
                    .Property(p => p.Ativo)
                    .HasColumnName("Ativo");
            });

        builder
            .OwnsOne(i => i.IntegracaoCidade, integracao =>
            {
                integracao
                .ToTable("IntegracaoCidade")
                .HasKey(x => x.Id);

                integracao
                .Property(i => i.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(i => i.Id, value => new IntegracaoCidadeId(value))
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
