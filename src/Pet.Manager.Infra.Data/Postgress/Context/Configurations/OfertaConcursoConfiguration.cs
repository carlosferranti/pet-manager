using Anima.Inscricao.Domain.Concursos.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Domain.OfertaConcursos.Entities;
using Anima.Inscricao.Domain.Ofertas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class OfertaConcursoConfiguration : AuditoriaTypeConfiguration<OfertaConcurso>
{
    private const int LimiteCaracteresOrigemId = 100;

    public override void Configure(EntityTypeBuilder<OfertaConcurso> builder)
    {
        builder.ToTable("OfertaConcurso")
            .HasKey(o => o.Id);

        builder
            .Property(o => o.Id)
            .HasConversion(o => o.Id, value => new OfertaConcursoId(value))
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder
            .Property(o => o.Key)
            .HasColumnName("Key")
            .IsRequired();

        builder
            .Property(o => o.ConcursoId)
            .HasConversion(o => o.Id, value => new ConcursoId(value))
            .HasColumnName("ConcursoId")
            .IsRequired();

        builder
            .HasOne<Concurso>()
            .WithMany()
            .HasForeignKey(o => o.ConcursoId);

        builder
            .Property(o => o.OfertaId)
            .HasConversion(o => o.Id, value => new OfertaId(value))
            .HasColumnName("OfertaId")
            .IsRequired();

        builder
            .HasOne<Oferta>()
            .WithMany()
            .HasForeignKey(o => o.OfertaId);

        builder.OwnsOne(p => p.Status, status =>
        {
            status
                .Property(p => p.Ativo)
                .HasColumnName("Ativo");
        });

        builder
            .OwnsOne(i => i.IntegracaoOfertaConcurso, integracao =>
            {
                integracao
                .ToTable("IntegracaoOfertaConcurso")
                .HasKey(i => i.Id);

                integracao
                .Property(i => i.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(i => i.Id, value => new IntegracaoOfertaConcursoId(value))
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

        builder
            .HasMany(i => i.OpcaoAcessos)
            .WithOne()
            .HasForeignKey(i => i.OfertaConcursoId);

        base.Configure(builder);
    }
}
