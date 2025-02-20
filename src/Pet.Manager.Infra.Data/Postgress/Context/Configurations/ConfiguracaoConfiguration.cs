using Anima.Inscricao.Domain.Configuracoes.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class ConfiguracaoConfiguration : AuditoriaTypeConfiguration<Configuracao>
{
    const int MaxLengthChave = 150;
    const int MaxLengthValor = 500;

    public override void Configure(EntityTypeBuilder<Configuracao> builder)
    {

        builder.ToTable("Configuracao")
            .HasKey(c => c.Id);

        builder
           .Property(pf => pf.Id)
           .HasConversion(o => o.Id, value => new ConfiguracaoId(value))
           .ValueGeneratedOnAdd()
           .IsRequired();

        builder
            .Property(pf => pf.Key)
            .HasColumnName("Key")
            .IsRequired();

        builder
            .Property(pf => pf.ChaveGenerica)
            .HasColumnName("ChaveGenerica")
            .HasMaxLength(MaxLengthChave)
            .IsRequired();

        builder
            .Property(pf => pf.Valor)
            .HasColumnName("Valor")
            .HasMaxLength(MaxLengthValor)
            .IsRequired();

        builder
            .OwnsOne(p => p.Status, status =>
            {
                status
                    .Property(p => p.Ativo)
                    .HasColumnName("Ativo");
            });

        base.Configure(builder);
    }
}
