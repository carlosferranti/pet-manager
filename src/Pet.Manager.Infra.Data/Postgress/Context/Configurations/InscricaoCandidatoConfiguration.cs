using Anima.Inscricao.Domain.Acessibilidades.Entities;
using Anima.Inscricao.Domain.Cupons.Entities;
using Anima.Inscricao.Domain.CursosExternos.Entities;
using Anima.Inscricao.Domain.Deficiencias.Entities;
using Anima.Inscricao.Domain.Empresas.Entities;
using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Domain.Escolas.Entities;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Domain.FormasEntrada.Entities;
using Anima.Inscricao.Domain.Inscricoes.Entities;
using Anima.Inscricao.Domain.Inscricoes.Enums;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Domain.Marcas.Entities;
using Anima.Inscricao.Domain.Matriculas.Entities;
using Anima.Inscricao.Domain.OfertaConcursos.Entities;
using Anima.Inscricao.Domain.Ofertas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Context.Configurations;
using Anima.Inscricao.Infra.Data.Utils;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Anima.Inscricao.Infra.Data.Postgress.Context.Configurations;

public class InscricaoCandidatoConfiguration : AuditoriaTypeConfiguration<InscricaoCandidato>
{
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresValor = 100;
    private const int LimiteCaracteresValorFormatado = 150;
    private const int LimiteCaracteresEndereco = 150;
    private const int LimiteCaracteresCep = 50;
    private const int LimiteCaracteresNomeEscola = 200;
    private const int LimiteCaracteresOrigemId = 100;
    private const int LimiteCaracteresUrl = 250;
    private const int LimiteCaracteresOutraEmpresa = 200;
    private const int LimiteCaracteresObservacaoFormaEntrada = 200;

    public override void Configure(EntityTypeBuilder<InscricaoCandidato> builder)
    {
        builder.ToTable("InscricaoCandidato")
            .HasKey(c => c.Id);

        builder
           .Property(pf => pf.Id)
           .HasConversion(o => o.Id, value => new InscricaoCandidatoId(value))
           .ValueGeneratedOnAdd()
           .IsRequired();

        builder
            .Property(pf => pf.Key)
            .HasColumnName("Key")
            .IsRequired();

        builder
            .Property(c => c.FichaId)
            .HasConversion(o => o.Id, value => new FichaId(value))
            .HasColumnName("FichaId")
            .IsRequired();

        builder
            .HasOne<Ficha>()
            .WithMany()
            .HasForeignKey(c => c.FichaId);

        builder.Property(pf => pf.MarcaId)
            .HasConversion(pf => pf.Id, value => new MarcaId(value))
            .HasColumnName("MarcaId")
            .IsRequired();

        builder
            .HasOne<Marca>()
            .WithMany()
            .HasForeignKey(p => p.MarcaId);

        builder.OwnsOne(i => i.Oferta, oferta =>
        {
            oferta
            .Property(o => o.OfertaConcursoId)
            .HasConversion(o => o.Id, value => new OfertaConcursoId(value))
            .HasColumnName("OfertaConcursoId");

            oferta
            .Property(o => o.OfertaId)
            .HasConversion(o => o.Id, value => new OfertaId(value))
            .HasColumnName("OfertaId");
        });

        builder.OwnsOne(i => i.Candidato, candidato =>
        {
            candidato
                .Property(c => c.Nome)
                .HasMaxLength(LimiteCaracteresNome)
                .HasColumnName("CandidatoNome");

            candidato
                .Property(c => c.NomeSocial)
                .HasMaxLength(LimiteCaracteresNome)
                .HasColumnName("CandidatoNomeSocial");

            candidato
            .Property(c => c.DataNascimento)
            .HasColumnName("CandidatoDataNascimento")
            .HasConversion(src => src.ConverterParaUtcDate(), dst => dst.ConverterParaLocalDate());

            candidato
                .Property(c => c.Sexo)
                .HasColumnName("CandidatoSexo");

            candidato
                .Property(c => c.NecessidadeEspecial)
                .HasColumnName("CandidatoNecessidadeEspecial");
        });

        builder.OwnsMany(i => i.Cupons, cupom =>
        {
            cupom
                .ToTable("InscricaoCupom")
                .HasKey(c => c.Id);

            cupom
                .Property(pf => pf.Key)
                .HasColumnName("Key")
                .IsRequired();

            cupom
                .Property(c => c.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(c => c.Id, value => new CupomInscricaoId(value))
                .HasColumnName("Id")
                .IsRequired();

            cupom
                .Property(c => c.CupomId)
                .HasColumnName("CupomId");

            cupom
                .Property(c => c.Validado)
                .HasColumnName("Validado");

            cupom
                .HasOne<Cupom>()
                .WithMany()
                .HasForeignKey(c => c.CupomId);

            cupom.OwnsOne(p => p.Auditoria, auditoria =>
            {
                auditoria
                    .Property(p => p.CriadoEm)
                    .HasColumnName("CriadoEm");

                auditoria
                    .Property(p => p.AlteradoEm)
                    .HasColumnName("AlteradoEm");
            });
        });

        builder.OwnsMany(i => i.Contatos, contato =>
        {
            contato
                .ToTable("InscricaoContato")
                .HasKey(c => c.Id);

            contato
                .Property(pf => pf.Key)
                .HasColumnName("Key")
                .IsRequired();

            contato
                .Property(c => c.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(c => c.Id, value => new ContatoInscricaoId(value))
                .HasColumnName("Id")
                .IsRequired();

            contato
                .Property(c => c.Tipo)
                .HasColumnName("Tipo");

            contato
                .Property(c => c.Valor)
                .HasMaxLength(LimiteCaracteresValor)
                .HasColumnName("Valor");

            contato
                .Property(c => c.ValorFormatado)
                .HasMaxLength(LimiteCaracteresValorFormatado)
                .HasColumnName("ValorFormatado");
        });

        builder.OwnsMany(i => i.Enderecos, endereco =>
        {
            endereco
                .ToTable("InscricaoEndereco")
                .HasKey(e => e.Id);

            endereco
                .Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(e => e.Id, value => new EnderecoInscricaoId(value))
                .HasColumnName("Id")
                .IsRequired();

            endereco
                .Property(pf => pf.Key)
                .HasColumnName("Key")
                .IsRequired();

            endereco
                .Property(e => e.Tipo)
                .HasColumnName("Tipo");

            endereco
                .Property(e => e.Cep)
                .HasMaxLength(LimiteCaracteresCep)
                .HasColumnName("Cep");

            endereco
                .Property(e => e.Rua)
                .HasMaxLength(LimiteCaracteresEndereco)
                .HasColumnName("Rua");

            endereco
                .Property(e => e.Numero)
                .HasMaxLength(LimiteCaracteresEndereco)
                .HasColumnName("Numero");

            endereco
                .Property(e => e.Complemento)
                .HasMaxLength(LimiteCaracteresEndereco)
                .HasColumnName("Complemento");

            endereco
                .Property(e => e.Bairro)
                .HasMaxLength(LimiteCaracteresEndereco)
                .HasColumnName("Bairro");

            endereco
                .Property(e => e.Cidade)
                .HasMaxLength(LimiteCaracteresEndereco)
                .HasColumnName("Cidade");

            endereco
                .Property(e => e.Estado)
                .HasMaxLength(LimiteCaracteresEndereco)
                .HasColumnName("Estado");
        });

        builder.OwnsMany(i => i.Documentos, documentos =>
        {
            documentos
                .ToTable("InscricaoDocumentos")
                .HasKey(c => c.Id);

            documentos
                .Property(c => c.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(c => c.Id, value => new DocumentoInscricaoId(value))
                .HasColumnName("Id")
                .IsRequired();

            documentos
                .Property(pf => pf.Key)
                .HasColumnName("Key")
                .IsRequired();

            documentos
                .Property(c => c.Tipo)
                .HasColumnName("Tipo");

            documentos
                .Property(c => c.Valor)
                .HasMaxLength(LimiteCaracteresValor)
                .HasColumnName("Valor");

            documentos
                .Property(c => c.ValorFormatado)
                .HasMaxLength(LimiteCaracteresValorFormatado)
                .HasColumnName("ValorFormatado");
        });

        builder.OwnsMany(i => i.SeguroFianca, seguro =>
        {
            seguro
                .ToTable("InscricaoSeguroFianca")
                .HasKey(c => c.Id);

            seguro
                .Property(c => c.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(c => c.Id, value => new SeguroFiancaInscricaoId(value))
                .HasColumnName("Id")
                .IsRequired();

            seguro
                .Property(pf => pf.Key)
                .HasColumnName("Key")
                .IsRequired();

            seguro.OwnsOne(i => i.DadosFiador, fiador =>
            {
                fiador
                .Property(f => f.TipoRelacionamentoSegurado)
                .HasColumnName("TipoRelacionamentoSegurado");

                fiador
                   .Property(f => f.PercentualFiador)
                   .HasColumnName("PercentualFiador");

                fiador
                   .Property(f => f.NomeFiador)
                   .HasMaxLength(LimiteCaracteresNome)
                   .HasColumnName("NomeFiador");

                fiador.OwnsOne(i => i.InfoRendaFiador, renda =>
                {
                    renda
                    .Property(r => r.RendaMediaMensal)
                    .HasColumnName("RendaMediaMensal");
                });
            });

            seguro.OwnsOne(i => i.DocumentosFiador, docFiador =>
            {
                docFiador
                    .Property(c => c.TipoDocumento)
                    .HasColumnName("TipoDocumento");

                docFiador
                    .Property(c => c.Valor)
                    .HasMaxLength(LimiteCaracteresValor)
                    .HasColumnName("DocumentoValor");

                docFiador
                    .Property(c => c.ValorFormatado)
                    .HasMaxLength(LimiteCaracteresValorFormatado)
                    .HasColumnName("DocumentoValorFormatado");
            });

            seguro.OwnsOne(i => i.ContatosFiador, contatoFiador =>
            {
                contatoFiador
                    .Property(c => c.TipoContato)
                    .HasColumnName("TipoContato");

                contatoFiador
                    .Property(c => c.Valor)
                    .HasMaxLength(LimiteCaracteresValor)
                    .HasColumnName("ContatoValor");

                contatoFiador
                    .Property(c => c.ValorFormatado)
                    .HasMaxLength(LimiteCaracteresValorFormatado)
                    .HasColumnName("ContatoValorFormatado");
            });
        });

        builder.OwnsMany(i => i.Status, status =>
        {
            status
                .ToTable("InscricaoStatus")
                .HasKey(c => c.Id);

            status
                .Property(c => c.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(c => c.Id, value => new StatusInscricaoId(value))
                .HasColumnName("Id")
                .IsRequired();

            status
                .Property(pf => pf.Key)
                .HasColumnName("Key")
                .IsRequired();

            status
                .Property(c => c.Tipo)
                .HasColumnName("Tipo");

            status
                .Property(c => c.Data)
                .HasColumnName("Data");

            status
                .Property(c => c.Atual)
                .HasColumnName("Atual");
        });

        builder.OwnsMany(i => i.Etapas, etapas =>
        {
            etapas
                .ToTable("InscricaoEtapas")
                .HasKey(c => c.Id);

            etapas
                .Property(c => c.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(c => c.Id, value => new EtapaInscricaoId(value))
                .HasColumnName("Id")
                .IsRequired();

            etapas
                .Property(pf => pf.Key)
                .HasColumnName("Key")
                .IsRequired();

            etapas
                .Property(c => c.EtapaFichaId)
                .HasConversion(c => c.Id, value => new EtapaFichaId(value))
                .HasColumnName("EtapaFichaId");

            etapas
                .Property(c => c.Atual)
                .HasColumnName("Atual");

            etapas
                .Property(c => c.Data)
                .HasColumnName("Data");
        });

        builder.OwnsMany(i => i.Acessibilidades, acessibilidade =>
        {
            acessibilidade
                .ToTable("InscricaoAcessibilidade")
                .HasKey(a => a.Id);

            acessibilidade
                .Property(a => a.Key)
                .HasColumnName("Key")
                .IsRequired();

            acessibilidade
                .Property(a => a.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(a => a.Id, value => new AcessibilidadeInscricaoId(value))
                .HasColumnName("Id")
                .IsRequired();

            acessibilidade
                .Property(a => a.AcessibilidadeId)
                .HasColumnName("AcessibilidadeId")
                .IsRequired();

            acessibilidade
                .HasOne<Acessibilidade>()
                .WithMany()
                .HasForeignKey(a => a.AcessibilidadeId);

            acessibilidade.OwnsOne(aa => aa.Auditoria, auditoria =>
            {
                auditoria
                    .Property(a => a.CriadoEm)
                    .HasColumnName("CriadoEm");

                auditoria
                    .Property(a => a.AlteradoEm)
                    .HasColumnName("AlteradoEm");
            });
        });

        builder.OwnsMany(i => i.Deficiencias, deficiencia =>
        {
            deficiencia
                .ToTable("InscricaoDeficiencia")
                .HasKey(d => d.Id);

            deficiencia
                .Property(d => d.Key)
                .HasColumnName("Key")
                .IsRequired();

            deficiencia
                .Property(d => d.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(d => d.Id, value => new DeficienciaInscricaoId(value))
                .HasColumnName("Id")
                .IsRequired();

            deficiencia
                .Property(d => d.DeficienciaId)
                .HasColumnName("DeficienciaId")
                .IsRequired();

            deficiencia
                .HasOne<Deficiencia>()
                .WithMany()
                .HasForeignKey(d => d.DeficienciaId);

            deficiencia.OwnsOne(da => da.Auditoria, auditoria =>
            {
                auditoria
                    .Property(a => a.CriadoEm)
                    .HasColumnName("CriadoEm");

                auditoria
                    .Property(a => a.AlteradoEm)
                    .HasColumnName("AlteradoEm");
            });
        });

        builder.OwnsMany(i => i.Empresas, empresa => 
        {
            empresa
            .ToTable("InscricaoEmpresa")
            .HasKey(d => d.Id);

            empresa
            .Property(d => d.Key)
            .HasColumnName("Key")
            .IsRequired();

            empresa
            .Property(d => d.Id)
            .ValueGeneratedOnAdd()
            .HasConversion(d => d.Id, value => new EmpresaInscricaoId(value))
            .HasColumnName("Id")
            .IsRequired();

            empresa
            .Property(d => d.EmpresaId)
            .HasColumnName("EmpresaId");

            empresa
            .Property(d => d.OutraEmpresa)
            .HasColumnName("OutraEmpresa")
            .HasMaxLength(LimiteCaracteresOutraEmpresa);

            empresa
           .HasOne<Empresa>()
           .WithMany()
           .HasForeignKey(d => d.EmpresaId);


            empresa.OwnsOne(da => da.Auditoria, auditoria =>
            {
                auditoria
                    .Property(a => a.CriadoEm)
                    .HasColumnName("CriadoEm");

                auditoria
                    .Property(a => a.AlteradoEm)
                    .HasColumnName("AlteradoEm");
            });
        });

        builder.OwnsMany(i => i.Escolaridades, escolaridade =>
        {
            escolaridade
                .ToTable("InscricaoEscolaridade")
                .HasKey(d => d.Id);

            escolaridade
                .Property(d => d.Key)
                .HasColumnName("Key")
                .IsRequired();

            escolaridade
                .Property(d => d.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(d => d.Id, value => new EscolaridadeInscricaoId(value))
                .HasColumnName("Id")
                .IsRequired();

            escolaridade
                .Property(d => d.AnoConclusao)
                .HasColumnName("AnoConclusao");

            escolaridade
                .Property(d => d.EstadoId)
                .HasColumnName("EstadoId");

            escolaridade
                .Property(d => d.CidadeId)
                .HasColumnName("CidadeId");

            escolaridade
                .Property(d => d.EscolaId)
                .HasColumnName("EscolaId");

            escolaridade
                .Property(d => d.OutraEscola)
                .HasColumnName("OutraEscola")
                .HasMaxLength(LimiteCaracteresNomeEscola);

            escolaridade
            .Property(d => d.Nivel)
            .HasColumnName("Nivel");

            escolaridade
            .Property(d => d.CursoExternoId)
            .HasColumnName("CursoExternoId");

            escolaridade
            .HasOne<Estado>()
            .WithMany()
            .HasForeignKey(d => d.EstadoId);

            escolaridade
                .HasOne<Cidade>()
                .WithMany()
                .HasForeignKey(d => d.CidadeId);

            escolaridade
               .HasOne<Escola>()
               .WithMany()
               .HasForeignKey(d => d.EscolaId);

            escolaridade
           .HasOne<CursoExterno>()
           .WithMany()
           .HasForeignKey(d => d.CursoExternoId);

            escolaridade.OwnsOne(da => da.Auditoria, auditoria =>
            {
                auditoria
                    .Property(a => a.CriadoEm)
                    .HasColumnName("CriadoEm");

                auditoria
                    .Property(a => a.AlteradoEm)
                    .HasColumnName("AlteradoEm");
            });
        });

        builder.OwnsMany(i => i.IntegracoesInscricao, integracao =>
        {
            integracao
                .ToTable("IntegracaoInscricao")
                .HasKey(x => x.Id);

            integracao
                .Property(i => i.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(c => c.Id, value => new IntegracaoInscricaoId(value))
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
                .HasForeignKey(o => o.IntegracaoSistemaId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        builder.OwnsMany(i => i.OpcoesAcesso, opcoesAcesso =>
        {
            opcoesAcesso
            .ToTable("InscricaoOpcaoAcesso")
            .HasKey(c => c.Id);

            opcoesAcesso
            .Property(pf => pf.Key)
            .HasColumnName("Key")
            .IsRequired();

            opcoesAcesso
            .Property(c => c.Id)
            .ValueGeneratedOnAdd()
            .HasConversion(c => c.Id, value => new InscricaoOpcaoAcessoId(value))
            .HasColumnName("Id")
            .IsRequired();

            opcoesAcesso
            .Property(c => c.Percentual)
            .HasColumnName("Percentual");

            opcoesAcesso
            .Property(c => c.OfertaConcursoOpcaoAcessoId)
            .HasConversion(c => c.Id, value => new OfertaConcursoOpcaoAcessoId(value))
            .HasColumnName("OfertaConcursoOpcaoAcessoId")
            .IsRequired();

            opcoesAcesso
            .HasOne<OfertaConcursoOpcaoAcesso>()
            .WithMany()
            .HasForeignKey(c => c.OfertaConcursoOpcaoAcessoId);

            opcoesAcesso.OwnsOne(p => p.Auditoria, auditoria =>
            {
                auditoria
                    .Property(p => p.CriadoEm)
                    .HasColumnName("CriadoEm");

                auditoria
                    .Property(p => p.AlteradoEm)
                    .HasColumnName("AlteradoEm");
            });
        });

        builder.OwnsMany(i => i.Matriculas, matricula =>
        {
            matricula
            .ToTable("InscricaoMatricula")
            .HasKey(c => c.Id);

            matricula
            .Property(pf => pf.Key)
            .HasColumnName("Key")
            .IsRequired();

            matricula
            .Property(c => c.Id)
            .ValueGeneratedOnAdd()
            .HasConversion(c => c.Id, value => new InscricaoMatriculaId(value))
            .HasColumnName("Id")
            .IsRequired();

            matricula
            .Property(c => c.MatriculaId)
            .HasConversion(c => c.Id, value => new MatriculaId(value))
            .HasColumnName("MatriculaId")
            .IsRequired();

            matricula
            .HasOne<Matricula>()
            .WithMany()
            .HasForeignKey(c => c.MatriculaId);

            matricula.OwnsOne(p => p.Auditoria, auditoria =>
            {
                auditoria
                    .Property(p => p.CriadoEm)
                    .HasColumnName("CriadoEm");

                auditoria
                    .Property(p => p.AlteradoEm)
                    .HasColumnName("AlteradoEm");
            });
        });

        builder
            .HasMany(i => i.Documentacao)
            .WithOne()
            .HasForeignKey(d => d.InscricaoCandidatoId);

        builder.OwnsOne(o => o.Origem, origem =>
        {
            origem
                .ToTable("InscricaoOrigem")
                .HasKey(x => x.Id);

            origem
                .Property(i => i.Id)
                .ValueGeneratedOnAdd()
                .HasConversion(c => c.Id, value => new InscricaoOrigemId(value))
                .HasColumnName("Id")
                .IsRequired();

            origem
                .Property(i => i.Tipo)
                .HasColumnName("Tipo")
                .IsRequired();

            origem
                .Property(o => o.Url)
                .HasColumnName("Url")
                .HasMaxLength(LimiteCaracteresUrl);
        });

        builder.OwnsMany(i => i.Filiacoes, filiacao =>
        {
            filiacao
            .ToTable("InscricaoFiliacao")
            .HasKey(c => c.Id);

            filiacao
            .Property(pf => pf.Key)
            .HasColumnName("Key")
            .IsRequired();

            filiacao
            .Property(c => c.Id)
            .ValueGeneratedOnAdd()
            .HasConversion(c => c.Id, value => new InscricaoFiliacaoId(value))
            .HasColumnName("Id")
            .IsRequired();

            filiacao
            .Property(c => c.Nome)
            .HasColumnName("Nome")
            .HasMaxLength(LimiteCaracteresNome)
            .IsRequired();

            filiacao
            .Property(c => c.Tipo)
            .HasColumnName("Tipo")
            .IsRequired();

            filiacao
            .OwnsOne(p => p.Status, status =>
            {
                status
                    .Property(p => p.Ativo)
                    .HasColumnName("Ativo");
            });

            filiacao.OwnsOne(p => p.Auditoria, auditoria =>
            {
                auditoria
                    .Property(p => p.CriadoEm)
                    .HasColumnName("CriadoEm");

                auditoria
                    .Property(p => p.AlteradoEm)
                    .HasColumnName("AlteradoEm");
            });
        });

        builder.OwnsMany(i => i.FormasEntrada, formaEntrada =>
        {
            formaEntrada
            .ToTable("InscricaoFormaEntrada")
            .HasKey(f => f.Id);

            formaEntrada
            .Property(f => f.Id)
            .ValueGeneratedOnAdd()
            .HasConversion(f => f.Id, value => new InscricaoFormaEntradaId(value))
            .HasColumnName("Id")
            .IsRequired();

            formaEntrada
            .Property(f => f.FormaEntradaId)
            .HasConversion(f => f.Id, value => new FormaEntradaId(value))
            .HasColumnName("FormaEntradaId")
            .IsRequired();

            formaEntrada
            .HasOne<FormaEntrada>()
            .WithMany()
            .HasForeignKey(f => f.FormaEntradaId);

            formaEntrada
            .Property(f => f.Observacoes)
            .HasColumnName("Observacoes")
            .HasMaxLength(LimiteCaracteresObservacaoFormaEntrada);

            formaEntrada
            .Property(f => f.CodigoTipoSelecao)
            .HasColumnName("CodigoTipoSelecao")
            .HasConversion(new EnumToStringConverter<TipoSelecaoFormaEntrada>())
            .IsRequired();

            formaEntrada
            .Property(f => f.Atual)
            .HasColumnName("Atual")
            .IsRequired();

            formaEntrada.OwnsOne(f => f.Auditoria, auditoria =>
            {
                auditoria
                    .Property(f => f.CriadoEm)
                    .HasColumnName("CriadoEm");

                auditoria
                    .Property(f => f.AlteradoEm)
                    .HasColumnName("AlteradoEm");
            });
        });

        base.Configure(builder);
    }
}