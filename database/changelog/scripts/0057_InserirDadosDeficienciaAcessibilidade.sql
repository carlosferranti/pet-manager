DO
$$
DECLARE 

    -- Variáveis de Deficiencias
    v_Cegueira INT;
    v_DeficienciaFisica INT;
    v_NaoPortadorNecessidadesEspeciais INT;
    v_DeficienciaAuditiva INT;
    v_AltasHabilidades INT;
    v_BaixaVisao INT;
    v_TEA INT;  
    v_DeficienciaIntelectualMental INT;
    v_DeficienciaMultipla INT;
    v_SindromeAsperger INT;
    v_SindromeRett INT;
    v_Surdez INT;
    v_Surdocegueira INT;
    v_TDAH INT;
    v_TranstornoDesintegrativoInfancia INT;
    v_SindromeGenetica INT;
    v_TranstornoAprendizagem INT;
    v_DoencaDegenerativa INT;
    v_DPAC INT;
    v_SequelasAVC INT;
    v_Lactante INT;
    v_Adventista INT;

    -- Variáveis de Acessibilidades
    v_Ledor INT;
    v_ProvaNormal INT;
    v_ProvaAmpliada INT;
    v_AuxilioTranscricao INT;
    v_HoraAdicional INT;
    v_MobiliarioAcessivel INT;
    v_SalaFacilAcesso INT;
    v_SalaEspecial INT;
    v_InterpreteLibras INT;
    v_AparelhoAuditivo INT;
    v_Calculadora INT;
    v_Amamentacao INT;
    v_ProvaAdaptada INT;

BEGIN
    -- Definição das variáveis para Deficiências
    SELECT "Id" INTO v_Cegueira FROM "Deficiencia" WHERE "Nome" = 'Cegueira';
    SELECT "Id" INTO v_DeficienciaFisica FROM "Deficiencia" WHERE "Nome" = 'Deficiência Física';
    SELECT "Id" INTO v_NaoPortadorNecessidadesEspeciais FROM "Deficiencia" WHERE "Nome" = 'Não portador de necessidades especiais';
    SELECT "Id" INTO v_DeficienciaAuditiva  FROM "Deficiencia" WHERE "Nome" = 'Deficiência Auditiva';
    SELECT "Id" INTO v_AltasHabilidades  FROM "Deficiencia" WHERE "Nome" = 'Altas habilidades / Superdotação';
    SELECT "Id" INTO v_BaixaVisao  FROM "Deficiencia" WHERE "Nome" = 'Baixa Visão';
    SELECT "Id" INTO v_TEA  FROM "Deficiencia" WHERE "Nome" = 'Transtorno do Espectro Autista - TEA';
    SELECT "Id" INTO v_DeficienciaIntelectualMental  FROM "Deficiencia" WHERE "Nome" = 'Deficiência Intelectual/Mental';
    SELECT "Id" INTO v_DeficienciaMultipla  FROM "Deficiencia" WHERE "Nome" = 'Deficiência Múltipla';
    SELECT "Id" INTO v_SindromeAsperger  FROM "Deficiencia" WHERE "Nome" = 'Síndrome de Asperger';
    SELECT "Id" INTO v_SindromeRett  FROM "Deficiencia" WHERE "Nome" = 'Síndrome de Rett';
    SELECT "Id" INTO v_Surdez  FROM "Deficiencia" WHERE "Nome" = 'Surdez';
    SELECT "Id" INTO v_Surdocegueira FROM "Deficiencia" WHERE "Nome" = 'Surdocegueira';
    SELECT "Id" INTO v_TranstornoDesintegrativoInfancia  FROM "Deficiencia" WHERE "Nome" = 'Transtorno Desintegrativo da Infância';
    SELECT "Id" INTO v_TDAH  FROM "Deficiencia" WHERE "Nome" = 'Transtorno de Déficit de Atenção e Hiperatividade (TDAH)';
    SELECT "Id" INTO v_SindromeGenetica  FROM "Deficiencia" WHERE "Nome" = 'Síndrome genética (Down, Turner, entre outras)';
    SELECT "Id" INTO v_TranstornoAprendizagem  FROM "Deficiencia" WHERE "Nome" = 'Transtorno de Aprendizagem (Dislexia, discalculia, disortografia)';
    SELECT "Id" INTO v_DoencaDegenerativa  FROM "Deficiencia" WHERE "Nome" = 'Doença degenerativa (ELA, esclerose múltipla, Parkison, Alzheimer)';
    SELECT "Id" INTO v_DPAC FROM "Deficiencia" WHERE "Nome" = 'Déficit do Processamento Auditivo Central (DPAC)';
    SELECT "Id" INTO v_SequelasAVC  FROM "Deficiencia" WHERE "Nome" = 'Sequelas de doenças cerebrovasculares AVC.';
    SELECT "Id" INTO v_Lactante FROM "Deficiencia" WHERE "Nome" = 'Lactante';
    SELECT "Id" INTO v_Adventista  FROM "Deficiencia" WHERE "Nome" = 'Adventista';

	-- Definição das variáveis para Acessibilidades
	SELECT "Id" INTO v_Amamentacao FROM "Acessibilidade" WHERE "Nome" = 'Autorização para amamentação';
	SELECT "Id" INTO v_AparelhoAuditivo  FROM "Acessibilidade" WHERE "Nome" = 'Autorização para usar aparelho auditivo';
	SELECT "Id" INTO v_Calculadora  FROM "Acessibilidade" WHERE "Nome" = 'Autorização para usar calculadora';
	SELECT "Id" INTO v_ProvaAdaptada  FROM "Acessibilidade" WHERE "Nome" = 'Horário de prova adaptado (para provas às sextas e aos sábados)';
	SELECT "Id" INTO v_InterpreteLibras  FROM "Acessibilidade" WHERE "Nome" = 'Intérprete de libras';
	SELECT "Id" INTO v_Ledor FROM "Acessibilidade" WHERE "Nome" = 'Ledor';
	SELECT "Id" INTO v_MobiliarioAcessivel  FROM "Acessibilidade" WHERE "Nome" = 'Mobiliário adaptado';
	SELECT "Id" INTO v_ProvaAmpliada  FROM "Acessibilidade" WHERE "Nome" = 'Prova ampliada';
	SELECT "Id" INTO v_ProvaNormal  FROM "Acessibilidade" WHERE "Nome" = 'Prova normal';
	SELECT "Id" INTO v_SalaFacilAcesso  FROM "Acessibilidade" WHERE "Nome" = 'Sala com acessibilidade';
	SELECT "Id" INTO v_SalaEspecial  FROM "Acessibilidade" WHERE "Nome" = 'Sala especial';
	SELECT "Id" INTO v_HoraAdicional FROM "Acessibilidade" WHERE "Nome" = 'Tempo adicional (60min)';
	SELECT "Id" INTO v_AuxilioTranscricao FROM "Acessibilidade" WHERE "Nome" = 'Transcritor';
	
	-- Inserindo mapeamento de deficiencies e acessibilidades
	INSERT INTO "DeficienciaAcessibilidade" ("DeficienciaId", "AcessibilidadeId")
	VALUES 
	(v_Cegueira, v_Ledor), 
	(v_Cegueira, v_AuxilioTranscricao), 
	(v_DeficienciaFisica, v_MobiliarioAcessivel), 
	(v_DeficienciaFisica, v_SalaFacilAcesso), 
	(v_NaoPortadorNecessidadesEspeciais,  v_ProvaNormal), 
	(v_DeficienciaAuditiva,  v_InterpreteLibras),
	(v_DeficienciaAuditiva, v_AparelhoAuditivo), 
	(v_AltasHabilidades,  v_ProvaNormal),
	(v_BaixaVisao,  v_ProvaAmpliada), 
	(v_TEA, v_SalaEspecial),
	(v_TEA, v_HoraAdicional),
	(v_DeficienciaIntelectualMental, v_SalaEspecial),
	(v_DeficienciaIntelectualMental, v_HoraAdicional), 
	(v_DeficienciaMultipla, v_SalaEspecial),
	(v_DeficienciaMultipla, v_SalaFacilAcesso),
	(v_DeficienciaMultipla,  v_InterpreteLibras),
	(v_DeficienciaMultipla, v_AparelhoAuditivo),
	(v_DeficienciaMultipla, v_Ledor), 
	(v_DeficienciaMultipla,  v_ProvaAmpliada), 
	(v_DeficienciaMultipla, v_AuxilioTranscricao),
	(v_DeficienciaMultipla, v_HoraAdicional), 
	(v_SindromeAsperger, v_SalaEspecial), 
	(v_SindromeAsperger, v_HoraAdicional), 
	(v_SindromeRett, v_SalaEspecial),
	(v_SindromeRett, v_HoraAdicional), 
	(v_Surdez,  v_InterpreteLibras),  
	(v_Surdocegueira,  v_InterpreteLibras), 
	(v_Surdocegueira, v_Ledor), 
	(v_Surdocegueira, v_AuxilioTranscricao), 
	(v_TranstornoDesintegrativoInfancia, v_SalaEspecial), 
	(v_TranstornoDesintegrativoInfancia, v_HoraAdicional), 
	(v_TDAH, v_HoraAdicional),  
	(v_TDAH, v_SalaEspecial), 
	(v_SindromeGenetica, v_HoraAdicional), 
	(v_TranstornoAprendizagem, v_HoraAdicional), 
	(v_TranstornoAprendizagem, v_SalaEspecial),
	(v_TranstornoAprendizagem, v_Calculadora),
	(v_DoencaDegenerativa, v_HoraAdicional), 
	(v_DoencaDegenerativa, v_SalaFacilAcesso), 
	(v_DoencaDegenerativa, v_Ledor), 
	(v_DoencaDegenerativa, v_AuxilioTranscricao),
	(v_DPAC,  v_InterpreteLibras), 
	(v_DPAC, v_AparelhoAuditivo), 
	(v_SequelasAVC, v_HoraAdicional), 
	(v_SequelasAVC, v_Ledor),  
	(v_SequelasAVC, v_AuxilioTranscricao),
	(v_Lactante, v_Amamentacao),
	(v_Adventista, v_ProvaAdaptada); 
END
$$;
