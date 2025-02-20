using Anima.Inscricao.Domain.Instituicoes.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Domain.Marcas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class InstituicaoConfiguration : AuditoriaTypeConfiguration<Instituicao>
{
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresSigla = 50;
    private const int LimiteCaracteresOrigemId = 100;

    public override void Configure(EntityTypeBuilder<Instituicao> builder)
    {
        builder.ToTable("Instituicao")
            .HasKey(c => c.Id);

        builder
           .Property(pf => pf.Id)
           .HasConversion(o => o.Id, value => new InstituicaoId(value))
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
            .OwnsOne(p => p.Status, status =>
            {
                status
                    .Property(p => p.Ativo)
                    .HasColumnName("Ativo");
            });

        builder.Property(pf => pf.MarcaId)
            .HasConversion(pf => pf.Id, value => new MarcaId(value))
            .HasColumnName("MarcaId")
            .IsRequired();

        builder
            .HasOne<Marca>()
            .WithMany()
            .HasForeignKey(p => p.MarcaId);

        builder
            .OwnsMany(i => i.IntegracaoInstituicao, integracao =>
            {
                integracao
                .ToTable("IntegracaoInstituicao")
                .HasKey(x => x.Id);

                integracao
                .Property(i => i.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(i => i.Id, value => new IntegracaoInstituicaoId(value))
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
                .HasForeignKey(o => o.IntegracaoSistemaId)
                .OnDelete(DeleteBehavior.Cascade);
            });

        base.Configure(builder);
    }
}
