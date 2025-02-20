DO
$$
DECLARE 
	
	v_codigoVestib INT;

    v_ProvaNormal INT;
    v_AutorizacaoAmamentacao INT;
    v_AutorizacaoAparelhoAuditivo INT;
    v_AutorizacaoCalculadora INT;
    v_HorarioProvaAdaptado INT;
    v_InterpreteLibras INT;
    v_Ledor INT;
    v_MobiliarioAdaptado INT;
    v_ProvaAmpliada INT;
    v_SalaComAcessibilidade INT;
    v_SalaEspecial INT;
    v_TempoAdicional INT;
    v_Transcritor INT;
begin
	
	SELECT "Id" INTO v_codigoVestib FROM "SistemaIntegracao" WHERE "Nome" = 'Vestib';
	
    SELECT "Id" INTO v_ProvaNormal FROM "Acessibilidade" WHERE "Nome" = 'Prova normal';
    SELECT "Id" INTO v_AutorizacaoAmamentacao FROM "Acessibilidade" WHERE "Nome" = 'Autorização para amamentação';
    SELECT "Id" INTO v_AutorizacaoAparelhoAuditivo FROM "Acessibilidade" WHERE "Nome" = 'Autorização para usar aparelho auditivo';
    SELECT "Id" INTO v_AutorizacaoCalculadora FROM "Acessibilidade" WHERE "Nome" = 'Autorização para usar calculadora';
    SELECT "Id" INTO v_HorarioProvaAdaptado FROM "Acessibilidade" WHERE "Nome" = 'Horário de prova adaptado (para provas às sextas e aos sábados)';
    SELECT "Id" INTO v_InterpreteLibras FROM "Acessibilidade" WHERE "Nome" = 'Intérprete de libras';
    SELECT "Id" INTO v_Ledor FROM "Acessibilidade" WHERE "Nome" = 'Ledor';
    SELECT "Id" INTO v_MobiliarioAdaptado FROM "Acessibilidade" WHERE "Nome" = 'Mobiliário adaptado';
    SELECT "Id" INTO v_ProvaAmpliada FROM "Acessibilidade" WHERE "Nome" = 'Prova ampliada';
    SELECT "Id" INTO v_SalaComAcessibilidade FROM "Acessibilidade" WHERE "Nome" = 'Sala com acessibilidade';
    SELECT "Id" INTO v_SalaEspecial FROM "Acessibilidade" WHERE "Nome" = 'Sala especial';
    SELECT "Id" INTO v_TempoAdicional FROM "Acessibilidade" WHERE "Nome" = 'Tempo adicional (60min)';
    SELECT "Id" INTO v_Transcritor FROM "Acessibilidade" WHERE "Nome" = 'Transcritor';

	INSERT INTO "IntegracaoAcessibilidade" ("Id", "IntegracaoSistemaId", "CodigoOrigem", "AcessibilidadeId")
	VALUES
	    (1, v_codigoVestib, 2, v_ProvaNormal),
	    (2, v_codigoVestib, 12, v_AutorizacaoAmamentacao),
	    (3, v_codigoVestib, 13, v_AutorizacaoAparelhoAuditivo),
	    (4, v_codigoVestib, 14, v_AutorizacaoCalculadora),
	    (5, v_codigoVestib, 15, v_HorarioProvaAdaptado),
	    (6, v_codigoVestib, 1, v_InterpreteLibras),
	    (7, v_codigoVestib, 16, v_Ledor),
	    (8, v_codigoVestib, 17, v_MobiliarioAdaptado),
	    (9, v_codigoVestib, 3, v_ProvaAmpliada),
	    (10, v_codigoVestib, 18, v_SalaComAcessibilidade),
	    (11, v_codigoVestib, 10, v_SalaEspecial),
	    (12, v_codigoVestib, 19, v_TempoAdicional),
	    (13, v_codigoVestib, 20, v_Transcritor);

END
$$;
