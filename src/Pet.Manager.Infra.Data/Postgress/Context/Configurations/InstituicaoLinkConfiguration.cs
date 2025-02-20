using Anima.Inscricao.Domain.Instituicoes.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Domain.Marcas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class InstituicaoLinkConfiguration : AuditoriaTypeConfiguration<InstituicaoLink>
{
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresSigla = 50;
    private const int LimiteCaracteresOrigemId = 100;

    public override void Configure(EntityTypeBuilder<InstituicaoLink> builder)
    {
        builder.ToTable("InstituicaoLink")
            .HasKey(c => c.Id);

        builder
           .Property(pf => pf.Id)
           .HasConversion(o => o.Id, value => new InstituicaoLinkId(value))
           .ValueGeneratedOnAdd()
           .IsRequired();

        builder
            .Property(pf => pf.Key)
            .HasColumnName("Key")
            .IsRequired();

        builder
            .Property(pf => pf.Url)
            .HasColumnName("Url")
            .HasMaxLength(LimiteCaracteresNome)
            .IsRequired();

        builder
            .Property(pf => pf.TipoLink)
            .HasColumnName("TipoLink")
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


        base.Configure(builder);
    }
}
