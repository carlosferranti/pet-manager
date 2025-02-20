using Anima.Inscricao.Domain.Empresas.Entities;
using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Domain.Escolas.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class EmpresaConfiguration : AuditoriaTypeConfiguration<Empresa>
{
    private const int LimiteCaracteresNome = 250;
    private const int LimiteCaracteresCodigoOrigem = 100;
    private const int LimiteCaracteresCep = 50;
    private const int LimiteCaracteresCnpj = 14;

    public override void Configure(EntityTypeBuilder<Empresa> builder)
    {
        builder.ToTable("Empresa")
            .HasKey(e => e.Id);

        builder
           .Property(e => e.Id)
           .HasConversion(o => o.Id, value => new EmpresaId(value))
           .ValueGeneratedOnAdd()
           .IsRequired();

        builder
            .Property(e => e.Key)
            .HasColumnName("Key")
            .IsRequired();

        builder
            .Property(e => e.NomeFantasia)
            .HasColumnName("NomeFantasia")
            .HasMaxLength(LimiteCaracteresNome);

        builder
            .Property(e => e.RazaoSocial)
            .HasColumnName("RazaoSocial")
            .HasMaxLength(LimiteCaracteresNome)
            .IsRequired();

        builder
            .Property(e => e.Cnpj)
            .HasColumnName("Cnpj")
            .HasMaxLength(LimiteCaracteresCnpj)
            .IsRequired();

        builder
            .OwnsOne(e => e.Status, status =>
            {
                status
                    .Property(p => p.Ativo)
                    .HasColumnName("Ativo");
            });

        builder
            .OwnsOne(e => e.IntegracaoEmpresa, integracao =>
            {
                integracao
                .ToTable("IntegracaoEmpresa")
                .HasKey(x => x.Id);

                integracao
                .Property(i => i.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(i => i.Id, value => new IntegracaoEmpresaId(value))
                .HasColumnName("Id")
                .IsRequired();

                integracao
                .Property(i => i.IntegracaoSistemaId)
                .HasColumnName("IntegracaoSistemaId")
                .IsRequired();

                integracao
                .Property(i => i.CodigoOrigem)
                .HasColumnName("CodigoOrigem")
                .HasMaxLength(LimiteCaracteresCodigoOrigem)
                .IsRequired();

                integracao
                .HasOne<IntegracaoSistema>()
                .WithMany()
                .HasForeignKey(o => o.IntegracaoSistemaId);
            });

        builder
            .OwnsMany(e => e.Enderecos, endereco =>
            {
                endereco
                .ToTable("EmpresaEndereco")
                .HasKey(e => e.Id);

                endereco
                .Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(i => i.Id, value => new EmpresaEnderecoId(value))
                .HasColumnName("Id")
                .IsRequired();

                endereco
                .Property(e => e.Key)
                .HasColumnName("Key")
                .IsRequired();

                endereco
                .Property(i => i.CidadeId)
                .HasConversion(i => i.Id, value => new CidadeId(value))
                .HasColumnName("CidadeId")
                .IsRequired();

                endereco
                .Property(e => e.Logradouro)
                .HasColumnName("Logradouro")
                .HasMaxLength(LimiteCaracteresNome);

                endereco
                .Property(e => e.Cep)
                .HasColumnName("Cep")
                .HasMaxLength(LimiteCaracteresCep);

                endereco
                .Property(e => e.Numero)
                .HasColumnName("Numero")
                .HasMaxLength(LimiteCaracteresNome);

                endereco
                .Property(e => e.Complemento)
                .HasColumnName("Complemento")
                .HasMaxLength(LimiteCaracteresNome);

                endereco
                .Property(e => e.Bairro)
                .HasColumnName("Bairro")
                .HasMaxLength(LimiteCaracteresNome);

                endereco
                .HasOne<Cidade>()
                .WithMany()
                .HasForeignKey(o => o.CidadeId);
            });

        base.Configure(builder);
    }
}
