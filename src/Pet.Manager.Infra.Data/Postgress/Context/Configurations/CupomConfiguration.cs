using Anima.Inscricao.Domain.Concursos.Entities;
using Anima.Inscricao.Domain.Cupons.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class CupomConfiguration : AuditoriaTypeConfiguration<Cupom>
{
    private const int LimiteCaracteresCodigo = 100;
    private const int LimiteCaracteresOrigemId = 100;
    private const int LimiteCaracteresDescricao = 500;


    public override void Configure(EntityTypeBuilder<Cupom> builder)
    {
        builder.ToTable("Cupom")
            .HasKey(c => c.Id);

        builder
           .Property(pf => pf.Id)
           .HasConversion(o => o.Id, value => new CupomId(value))
           .ValueGeneratedOnAdd()
           .IsRequired();

        builder
            .Property(pf => pf.Codigo)
            .HasColumnName("Codigo")
            .HasMaxLength(LimiteCaracteresCodigo)
            .IsRequired();

        builder .Property(pf => pf.Descricao)
            .HasColumnName("Descricao")
            .HasMaxLength(LimiteCaracteresDescricao)
            .IsRequired();

        builder
            .Property(pf => pf.ValorDesconto)
            .HasColumnName("ValorDesconto")
            .IsRequired();

        builder
            .Property(pf => pf.TipoDesconto)
            .HasColumnName("TipoDesconto")
            .IsRequired();

        builder
            .Property(pf => pf.DataValidade)
            .HasColumnName("DataValidade");

        builder
            .Property(pf => pf.ConcursoId)
            .HasColumnName("ConcursoId")
            .IsRequired();

        builder
            .HasOne<Concurso>()
            .WithMany()
            .HasForeignKey(o => o.ConcursoId);

        builder
            .OwnsOne(p => p.Status, status =>
            {
                status
                    .Property(p => p.Ativo)
                    .HasColumnName("Ativo");
            });

        builder
            .OwnsOne(i => i.IntegracaoCupom, integracao =>
            {
                integracao
                .ToTable("IntegracaoCupom")
                .HasKey(x => x.Id);

                integracao
                .Property(i => i.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(i => i.Id, value => new IntegracamCupomId(value))
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
