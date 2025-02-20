using Anima.Inscricao.Application.DTOs.Candidatos;
using Anima.Inscricao.Application.DTOs.Inscricoes;
using Anima.Inscricao.Application.DTOs.Instituicao;
using Anima.Inscricao.Application.Interfaces.Repositories;
using Anima.Inscricao.Infra.Data.Oracle.Connections;

using Dapper;

namespace Anima.Inscricao.Infra.Data.Oracle.Repositories;

public class CandidatoRepository : ICandidatoRepository
{
    private readonly SiafConnection _siafConnection;

    public CandidatoRepository(SiafConnection siafConnection)
    {
        _siafConnection = siafConnection;
    }

    public async Task<IEnumerable<DiarioClasseCandidatoDto>> PesquisarDiarioClasseCandidatoAsync(string cpf)
    {
        const string query = @"SELECT DISTINCT ALU.COD_ALUNO			AS CodigoAluno, 
                                       			ALU.NOM_ALUNO			AS NomeAluno, 
                                       			ALU.NUM_cpf				AS CpfAluno,
                                       			ALU.COD_TPO_ENTRADA		AS CodigoFormaIngresso, 
                                       			ALU.COD_STA_ALUNO		AS CodigoStatusAluno, 
                                       			ALU.COD_INSTITUICAO		AS CodigoInstituicao,
                                       			PL.DAT_INI_PERIODO 		AS InicioPeriodoLetivo,
                                       			PL.DAT_FIM_PERIODO 		AS TerminoPeriodoLetivo,
                                       			SD.COD_STA_DIARIO 		AS CodigoStatusDiario,
                                       			SD.DSC_STA_DIARIO 		AS StatusDiario
                                FROM DBSIAF.ALUNO ALU
                                INNER JOIN DBSIAF.CURSO CUR        			ON ALU.COD_CURSO = CUR.COD_CURSO
                                INNER JOIN DBSIAF.ITEM_DIARIO_CLASSE IDC 	ON IDC.COD_ALUNO = ALU.COD_ALUNO 
                                INNER JOIN DBSIAF.DIARIO_CLASSE DC 			ON DC.COD_DIARIO_CLASSE = IDC.COD_DIARIO_CLASSE 
                                INNER JOIN DBSIAF.STATUS_DIARIO SD 			ON SD.COD_STA_DIARIO = DC.COD_STA_DIARIO 
                                INNER JOIN DBSIAF.PERIODO_LETIVO PL			ON PL.COD_PERIODO_LETIVO = DC.COD_PERIODO_LETIVO 
                                WHERE ALU.COD_PESSOA = DBSIAF.PC_PESSOA.F_BUSCA_PESSOA_CPF(:cpf)
                                AND CUR.COD_NIV_CURSO = 1 -- Graduação
                                AND alu.COD_STA_ALUNO = 1 -- Ativo";

        var parameters = new DynamicParameters();
        parameters.Add(":cpf", cpf);

        using var connection = _siafConnection.ObterConexao();

        return await connection.QueryAsync<DiarioClasseCandidatoDto>(query, parameters);
    }

    public async Task<IEnumerable<CandidatoVinculoDto>> PesquisarVinculoCandidatoAsync(string cpf, string? codigoMarca, string? ra = null)
    {
        const string query = @"SELECT ALU.COD_ALUNO         AS CodigoAluno, 
                                    ALU.NOM_ALUNO           AS NomeAluno, 
                                    ALU.COD_TPO_ENTRADA     AS CodigoFormaIngresso, 
                                    ALU.COD_STA_ALUNO       AS CodigoStatusAluno, 
                                    CUR.NOM_CURSO           AS NomeCurso, 
                                    TUR.DSC_TURNO           AS NomeTurno,
                                    CAM.NOM_CAMPUS          AS NomeUnidade, 
                                    ALU.NUM_MATRICULA       AS Ra, 
                                    TIE.DSC_TPO_ENTRADA     AS NomeFormaIngresso, 
                                    ALU.COD_INSTITUICAO     AS CodigoInstituicao,
                                    ALU.DAT_ENTRADA         AS DataEntrada, 
                                    ALU.CODCONC             AS CodigoConcurso, 
                                    ALU.COD_CAMPUS          AS CodigoCampusSiaf, 
                                    TTS.COD_STA_ALUNO       AS CodigoStatusFinanceiro,
                                    IES.COD_MARCA 			AS CodigoMarca,
                                    CASE WHEN IND_DIGITAL_LIVE IS NULL THEN 'P' ELSE IND_DIGITAL_LIVE END AS IndicadorDigitalLive
                             FROM DBSIAF.ALUNO ALU
                             INNER JOIN DBSIAF.CURSO CUR                ON ALU.COD_CURSO = CUR.COD_CURSO
                             INNER JOIN DBSIAF.TURNO TUR                ON ALU.COD_TURNO = TUR.COD_TURNO
                             INNER JOIN DBSIAF.CAMPUS CAM               ON ALU.COD_CAMPUS = CAM.COD_CAMPUS
                             INNER JOIN DBSIAF.STATUS_ALUNO STU         ON ALU.COD_STA_ALUNO = STU.COD_STA_ALUNO
                             INNER JOIN DBSIAF.TIPO_ENTRADA TIE         ON ALU.COD_TPO_ENTRADA = TIE.COD_TPO_ENTRADA
                             INNER JOIN DBSIAF.INSTITUICAO_ENSINO IES 	ON IES.COD_INSTITUICAO = ALU.COD_INSTITUICAO 
                             LEFT JOIN  DBSIAF.TIPO_SAIDA TTS           ON ALU.COD_TPO_SAIDA = TTS.cod_Tpo_saida
                             LEFT JOIN DBVESTIB.CONCURSO CON            ON CON.CODCONC = ALU.CODCONC
                             LEFT JOIN DBVESTIB.TIPO_CONCURSO TPC       ON TPC.COD_TPO_CONCURSO  = CON.COD_TPO_CONCURSO 
                             WHERE ALU.COD_PESSOA = DBSIAF.PC_PESSOA.F_BUSCA_PESSOA_CPF(:cpf)
                             AND CUR.COD_NIV_CURSO = 1 -- Graduação
                             AND ALU.COD_STA_ALUNO <> 6 -- 6 é cancelado
                             AND ALU.COD_STA_ALUNO <> 8 -- 9 é remanejado
                             AND ALU.COD_STA_ALUNO <> 9 -- 9 é remanejado
                             AND ALU.COD_STA_ALUNO <> 10 -- 10 é unificado
                             AND TIE.DSC_TPO_ENTRADA <> 'Disciplinas Isoladas'
                             AND ALU.COD_PESSOA <> 0 -- Registros invalidos
                             AND 
                             (
                                (
                                    ALU.COD_TPO_ENTRADA IN (2, 5, 68) 
                                    AND EXISTS
                                    (SELECT IDC.COD_DIARIO_CLASSE
                                    FROM DBSIAF.ITEM_DIARIO_CLASSE IDC
                                     WHERE IDC.COD_ALUNO = ALU.COD_ALUNO)
                                )
                                OR(
                                    ALU.COD_TPO_ENTRADA NOT IN (2, 5, 68)
                                )
                                OR ( ALU.COD_INSTITUICAO IN (125, 127) )
                             )
                             AND 
                             ((ALU.COD_STA_ALUNO = 7 AND ALU.COD_TPO_SAIDA NOT IN (14, 12, 11, 16, 15, 9))
                                 OR ALU.COD_STA_ALUNO <> 7)
                            AND ((IES.COD_MARCA = :codigoMarca) OR (:codigoMarca IS NULL))
                            AND ((ALU.NUM_MATRICULA = :ra) OR (:ra IS NULL))";

        var parameters = new DynamicParameters();
        parameters.Add(":cpf", cpf);
        parameters.Add(":codigoMarca", codigoMarca);
        parameters.Add(":ra", ra);

        using var connection = _siafConnection.ObterConexao();

        return await connection.QueryAsync<CandidatoVinculoDto>(query, parameters);
    }

    public async Task<IList<CampusVestibDto>> BuscarDetalhesCampus(long? codCampusSiaf)
    {
        const string query = @"SELECT CODCAM as CodigoCampus, 
                               COD_CAMPUS_SIAF as CodigoCampusSiaf, 
                               DSC_AGRUPAMENTO as NomeCampusAgrupamento
                               FROM dbvestib.campus WHERE cod_campus_siaf = :codCampusSiaf";

        var parameters = new DynamicParameters();
        parameters.Add(":codCampusSiaf", codCampusSiaf);

        using var connection = _siafConnection.ObterConexao();

        var result = (await connection.QueryAsync<CampusVestibDto>(query, parameters)).ToList();
        return result;
    }

    public async Task<IList<InstituicaoAssociadaVestibDto>> BuscarInstituicoesAssociadasAsync(string? codigoVestibInstituicaoAnima)
    {
        const string query = @"SELECT   ia.SGLINSTITUICAO as SiglaInstituicao,
                                        ia.CODINSTITUICAO as CodigoInstituicao,
                                        ia.CODINSTITUICAO_ASSOCIADA as CodigoInstituicaoAssociada,
                                        ie.COD_INSTITUICAO_SIAF as CodigoInstituicaoSiaf
                                FROM DBVESTIB.INSTITUICAO_ASSOCIADA ia 
                                INNER JOIN DBVESTIB.INSTITUICAO_ENSINO ie ON ie.CODINSTITUICAO = ia.CODINSTITUICAO 
                                WHERE ia.CODINSTITUICAO_ASSOCIADA = :codigoVestibInstituicaoAnima OR :codigoVestibInstituicaoAnima is null";

        var parameters = new DynamicParameters();
        parameters.Add(":codigoVestibInstituicaoAnima", codigoVestibInstituicaoAnima);

        using var connection = _siafConnection.ObterConexao();

        return (await connection.QueryAsync<InstituicaoAssociadaVestibDto>(query, parameters)).ToList();
    }

    public async Task<bool> VerificarReprovacaoCandidato(string codigoConcurso, string codigoCandidato)
    {
        const string query = @"SELECT * FROM DBVESTIB.CLASSIFICACAO_CANDIDATO
                                WHERE COD_STA_CLASSIFICACAO IN (11,14) -- status reprovado
                                AND CODCONC = :codigoConcurso AND CODCAN = :codigoInscricao";

        var parameters = new DynamicParameters();
        parameters.Add(":codigoConcurso", codigoConcurso);
        parameters.Add(":codigoInscricao", codigoCandidato);

        using var connection = _siafConnection.ObterConexao();

        var resultado = await connection.QueryAsync(query, parameters);
        return resultado.Any();
    }

    public async Task<bool> VerificarInscricaoCancelada(string codigoConcurso, string codigoInscricao)
    {
        const string query = @"SELECT i.CODCONC , i.CODINSC , i.COD_STATUS_INSCRICAO  
                                FROM dbvestib.INSCRICAO i 
                                WHERE i.CODCONC = :codigoConcurso AND i.CODINSC = :codigoInscricao
                                AND i.COD_STATUS_INSCRICAO = 4 -- cancelado";

        var parameters = new DynamicParameters();
        parameters.Add(":codigoConcurso", codigoConcurso);
        parameters.Add(":codigoInscricao", codigoInscricao);

        using var connection = _siafConnection.ObterConexao();

        var resultado = await connection.QueryAsync(query, parameters);
        return resultado.Any();
    }

}
