using Anima.Inscricao.Domain.Inscricoes.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class InscricaoDocumentacaoConfiguration : AuditoriaTypeConfiguration<DocumentacaoInscricao>
{
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresExtensao = 10;

    public override void Configure(EntityTypeBuilder<DocumentacaoInscricao> builder)
    {
        builder
        .ToTable("InscricaoDocumentacao")
        .HasKey(c => c.Id);

        builder
        .Property(d => d.Id)
        .ValueGeneratedOnAdd()
        .HasConversion(o => o.Id, value => new DocumentacaoInscricaoId(value))
        .HasColumnName("Id")
        .IsRequired();

        builder
        .Property(d => d.InscricaoCandidatoId)
        .HasConversion(o => o.Id, value => new InscricaoCandidatoId(value))
        .HasColumnName("InscricaoCandidatoId")
        .IsRequired();

        builder
        .Property(pf => pf.Key)
        .HasColumnName("Key")
        .IsRequired();

        builder
        .Property(d => d.Observacoes)
        .HasColumnName("Observacoes");

        builder
        .Property(d => d.Tipo)
        .HasColumnName("TipoDocumento");

        builder.OwnsOne(a => a.Arquivo, arquivo =>
        {
            arquivo
            .Property(d => d.TipoLocalArquivo)
            .HasColumnName("TipoLocalArquivo")
            .IsRequired();

            arquivo
            .Property(d => d.Chave)
            .HasColumnName("ChaveArquivo")
            .IsRequired();

            arquivo.OwnsOne(arq => arq.Informacoes, info =>
            {
                info
                .Property(i => i.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(LimiteCaracteresNome);

                info
                .Property(i => i.Extensao)
                .HasColumnName("Extensao")
                .HasMaxLength(LimiteCaracteresExtensao);

                info
                .Property(i => i.Tamanho)
                .HasColumnName("Tamanho");
            });
        });

        builder.OwnsOne(p => p.Status, status =>
        {
            status
                .Property(p => p.Ativo)
                .HasColumnName("Ativo");
        });

        base.Configure(builder);
    }
}