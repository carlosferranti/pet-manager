using Anima.Inscricao.Domain.Campi.Entities;
using Anima.Inscricao.Domain.Cursos.Entities;
using Anima.Inscricao.Domain.Instituicoes.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Domain.Produtos.Entities;
using Anima.Inscricao.Domain.Turnos.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class ProdutoConfiguration : AuditoriaTypeConfiguration<Produto>
{
    private const int LimiteCaracteresSku = 255;
    private const int LimiteCaracteresOrigemId = 100;

    public override void Configure(EntityTypeBuilder<Produto> builder)
    {
        builder.ToTable("Produto")
            .HasKey(p => p.Id);

        builder.Property(p => p.Id)
            .HasConversion(p => p.Id, value => new ProdutoId(value))
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(p => p.Key)
            .HasColumnName("Key")
            .IsRequired();

        builder
            .Property(p => p.InstituicaoId)
            .HasConversion(i => i.Id, value => new InstituicaoId(value))
            .HasColumnName("InstituicaoId")
            .IsRequired();

        builder
            .HasOne<Instituicao>()
            .WithMany()
            .HasForeignKey(i => i.InstituicaoId);

        builder
            .Property(c => c.CampusId)
            .HasConversion(c => c.Id, value => new CampusId(value))
            .HasColumnName("CampusId")
            .IsRequired();

        builder
            .HasOne<Campus>()
            .WithMany()
            .HasForeignKey(c => c.CampusId);

        builder
           .Property(c => c.CursoId)
           .HasConversion(c => c.Id, value => new CursoId(value))
           .HasColumnName("CursoId")
           .IsRequired();

        builder
            .HasOne<Curso>()
            .WithMany()
            .HasForeignKey(c => c.CursoId);

        builder
          .Property(t => t.TurnoId)
          .HasConversion(t => t.Id, value => new TurnoId(value))
          .HasColumnName("TurnoId")
          .IsRequired();

        builder
            .HasOne<Turno>()
            .WithMany()
            .HasForeignKey(t => t.TurnoId);

        builder
            .Property(s => s.Sku)
            .HasColumnName("Sku")
            .HasMaxLength(LimiteCaracteresSku)
            .IsRequired();


        builder.OwnsOne(p => p.Status, status =>
        {
            status
                .Property(p => p.Ativo)
                .HasColumnName("Ativo");
        });

        builder
           .OwnsOne(i => i.IntegracaoProduto, integracao =>
           {
               integracao
               .ToTable("IntegracaoProduto")
               .HasKey(i => i.Id);

               integracao
               .Property(i => i.Id)
               .ValueGeneratedOnAdd()
               .HasConversion(i => i.Id, value => new IntegracaoProdutoId(value))
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
