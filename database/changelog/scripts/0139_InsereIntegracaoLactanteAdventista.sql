DO
$$
DECLARE 
	v_codigoVestib INT;
    v_Lactante INT;
    v_Adventista INT;

begin
	
	SELECT "Id" INTO v_codigoVestib FROM "SistemaIntegracao" WHERE "Nome" = 'Vestib';
    SELECT "Id" INTO v_Lactante FROM "Deficiencia" WHERE "Nome" = 'Lactante';
    SELECT "Id" INTO v_Adventista FROM "Deficiencia" WHERE "Nome" = 'Adventista';

	INSERT INTO "IntegracaoDeficiencia"  ("IntegracaoSistemaId", "CodigoOrigem", "DeficienciaId")
	VALUES
	    (v_codigoVestib, 25, v_Lactante),
	    (v_codigoVestib, 26, v_Adventista);
END
$$;