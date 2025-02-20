using Anima.Inscricao.Domain.OfertaConcursos.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class OfertaConcursoOpcaoAcessoConfiguration : AuditoriaTypeConfiguration<OfertaConcursoOpcaoAcesso>
{
    public override void Configure(EntityTypeBuilder<OfertaConcursoOpcaoAcesso> builder)
    {
        builder
            .ToTable("OfertaConcursoOpcaoAcesso")
            .HasKey(i => i.Id);

        builder
            .Property(i => i.Id)
            .ValueGeneratedOnAdd()
            .HasConversion(i => i.Id, value => new OfertaConcursoOpcaoAcessoId(value))
            .HasColumnName("Id")
            .IsRequired();

        builder
            .Property(i => i.OfertaConcursoId)
            .HasConversion(o => o.Id, value => new OfertaConcursoId(value))
            .HasColumnName("OfertaConcursoId")
            .IsRequired();

        builder
            .Property(i => i.TipoOpcaoAcesso)
            .HasColumnName("TipoOpcaoAcesso")
            .IsRequired();

        builder
            .Property(o => o.Key)
            .HasColumnName("Key")
            .IsRequired();

        base.Configure(builder);
    }
}