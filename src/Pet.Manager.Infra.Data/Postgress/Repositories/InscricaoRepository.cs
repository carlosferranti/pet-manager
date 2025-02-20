using Anima.Inscricao.Domain.Concursos.Entities;
using Anima.Inscricao.Domain.Cursos.Entities;
using Anima.Inscricao.Domain.FormasEntrada.Entities;
using Anima.Inscricao.Domain.Inscricoes.Entities;
using Anima.Inscricao.Domain.Marcas.Entities;
using Anima.Inscricao.Domain.Turnos.Entities;
using Anima.Inscricao.Domain.Inscricoes.Events;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;
using Anima.Inscricoes.Domain.Inscricoes;

using Microsoft.EntityFrameworkCore;

using Npgsql;
using Anima.Inscricao.Domain.Inscricoes.Enums;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class InscricaoRepository : Repository<InscricaoCandidato, InscricaoCandidatoId>, IInscricaoRepository
{
    public InscricaoRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }

    public async Task ExcluirContatos(Guid InscricaoCandidatoKey, CancellationToken cancellationToken)
    {
        const string Sql = @"DELETE FROM ""InscricaoContato"" contato
                             USING ""InscricaoCandidato"" inscricao 
                             WHERE contato.""InscricaoCandidatoId"" = inscricao.""Id""
                             AND inscricao.""Key"" = @InscricaoCandidatoKey";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task InserirContatos(Guid InscricaoCandidatoKey, ContatoInscricao contatoInscricao, CancellationToken cancellationToken)
    {
        const string Sql = @"INSERT INTO ""InscricaoContato""
                                (""InscricaoCandidatoId"", ""Key"", ""Tipo"", ""Valor"", ""ValorFormatado"")
                             VALUES 
                                ((SELECT ""Id"" FROM ""InscricaoCandidato"" WHERE ""Key"" = @InscricaoCandidatoKey), @Key, @Tipo, @Valor, @ValorFormatado)";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
            new NpgsqlParameter("@Key", contatoInscricao.Key),
            new NpgsqlParameter("@Tipo", (int)contatoInscricao.Tipo),
            new NpgsqlParameter("@Valor", contatoInscricao.Valor),
            new NpgsqlParameter("@ValorFormatado", contatoInscricao.ValorFormatado),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task ExcluirDocumentos(Guid InscricaoCandidatoKey, CancellationToken cancellationToken)
    {
        const string Sql = @"DELETE FROM ""InscricaoDocumentos"" documentos
                             USING ""InscricaoCandidato"" inscricao 
                             WHERE documentos.""InscricaoCandidatoId"" = inscricao.""Id""
                             AND inscricao.""Key"" = @InscricaoCandidatoKey";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task InserirDocumento(Guid InscricaoCandidatoKey, DocumentoInscricao documentoInscricao, CancellationToken cancellationToken)
    {
        const string Sql = @"INSERT INTO ""InscricaoDocumentos""
                                (""InscricaoCandidatoId"", ""Key"", ""Tipo"", ""Valor"", ""ValorFormatado"")
                             VALUES 
                                ((SELECT ""Id"" FROM ""InscricaoCandidato"" WHERE ""Key"" = @InscricaoCandidatoKey), @Key, @Tipo, @Valor, @ValorFormatado)";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
            new NpgsqlParameter("@Key", documentoInscricao.Key),
            new NpgsqlParameter("@Tipo", (int)documentoInscricao.Tipo),
            new NpgsqlParameter("@Valor", documentoInscricao.Valor),
            new NpgsqlParameter("@ValorFormatado", documentoInscricao.ValorFormatado),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task ExcluirEndereco(Guid InscricaoCandidatoKey, CancellationToken cancellationToken)
    {
        const string Sql = @"DELETE FROM ""InscricaoEndereco"" endereco
                             USING ""InscricaoCandidato"" inscricao 
                             WHERE endereco.""InscricaoCandidatoId"" = inscricao.""Id""
                             AND inscricao.""Key"" = @InscricaoCandidatoKey";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task InserirEndereco(Guid InscricaoCandidatoKey, EnderecoInscricao enderecoInscricao, CancellationToken cancellationToken)
    {
        const string Sql = @"INSERT INTO ""InscricaoEndereco""
                                (""InscricaoCandidatoId"", ""Key"", ""Tipo"", ""Cep"", ""Rua"", ""Numero"", ""Complemento"", ""Bairro"", ""Cidade"", ""Estado"")
                             VALUES 
                                ((SELECT ""Id"" FROM ""InscricaoCandidato"" WHERE ""Key"" = @InscricaoCandidatoKey), @Key, @Tipo, @Cep, @Rua, @Numero, @Complemento, @Bairro, @Cidade, @Estado)";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
            new NpgsqlParameter("@Key", enderecoInscricao.Key),
            new NpgsqlParameter("@Tipo", (int)enderecoInscricao.Tipo),
            new NpgsqlParameter("@Cep", enderecoInscricao.Cep),
            new NpgsqlParameter("@Rua", enderecoInscricao.Rua),
            new NpgsqlParameter("@Numero", enderecoInscricao.Numero),
            new NpgsqlParameter("@Complemento", enderecoInscricao.Complemento != null ? enderecoInscricao.Complemento : DBNull.Value),
            new NpgsqlParameter("@Bairro", enderecoInscricao.Bairro),
            new NpgsqlParameter("@Cidade", enderecoInscricao.Cidade),
            new NpgsqlParameter("@Estado", enderecoInscricao.Estado),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task InserirEtapas(Guid InscricaoCandidatoKey, EtapaInscricao etapaInscricao, CancellationToken cancellationToken)
    {
        const string Sql = @"INSERT INTO ""InscricaoEtapas""
                                (""InscricaoCandidatoId"", ""Key"", ""EtapaFichaId"", ""Data"", ""Atual"")
                             VALUES 
                                ((SELECT ""Id"" FROM ""InscricaoCandidato"" WHERE ""Key"" = @InscricaoCandidatoKey), @Key, @EtapaFichaId, @Data, @Atual)";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
            new NpgsqlParameter("@Key", etapaInscricao.Key),
            new NpgsqlParameter("@EtapaFichaId", etapaInscricao.EtapaFichaId.Id),
            new NpgsqlParameter("@Data", etapaInscricao.Data),
            new NpgsqlParameter("@Atual", etapaInscricao.Atual),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task AtualizarInformacaoCandidato(Guid InscricaoCandidatoKey, InfoCandidato infoCandidato, CancellationToken cancellationToken)
    {
        const string Sql = @"UPDATE ""InscricaoCandidato"" SET 
                                ""CandidatoNome"" = CASE WHEN TRIM(COALESCE(@CandidatoNome, ""CandidatoNome"")) <> '' THEN COALESCE(@CandidatoNome, ""CandidatoNome"") ELSE null END,
                                ""CandidatoNomeSocial"" = CASE WHEN TRIM(COALESCE(@CandidatoNomeSocial, ""CandidatoNomeSocial"")) <> '' THEN COALESCE(@CandidatoNomeSocial, ""CandidatoNomeSocial"") ELSE null END,
                                ""CandidatoDataNascimento"" = CASE WHEN COALESCE((@CandidatoDataNascimento <> @DataPadrao), true) THEN COALESCE(@CandidatoDataNascimento, ""CandidatoDataNascimento"") ELSE null END,
                                ""CandidatoSexo"" = CASE WHEN COALESCE((@CandidatoSexo <> 0), true) THEN COALESCE(@CandidatoSexo, ""CandidatoSexo"") ELSE null END,
                                ""CandidatoNecessidadeEspecial"" = COALESCE(@CandidatoNecessidadeEspecial, ""CandidatoNecessidadeEspecial"") 
                             WHERE ""Key"" = @Key";

        object[] parametros =
        {
            new NpgsqlParameter("@DataPadrao", DateTime.MinValue),
            new NpgsqlParameter("@CandidatoNome", infoCandidato.Nome != null ? infoCandidato.Nome : DBNull.Value),
            new NpgsqlParameter("@CandidatoNomeSocial", infoCandidato.NomeSocial != null ? infoCandidato.NomeSocial : DBNull.Value),
            new NpgsqlParameter("@CandidatoDataNascimento", infoCandidato.DataNascimento != null ? infoCandidato.DataNascimento : DBNull.Value),
            new NpgsqlParameter("@CandidatoSexo", infoCandidato.Sexo != null ? infoCandidato.Sexo : DBNull.Value),
            new NpgsqlParameter("@CandidatoNecessidadeEspecial", infoCandidato.NecessidadeEspecial != null ? infoCandidato.NecessidadeEspecial : DBNull.Value),
            new NpgsqlParameter("@Key", InscricaoCandidatoKey),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task AtualizarOferta(Guid InscricaoCandidatoKey, InfoOfertaInscricao infoOfertaInscricao, CancellationToken cancellationToken)
    {
        const string Sql = @"UPDATE ""InscricaoCandidato"" SET 
                                ""OfertaConcursoId"" = CASE WHEN COALESCE((@OfertaConcursoId <> 0), true) THEN COALESCE(@OfertaConcursoId, ""OfertaConcursoId"") ELSE null END,
                                ""OfertaId"" = CASE WHEN COALESCE((@OfertaId <> 0), true) THEN COALESCE(@OfertaId, ""OfertaId"") ELSE null END
                             WHERE ""Key"" = @Key";

        object[] parametros =
        {
            new NpgsqlParameter("@OfertaConcursoId", infoOfertaInscricao.OfertaConcursoId?.Id != null ? infoOfertaInscricao.OfertaConcursoId.Id : DBNull.Value),
            new NpgsqlParameter("@OfertaId", infoOfertaInscricao.OfertaId?.Id != null ? infoOfertaInscricao.OfertaId.Id : DBNull.Value),
            new NpgsqlParameter("@Key", InscricaoCandidatoKey),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task AtualizarOrigem(Guid InscricaoCandidatokey, InscricaoOrigem origem, CancellationToken cancellationToken)
    {
        const string Sql = @"UPDATE ""InscricaoOrigem"" io SET 
                        ""Tipo"" = CASE 
                                        WHEN @Tipo = 0 THEN ""Tipo""
                                        ELSE @Tipo 
                                     END,
                        ""Url"" = CASE 
                                    WHEN @Url IS NULL THEN ""Url""
                                    WHEN @Url = '' THEN null
                                    ELSE @Url 
                                  END
                     FROM ""InscricaoCandidato"" ic
                     WHERE io.""InscricaoCandidatoId"" = ic.""Id""    
                     AND ic.""Key"" = @Key";

        object[] parametros =
        {
            new NpgsqlParameter("@Tipo", (int)origem.Tipo),
            new NpgsqlParameter("@Url", origem.Url ?? (object)DBNull.Value) { NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar },
            new NpgsqlParameter("@Key", InscricaoCandidatokey),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task InserirStatus(Guid InscricaoCandidatoKey, StatusInscricao statusInscricao, CancellationToken cancellationToken)
    {
        const string Sql = @"INSERT INTO ""InscricaoStatus""
                                (""InscricaoCandidatoId"", ""Key"", ""Tipo"", ""Data"", ""Atual"")
                             VALUES 
                                ((SELECT ""Id"" FROM ""InscricaoCandidato"" WHERE ""Key"" = @InscricaoCandidatoKey), @Key, @Tipo, @Data, @Atual)";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
            new NpgsqlParameter("@Key", statusInscricao.Key),
            new NpgsqlParameter("@Tipo", statusInscricao.Tipo),
            new NpgsqlParameter("@Data", statusInscricao.Data),
            new NpgsqlParameter("@Atual", statusInscricao.Atual),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task ExcluirSeguroFianca(Guid InscricaoCandidatoKey, CancellationToken cancellationToken)
    {
        const string Sql = @"DELETE FROM ""InscricaoSeguroFianca"" seguro
                             USING ""InscricaoCandidato"" inscricao 
                             WHERE seguro.""InscricaoCandidatoId"" = inscricao.""Id""
                             AND inscricao.""Key"" = @InscricaoCandidatoKey";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task InserirSeguroFianca(Guid InscricaoCandidatoKey, SeguroFiancaInscricao seguroFiancaInscricao, CancellationToken cancellationToken)
    {
        const string Sql = @"INSERT INTO ""InscricaoSeguroFianca""
                                (""InscricaoCandidatoId"", ""Key"", ""TipoRelacionamentoSegurado"", ""PercentualFiador"", ""NomeFiador"", ""RendaMediaMensal"", ""TipoDocumento"", ""DocumentoValor"", ""DocumentoValorFormatado"", ""TipoContato"", ""ContatoValor"", ""ContatoValorFormatado"")
                             VALUES 
                                ((SELECT ""Id"" FROM ""InscricaoCandidato"" WHERE ""Key"" = @InscricaoCandidatoKey), @Key, @TipoRelacionamentoSegurado, @PercentualFiador, @NomeFiador, @RendaMediaMensal, @TipoDocumento, @DocumentoValor, @DocumentoValorFormatado, @TipoContato, @ContatoValor, @ContatoValorFormatado)";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
            new NpgsqlParameter("@Key", seguroFiancaInscricao.Key),
            new NpgsqlParameter("@TipoRelacionamentoSegurado", seguroFiancaInscricao.DadosFiador.TipoRelacionamentoSegurado != null ? seguroFiancaInscricao.DadosFiador.TipoRelacionamentoSegurado : DBNull.Value),
            new NpgsqlParameter("@PercentualFiador", seguroFiancaInscricao.DadosFiador.PercentualFiador != null ? seguroFiancaInscricao.DadosFiador.PercentualFiador : DBNull.Value),
            new NpgsqlParameter("@NomeFiador", seguroFiancaInscricao.DadosFiador.NomeFiador != null ? seguroFiancaInscricao.DadosFiador.NomeFiador : DBNull.Value),
            new NpgsqlParameter("@RendaMediaMensal", seguroFiancaInscricao.DadosFiador?.InfoRendaFiador?.RendaMediaMensal != null ? seguroFiancaInscricao.DadosFiador?.InfoRendaFiador?.RendaMediaMensal : DBNull.Value),
            new NpgsqlParameter("@TipoDocumento", (int)seguroFiancaInscricao.DocumentosFiador.TipoDocumento),
            new NpgsqlParameter("@DocumentoValor", seguroFiancaInscricao.DocumentosFiador.Valor != null ? seguroFiancaInscricao.DocumentosFiador.Valor : DBNull.Value),
            new NpgsqlParameter("@DocumentoValorFormatado", seguroFiancaInscricao.DocumentosFiador.ValorFormatado != null ? seguroFiancaInscricao.DocumentosFiador.ValorFormatado : DBNull.Value),
            new NpgsqlParameter("@TipoContato", (int)seguroFiancaInscricao.ContatosFiador.TipoContato),
            new NpgsqlParameter("@ContatoValor", seguroFiancaInscricao.ContatosFiador.Valor != null ? seguroFiancaInscricao.ContatosFiador.Valor : DBNull.Value),
            new NpgsqlParameter("@ContatoValorFormatado", seguroFiancaInscricao.ContatosFiador.ValorFormatado != null ? seguroFiancaInscricao.ContatosFiador.ValorFormatado : DBNull.Value),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task ExcluirCupons(Guid InscricaoCandidatoKey, CancellationToken cancellationToken)
    {
        const string Sql = @"DELETE FROM ""InscricaoCupom"" cupom
                             USING ""InscricaoCandidato"" inscricao 
                             WHERE cupom.""InscricaoCandidatoId"" = inscricao.""Id""
                             AND inscricao.""Key"" = @InscricaoCandidatoKey";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task InserirCupons(Guid InscricaoCandidatoKey, CupomInscricao cupomInscricao, CancellationToken cancellationToken)
    {
        const string Sql = @"INSERT INTO ""InscricaoCupom""
                                (""InscricaoCandidatoId"", ""Key"", ""CupomId"", ""Validado"", ""CriadoEm"", ""AlteradoEm"")
                             VALUES 
                                ((SELECT ""Id"" FROM ""InscricaoCandidato"" WHERE ""Key"" = @InscricaoCandidatoKey), @Key, @CupomId, @Validado, current_timestamp, current_timestamp)";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
            new NpgsqlParameter("@Key", cupomInscricao.Key),
            new NpgsqlParameter("@CupomId", cupomInscricao.CupomId.Id),
            new NpgsqlParameter("@Validado", cupomInscricao.Validado),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task ExcluirAcessibilidade(Guid InscricaoCandidatoKey, CancellationToken cancellationToken)
    {
        const string Sql = @"DELETE FROM ""InscricaoAcessibilidade"" acessibilidade
                             USING ""InscricaoCandidato"" inscricao 
                             WHERE acessibilidade.""InscricaoCandidatoId"" = inscricao.""Id""
                             AND inscricao.""Key"" = @InscricaoCandidatoKey";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task InserirAcessibilidade(Guid InscricaoCandidatoKey, AcessibilidadeInscricao acessibilidadeInscricao, CancellationToken cancellationToken)
    {
        const string Sql = @"INSERT INTO ""InscricaoAcessibilidade""
                                (""InscricaoCandidatoId"", ""Key"", ""AcessibilidadeId"", ""CriadoEm"", ""AlteradoEm"")
                             VALUES 
                                ((SELECT ""Id"" FROM ""InscricaoCandidato"" WHERE ""Key"" = @InscricaoCandidatoKey), @Key, @AcessibilidadeId, current_timestamp, current_timestamp)";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
            new NpgsqlParameter("@Key", acessibilidadeInscricao.Key),
            new NpgsqlParameter("@AcessibilidadeId", acessibilidadeInscricao.AcessibilidadeId.Id),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task ExcluirDeficiencia(Guid InscricaoCandidatoKey, CancellationToken cancellationToken)
    {
        const string Sql = @"DELETE FROM ""InscricaoDeficiencia"" deficiencia
                             USING ""InscricaoCandidato"" inscricao 
                             WHERE deficiencia.""InscricaoCandidatoId"" = inscricao.""Id""
                             AND inscricao.""Key"" = @InscricaoCandidatoKey";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task InserirDeficiencia(Guid InscricaoCandidatoKey, DeficienciaInscricao deficienciaInscricao, CancellationToken cancellationToken)
    {
        const string Sql = @"INSERT INTO ""InscricaoDeficiencia""
                                (""InscricaoCandidatoId"", ""Key"", ""DeficienciaId"", ""CriadoEm"", ""AlteradoEm"")
                             VALUES 
                                ((SELECT ""Id"" FROM ""InscricaoCandidato"" WHERE ""Key"" = @InscricaoCandidatoKey), @Key, @DeficienciaId, current_timestamp, current_timestamp)";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
            new NpgsqlParameter("@Key", deficienciaInscricao.Key),
            new NpgsqlParameter("@DeficienciaId", deficienciaInscricao.DeficienciaId.Id),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task ExcluirEscolaridade(Guid InscricaoCandidatoKey, CancellationToken cancellationToken)
    {
        const string Sql = @"DELETE FROM ""InscricaoEscolaridade"" escolaridade
                             USING ""InscricaoCandidato"" inscricao 
                             WHERE escolaridade.""InscricaoCandidatoId"" = inscricao.""Id""
                             AND inscricao.""Key"" = @InscricaoCandidatoKey";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task InserirEscolaridade(Guid InscricaoCandidatoKey, EscolaridadeInscricao escolaridadeInscricao, CancellationToken cancellationToken)
    {
        const string Sql = @"INSERT INTO ""InscricaoEscolaridade""
                                (""InscricaoCandidatoId"", ""Key"", ""AnoConclusao"", ""EstadoId"", ""CidadeId"", ""EscolaId"", ""OutraEscola"", ""Nivel"", ""CursoExternoId"", ""CriadoEm"", ""AlteradoEm"", ""InstituicaoEstrangeira"")
                             VALUES 
                                ((SELECT ""Id"" FROM ""InscricaoCandidato"" WHERE ""Key"" = @InscricaoCandidatoKey), @Key, @AnoConclusao, @EstadoId, @CidadeId, @EscolaId, @OutraEscola, @Nivel, @CursoExternoId, current_timestamp, current_timestamp, @InstituicaoEstrangeira)";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
            new NpgsqlParameter("@Key", escolaridadeInscricao.Key),
            new NpgsqlParameter("@AnoConclusao", escolaridadeInscricao.AnoConclusao != null ? escolaridadeInscricao.AnoConclusao : DBNull.Value),
            new NpgsqlParameter("@EstadoId", escolaridadeInscricao.EstadoId?.Id != null ? escolaridadeInscricao.EstadoId.Id : DBNull.Value),
            new NpgsqlParameter("@CidadeId", escolaridadeInscricao.CidadeId?.Id != null ? escolaridadeInscricao.CidadeId.Id : DBNull.Value),
            new NpgsqlParameter("@EscolaId", escolaridadeInscricao.EscolaId?.Id != null ? escolaridadeInscricao.EscolaId.Id : DBNull.Value),
            new NpgsqlParameter("@OutraEscola", escolaridadeInscricao.OutraEscola != null ? escolaridadeInscricao.OutraEscola : DBNull.Value),
            new NpgsqlParameter("@Nivel", (int)escolaridadeInscricao.Nivel),
            new NpgsqlParameter("@CursoExternoId", escolaridadeInscricao.CursoExternoId?.Id != null ? escolaridadeInscricao.CursoExternoId.Id : DBNull.Value),
            new NpgsqlParameter("@InstituicaoEstrangeira", escolaridadeInscricao.InstituicaoEstrangeira),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task<InscricaoCandidatoId> ObterInscriaoCandidatoIdAsync(Guid key)
    {
        const string Sql = @"SELECT ""Id"" FROM ""InscricaoCandidato"" WHERE ""Key"" = @key";

        object[] parametros =
        {
            new NpgsqlParameter("@key", key),
        };

        return await Context.Database.SqlQueryRaw<InscricaoCandidatoId>(Sql, parametros).SingleAsync();
    }

    public async Task<IEnumerable<DocumentoInscricao>?> ObterDocumentosCandidatoInscricaoAsync(InscricaoCandidatoId inscricaoCandidatoId, CancellationToken cancellationToken)
    {
        string sql = $@"SELECT  i.""Id"",
                                d.""Key"",
                                d.""Valor"",
                                d.""ValorFormatado"",
                                d.""Tipo""
                        FROM ""InscricaoCandidato"" i
                        INNER JOIN ""InscricaoDocumentos"" d on d.""InscricaoCandidatoId"" = i.""Id""
                        WHERE i.""Id"" = {inscricaoCandidatoId.Id}";

        return await Context.Set<InscricaoCandidato>()
            .FromSqlRaw(sql)
            .IgnoreAutoIncludes()
            .IgnoreQueryFilters()
            .AsNoTracking()
            .SelectMany(x => x.Documentos)
            .ToListAsync(cancellationToken);
    }

    public async Task<InfoCandidato?> ObterInfoCandidatoInscricaoAsync(InscricaoCandidatoId inscricaoCandidatoId, CancellationToken cancellationToken)
    {
        string sql = $@"SELECT  i.""Id"",
                                i.""Key"",
                                i.""CandidatoNome"",
                                i.""CandidatoDataNascimento"",
                                i.""CandidatoSexo"",
                                i.""CandidatoNecessidadeEspecial"",
                                i.""CandidatoNomeSocial""
                        FROM ""InscricaoCandidato"" i
                        WHERE i.""Id"" = {inscricaoCandidatoId.Id}";

        return await Context.Set<InscricaoCandidato>()
            .FromSqlRaw(sql)
            .IgnoreAutoIncludes()
            .IgnoreQueryFilters()
            .AsNoTracking()
            .Select(x => x.Candidato)
            .SingleOrDefaultAsync(cancellationToken);
    }
    public async Task<Curso?> ObterCursoInscricaoAsync(InscricaoCandidatoId inscricaoCandidatoId, CancellationToken cancellationToken)
    {
        string sql = $@"SELECT  c.*
                        FROM ""InscricaoCandidato"" i
                        INNER JOIN ""Oferta"" o on o.""Id"" = i.""OfertaId""
                        INNER JOIN ""Produto"" p on p.""Id"" = o.""ProdutoId""
                        INNER JOIN ""Curso"" c on c.""Id"" = p.""CursoId""
                        WHERE i.""Id"" = {inscricaoCandidatoId.Id}";

        return await Context.Set<Curso>()
            .FromSqlRaw(sql)
            .IgnoreAutoIncludes()
            .IgnoreQueryFilters()
            .AsNoTracking()
            .SingleOrDefaultAsync(cancellationToken);
    }

    public async Task<Turno?> ObterTurnoInscricaoAsync(InscricaoCandidatoId inscricaoCandidatoId, CancellationToken cancellationToken)
    {
        string sql = $@"SELECT  t.*
                        FROM ""InscricaoCandidato"" i
                        INNER JOIN ""Oferta"" o on o.""Id"" = i.""OfertaId""
                        INNER JOIN ""Produto"" p on p.""Id"" = o.""ProdutoId""
                        INNER JOIN ""Turno"" t on t.""Id"" = p.""TurnoId""
                        WHERE i.""Id"" = {inscricaoCandidatoId.Id}";

        return await Context.Set<Turno>()
            .FromSqlRaw(sql)
            .IgnoreAutoIncludes()
            .IgnoreQueryFilters()
            .AsNoTracking()
            .SingleOrDefaultAsync(cancellationToken);
    }

    public async Task<Concurso?> ObterConcursoInscricaoAsync(InscricaoCandidatoId inscricaoCandidatoId, CancellationToken cancellationToken)
    {
        string sql = $@"SELECT c.*
                        FROM ""InscricaoCandidato"" i
                        INNER JOIN ""OfertaConcurso"" oc on oc.""Id"" = i.""OfertaConcursoId""
                        INNER JOIN ""Concurso"" c on c.""Id"" = oc.""ConcursoId""
                        WHERE i.""Id"" = {inscricaoCandidatoId.Id}";

        return await Context.Set<Concurso>()
            .FromSqlRaw(sql)
            .IgnoreAutoIncludes()
            .Include(c => c.IntegracaoConcurso)
            .AsNoTracking()
            .SingleOrDefaultAsync(cancellationToken);
    }

    public async Task<Marca> ObterMarcaInscricaoAsync(InscricaoCandidatoId inscricaoCandidatoId, CancellationToken cancellationToken)
    {
        string sql = $@"SELECT 	m.*
                        FROM ""InscricaoCandidato"" i
                        INNER JOIN ""Marca"" m on m.""Id"" = i.""MarcaId""
                        WHERE i.""Id"" = {inscricaoCandidatoId.Id}";

        return await Context.Set<Marca>()
            .FromSqlRaw(sql)
            .IgnoreAutoIncludes()
            .IgnoreQueryFilters()
            .AsNoTracking()
            .SingleAsync(cancellationToken);
    }


    /// <summary>
    /// Método que consulta as inscrições que possuem forma de entrada de um candidato, a partir das informações de outra 
    /// inscrição recebida por parâmetro, comparando CPF e Data de nascimento
    /// </summary>
    /// <param name="inscricaoCandidatoId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<IEnumerable<InscricaoCandidato>> ObterInscricoesFinalizadasCandidatoPorInscricao(InscricaoCandidatoId inscricaoCandidatoId, CancellationToken cancellationToken)
    {
        string sql = $@"SELECT ic.*
                        FROM ""InscricaoCandidato"" ic
                        JOIN ""InscricaoDocumentos"" id ON ic.""Id"" = id.""InscricaoCandidatoId"" 
                        JOIN ""Oferta"" o ON ic.""OfertaId"" = o.""Id""
                        JOIN ""InscricaoFormaEntrada"" ife on ife.""InscricaoCandidatoId"" = ic.""Id""
                        JOIN ""FormaEntrada"" fe ON ife.""FormaEntradaId"" = fe.""Id"" 
                        JOIN (SELECT insc.""Key"" as ""Key"", insc.""CandidatoDataNascimento"" as ""DataNascimento"", oferta.""IntakeId"" as ""IntakeId"", doc.""Valor"" as ""ValorDocumento"", insc.""MarcaId"" as ""MarcaId""  
		                         FROM ""InscricaoCandidato"" insc
		                         JOIN ""Oferta"" oferta ON insc.""OfertaId"" = oferta.""Id"" 
		                         JOIN ""InscricaoDocumentos"" doc ON insc.""Id"" = doc.""InscricaoCandidatoId"" 
		                        WHERE insc.""Id"" =  {inscricaoCandidatoId.Id}
		                      ) inscricaoAtual on inscricaoAtual.""ValorDocumento"" = id.""Valor"" 
		      				                  and inscricaoAtual.""DataNascimento"" = ic.""CandidatoDataNascimento"" 
		      				                  and inscricaoAtual.""IntakeId"" = o.""IntakeId"" 
		      				                  and inscricaoAtual.""MarcaId"" = ic.""MarcaId""
                       WHERE ife.""FormaEntradaId"" is not null";

        return await Context.Set<InscricaoCandidato>()
            .FromSqlRaw(sql)
            .Select(l => l)
            .IgnoreAutoIncludes()
            .IgnoreQueryFilters()
            .AsNoTracking()
            .ToListAsync(cancellationToken);

    }

    public async Task<IEnumerable<(string NomeSistema, string CodigoOrigem)>> ObterIntegracaoInscricao(Guid infoInscricaoCandidatoKey, CancellationToken cancellationToken)
    {
        var query = await Context.Set<InscricaoCandidato>()
                    .Where(inscricao => inscricao.Key == infoInscricaoCandidatoKey)
                    .SelectMany(inscricao => inscricao.IntegracoesInscricao)
                    .Select(integracaoIns => new
                    {
                        CodigoOrigem = integracaoIns.CodigoOrigem,
                        NomeSistema = Context.Set<IntegracaoSistema>()
                            .Where(integracao => integracao.Id == integracaoIns.IntegracaoSistemaId)
                            .Select(integracao => integracao.Nome)
                            .FirstOrDefault()
                    })
                    .ToListAsync(cancellationToken);

        return query.Select(x => (x.NomeSistema, x.CodigoOrigem));
    }

    public async Task ExcluirOfertaConcursoOpcaoEntrada(Guid InscricaoCandidatoKey, CancellationToken cancellationToken)
    {
        const string Sql = @"DELETE FROM ""InscricaoOpcaoAcesso"" opcaoAcesso
                             USING ""InscricaoCandidato"" inscricao 
                             WHERE opcaoAcesso.""InscricaoCandidatoId"" = inscricao.""Id""
                             AND inscricao.""Key"" = @InscricaoCandidatoKey";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task InserirOfertaConcursoOpcaoEntrada(Guid InscricaoCandidatoKey, InscricaoOpcaoAcesso inscricaoOpcaoAcesso, CancellationToken cancellationToken)
    {
        const string Sql = @"INSERT INTO ""InscricaoOpcaoAcesso""
                                (""InscricaoCandidatoId"", ""Key"", ""OfertaConcursoOpcaoAcessoId"", ""CriadoEm"", ""AlteradoEm"", ""Percentual"")
                             VALUES 
                                ((SELECT ""Id"" FROM ""InscricaoCandidato"" WHERE ""Key"" = @InscricaoCandidatoKey), @Key, @OfertaConcursoOpcaoAcessoId, current_timestamp, current_timestamp, @Percentual)";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
            new NpgsqlParameter("@Key", inscricaoOpcaoAcesso.Key),
            new NpgsqlParameter("@OfertaConcursoOpcaoAcessoId", inscricaoOpcaoAcesso.OfertaConcursoOpcaoAcessoId.Id),
            new NpgsqlParameter("@Percentual", inscricaoOpcaoAcesso.Percentual != null ? inscricaoOpcaoAcesso.Percentual : DBNull.Value),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task ExcluirEmpresa(Guid InscricaoCandidatoKey, CancellationToken cancellationToken)
    {
        const string Sql = @"DELETE FROM ""InscricaoEmpresa"" empresa
                             USING ""InscricaoCandidato"" inscricao 
                             WHERE empresa.""InscricaoCandidatoId"" = inscricao.""Id""
                             AND inscricao.""Key"" = @InscricaoCandidatoKey";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task InserirEmpresa(Guid InscricaoCandidatoKey, EmpresaInscricao empresaInscricao, CancellationToken cancellationToken)
    {
        const string Sql = @"INSERT INTO ""InscricaoEmpresa""
                                (""InscricaoCandidatoId"", ""Key"", ""EmpresaId"", ""OutraEmpresa"", ""CriadoEm"", ""AlteradoEm"")
                             VALUES 
                                ((SELECT ""Id"" FROM ""InscricaoCandidato"" WHERE ""Key"" = @InscricaoCandidatoKey), @Key, @EmpresaId, @OutraEmpresa, current_timestamp, current_timestamp)";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
            new NpgsqlParameter("@Key", empresaInscricao.Key),
            new NpgsqlParameter("@EmpresaId", empresaInscricao.EmpresaId?.Id != null ? empresaInscricao.EmpresaId.Id : DBNull.Value),
            new NpgsqlParameter("@OutraEmpresa", empresaInscricao.OutraEmpresa != null ? empresaInscricao.OutraEmpresa : DBNull.Value),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task ExcluirMatricula(Guid InscricaoCandidatoKey, CancellationToken cancellationToken)
    {
        const string Sql = @"DELETE FROM ""InscricaoMatricula"" matricula
                             USING ""InscricaoCandidato"" inscricao 
                             WHERE matricula.""InscricaoCandidatoId"" = inscricao.""Id""
                             AND inscricao.""Key"" = @InscricaoCandidatoKey";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task InserirMatricula(Guid InscricaoCandidatoKey, InscricaoMatricula inscricaoMatricula, CancellationToken cancellationToken)
    {
        const string Sql = @"INSERT INTO ""InscricaoMatricula""
                                (""InscricaoCandidatoId"", ""Key"", ""MatriculaId"", ""CriadoEm"", ""AlteradoEm"")
                             VALUES 
                                ((SELECT ""Id"" FROM ""InscricaoCandidato"" WHERE ""Key"" = @InscricaoCandidatoKey), @Key, @MatriculaId, current_timestamp, current_timestamp)";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
            new NpgsqlParameter("@Key", inscricaoMatricula.Key),
            new NpgsqlParameter("@MatriculaId", inscricaoMatricula.MatriculaId?.Id != null ? inscricaoMatricula.MatriculaId.Id : DBNull.Value),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task<ConcursoId> ObterConcursoInscricaoCandidatoIdAsync(Guid InscricaoCandidatoKey)
    {
        const string Sql = @"SELECT oc.""ConcursoId"" as ""Id""
                             FROM ""InscricaoCandidato"" i
                             INNER JOIN ""OfertaConcurso"" oc ON oc.""Id"" = i.""OfertaConcursoId""
                             WHERE i.""Key"" = @InscricaoCandidatoKey";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
        };

        return await Context.Database.SqlQueryRaw<ConcursoId>(Sql, parametros).SingleAsync();
    }

    public async Task<List<Guid>> ObterConcursosInscricaoAtivaCandidatoAsync(Guid marcaKey, Guid intakeKey, string cpf)
    {
        const string Sql = @"SELECT c.""Key""
                             FROM ""InscricaoCandidato"" i
                             INNER JOIN ""InscricaoDocumentos"" idc on idc.""InscricaoCandidatoId"" = i.""Id""
                             INNER JOIN ""Marca"" m on m.""Id"" = i.""MarcaId""
                             INNER JOIN ""Oferta"" o on o.""Id"" = i.""OfertaId""
                             INNER JOIN ""OfertaConcurso"" oc on oc.""Id"" = i.""OfertaConcursoId""
                             INNER JOIN ""Concurso"" c on c.""Id"" = oc.""ConcursoId""
                             INNER JOIN ""Intake"" it on it.""Id"" = o.""IntakeId""
                             WHERE idc.""Tipo"" = 2 -- CPF
                             AND m.""Key"" = @MarcaKey
                             AND it.""Key"" = @IntakeKey
                             AND idc.""Valor"" = @Cpf
                             AND i.""Id"" in (select ist.""InscricaoCandidatoId"" 
                             				  from ""InscricaoStatus"" ist 
                             				  where ist.""InscricaoCandidatoId"" = i.""Id"" 
                             				  and ist.""Tipo"" = 3 /*Concluido*/)";

        object[] parametros =
        {
            new NpgsqlParameter("@MarcaKey", marcaKey),
            new NpgsqlParameter("@IntakeKey", intakeKey),
            new NpgsqlParameter("@Cpf", cpf),
        };

        return await Context.Database.SqlQueryRaw<Guid>(Sql, parametros).ToListAsync();
    }

    public async Task ExcluirFiliacao(Guid InscricaoCandidatoKey, CancellationToken cancellationToken)
    {
        const string Sql = @"DELETE FROM ""InscricaoFiliacao"" filiacao
                             USING ""InscricaoCandidato"" inscricao 
                             WHERE filiacao.""InscricaoCandidatoId"" = inscricao.""Id""
                             AND inscricao.""Key"" = @InscricaoCandidatoKey";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task InserirFiliacao(Guid InscricaoCandidatoKey, InscricaoFiliacao inscricaoFiliacao, CancellationToken cancellationToken)
    {
        const string Sql = @"INSERT INTO ""InscricaoFiliacao""
                                (""InscricaoCandidatoId"", ""Nome"", ""Tipo"", ""Key"", ""Ativo"", ""CriadoEm"", ""AlteradoEm"")
                             VALUES 
                                ((SELECT ""Id"" FROM ""InscricaoCandidato"" WHERE ""Key"" = @InscricaoCandidatoKey), @Nome, @Tipo, @Key, @Ativo, current_timestamp, current_timestamp)";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", InscricaoCandidatoKey),
            new NpgsqlParameter("@Nome", inscricaoFiliacao.Nome),
            new NpgsqlParameter("@Tipo", (int)inscricaoFiliacao.Tipo),
            new NpgsqlParameter("@Key", inscricaoFiliacao.Key),
            new NpgsqlParameter("@Ativo", inscricaoFiliacao.Status.Ativo),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task DesatualizarInscricaoFormaEntradaCandidatoAsync(Guid inscricaoCandidatoKey, TipoSelecaoFormaEntrada tipoSelecaoFormaEntrada, CancellationToken cancellationToken)
    {
        const string Sql = @"UPDATE ""InscricaoFormaEntrada""
                             SET ""Atual"" = false,
                                 ""AlteradoEm"" = current_timestamp
                             WHERE ""InscricaoCandidatoId"" = (SELECT ""Id"" FROM ""InscricaoCandidato"" WHERE ""Key"" = @InscricaoCandidatoKey)
                             AND ""CodigoTipoSelecao"" = @CodigoTipoSelecao";

        object[] parametros =
        {
            new NpgsqlParameter("@CodigoTipoSelecao", tipoSelecaoFormaEntrada.ToString()),
            new NpgsqlParameter("@InscricaoCandidatoKey", inscricaoCandidatoKey),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }

    public async Task InserirInscricaoFormaEntradaCandidatoAsync(Guid inscricaoCandidatoKey, InscricaoFormaEntrada inscricaoFormaEntrada, CancellationToken cancellationToken)
    {
        const string Sql = @"INSERT INTO ""InscricaoFormaEntrada""
                                (""InscricaoCandidatoId"", ""FormaEntradaId"", ""CodigoTipoSelecao"", ""Observacoes"", ""Atual"", ""CriadoEm"", ""AlteradoEm"")
                             VALUES 
                                ((SELECT ""Id"" FROM ""InscricaoCandidato"" WHERE ""Key"" = @InscricaoCandidatoKey), @FormaEntradaId, @CodigoTipoSelecao, @Observacoes, @Atual, current_timestamp, current_timestamp)";

        object[] parametros =
        {
            new NpgsqlParameter("@InscricaoCandidatoKey", inscricaoCandidatoKey),
            new NpgsqlParameter("@FormaEntradaId", inscricaoFormaEntrada.FormaEntradaId.Id),
            new NpgsqlParameter("@CodigoTipoSelecao", inscricaoFormaEntrada.CodigoTipoSelecao.ToString()),
            new NpgsqlParameter("@Observacoes", inscricaoFormaEntrada.Observacoes != null ? inscricaoFormaEntrada.Observacoes : DBNull.Value),
            new NpgsqlParameter("@Atual", inscricaoFormaEntrada.Atual),
        };

        await Context.Database.ExecuteSqlRawAsync(Sql, parametros, cancellationToken);
    }
}
