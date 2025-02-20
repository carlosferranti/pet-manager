using Anima.Inscricao.Domain.Cursos.Entities;
using Anima.Inscricao.Domain.Instituicoes.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Domain.Modalidades.Entities;
using Anima.Inscricao.Domain.NiveisCurso.Entities;
using Anima.Inscricao.Domain.TiposFormacao.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class CursoConfiguration : AuditoriaTypeConfiguration<Curso>
{
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresOrigemId = 100;
    private const int LimiteCaracteresNomeComercial = 200;

    public override void Configure(EntityTypeBuilder<Curso> builder)
    {
        builder.ToTable("Curso")
            .HasKey(c => c.Id);

        builder
           .Property(c => c.Id)
           .HasConversion(o => o.Id, value => new CursoId(value))
           .ValueGeneratedOnAdd()
           .IsRequired();

        builder
            .Property(c => c.Key)
            .HasColumnName("Key")
            .IsRequired();

        builder
            .Property(c => c.Nome)
            .HasColumnName("Nome")
            .HasMaxLength(LimiteCaracteresNome)
            .IsRequired();

        builder.Property(c => c.NomeComercial)
            .HasColumnName("NomeComercial")
            .HasMaxLength(LimiteCaracteresNomeComercial);

        builder
            .Property(c => c.ModalidadeId)
            .HasConversion(o => o.Id, value => new ModalidadeId(value))
            .HasColumnName("ModalidadeId")
            .IsRequired();

        builder
            .HasOne<Modalidade>()
            .WithMany()
            .HasForeignKey(c => c.ModalidadeId);

        builder
            .Property(c => c.TipoFormacaoId)
            .HasConversion(o => o.Id, value => new TipoFormacaoId(value))
            .HasColumnName("TipoFormacaoId")
            .IsRequired();

        builder
            .HasOne<TipoFormacao>()
            .WithMany()
            .HasForeignKey(c => c.TipoFormacaoId);

        builder
            .Property(c => c.NivelCursoId)
            .HasConversion(o => o.Id, value => new NivelCursoId(value))
            .HasColumnName("NivelCursoId")
            .IsRequired();

        builder
            .HasOne<NivelCurso>()
            .WithMany()
            .HasForeignKey(c => c.NivelCursoId);

        builder
            .Property(c => c.InstituicaoId)
            .HasConversion(o => o.Id, value => new InstituicaoId(value))
            .HasColumnName("InstituicaoId")
            .IsRequired();

        builder
            .HasOne<Instituicao>()
            .WithMany()
            .HasForeignKey(c => c.InstituicaoId);

        builder.OwnsOne(p => p.Status, status =>
        {
            status
                .Property(p => p.Ativo)
                .HasColumnName("Ativo");
        });

        builder
            .OwnsOne(i => i.IntegracaoCurso, integracao =>
            {
                integracao
                .ToTable("IntegracaoCurso")
                .HasKey(i => i.Id);

                integracao
                .Property(i => i.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(i => i.Id, value => new IntegracaoCursoId(value))
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

