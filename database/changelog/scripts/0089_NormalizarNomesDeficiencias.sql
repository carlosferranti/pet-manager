DO
$$
DECLARE 

    -- Variáveis de Deficiencias
    v_NaoPortadorNecessidadesEspeciais INT;
    v_AltasHabilidades INT;
    v_TEA INT;  
    v_DeficienciaIntelectualMental INT;
    v_SindromeGenetica INT;
    v_TranstornoAprendizagem INT;
    v_DoencaDegenerativaELA INT;
    v_SequelasAVC INT;


BEGIN
    -- Definição das variáveis para Deficiências
    SELECT "Id" INTO v_NaoPortadorNecessidadesEspeciais FROM "Deficiencia" WHERE "Nome" = 'Não portador de necessidades especiais';
    SELECT "Id" INTO v_AltasHabilidades FROM "Deficiencia" WHERE "Nome" = 'Altas habilidades / Superdotação';
    SELECT "Id" INTO v_TEA FROM "Deficiencia" WHERE "Nome" = 'Transtorno do Espectro Autista - TEA';
    SELECT "Id" INTO v_DeficienciaIntelectualMental FROM "Deficiencia" WHERE "Nome" = 'Deficiência Intelectual/Mental';
    SELECT "Id" INTO v_SindromeGenetica FROM "Deficiencia" WHERE "Nome" = 'Síndrome genética (Down, Turner, entre outras)';
    SELECT "Id" INTO v_TranstornoAprendizagem FROM "Deficiencia" WHERE "Nome" = 'Transtorno de Aprendizagem (Dislexia, discalculia, disortografia)';
    SELECT "Id" INTO v_DoencaDegenerativaELA FROM "Deficiencia" WHERE "Nome" = 'Doença degenerativa (ELA, esclerose múltipla, Parkison, Alzheimer)';
    SELECT "Id" INTO v_SequelasAVC FROM "Deficiencia" WHERE "Nome" = 'Sequelas de doenças cerebrovasculares AVC.';

    UPDATE "Deficiencia" SET "Nome" = 'Não Portador de Necessidades Especiais' WHERE "Id" = v_NaoPortadorNecessidadesEspeciais;
    UPDATE "Deficiencia" SET "Nome" = 'Altas Habilidades/Superdotação' WHERE "Id" = v_AltasHabilidades;
    UPDATE "Deficiencia" SET "Nome" = 'Transtorno do Espectro Autista (TEA)' WHERE "Id" = v_TEA;
    UPDATE "Deficiencia" SET "Nome" = 'Deficiência Intelectual/Mental' WHERE "Id" = v_DeficienciaIntelectualMental;
    UPDATE "Deficiencia" SET "Nome" = 'Síndrome Genética (Down, Turner, entre outras)' WHERE "Id" = v_SindromeGenetica;
    UPDATE "Deficiencia" SET "Nome" = 'Transtorno de Aprendizagem (Dislexia, Discalculia, Disortografia)' WHERE "Id" = v_TranstornoAprendizagem;
    UPDATE "Deficiencia" SET "Nome" = 'Doença Degenerativa (ELA, Esclerose Múltipla, Parkinson, Alzheimer)' WHERE "Id" = v_DoencaDegenerativaELA;
    UPDATE "Deficiencia" SET "Nome" = 'Sequelas de Doenças Cerebrovasculares (AVC)' WHERE "Id" = v_SequelasAVC;

END
$$;


