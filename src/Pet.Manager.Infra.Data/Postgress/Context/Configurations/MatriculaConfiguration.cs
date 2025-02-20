using Anima.Inscricao.Domain.Matriculas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class MatriculaConfiguration : AuditoriaTypeConfiguration<Matricula>
{
    public const int LimiteCodigoAluno = 50;
    public const int LimiteRaAluno = 50;

    public override void Configure(EntityTypeBuilder<Matricula> builder)
    {
        builder.ToTable("Matricula")
            .HasKey(c => c.Id);

        builder
           .Property(c => c.Id)
           .HasConversion(o => o.Id, value => new MatriculaId(value))
           .ValueGeneratedOnAdd()
           .IsRequired();

        builder
            .Property(c => c.Key)
            .HasColumnName("Key");

        builder
            .Property(c => c.CodigoAluno)
            .HasColumnName("CodigoAluno")
            .IsRequired()
            .HasMaxLength(LimiteCodigoAluno);

        builder
            .Property(c => c.Ra)
            .HasColumnName("Ra")
            .HasMaxLength(LimiteRaAluno);

        builder
            .Property(c => c.StatusMatricula)
            .HasColumnName("Status")
            .HasMaxLength(LimiteRaAluno);

        builder.OwnsOne(p => p.Status, status =>
        {
            status
                .Property(p => p.Ativo)
                .HasColumnName("Ativo");
        });

        base.Configure(builder);
    }
}