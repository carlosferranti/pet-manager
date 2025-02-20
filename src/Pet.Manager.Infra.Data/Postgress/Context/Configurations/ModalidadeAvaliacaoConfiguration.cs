using Anima.Inscricao.Domain.ModalidadesAvaliacao.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class ModalidadeAvaliacaoConfiguration : AuditoriaTypeConfiguration<ModalidadeAvaliacao>
{
    private const int LimiteCaracteresNome = 150;

    public override void Configure(EntityTypeBuilder<ModalidadeAvaliacao> builder)
    {
        builder.ToTable("ModalidadeAvaliacao")
            .HasKey(m => m.Id);

        builder
           .Property(m => m.Id)
           .HasConversion(m => m.Id, value => new ModalidadeAvaliacaoId(value))
           .ValueGeneratedOnAdd()
           .IsRequired();

        builder
            .Property(m => m.Key)
            .HasColumnName("Key")
            .IsRequired();

        builder
            .Property(m => m.Nome)
            .HasColumnName("Nome")
            .HasMaxLength(LimiteCaracteresNome)
            .IsRequired();

        builder
            .OwnsOne(m => m.Status, status =>
            {
                status
                    .Property(p => p.Ativo)
                    .HasColumnName("Ativo");
            });

        base.Configure(builder);
    }
}
