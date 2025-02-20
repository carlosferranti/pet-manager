using Anima.Inscricao.Domain.Concursos.Entities;
using Anima.Inscricao.Domain.FormasEntrada.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Domain.Modalidades.Entities;
using Anima.Inscricao.Domain.ModalidadesAvaliacao.Entities;
using Anima.Inscricao.Domain.TiposFormacao.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;
using Anima.Inscricao.Infra.Data.Utils;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class ConcursoConfiguration : AuditoriaTypeConfiguration<Concurso>
{
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresPeriodoLetivo = 10;
    private const int LimiteCaracteresOrigemId = 100;

    public override void Configure(EntityTypeBuilder<Concurso> builder)
    {
        builder.ToTable("Concurso")
            .HasKey(c => c.Id);

        builder
           .Property(c => c.Id)
           .HasConversion(o => o.Id, value => new ConcursoId(value))
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

        builder
            .Property(c => c.PeriodoLetivo)
            .HasColumnName("PeriodoLetivo")
            .HasMaxLength(LimiteCaracteresPeriodoLetivo)
            .IsRequired();

        builder
            .Property(c => c.DivulgacaoResultado)
            .HasColumnName("DivulgacaoResultado")
            .HasConversion(src => src.ConverterParaUtcDate(), dst => dst.ConverterParaLocalDate());

        builder.OwnsOne(c => c.VigenciaInscricao, vigenciaInscricao =>
        {
            vigenciaInscricao
                .Property(p => p.Inicio)
                .HasColumnName("InicioInscricao")
                .HasConversion(src => src.ConverterParaUtcDate(), dst => dst.ConverterParaLocalDate())
                .IsRequired();

            vigenciaInscricao
                .Property(p => p.Termino)
                .HasColumnName("TerminoInscricao")
                .HasConversion(src => src.ConverterParaUtcDate(), dst => dst.ConverterParaLocalDate())
                .IsRequired();
        });

        builder
            .Property(p => p.InicioProva)
            .HasColumnName("InicioProva")
            .HasConversion(src => src.ConverterParaUtcDate(), dst => dst.ConverterParaLocalDate());

        builder
            .Property(p => p.TerminoProva)
            .HasColumnName("TerminoProva")
            .HasConversion(src => src.ConverterParaUtcDate(), dst => dst.ConverterParaLocalDate());

        builder
            .Property(m => m.ModalidadeAvaliacaoId)
            .HasColumnName("ModalidadeAvaliacaoId")
            .HasConversion(m => m!.Id, value => new ModalidadeAvaliacaoId(value));

        builder
            .HasOne<ModalidadeAvaliacao>()
            .WithMany()
            .HasForeignKey(m => m.ModalidadeAvaliacaoId);

        builder.OwnsOne(c => c.ConcursoParametros, concursoParametros =>
        {
            concursoParametros
                .Property(p => p.RecebeDocumentoConclusaoEnsinoSuperior)
                .HasColumnName("RecebeDocumentoConclusaoEnsinoSuperior");

            concursoParametros
                .Property(p => p.SolicitaAnoInscricaoEnem)
                .HasColumnName("SolicitaAnoInscricaoEnem");

            concursoParametros
                .Property(p => p.ExigeAceiteDeferimento)
                .HasColumnName("ExigeAceiteDeferimento");
        });

        builder.OwnsOne(p => p.Status, status =>
        {
            status
                .Property(p => p.Ativo)
                .HasColumnName("Ativo");
        });

        builder.OwnsMany(c => c.FormasEntrada, formasEntrada =>
        {
            formasEntrada
                .ToTable("ConcursoFormaEntrada")
                .HasKey(f => f.Id);

            formasEntrada
                .Property(f => f.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(f => f.Id, value => new ConcursoFormaEntradaId(value))
                .HasColumnName("Id")
                .IsRequired();

            formasEntrada
                .Property(f => f.FormaEntradaId)
                .HasColumnName("FormaEntradaId")
                .HasConversion(f => f.Id, value => new FormaEntradaId(value))
                .IsRequired();

            formasEntrada
                .HasOne<FormaEntrada>()
                .WithMany()
                .HasForeignKey(f => f.FormaEntradaId);
        });

        builder.OwnsMany(c => c.TiposFormacao, tiposFormacao =>
        {
            tiposFormacao
                .ToTable("ConcursoTipoFormacao")
                .HasKey(f => f.Id);

            tiposFormacao
                .Property(f => f.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(f => f.Id, value => new ConcursoTipoFormacaoId(value))
                .HasColumnName("Id")
                .IsRequired();

            tiposFormacao
                .Property(f => f.TipoFormacaoId)
                .HasColumnName("TipoFormacaoId")
                .HasConversion(f => f.Id, value => new TipoFormacaoId(value))
                .IsRequired();

            tiposFormacao
                .HasOne<TipoFormacao>()
                .WithMany()
                .HasForeignKey(f => f.TipoFormacaoId);
        });

        builder.OwnsMany(c => c.Modalidades, modalidade =>
        {
            modalidade
                .ToTable("ConcursoModalidade")
                .HasKey(m => m.Id);

            modalidade
                .Property(m => m.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(f => f.Id, value => new ConcursoModalidadeId(value))
                .HasColumnName("Id")
                .IsRequired();

            modalidade
                .Property(m => m.ModalidadeId)
                .HasColumnName("ModalidadeId")
                .HasConversion(m => m.Id, value => new ModalidadeId(value))
                .IsRequired();

            modalidade
                .HasOne<Modalidade>()
                .WithMany()
                .HasForeignKey(m => m.ModalidadeId);
        });

        builder
            .OwnsOne(i => i.IntegracaoConcurso, integracao =>
            {
                integracao
                .ToTable("IntegracaoConcurso")
                .HasKey(i => i.Id);

                integracao
                .Property(i => i.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(i => i.Id, value => new IntegracaoConcursoId(value))
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

        builder
            .OwnsMany(i => i.IntegracoesFormaProva, integracoesFormaProva =>
            {
                integracoesFormaProva
                .ToTable("IntegracaoConcursoFormaProva")
                .HasKey(i => i.Id);

                integracoesFormaProva
                .Property(i => i.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(i => i.Id, value => new IntegracaoConcursoFormaProvaId(value))
                .HasColumnName("Id")
                .IsRequired();

                integracoesFormaProva
                .Property(i => i.IntegracaoSistemaId)
                .HasColumnName("IntegracaoSistemaId")
                .IsRequired();

                integracoesFormaProva
                .Property(i => i.CodigoOrigem)
                .HasColumnName("CodigoOrigem")
                .HasMaxLength(LimiteCaracteresOrigemId)
                .IsRequired();

                integracoesFormaProva
                .HasOne<IntegracaoSistema>()
                .WithMany()
                .HasForeignKey(o => o.IntegracaoSistemaId);
            });

        base.Configure(builder);
    }
}