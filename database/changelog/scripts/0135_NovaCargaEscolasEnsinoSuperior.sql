INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DE MATO GROSSO', 1, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DE SERGIPE', 3, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '100',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DO AMAZONAS', 4, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '102',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DO PIAUÍ', 5, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1153',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DE OURO PRETO', 6, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '125',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE ESTADUAL DE LONDRINA', 9, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '979',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('PONTIFÍCIA UNIVERSIDADE CATÓLICA DO PARANÁ', 10, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '126',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DO RIO GRANDE', 12, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1557',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE DE CAXIAS DO SUL', 13, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '215',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE CATÓLICA DE PELOTAS', 18, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '225',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE ESTADUAL DE SANTA CRUZ', 24, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '523',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA NACIONAL DE CIÊNCIAS ESTATÍSTICAS', 26, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '450',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE VALE DO RIO VERDE', 27, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '530',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE ESTADUAL DO CEARÁ', 29, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '531',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE JOSÉ DO ROSÁRIO VELLANO', 30, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '573',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE ESTADUAL DE CIÊNCIAS DA SAÚDE DE ALAGOAS - UNCISAL', 32, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2407',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE SOROCABA', 33, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '891',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE AMERICANA', 35, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '526',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA RUBENS LARA', 36, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '748',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE JAHU', 37, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '785',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE DO ESTADO DO PARÁ', 38, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '906',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE ESTADUAL DE GOIÁS', 47, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '583',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE DIREITO DE SÃO BERNARDO DO CAMPO', 58, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '663',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA DE ENGENHARIA DE PIRACICABA', 67, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '736',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE FILOSOFIA CIÊNCIAS E LETRAS DE PENÁPOLIS', 68, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1051',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE DO ESTADO DO RIO GRANDE DO NORTE', 71, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1053',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE FORMAÇÃO DE PROFESSORES DA MATA SUL', 72, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2321',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO DE ENSINO SUPERIOR DE ARCOVERDE', 73, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1060',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE FILOSOFIA CIÊNCIAS E LETRAS DE SÃO JOSÉ DO RIO PARDO', 74, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1566',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE REGIONAL DE BLUMENAU', 76, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1068',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DA REGIÃO DOS LAGOS', 77, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1076',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE FILOSOFIA CIÊNCIAS E LETRAS DE ALEGRE', 78, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1077',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO MUNICIPAL DE ENSINO SUPERIOR DE CATANDUVA', 79, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '781',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO PARA O DESENVOLVIMENTO DO ALTO VALE DO ITAJAÍ', 80, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2292',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE FILOSOFIA CIÊNCIAS E LETRAS DE MACAÉ', 84, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1093',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DE BRUSQUE', 87, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1102',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE MEDICINA DE JUNDIAÍ', 93, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '818',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR DE EDUCAÇÃO FÍSICA DE JUNDIAÍ', 94, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '817',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DE SÃO JOÃO DEL REI', 107, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1120',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS RUI BARBOSA', 109, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '615',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO NACIONAL DE TELECOMUNICAÇÕES', 126, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1161',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO FÍSICA DE BARRA BONITA', 131, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1164',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO CLARETIANO', 135, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1948',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE DO SAGRADO CORAÇÃO', 137, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '873',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO BARÃO DE MAUÁ', 138, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '604',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS ECONÔMICAS DO TRIÂNGULO MINEIRO', 139, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1181',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE DIREITO DE VARGINHA - FADIVA', 141, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1172',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DO TRIÂNGULO', 142, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1343',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS HUMANAS DE OLINDA', 144, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1184',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DE RIO PRETO', 146, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '648',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE MEDICINA DE SÃO JOSÉ DO RIO PRETO', 149, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '642',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE DE SOROCABA', 150, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '892',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA DE ADMINISTRAÇÃO DE EMPRESAS DE SÃO PAULO', 151, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '301',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE FILOSOFIA CIÊNCIAS E LETRAS DE CARUARU', 159, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1210',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE VEIGA DE ALMEIDA', 165, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '458',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FAI - CENTRO DE ENSINO SUPERIOR EM GESTÃO, TECNOLOGIA E EDUCAÇÃO', 166, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1162',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES DA FUNDAÇÃO DE ENSINO DE MOCOCA', 170, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '730',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS CONTÁBEIS E DE ADMINISTRAÇÃO DE EMPRESAS', 191, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '462',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE FILOSOFIA CIÊNCIAS E LETRAS SOUZA MARQUES', 192, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '464',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ENGENHARIA SOUZA MARQUES', 193, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '461',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA DE ENFERMAGEM DA FUNDAÇÃO TÉCNICO EDUCACIONAL SOUZA MARQUES', 194, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '463',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO SUPERIOR DO PARANÁ', 197, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '127',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO ÍTALO-BRASILEIRO', 206, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '307',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE DE RIBEIRÃO PRETO', 208, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '606',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO FECAP', 213, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '19618',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ENGENHARIA DE MINAS GERAIS - FEAMIG', 214, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2435',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO METODISTA IZABELA HENDRIX', 216, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2436',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DAS FACULDADES ASSOCIADAS DE ENSINO - FAE', 217, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1334',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO CIÊNCIAS E ARTES DOM BOSCO DE MONTE APRAZÍVEL', 219, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1336',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DE VOTUPORANGA', 222, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1331',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE MEDICINA DO ABC', 224, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '803',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO LUSÍADA', 226, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '749',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE SÃO BERNARDO DO CAMPO - FASB', 231, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '666',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE SANTA ÚRSULA', 240, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '468',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO ANHANGUERA', 242, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '20779',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ENGENHARIA E AGRIMENSURA DE PIRASSUNUNGA - FEAP', 255, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1356',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DE OURINHOS', 265, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '734',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE METODISTA DE PIRACICABA', 266, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '737',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE FACCAT', 269, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1200',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE DO OESTE PAULISTA', 271, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '696',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE DO VALE DO PARAÍBA', 275, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '628',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE DIREITO DE SOROCABA', 276, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '893',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS SIMONSEN', 278, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '470',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS HÉLIO ALONSO', 279, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '471',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE MEDICINA DE ITAJUBÁ', 284, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1034',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE DIREITO DO VALE DO RIO DOCE', 288, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1377',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE TRÊS DE MAIO', 294, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2279',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE JANDAIA DO SUL', 299, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1385',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE MEDICINA DE BARBACENA', 307, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1432',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE DESENHO DE TATUÍ', 321, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '842',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE IGUAÇU', 330, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1465',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MACHADO SOBRINHO', 336, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2380',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO DE ENSINO SUPERIOR DE JUIZ DE FORA', null,null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2381',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Pontifícia Universidade Católica de Minas Gerais', null,null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '3878',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO NEWTON PAIVA', 343, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2440',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA DE ENGENHARIA KENNEDY', 345, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2441',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE CIÊNCIAS APLICADAS - ISCA', 346, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1476',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE EVANGÉLICA DO PARANÁ', 353, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '128',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE TUIUTI DO PARANÁ', 355, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '129',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO PAULISTANO', 360, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '314',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Paulista de Serviço Social de São Caetano do Sul', 361, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '864',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PAULISTA DE SERVIÇO SOCIAL', 362, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '431',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE ESTADUAL DE MONTES CLAROS', 367, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1510',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO FÍSICA DA ASSOCIAÇÃO CRISTÃ DE MOÇOS DE SOROCABA', 368, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '894',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE MÚSICA CARLOS GOMES', 371, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '429',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE BIBLIOTECONOMIA E CIÊNCIA DA INFORMAÇÃO', 372, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '317',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA DE SOCIOLOGIA E POLÍTICA DE SÃO PAULO', 373, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '316',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE DA AMAZÔNIA', 383, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '907',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE SALVADOR', 385, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '933',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DE GOIÁS', 386, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1229',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA DE ENGENHARIA DE AGRIMENSURA', 399, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '935',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DE BRASÍLIA', 402, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '35',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DA UPIS', 404, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '38',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FOCCA - FACULDADE DE OLINDA', 405, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1186',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS HUMANAS ESUDA', 410, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '186',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS MÉDICAS DA SANTA CASA SÃO PAULO', 415, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '319',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Universidade Cidade de São Paulo ', 417, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '7418',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO FILADÉLFIA', 430, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '980',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE MEDICINA DE MARÍLIA', 431, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '598',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PARANAENSE', 432, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '12',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PARANAENSE', 432, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1523',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE FILOSOFIA CIÊNCIAS E LETRAS DE ITUVERAVA', 438, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2390',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DOUTOR FRANCISCO MAEDA', 439, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2389',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE DIREITO DE ITÚ', 440, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '870',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE DE CRUZ ALTA', 446, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1568',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO LUTERANO DE JI-PARANÁ', 450, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1937',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO LUTERANO DE MANAUS', 452, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '40',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO LUTERANO DE PALMAS', 453, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1546',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CAMAQÜENSE DE CIÊNCIAS CONTÁBEIS E ADMINISTRATIVAS', 454, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1576',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE ANHANGUERA DE SÃO PAULO - UNIAN-SP', 457, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '6258',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE IBIRAPUERA', 458, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '323',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ADMINISTRAÇÃO DA FUNDAÇÃO ARMANDO ALVARES PENTEADO', 461, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '11158',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE DO GRANDE RIO PROFESSOR JOSÉ DE SOUZA HERDY', 472, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1583',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS ECONÔMICAS, ADMINISTRATIVAS E DA COMPUTAÇÃO DOM BOSCO', 473, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1579',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE FILOSOFIA CIÊNCIAS E LETRAS DOM BOSCO', 474, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1578',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE MEDICINA DE PETRÓPOLIS', 475, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1587',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO SERRA DOS ÓRGÃOS', 480, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1159',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE DO EXTREMO SUL CATARINENSE', 482, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1594',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DE VOLTA REDONDA', 489, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1327',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO DE ENSINO SUPERIOR DE VALENÇA', 490, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1604',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO CIÊNCIAS E LETRAS DON DOMÊNICO', 491, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1622',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ADMINISTRAÇÃO CIÊNCIAS ECON E CONTÁBEIS DE GUARATINGUETÁ', 492, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '890',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO DE GUARATINGUETÁ', 493, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '889',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR DE CIÊNCIAS DA SANTA CASA DE MISERICÓRDIA DE VITÓRIA', 501, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1284',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE MEDICINA DE CAMPOS', 506, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2527',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE TRIÂNGULO MINEIRO', 507, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1635',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS SOCIAIS APLICADAS DO SUL DE MINAS - FACESM', 508, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1031',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE VALE DO RIO DOCE', 513, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1379',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DE BARRA MANSA', 514, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1639',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO SÃO LUÍS', 517, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '800',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DO DISTRITO FEDERAL', 518, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '39',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE CATÓLICA DO SALVADOR', 519, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '936',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO CELSO LISBOA', 522, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '473',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('PONTIFÍCIA UNIVERSIDADE CATÓLICA DO RIO DE JANEIRO', 528, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '474',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE MÚSICA DO ESPÍRITO SANTO', 530, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1285',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE REGIONAL DO NOROESTE DO ESTADO DO RIO GRANDE DO SUL', 532, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2316',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DE ITAPETININGA', 533, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '617',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA BAHIANA DE MEDICINA E SAÚDE PÚBLICA', 534, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '937',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DE MANDAGUARI - UNIMAN', 535, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1649',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS HUMANAS DE ITABIRA', 544, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1942',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS ADMINISTRATIVAS E CONTÁBEIS DE ITABIRA', 545, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1941',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Pontifícia Universidade Católica de São Paulo', null,null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '12878',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE DO ESTADO DO RIO DE JANEIRO', 547, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '475',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DO MARANHÃO', 548, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1674',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DO ACRE', 549, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2363',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE FILOSOFIA, CIÊNCIAS E LETRAS DE BOA ESPERANÇA', 554, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2485',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE DE FORTALEZA', 555, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '532',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE ESTADUAL DO MARANHÃO', 568, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1661',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DO PARÁ', 569, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '923',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DO PARANÁ', 571, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '174',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DO ESPÍRITO SANTO', 573, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1301',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL RURAL DO RIO DE JANEIRO', 574, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2197',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DE JUIZ DE FORA', 576, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2388',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DE ALAGOAS', 577, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2422',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DA BAHIA', 578, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '968',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DA PARAÍBA', 579, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1503',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DO RIO GRANDE DO SUL', 581, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '280',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DE SANTA MARIA', 582, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1474',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DO CEARÁ', 583, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '560',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL RURAL DE PERNAMBUCO', 587, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '207',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL RURAL DO SEMI-ÁRIDO', 589, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1058',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL RURAL DA AMAZÔNIA', 590, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '926',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DE LAVRAS', 592, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1885',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO FEDERAL DE EDUCAÇÃO TECNOLÓGICA CELSO SUCKOW DA FONSECA', 593, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '517',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DE ALFENAS', 595, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '574',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DOS VALES DO JEQUITINHONHA E MUCURI', 596, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2097',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DO TRIÂNGULO MINEIRO', 597, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1183',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DE ITAJUBÁ - UNIFEI', 598, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1033',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE MUNICIPAL DE SÃO CAETANO DO SUL', 605, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '862',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE DIREITO DE CACHOEIRO DO ITAPEMIRIM', 606, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1686',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS CONTÁBEIS E ADMINISTRATIVAS DE CACHOEIRO DO ITAPEMIRIM', 607, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1687',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE FILOSOFIA CIÊNCIAS E LETRAS PROFESSORA NAIR FORTES ABU-MERHY', 615, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1393',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS SILVA E SOUZA', 622, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '477',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CENECISTA DE CAPIVARI', 625, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1699',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO MILITAR DE ENGENHARIA', 633, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '519',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DE PELOTAS', 634, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '226',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR DE PROPAGANDA E MARKETING', 636, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '327',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE DIREITO MILTON CAMPOS', 638, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2493',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS MARIA THEREZA', 640, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1725',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Centro Universitário - Católica de Santa Catarina em Jaraguá do Sul', 645, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2496',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES ASSOCIADAS DE UBERABA - FAZU', 648, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1178',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DE UNIÃO DA VITÓRIA', 649, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1208',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SANTA CECÍLIA', 652, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '654',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE FORMAÇÃO DE PROFESSORES DE SERRA TALHADA', 657, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1732',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PIO DÉCIMO', 661, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1359',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE DE TAUBATÉ', 665, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2347',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE ESTADUAL DE FEIRA DE SANTANA', 666, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1740',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DE JACAREPAGUÁ', 667, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '480',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DE ENSINO SUPERIOR DO AMAZONAS', 668, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '104',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE NILTON LINS', 669, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '105',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE ANHANGUERA - UNIDERP', 671, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '8718',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO DE ENSINO SUPERIOR DO VALE SÃO FRANCISCO', 674, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2234',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE REABILITAÇÃO DA ASCE', 677, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '481',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO NOROESTE DE MINAS', 682, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1762',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS APLICADAS DE LIMOEIRO', 686, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1768',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE ESTADUAL DO SUDOESTE DA BAHIA', 688, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1319',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DO ESTADO DO RIO DE JANEIRO', 693, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '482',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS DA ADMINISTRAÇÃO DE GARANHUNS', 701, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1772',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE FORMAÇÃO DE PROFESSORES DE ARARIPINA', 703, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2233',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS AGRÁRIAS DE ARARIPINA', 704, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2232',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SÃO JOSÉ', 705, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '483',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ARTES DULCINA DE MORAES', 706, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '42',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO CENTRAL PAULISTA', 707, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '692',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FAE CENTRO UNIVERSITÁRIO', 715, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '743',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DE BOTUCATU', 716, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '621',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FUNDAÇÃO UNIVERSIDADE FEDERAL DE CIÊNCIAS DA SAÚDE DE PORTO ALEGRE', 717, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '275',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE DO ESTADO DE MATO GROSSO', 719, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2506',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS HUMANAS E SOCIAIS APLICADAS DO CABO DE SANTO AGOSTINHO', 720, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2502',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO DE ASSIS', 721, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '720',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA DE EDUCAÇÃO FÍSICA DE ASSIS', 722, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '719',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ADMINISTRAÇÃO DE ASSIS', 723, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '718',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PITÁGORAS DE LINHARES', 736, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2003',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO SÃO CAMILO', 737, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '330',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO SÃO CAMILO - ESPÍRITO SANTO', 739, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1688',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO MUNICIPAL DE ENSINO SUPERIOR DE SÃO MANUEL', 745, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '868',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO UNIRG', 750, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1824',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE PARÁ DE MINAS', 752, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1781',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS HUMANAS DO SERTÃO CENTRAL', 753, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1825',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO DE ENSINO SUPERIOR DE CATALÃO', 754, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1826',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE ESTADUAL DO PIAUÍ', 756, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1131',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS HUMANAS DE PERNAMBUCO', 760, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '187',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES SPEI', 761, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '133',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO UNIFICADO DE ENSINO SUPERIOR OBJETIVO', 763, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1231',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PINHEIRO GUIMARÃES', 764, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '486',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia de Jacareí', 778, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '824',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE JACAREÍ', 778, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '825',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE PONTA PORÃ', 779, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1738',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGUERA DE RONDONÓPOLIS', 781, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2429',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO DE TANGARÁ DA SERRA', 785, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '879',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE RONDÔNIA', 788, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1617',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DE RORAIMA', 789, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1854',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DO ESTADO DO PARÁ', 792, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '909',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DE VÁRZEA GRANDE', 794, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1278',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DE DIAMANTINO', 795, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1878',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS SOCIAIS APLICADAS DO VALE DO SÃO LOURENÇO', 796, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2218',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade AVEC de Vilhena', 797, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1313',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DE ARACRUZ', 798, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1372',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MONTENEGRO', 801, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2237',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE DIREITO E CIÊNCIAS SOCIAIS DO LESTE DE MINAS - FADILESTE', 809, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1879',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO TÉCNICO-EDUCACIONAL SUPERIOR DO OESTE PARANAENSE', 810, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2269',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE FILOSOFIA E CIÊNCIAS HUMANAS DE GOIATUBA', 824, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1881',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PRESBITERIANA GAMMON', 825, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1882',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE SÃO LOURENÇO', 828, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '858',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE DO TOCANTINS', 829, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1548',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DO AMAPÁ', 830, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1836',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS HUMANAS DO VALE DO RIO GRANDE', 831, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1752',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ARQUIDIOCESANA DE CURVELO', 832, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1888',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS TECNOLÓGICAS DE FORTALEZA', 838, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '534',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE VITORIANA DE CIÊNCIAS CONTÁBEIS', 839, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1286',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE VITORIANA DE TECNOLOGIA', 840, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1287',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS E TECNOLOGIA DE BIRIGUI', 843, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2515',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DA FUNDAÇÃO EDUCACIONAL ARAÇATUBA', 845, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '797',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ADMINISTRAÇÃO DE TERESINA', 846, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1132',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PIAUIENSE DE PROCESSAMENTO DE DADOS', 847, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1133',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PARAIBANA DE PROCESSAMENTO DE DADOS', 848, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1484',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE JESUÍTA DE FILOSOFIA E TEOLOGIA', 849, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2444',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO DE ENSINO SUPERIOR DO AMAPÁ', 861, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1837',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES UNIFICADAS DE FOZ DO IGUAÇU', 873, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1892',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ECONOMIA E PROCESSAMENTO DE DADOS DE FOZ DO IGUAÇU', 877, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1894',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DO LESTE DE MINAS GERAIS', 878, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1540',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO MUNICIPAL DE ENSINO SUPERIOR DE ASSIS', 881, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '717',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO MUNICIPAL DE ENSINO SUPERIOR DE BEBEDOURO VICTÓRIO CARDASSI', 882, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '689',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE HORTOLÂNDIA', 886, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2396',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA DE GOVERNO PROFESSOR PAULO NEVES DE CARVALHO', 890, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2445',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS ADMINISTRATIVAS E DE TECNOLOGIA', 900, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1606',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ALAGOANA DE ADMINISTRAÇÃO', 908, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2413',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DE PARANAÍBA - FIPAR', 913, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1803',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ADMINISTRAÇÃO DE FÁTIMA DO SUL', 915, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1908',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE REGES DE DRACENA', 922, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1628',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ADMINISTRAÇÃO E CIÊNCIAS CONTÁBEIS DE SÃO ROQUE', 923, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '712',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO ANHANGUERA DE CAMPO GRANDE', 926, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1276',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CATÓLICA DE ANÁPOLIS', 939, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '586',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdades Magsul', 940, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1737',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR DE PROPAGANDA E MARKETING DO RIO DE JANEIRO', 944, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '479',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE CIÊNCIAS SOCIAIS E HUMANAS', 945, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1225',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE METROPOLITANA DE SANTOS', 953, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '753',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE TAQUARITINGA', 967, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '767',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DE PONTA PORÃ', 976, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1736',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR EM MEIO AMBIENTE', 989, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1916',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SENAI-CETIQT', 991, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '488',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Duque de Caxias', 994, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1585',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR E CENTRO EDUCACIONAL LUTERANO - BOM JESUS - IELUSC', 1014, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1082',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS E TECNOLOGIA DE UNAÍ - FACTU', 1019, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1206',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS DE TIMBAÚBA', 1021, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1922',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Ciências de Timbaúba', 1021, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1923',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE ESTADUAL DO NORTE FLUMINENSE DARCY RIBEIRO', 1027, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2534',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE ESTADUAL DE MATO GROSSO DO SUL', 1028, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1755',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DE TRÊS LAGOAS', 1038, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2501',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE POSITIVO', 1042, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '131',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO HERMINIO OMETTO', 1043, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '581',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIÃO DAS FACULDADES DOS GRANDES LAGOS', 1046, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '645',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR FUCAPI', 1049, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '107',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DA SEUNE', 1051, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2414',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA E CIÊNCIAS DE FEIRA DE SANTANA', 1053, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1743',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Estácio FIB - Centro Universitário Estácio da Bahia', 1058, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '939',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE LOURENÇO FILHO', 1059, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '562',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DO INSTITUTO DE EDUCAÇÃO SUPERIOR DE BRASÍLIA - IESB', 1060, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '43',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Doctum de Vila Velha', 1063, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1217',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Doctum de Vitória', 1064, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1283',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO E PESQUISA OBJETIVO', 1066, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1547',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE JUSSARA', 1067, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2259',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ALDETE MARIA ALVES', 1068, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1926',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR DA FUNLEC', 1071, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1271',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE EDUCAÇÃO SUPERIOR DA PARAÍBA', 1075, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1927',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE FILOSOFIA, CIÊNCIAS E LETRAS DE CAJAZEIRAS', 1076, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1929',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ARTHUR SÁ EARP NETO', 1080, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1588',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO FEDERAL DE EDUCAÇÃO, CIÊNCIA E TECNOLOGIA DO RIO GRANDE DO NORTE', 1082, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1796',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CENECISTA DE BENTO GONÇALVES', 1084, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1695',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE METODISTA DE SANTA MARIA', 1085, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1469',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS APARÍCIO CARVALHO', 1087, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1607',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SÃO LUÍS DE FRANÇA', 1090, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1362',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DE BAURU', 1092, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '875',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE PRESIDENTE EPITÁCIO - FAPE', 1096, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1559',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CARLOS DRUMMOND DE ANDRADE', 1100, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '52398',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Centro Universitário Estácio do Ceará', 1107, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '533',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO EURO-AMERICANO', 1113, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '45',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SANTA TEREZINHA', 1115, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1663',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE REGES DE OSVALDO CRUZ', 1122, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1765',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE EDUCAÇÃO SUPERIOR UNYAHNA DE SALVADOR', 1123, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '940',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS ESPÍRITA', 1125, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '138',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE ESTADUAL DO CENTRO OESTE', 1126, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '975',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DO NORTE PAULISTA', 1129, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '643',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE METODISTA DE CIÊNCIAS HUMANAS E EXATAS', 1130, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2514',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS HUMANAS E SOCIAIS DE IGARASSU', 1136, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1949',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ESTUDOS ADMINISTRATIVOS DE MINAS GERAIS - FEAD-MG', 1139, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2446',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE GAMA E SOUZA', 1141, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '490',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS HUMANAS', 1144, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1905',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ADMINISTRAÇÃO E NEGÓCIOS DE SERGIPE', 1151, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1363',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SALESIANA DE SANTA TERESA', 1155, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1533',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR SÃO FRANCISCO DE ASSIS', 1157, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1508',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO DE ENSINO SUPERIOR DE VITÓRIA', 1159, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1291',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CAMBURY', 1160, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1232',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSPER INSTITUTO DE ENSINO E PESQUISA', 1161, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '377',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ALTA FLORESTA', 1162, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1418',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE METROPOLITANA DE CAMAÇARI', 1170, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1921',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGUERA DE BRASÍLIA', 1173, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '19',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE SABARÁ', 1174, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1437',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ESTÁCIO DO RIO GRANDE DO SUL - ESTÁCIO FARGS', 1175, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '260',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR DE AMERICANA', 1182, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '527',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO MÓDULO', 1187, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1849',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE DO PLANALTO CATARINENSE', 1189, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1600',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR DE FORTALEZA', 1191, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '535',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS DA SAÚDE DE SÃO PAULO', 1192, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '346',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE PONTA PORÃ', 1194, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1739',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SENAI DE TECNOLOGIA MECATRÔNICA', 1195, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '863',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DE MARINGÁ - UNICESUMAR', 1196, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1006',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS SOCIAIS E APLICADAS DO PARANÁ', 1198, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '139',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE EDUCACIONAL DA LAPA', 1205, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2301',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FAL ESTÁCIO - FACULDADE ESTÁCIO DE NATAL', 1208, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1788',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS CONTÁBEIS DE ASSIS', 1212, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '721',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE FLEMING', 1213, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '245',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO ITAPETININGANO DE ENSINO SUPERIOR', 1219, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '618',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE GAMMON', 1221, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1464',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DE JALES', 1224, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '779',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO AMPARENSE', 1225, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '575',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR DO ACRE', 1226, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2365',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SÃO FRANCISCO DE BARREIRAS - FASB', 1227, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1969',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO REGIONAL UNIVERSITÁRIO DE ESPÍRITO SANTO DO PINHAL', 1230, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1353',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO CAMPOS DE ANDRADE', 1232, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '132',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE METROPOLITANA', 1234, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1614',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE NOSSA SENHORA APARECIDA', 1237, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1973',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PADRÃO', 1239, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1233',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PADRÃO', 1239, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1975',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ESTUDOS SOCIAIS DO ESPÍRITO SANTO', 1240, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1979',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE BRASILEIRA', 1244, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1292',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS CONTÁBEIS DE NOVA ANDRADINA - FACINAN', 1247, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1995',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE PEDAGOGIA', 1248, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1993',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO DE COSTA RICA', 1249, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1997',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PROMOVE DE MINAS GERAIS', 1252, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2474',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE METODISTA GRANBERY', 1253, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2383',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ADMINISTRAÇÃO DE ITABIRITO', 1254, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1428',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Boa Viagem', 1255, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1502',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE BEZERRA DE ARAÚJO', 1263, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '491',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS URUBUPUNGÁ', 1266, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1352',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO TAUBATÉ DE ENSINO SUPERIOR', 1276, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2349',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ITÁPOLIS - FACITA', 1279, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1999',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Estácio Cotia', 1280, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '837',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SENAI DE TECNOLOGIA AMBIENTAL', 1286, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '668',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Álvares de Azevedo', 1290, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '380',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DAS AMÉRICAS', 1294, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '35141',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MORUMBI SUL', 1295, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '18360',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR DE MARKETING', 1296, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '189',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Estácio de Alagoas - Estácio FAL', 1298, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2411',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DE FERNANDÓPOLIS', 1299, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1806',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO TAQUARITINGUENSE DE ENSINO SUPERIOR DR. ARISTIDES DE CARVALHO SCHLOBACH', 1300, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '768',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO MATONENSE MUNICIPAL DE ENSINO SUPERIOR', 1301, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1919',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE BATISTA BRASILEIRA', 1302, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '943',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ENSINO SUPERIOR E FORMAÇÃO INTEGRAL', 1307, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '885',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE NOVO MILÊNIO', 1308, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1222',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE AMERICANA', 1310, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '529',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DE RONDONÓPOLIS', 1312, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2431',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE EDUVALE DE AVARÉ', 1322, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1045',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE APUCARANA', 1325, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1354',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CAPIXABA DA SERRA', 1326, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1040',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR DE PROPAGANDA E MARKETING DE PORTO ALEGRE', 1327, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '259',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE COMUNICAÇÃO E TURISMO DE OLINDA', 1328, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1187',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE COTEMIG', 1330, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2448',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CECAP DO LAGO NORTE', 1333, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '46',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MATER DEI', 1337, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1863',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE BORGES DE MENDONÇA', 1344, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1024',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE BATISTA DE MINAS GERAIS', 1346, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2449',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO VALE DO JAGUARIBE', 1350, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2017',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DE JAHU', 1355, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '786',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CAPIXABA DE NOVA VENÉCIA', 1359, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1904',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE UBAENSE OZANAM COELHO', 1362, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1340',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE VISCONDE DE CAIRÚ', 1363, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '931',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA E CIÊNCIAS DE VITÓRIA DA CONQUISTA', 1364, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1324',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE MIRANDÓPOLIS', 1371, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2191',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CASA BRANCA', 1373, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2036',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS SOCIAIS DE GUARANTÃ DO NORTE', 1374, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2020',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CATÓLICA RAINHA DA PAZ DE ARAPUTANGA', 1375, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '715',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS SÃO PEDRO', 1379, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1290',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdades EST', 1382, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '224',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE JOSÉ LACERDA FILHO DE CIÊNCIAS APLICADAS', 1383, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2221',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CASTRO ALVES', 1394, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '972',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CALDAS NOVAS', 1395, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2044',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ADELMAR ROSADO', 1401, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1139',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE PIMENTA BUENO', 1403, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1720',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE PIRACANJUBA', 1404, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1723',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO CENTRO LESTE', 1409, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1037',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DOIS DE JULHO', 1411, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '944',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE PRIMAVERA', 1413, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1526',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO TOLEDO', 1418, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '796',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DO NORTE', 1422, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '106',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE EVOLUTIVO', 1425, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '557',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO LUTERANO DE ENSINO SUPERIOR DE ITUMBIARA', 1426, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1571',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR PLANALTO', 1428, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '44',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE BATISTA DO RIO DE JANEIRO', 1429, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '495',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE BERTIOGA', 1432, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2157',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ORÍGENES LESSA', 1433, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1962',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR BATISTA DO AMAZONAS', 1436, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '109',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR DE TECNOLOGIA E EDUCAÇÃO DE RIO CLARO', 1437, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1541',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ADMINISTRAÇÃO DE EMPRESAS', 1438, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '237',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS ECONÔMICAS', 1439, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '236',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO APHONSIANO DE ENSINO SUPERIOR', 1440, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2270',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DO PIAUÍ', 1441, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1140',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE DIREITO DE TANGARÁ DA SERRA', 1442, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '883',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS EINSTEIN DE LIMEIRA', 1444, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1477',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO PLANALTO DO DISTRITO FEDERAL - UNIPLAN', 1446, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '3',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DO CERRADO-PATROCÍNIO', 1450, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1509',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO NORTE DO PARANÁ', 1453, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2510',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SALESIANA DO NORDESTE', 1454, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '191',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SANTÍSSIMO SACRAMENTO', 1455, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1262',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGUERA DE SERTÃOZINHO', 1456, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '772',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Estácio Euro- Panamericana de Humanidades e Tecnologias - Estácio EUROPAN', 1457, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '836',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia e Ciências', 1461, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '951',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA E CIÊNCIAS', 1461, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '950',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia e Ciências', 1461, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1868',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia e Ciências', 1461, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '424',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO PARAIBANO DE ENSINO RENOVADO', 1462, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1483',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE RIBEIRÃO PRETO', 1465, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '611',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MICHELANGELO', 1477, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '70',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE IBMEC', 1484, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2455',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ESTÁCIO DE SÁ DE VITÓRIA', 1486, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1281',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DOM BOSCO', 1487, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2399',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO INTERNACIONAL', 1491, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '146',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PITÁGORAS DE UBERLÂNDIA', 1492, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1349',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ESTÁCIO DE SÁ DE VILA VELHA', 1496, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1216',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ADMINISTRAÇÃO DE SANTA CRUZ DO RIO PARDO', 1497, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1427',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR E FORMAÇÃO AVANÇADA DE VITÓRIA', 1498, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1288',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGUERA DE TABOÃO DA SERRA', 1499, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2427',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ENSINO SUPERIOR DE SÃO MIGUEL DO IGUAÇU', 1500, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2059',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PROJEÇÃO DE CEILÂNDIA', 1507, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '83',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Centro Univeristário da Faculdade Estácio de Sá de Belo Horizonte', 1509, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '9298',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO ESTÁCIO DE SÁ DE SANTA CATARINA', 1510, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '26119',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE VALE DO CRICARÉ', 1514, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2061',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO DE PORTO VELHO', 1515, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1612',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGUERA DE TAGUATINGA', 1518, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '18',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE FIA DE ADMINISTRAÇÃO E NEGÓCIOS', 1520, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '379',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE DIREITO FRANCISCO BELTRÃO', 1523, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2055',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI ANTOINE SKAF', 1526, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '338',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Pinhais', 1535, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1721',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TELÊMACO BORBA', 1536, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1124',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR DE RONDÔNIA', 1540, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2063',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DECISÃO', 1544, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '26799',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO SÃO FRANCISCO', 1546, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2066',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE MEDICINA ESTÁCIO DE JUAZEIRO DO NORTE', 1547, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2304',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO FÍSICA DE FOZ DO IGUAÇU', 1550, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1893',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DO VALE DO RIBEIRA', 1554, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2520',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SETE DE SETEMBRO', 1556, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1876',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DO ESPÍRITO SANTO', 1559, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1375',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ILHA SOLTEIRA', 1562, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2517',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SUL FLUMINENSE', 1564, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1328',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE UNIME DE CIÊNCIAS JURÍDICAS', 1565, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1957',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DE ARARAQUARA', 1569, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '683',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE UNIME DE CIÊNCIAS SOCIAIS', 1571, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1956',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ALFREDO NASSER', 1573, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1974',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE EDUCACIONAL DE MEDIANEIRA', 1574, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2076',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DO PLANALTO DE ARAXÁ', 1575, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1119',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR BLAURO CARDOSO DE MATTOS', 1576, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1041',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE INTERMUNICIPAL DO NOROESTE DO PARANÁ', 1577, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1933',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS E EDUCAÇÃO SENA AIRES', 1580, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1226',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DA CIDADE DE SANTA LUZIA', 1581, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '4378',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE INDAIATUBA', 1583, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2391',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE GUARATINGUETÁ', 1584, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '888',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ENERGIA DE ADMINISTRAÇÃO E NEGÓCIOS', 1585, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1021',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE DO VALE DO SAPUCAÍ', 1586, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2356',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DE TANGARÁ DA SERRA', 1587, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '882',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ESTÁCIO DE SÃO LUÍS', 1590, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1664',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ODONTOLOGIA DE MANAUS', 1592, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '110',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS E EDUCAÇÃO DO ESPÍRITO SANTO', 1596, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1294',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE CIÊNCIAS DA SAÚDE', 1600, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1512',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CIDADE DE COROMANDEL', 1601, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2083',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ADMINISTRAÇÃO DE NOVA ANDRADINA - FANOVA', 1605, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1994',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DE CASSILÂNDIA', 1606, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2084',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE LUTERANA SÃO MARCOS', 1607, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2290',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DOS CERRADOS PIAUIENSES', 1609, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2085',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DAS ATIVIDADES EMPRESARIAIS DE TERESINA', 1610, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1142',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ADVENTISTA PARANAENSE', 1613, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2087',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ASTORGA', 1614, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2151',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANGEL VIANNA', 1616, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '496',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SANTA RITA', 1620, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1118',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE NETWORK', 1621, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1891',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO INTERIOR PAULISTA', 1622, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1165',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS AGRÁRIAS DE ANDRADINA', 1623, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '613',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MARECHAL RONDON', 1624, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '867',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Marechal Rondon', 1624, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1315',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS HUMANAS DE AGUAÍ', 1628, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1382',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PITÁGORAS DE LONDRINA', 1632, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '984',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CASTELLI ESCOLA SUPERIOR DE HOTELARIA', 1636, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2289',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS JURÍDICAS E SOCIAIS DE MACEIÓ', 1637, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2424',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO AMAZONAS', 1638, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '120',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS HUMANAS E SOCIAIS', 1640, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1880',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SOCIAL DA BAHIA', 1641, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '946',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA E CIÊNCIAS DE ITABUNA', 1642, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2071',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANÍSIO TEIXEIRA DE FEIRA DE SANTANA', 1643, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1741',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE UNIME DE EDUCAÇÃO E COMUNICAÇÃO', 1644, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1955',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA E CIÊNCIAS DE JEQUIÉ', 1645, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2146',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO CIÊNCIAS E LETRAS DE PARAÍSO', 1646, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1801',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ENSINO E CULTURA DO CEARÁ', 1647, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '537',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIA E EDUCAÇÃO DO CAPARAÓ', 1653, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2090',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CENECISTA DE SETE LAGOAS', 1655, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2338',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR DE TERESINA', 1656, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1134',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE EDUCACIONAL DE DOIS VIZINHOS', 1657, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2262',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE INTEGRADA DA GRANDE FORTALEZA', 1658, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '538',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ESTÁCIO DE SÁ DE OURINHOS', 1659, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '733',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Projeção de Sobradinho', 1661, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '82',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ARAGUAIA', 1663, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1236',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DA SAÚDE E ECOLOGIA HUMANA', 1664, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1306',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE KENNEDY', 1665, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1417',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO METROPOLITANO DE ENSINO SUPERIOR', 1669, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1406',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ASA DE BRUMADINHO', 1670, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2091',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO ESPERANÇA DE ENSINO SUPERIOR', 1672, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1450',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE METROPOLITANA DA GRANDE RECIFE', 1675, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1535',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ENSINO SUPERIOR DO PIAUÍ', 1677, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1143',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS DE WENCESLAU BRAZ', 1678, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2297',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CAMPINA GRANDE DO SUL', 1679, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2406',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SALESIANA MARIA AUXILIADORA', 1682, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1094',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PIAUIENSE', 1683, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '16760',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE BARDDAL DE ARTES APLICADAS', 1686, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1029',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR DE TECNOLOGIA E EDUCAÇÃO DE PORTO FERREIRA', 1692, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2354',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ITANHAÉM', 1693, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1978',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR DE CRICIÚMA - ESUCRI', 1694, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1595',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CENTRAL DE CRISTALINA', 1696, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2092',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ESCRITOR OSMAN DA COSTA LINS', 1697, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1646',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO DE JARU', 1699, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1935',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PROMOVE DE SETE LAGOAS', 1700, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2344',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MACHADO DE ASSIS', 1701, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '489',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE INFORMÁTICA DO RECIFE', 1706, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1189',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS CONTÁBEIS DE RECIFE', 1707, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1188',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO PERNAMBUCANO DE ENSINO SUPERIOR', 1708, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '21',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGUERA DE NEGÓCIOS E TECNOLOGIAS DA INFORMAÇÃO', 1710, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '17',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE PRESIDENTE PRUDENTE', 1711, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '698',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS E TECNOLOGIA DE TERESINA', 1712, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1145',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE SÃO VICENTE', 1713, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '929',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR DE GESTÃO COMERCIAL E MARKETING', 1714, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '31',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE NOBRE DE FEIRA DE SANTANA', 1718, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1742',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MINAS GERAIS', 1720, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2451',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE VIÇOSA', 1721, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1307',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE PORTO VELHO', 1722, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1611',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR DE ADMINISTRAÇÃO E GESTÃO', 1723, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '6800',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE XV DE AGOSTO', 1725, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1075',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SANTA AMÉLIA', 1726, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '999',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CARIACICA', 1727, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1983',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE INTERAMERICANA DE PORTO VELHO', 1728, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1613',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE GENNARI E PEARTREE', 1732, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1877',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ENSINO SUPERIOR DE MARECHAL CÂNDIDO RONDON', 1733, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1906',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO LA SALLE DO RIO DE JANEIRO', 1736, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1726',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO LUTERANO DE ENSINO SUPERIOR DE PORTO VELHO', 1738, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1621',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA OSWALDO CRUZ', 1743, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '356',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia Alvares de Azevedo', 1745, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '381',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE LUSO-BRASILEIRA', 1749, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2098',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ENFERMAGEM NOVA ESPERANÇA', 1753, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1485',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ASSOCIADA BRASIL', 1756, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '357',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE INDEPENDENTE DO NORDESTE', 1758, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1321',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PADRE JOÃO BAGOZZI', 1759, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '148',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA E NEGÓCIOS CARLOS DRUMMOND DE ANDRADE', 1762, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '354',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI CHAPECÓ', 1763, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2330',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE JOSÉ BONIFÁCIO', 1765, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1938',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ESPÍRITO SANTENSE', 1766, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1984',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SANTA MARIA', 1771, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1930',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE EDUCACIONAL DE PONTA GROSSA', 1774, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1003',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE METROPOLITANA DE GUARAMIRIM', 1777, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2016',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE AIEC', 1779, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '51',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE HORIZONTINA', 1780, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2037',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE INTESP', 1781, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2277',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS SOCIAIS APLICADAS', 1783, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '881',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS SOCIAIS APLICADAS', 1783, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1968',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS SOCIAIS APLICADAS', 1783, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1337',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE COLIDER', 1785, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2102',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO MACHADENSE DE ENSINO SUPERIOR', 1786, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1114',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ADMINISTRAÇÃO E ARTES DE LIMEIRA', 1788, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1478',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CATUAÍ', 1789, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2103',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO SUL DA BAHIA', 1790, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1122',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE EDUCACIONAL DE CORNÉLIO PROCÓPIO', 1798, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2105',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE REALEZA', 1800, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1640',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DOM BOSCO DE UBIRATÃ', 1801, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1202',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA E CIÊNCIAS DE PERNAMBUCO', 1803, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '194',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE MAUÁ - FAMA', 1804, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '905',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade dos Guararapes', 1805, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '173',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO FEDERAL DE EDUCAÇÃO, CIÊNCIA E TECNOLOGIA DO CEARÁ', 1807, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '558',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO FEDERAL DE EDUCAÇÃO, CIÊNCIA E TECNOLOGIA DO PARÁ', 1813, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '920',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR DE BAURU', 1816, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '876',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Estácio de Curitiba', 1817, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '135',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE LIONS', 1821, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1238',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SUL-AMERICANA', 1822, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1239',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR DO AMAPÁ', 1823, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1839',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ESTUDOS SUPERIORES DE MINAS GERAIS', 1825, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2447',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE LUTERANA DE TEOLOGIA', 1827, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2186',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA DA CIDADE - FACULDADE DE ARQUITETURA E URBANISMO', 1828, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '358',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGUERA DE PASSO FUNDO', 1830, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '254',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE AGUDOS', 1834, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1383',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO FUNDAÇÃO DE ENSINO OCTÁVIO BASTOS - FEOB', 1836, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1335',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS MACHADO DE ASSIS', 1842, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2315',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS STELLA MARIS DE ANDRADINA', 1844, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '614',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DE LINS', 1846, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '708',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PITÁGORAS DE IMPERATRIZ', 1847, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2041',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA BRASILEIRA DE ADMINISTRAÇÃO PÚBLICA E DE EMPRESAS', 1851, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '453',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SABERES', 1852, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1295',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA IBTA', 1853, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '13278',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO NORTE NOVO DE APUCARANA', 1856, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1355',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DEHONIANA', 1857, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2351',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS GERENCIAIS PADRE ARNALDO JANSSEN', 1860, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2438',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DA REGIÃO SERRANA', 1862, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1480',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ADMINISTRAÇÃO DA ASSOCIAÇÃO BRASILIENSE DE EDUCAÇÃO', 1864, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2118',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS REGIONAIS DE AVARÉ', 1870, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1042',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MERCÚRIO', 1873, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '498',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE OURINHOS', 1874, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '732',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE FILOSOFIA, CIÊNCIAS E LETRAS DE IBITINGA', 1875, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2120',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MUNICIPAL PROFESSOR FRANCO MONTORO DE MOGI GUAÇU', 1876, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1808',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DA FUNDAÇÃO EDUCACIONAL INACIANA PE SABÓIA DE MEDEIROS', 1878, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '665',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CASA DO ESTUDANTE', 1880, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1373',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DA ESCADA', 1881, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2121',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS AGRÁRIAS E DA SAÚDE', 1883, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1954',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ENIAC', 1892, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '759',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE EUROPÉIA DE ADMINISTRAÇÃO E MARKETING', 1894, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1538',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO CHRISTUS', 1895, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '541',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO LITORAL SUL PAULISTA', 1898, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '789',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANCHIETA DE ENSINO SUPERIOR DO PARANÁ', 1900, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '149',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SANTO AGOSTINHO', 1902, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1513',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CRISTO REI', 1903, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2106',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR MATERDEI', 1906, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '111',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE EDUCACIONAL DE COLOMBO', 1907, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2101',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA DE ENSINO SUPERIOR FABRA', 1908, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1038',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS BIOMÉDICAS DE CACOAL', 1917, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1852',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE SÃO BENTO', 1921, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '360',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE DIREITO PADRE ARNALDO JANSSEN', 1923, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2437',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ADMINISTRAÇÃO DE CATAGUASES', 1926, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1401',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DO VALE DO IGUAÇU', 1927, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1209',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO DE SÃO PAULO', 1930, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '361',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR FRANCISCANO', 1931, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1848',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PALOTINA', 1932, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1475',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE BIRIGUI', 1933, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2516',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SINOP', 1934, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '812',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE EVANGÉLICA DE SALVADOR', 1937, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '971',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR DE LONDRINA - INESUL', 1939, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '985',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE NOVA SERRANA', 1940, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1903',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CUIABÁ', 1941, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '10',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA IBRATEC', 1944, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '202',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE SORRISO', 1945, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1090',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE LEGALE', 1946, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '405',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ENSINO SUPERIOR DA PARAÍBA', 1948, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1487',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS JURÍDICAS E SOCIAIS APLICADAS DO ARAGUAIA', 1952, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1887',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI BLUMENAU', 1958, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1070',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO TECNOLÓGICO E DAS CIÊNCIAS SOCIAIS APLICADAS E DA SAÚDE DO CENTRO EDUC. N. SRª AUXILIADORA', 1961, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2530',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO DO CENTRO EDUCACIONAL NOSSA SENHORA AUXILIADORA', 1962, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2529',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA EM HOTELARIA, GASTRONOMIA E TURISMO DE SÃO PAULO', 1964, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '362',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE ALAGOAS', 1965, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2416',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ALBERT EINSTEIN', 1966, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '53',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO VALE DO ITAPECURÚ', 1967, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2127',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE BRASILEIRA DE TECNOLOGIA', 1968, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1371',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO ESPÍRITO SANTO', 1970, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1299',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO ESPÍRITO SANTO', 1970, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1689',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO ORÍGENES LESSA', 1973, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1963',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO DE CAXIAS', 1974, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2128',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO DE ESTUDOS SUPERIORES APRENDIZ', 1977, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1434',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE METROPOLITANA DA GRANDE FORTALEZA', 1978, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '542',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS GERENCIAIS DE MANHUAÇU', 1984, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1421',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ESTÁCIO DE SÁ DE JUIZ DE FORA', 1986, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '7198',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE AVANTIS', 1988, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2029',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR DE PIEDADE', 1992, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1536',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE MEDICINA NOVA ESPERANÇA', 1995, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1486',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO CUIABÁ DE ENSINO E CULTURA', 1996, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '11',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TAQUARITINGA', 2009, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '769',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ESAMC SOROCABA', 2010, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '897',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE JK - UNIDADE II - GAMA', 2021, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '54',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ROLIM DE MOURA', 2022, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1524',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CAMPINA GRANDE', 2027, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1654',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO CAMPO LIMPO PAULISTA', 2030, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2001',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Estácio do Pará - Estácio FAP', 2036, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '910',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE UNIME DE CIÊNCIAS EXATAS E TECNOLÓGICAS', 2037, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1958',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CIDADE LUZ', 2039, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2518',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO FUTURO', 2040, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1422',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE FIGUEIREDO COSTA - FIC', 2042, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2417',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE VALE DO SALGADO', 2043, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2254',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE AMADEUS', 2045, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1364',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ESTUDOS SUPERIORES DO MARANHÃO', 2049, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1670',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO DE NOVA ANDRADINA', 2054, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1996',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DA ALTA PAULISTA', 2056, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1199',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE DESENVOLVIMENTO SUSTENTÁVEL DE CRUZEIRO DO SUL', 2072, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2094',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO PADRÃO', 2073, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1234',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR DE ALAGOAS', 2075, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2412',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ITAITUBA', 2079, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2228',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS MÉDICAS DA PARAÍBA', 2082, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1488',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO BAIANO DE ENSINO SUPERIOR', 2085, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '13538',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR DE FOZ DO IGUAÇU', 2086, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1895',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO PRÓ-SABER', 2091, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '499',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE AURIFLAMA', 2102, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2204',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TEOLOGIA DE HOKEMÃH', 2104, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2140',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DOM BOSCO DE PORTO ALEGRE', 2113, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '262',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIA E TECNOLOGIA', 2117, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1780',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Estácio FASE - Faculdade Estácio de Sergipe', 2122, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1361',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CALAFIORI', 2124, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1561',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA DE DIREITO DO RIO DE JANEIRO', 2126, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '451',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA DE ECONOMIA DE SÃO PAULO', 2129, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '300',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE FAPAN', 2131, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '33619',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Ciências, Educação e Teologia do Norte do Brasil', 2133, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1859',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES BATISTA DO PARANÁ', 2141, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '150',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO ACRE', 2146, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2367',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE PALMAS', 2148, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1551',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MATO GROSSO DO SUL', 2149, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1273',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE CIÊNCIAS HUMANAS E SOCIAIS ANÍSIO TEIXEIRA', 2154, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '777',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SÃO TOMÁS DE AQUINO', 2156, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1694',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SANTANA', 2160, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1000',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE EUGÊNIO GOMES', 2163, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2162',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE FOZ DO IGUAÇU', 2165, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1898',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CAMPO GRANDE', 2168, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1272',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO BELO HORIZONTE DE ENSINO SUPERIOR', 2171, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2463',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE SANTA CATARINA', 2174, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '831',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO PAULISTA DE ENSINO', 2177, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '855',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('RATIO - FACULDADE TEOLÓGICA E FILOSÓFICA', 2180, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '543',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SALESIANA DOM BOSCO', 2186, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '113',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO MARANHÃO', 2189, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1669',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGUERA DE PELOTAS', 2191, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '230',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO IVOTI', 2192, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2511',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGUERA DO RIO GRANDE', 2194, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1558',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MONTEIRO LOBATO', 2198, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '263',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE VALE DO GORUTUBA', 2200, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2142',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO DE GUARATUBA', 2202, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2524',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TUPI PAULISTA', 2205, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1338',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Doctum de Juiz de Fora', 2220, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2378',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE VICTOR HUGO', 2229, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '859',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS SOCIAIS APLICADAS DE BELO HORIZONTE', 2233, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2456',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE TEOLÓGICA BATISTA EQUATORIAL', 2237, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '914',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE FORTALEZA', 2240, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '551',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PARAÍBANA', 2243, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1494',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DA CIDADE DE MACEIÓ', 2244, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2418',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE METROPOLITANA DE CIENCIAS E TECNOLOGIA', 2246, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1821',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Paulista São José', 2247, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '402',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SERGIPANA', 2248, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1366',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE COMUNICAÇÃO PITÁGORAS UNIDADE GUARAPARI', 2264, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1399',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CAMBURY DE FORMOSA', 2266, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2082',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CAFELÂNDIA', 2282, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2265',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR DE TEOLOGIA E ESPIRITUALIDADE FRANCISCANA', 2287, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '273',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE UNIÃO CULTURAL DO ESTADO DE SÃO PAULO', 2289, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '798',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE DIREITO DE SANTA MARIA', 2297, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1470',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE FIDELIS', 2301, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '151',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE GEREMÁRIO DANTAS', 2308, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '500',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE LUTERANA RUI BARBOSA', 2312, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1907',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR DE EDUCAÇÃO CORPORATIVA', 2319, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '834',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO ATENEU', 2320, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1219',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DA AMAZÔNIA', 2323, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '577',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DA AMAZÔNIA', 2323, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1312',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE UNIÃO BANDEIRANTE', 2324, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '833',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ITEANA DE BOTUCATU', 2328, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '622',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MONTES BELOS', 2336, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1569',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DA ALDEIA DE CARAPICUÍBA', 2341, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '639',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DA AMAZÔNIA OCIDENTAL', 2343, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2368',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE FILOSOFIA BERTHIER', 2346, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '248',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUIÇÃO DE ENSINO SÃO FRANCISCO', 2348, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1809',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR MADRE CELESTE', 2350, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '576',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ESPÍRITO SANTENSE DE CIÊNCIAS JURÍDICAS', 2351, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1981',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGUERA DE MATÃO', 2355, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1920',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PAN AMERICANA', 2356, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2133',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CATÓLICA DO TOCANTINS', 2365, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1545',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MERIDIONAL', 2383, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '249',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE FILOSOFIA E TEOLOGIA PAULO VI', 2389, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '727',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE SOROCABA', 2399, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '900',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ENSINO SUPERIOR DE FLORIANO', 2413, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2152',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE INTEGRADA BRASIL AMAZONIA - FIBRA', 2426, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '915',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS GERENCIAIS DA BAHIA', 2427, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '952',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS E TECNOLOGIAS DE CAMPOS GERAIS', 2428, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2125',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PITÁGORAS DE TEIXEIRA DE FREITAS', 2437, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1123',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CIDADE DE JOÃO PINHEIRO', 2440, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1965',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS BIOMÉDICAS DO ESPÍRITO SANTO', 2442, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1980',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PROMOVE DE BELO HORIZONTE', 2450, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2473',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ADMINISTRAÇÃO DE CHAPADÃO DO SUL', 2456, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2155',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ESTUDOS AVANÇADOS DO PARÁ', 2459, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '916',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACUDADE IEDUCARE - FIED', 2466, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2156',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO TEOLÓGICO FRANCISCANO', 2468, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1590',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO MACAPAENSE DE ENSINO SUPERIOR', 2469, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1841',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SALVADOR DE ENSINO E CULTURA', 2470, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '938',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MARIA MILZA', 2474, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2009',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ADMINISTRAÇÃO DE MARIANA', 2477, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1445',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE INTEGRAÇÃO DO ENSINO SUPERIOR DO CONE SUL', 2478, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2281',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PROCESSUS', 2484, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '76',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CATÓLICA DE FORTALEZA', 2485, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '545',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANGLICANA DE ERECHIM', 2488, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2285',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO DO CECAP', 2491, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '47',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE EINSTEIN', 2500, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '954',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ESTÁCIO DE SÁ DE GOIÁS', 2501, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1228',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE DIREITO UNIDADE GUARAPARI', 2511, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1398',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO DO SUL DO PIAUÍ', 2521, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2296',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE RORAIMENSE DE ENSINO SUPERIOR', 2536, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1857',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SÃO GERALDO', 2537, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1985',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE EVANGÉLICA DO MEIO NORTE', 2539, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2172',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TEOLOGIA, FILOSOFIA E CIÊNCIAS HUMANAS GAMALIEL', 2548, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1197',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO SANTA TEREZINHA', 2554, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2039',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FIAM-FAAM - CENTRO UNIVERSITÁRIO', 2556, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '313',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ENSINO SUPERIOR DA CIDADE DE FEIRA DE SANTANA', 2560, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1744',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DE CAMPINA GRANDE', 2564, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1657',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ABEU - CENTRO UNIVERSITÁRIO', 2565, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1581',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ZACARIAS DE GÓES', 2568, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2158',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA FAESA', 2569, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1297',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE REGIONAL DE FILOSOFIA, CIÊNCIAS E LETRAS DE CANDEIAS', 2572, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2126',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE TEOLÓGICA SUL AMERICANA', 2573, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '987',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS SOARES DE OLIVEIRA', 2575, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1047',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES PITÁGORAS UNIDADE GUARAPARI', 2576, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1397',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ATENAS', 2579, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '6018',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SÃO SALVADOR', 2581, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '955',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ENSINO SUPERIOR DO CENTRO DO PARANÁ', 2582, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2161',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA BRASILEIRA DE ECONOMIA E FINANÇAS', 2591, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '455',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE JUAZEIRO DO NORTE', 2593, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2306',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Meta', 2613, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2369',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SANTO ANTÔNIO DE PÁDUA', 2616, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1457',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SÃO BENTO DO RIO DE JANEIRO', 2617, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '501',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE AMPÉRE', 2620, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2267',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA IBTA - SÃO JOSÉ DOS CAMPOS', 2625, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '634',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS CONTÁBEIS E DE ADMINISTRAÇÃO DO VALE DO JURUENA', 2629, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1945',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DO EXTREMO SUL DA BAHIA', 2632, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2049',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DINÂMICA DO VALE DO PIRANGA', 2636, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1442',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SÃO VICENTE', 2642, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2326',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE INTEGRADA DE SANTA MARIA', 2647, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1471',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE UNIDA DE VITÓRIA', 2652, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1298',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PIEMONTE', 2653, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2236',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO SÃO JUDAS TADEU', 2677, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2153',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DOM ALBERTO', 2687, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2513',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE INESP - INSTITUTO NACIONAL DE ENSINO E PESQUISA', 2688, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '827',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS JURÍDICAS DE PARAÍSO DO TOCANTINS', 2702, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1802',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR DO SUL DO MARANHÃO', 2724, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2040',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR DE ADMINISTRAÇÃO DE EMPRESAS', 2726, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '633',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO VERA CRUZ', 2744, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '364',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR DA AMAZÔNIA', 2745, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '919',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Ciências Educacionais de Capim Grosso', 2753, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2245',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO VALE DO ITAJAÍ MIRIM', 2755, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1103',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGUERA DE VALPARAÍSO', 2756, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1227',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS GERENCIAIS DE SÃO GOTARDO', 2763, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '784',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE EMPRESARIAL DE CHAPECÓ', 2766, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2331',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE UNIDA DE CAMPINAS', 2770, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1252',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO DE ENSINO SUPERIOR DE ILHÉUS', 2771, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '524',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE MACAPÁ', 2773, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1846',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Centro Universitário UNIFAFIBE', 2774, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '688',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdades Integradas Desembargador Sávio Brandão', 2775, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1280',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE INFORMÁTICA DE OURO PRETO DO OESTE', 2779, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1833',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DO NORDESTE', 2783, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '547',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES PEQUENO PRÍNCIPE', 2787, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '152',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS AGRÁRIAS E EXATAS DE PRIMAVERA DO LESTE', 2791, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1634',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE UBS', 2793, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '365',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS SOCIAIS E HUMANAS SOBRAL PINTO', 2794, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2430',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE IPORÁ', 2796, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2045',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FANEESP - FACULDADE NACIONAL DE EDUCAÇÃO E ENSINO SUPERIOR DO PARANÁ', 2799, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '745',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MODELO', 2805, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '153',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE EVANGÉLICA DE SÃO PAULO', 2806, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '366',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES ITECNE DE CASCAVEL', 2808, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2403',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SÃO SEBASTIÃO', 2814, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '626',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE NOSSA SENHORA DE FÁTIMA', 2826, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '218',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE NOSSA SENHORA DE FÁTIMA', 2826, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1302',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE EVANGÉLICA DO PIAUI', 2827, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1147',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DOM BOSCO DE GOIOERÊ', 2831, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2089',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SUL DA AMÉRICA', 2836, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1976',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PARANAPANEMA', 2841, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2490',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS MÉDICAS E DA SAÚDE DE JUIZ DE FORA', 2843, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2384',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SALESIANA DOM BOSCO DE PIRACICABA', 2844, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '738',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE REINALDO RAMOS', 2845, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1655',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR DOM HELDER CÂMARA', 2849, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2460',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SÃO FRANCISCO DE ASSIS', 2855, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '265',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE BELÉM', 2859, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '917',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ZUMBI DOS PALMARES', 2886, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '368',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE BARÃO DE PIRATININGA', 2891, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '714',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO E TECNOLOGIA DA REGIÃO MISSIONEIRA', 2895, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2286',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SATC', 2896, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1596',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CONCÓRDIA', 2903, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2108',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE JK - GUARÁ', 2904, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '57',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE NATALENSE DE ENSINO E CULTURA', 2908, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1787',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO ESTADO DO MARANHÃO', 2909, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1662',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE VERDE NORTE', 2910, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1925',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CIDADE DE PATOS DE MINAS', 2915, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1870',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE BRASIL NORTE', 2917, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1842',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO DE BARRETOS', 2922, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1048',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO SUL', 2944, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2069',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO BAIXO PARNAÍBA', 2949, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2173',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO PANTANAL MATOGROSSENSE', 2961, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2507',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PROJEÇÃO DO GUARÁ', 2964, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '58',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO OCIDENTE', 2969, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '953',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS HUMANAS E BIOLÓGICAS E DA SAÚDE', 2973, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1633',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS JURÍDICAS E SOCIAIS APLICADAS DE PRIMAVERA DO LESTE', 2974, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1632',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR SANTA CECÍLIA', 3004, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '703',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO INSTITUTO NACIONAL DE PÓS-GRADUAÇÃO DE SÃO JOSÉ DOS CAMPOS', 3008, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '630',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FAJOPA - FACULDADE JOÃO PAULO II', 3012, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '599',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SANTA RITA DE CÁSSIA', 3020, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1572',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CHRISTUS FACULDADE DO PIAUÍ', 3042, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1724',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE TEOLÓGICA DE CIÊNCIAS HUMANAS E SOCIAIS LOGOS', 3051, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '369',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE INTERNACIONAL DA PARAÍBA', 3099, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1491',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ODONTOLOGIA DO RECIFE', 3146, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '195',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANCHIETA DO RECIFE', 3148, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '196',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PITÁGORAS DE DIVINÓPOLIS - FPD', 3149, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1389',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE COMUNITÁRIA DA REGIÃO DE CHAPECÓ', 3151, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2332',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI JARAGUÁ DO SUL', 3155, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2497',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO ALMEIDA RODRIGUES', 3157, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1111',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI FLORIANÓPOLIS', 3159, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1018',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO FEDERAL DE EDUCAÇÃO, CIÊNCIA E TECNOLOGIA DE ALAGOAS', 3160, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2421',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Instituto Federal de Educação, Ciência e Tecnologia do Sertão Pernambucano', 3161, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1713',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE EQUIPE', 3171, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1004',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE DO ESTADO DO AMAZONAS', 3172, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '117',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO FEDERAL DE EDUCAÇÃO, CIÊNCIA E TECNOLOGIA DE RORAIMA', 3184, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1861',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO DE CAJAZEIRAS', 3192, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1931',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DOS CAMPOS GERAIS', 3193, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '998',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE MINAS BH', 3194, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2461',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO ALBERT EINSTEIN', 3203, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '52',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE QUATRO MARCOS', 3204, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1565',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS DA BAHIA - FACIBA', 3216, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '949',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR DE CIÊNCIAS DA SAÚDE', 3223, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '59',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE LUIZ EDUARDO MAGALHÃES', 3230, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2241',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MADRE THAIS', 3268, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '525',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SÃO BENTO DA BAHIA', 3270, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '959',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SANTO ANTONIO', 3285, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1264',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA INFORMÁTICA', 3299, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '549',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE JUNQUEIRÓPOLIS', 3302, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1947',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DE PATOS', 3304, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1865',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA IPUC', 3306, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1575',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ENSINO SUPERIOR DE CATALÃO', 3319, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1828',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE EDUCAÇÃO E ENSINO SUPERIOR DE CAMPINAS', 3323, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '240',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAC RIO', 3332, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '502',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE ESTADUAL DO RIO GRANDE DO SUL', 3336, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '286',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE TERESINA', 3337, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1148',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE EDUCAÇÃO SUPERIOR PRESIDENTE KENNEDY - CENTRO DE FORMAÇÃO DE PROFISSIONAIS DE EDUCAÇÃO', 3360, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1790',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE GUARAÍ', 3363, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2048',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SÃO FRANCISCO DE JUAZEIRO', 3365, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1867',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO DE OLIVEIRA', 3367, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1760',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DE PATOS DE MINAS', 3371, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1871',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DE LAVRAS', 3372, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1884',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR MÚLTIPLO', 3375, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2178',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TEOLOGIA INTEGRADA', 3376, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1950',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MONTESSORIANO DE SALVADOR', 3377, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '964',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MISSIONEIRA DO PARANÁ', 3380, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2404',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PARAÍSO DO CEARÁ', 3388, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2308',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE RAÍZES', 3389, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '584',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ENSINO SUPERIOR DOM BOSCO', 3393, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2107',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE LS', 3396, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '61',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE BOAS NOVAS DE CIÊNCIAS TEOLÓGICAS, SOCIAIS E BIOTECNOLÓGICAS', 3397, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '118',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Uberlandense de Núcleos Integrados de Ensino, Serviço Social e Aprendizagem', 3430, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1350',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO SERIDÓ', 3431, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2096',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DE CIÊNCIAS HUMANAS, SAÚDE E EDUCAÇÃO DE GUARULHOS', 3432, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '758',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE SAÚDE IBITURUNA', 3434, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1521',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Araraquara', 3436, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '685',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE INEDI', 3443, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2138',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO IBITURUNA', 3448, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1519',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE POLITÉCNICA DE CAMPINAS', 3456, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '244',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Centro de Ensino Superior de Conselheiro Lafaiete', 3488, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1115',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PINHALZINHO', 3495, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1722',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS EDUCACIONAIS DE SERGIPE', 3506, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1365',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE VICENTINA - FAVI', 3509, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '154',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS GERENCIAIS ALVES FORTES', 3514, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1392',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DA VITÓRIA DE SANTO ANTÃO', 3515, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1645',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS DA SAÚDE ARCHIMEDES THEODORO', 3516, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1391',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE JANGADA', 3518, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2499',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CATÓLICA DE POUSO ALEGRE', 3522, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2360',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE DIREITO DA FUNDAÇÃO ESCOLA SUPERIOR DO MINISTÉRIO PÚBLICO', 3523, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '269',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE EVANGÉLICA DE TECNOLOGIA, CIÊNCIAS E BIOTECNOLOGIA DA CGADB', 3525, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '503',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO EURÍPEDES DE MARÍLIA', 3529, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '597',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE NANUQUE', 3530, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2491',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CERES', 3533, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '647',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TEOLOGIA EVANGÉLICA EM CURITIBA - FATEV', 3536, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '155',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR DE MINAS GERAIS', 3542, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1570',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE NOVO HAMBURGO', 3543, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '522',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE TEOLÓGICA BATISTA DE BRASÍLIA', 3573, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '62',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO SANTA CRUZ', 3584, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2230',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SANTA CRUZ', 3585, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2229',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DIOCESANA SÃO JOSÉ', 3587, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2370',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ENFERMAGEM SÃO VICENTE DE PAULA', 3590, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1492',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR ASSOCIADA DE GOIÂNIA', 3607, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1241',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS IPITANGA', 3609, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1953',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGUERA DE VALINHOS', 3612, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1215',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS IESGO', 3613, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2080',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PERNAMBUCANA DE SAÚDE', 3615, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '197',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS HUMANAS E EXATAS DO SERTÃO DO SÃO FRANCISCO', 3617, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2235',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DAMAS DA INSTRUÇÃO CRISTÃ', 3631, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '198',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdades Integradas do Rio Grande do Norte - FANORTES', 3643, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1791',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CATÓLICA SANTA TERESINHA', 3644, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2143',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CIDADE VERDE', 3649, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1011',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE COMPUTAÇÃO DE MONTES CLAROS', 3657, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1518',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DOM LUIS DE ORLEANS E BRAGANÇA', 3669, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1644',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('SINAL - FACULDADE DE TEOLOGIA E FILOSOFIA', 3675, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2364',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO DO MUNICÍPIO DE ITAPERUNA', 3682, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1099',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DO VALE DO IVAÍ', 3688, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2298',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA IPEP DE CAMPINAS', 3692, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '233',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA IPEP DE SÃO PAULO', 3693, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '4958',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SAINT PASTOUS', 3697, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '270',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR NACIONAL DE SEGUROS', 3710, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '504',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CIÊNCIAS DA VIDA', 3716, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2342',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MARANHENSE SÃO JOSÉ DOS COCAIS', 3724, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2179',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DOM PEDRO II', 3753, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '644',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS ADVENTISTAS DE MINAS GERAIS', 3754, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1883',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SERRA DA MESA', 3757, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1214',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade SOCIESC', 3758, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1019',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MADRE TEREZA', 3769, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2182',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE TEOLÓGICA BATISTA DE SÃO PAULO', 3770, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '372',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade IBGEN', 3772, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '271',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SÃO TOMAZ DE AQUINO', 3774, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '960',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO UVB.BR', 3775, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '373',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR DE MATO GROSSO', 3776, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CURITIBANA', 3777, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '4',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ARACAJU', 3778, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1360',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA CACHOEIRO DE ITAPEMIRIM', 3782, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1690',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PARAENSE DE ENSINO', 3783, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '918',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR DO RIO GRANDE DO NORTE', 3784, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1792',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO MARANHENSE DE ENSINO E CULTURA', 3785, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1671',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ENSINO DE MINAS GERAIS', 3786, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2443',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ENSINO SUPERIOR DA AMAZÔNIA', 3787, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1834',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE JUIZ DE FORA', 3788, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2382',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE EVANGÉLICA DE GOIANÉSIA', 3789, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2504',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA ENSITEC', 3790, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '157',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SENAC PORTO ALEGRE - FSPOA', 3804, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '268',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DA PARAÍBA', 3805, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1928',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE EDUCAÇÃO SUPERIOR DE POUSO ALEGRE', 3823, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2357',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA MÓDULO PAULISTA', 3837, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '438',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE BAIANA DE DIREITO E GESTÃO', 3847, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '963',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FUNDAÇÃO UNIVERSIDADE FEDERAL DO TOCANTINS', 3849, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1555',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE LUCIANO FEIJÃO', 3862, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1065',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE REGIONAL DE ALAGOINHAS', 3864, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1263',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE BRASILEIRA DE EDUCAÇÃO E CULTURA', 3866, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1242',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MAUÁ DE BRASÍLIA', 3867, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '64',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO FLORENCE DE ENSINO SUPERIOR', 3869, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1672',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE INTEGRAÇÃO DO SERTÃO', 3881, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1734',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ARNALDO HORÁCIO FERREIRA', 3921, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2239',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MÉTODO DE SÃO PAULO', 3933, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '376',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGUERA DE LIMEIRA', 3936, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1479',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Anhanguera de Indaiatuba', 3937, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2394',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ENSINO SUPERIOR SANTA BARBARA', 3940, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '843',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS JURÍDICAS E GERENCIAIS DE OLIVEIRA', 3954, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1759',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DE CATAGUASES', 3955, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1402',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO SUPERIOR DE ENSINO E PESQUISA DE MACHADO', 3972, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1113',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE DE RIO VERDE', 3974, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1109',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DO AMAPÁ', 3977, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1843',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA PENTÁGONO', 3978, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '807',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FUNDAÇÃO UNIVERSIDADE FEDERAL DO VALE DO SÃO FRANCISCO', 3984, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1706',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO SENAC', 3985, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '332',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE UNIÃO DE GOYAZES', 3987, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2271',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SÃO MATEUS', 3991, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1616',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA CETEP', 3993, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '156',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SENAC PERNAMBUCO', 3996, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '199',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO INFNET RIO DE JANEIRO', 3998, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '505',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ENSINO SUPERIOR DO INTERIOR PAULISTA', 4000, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '600',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAC PELOTAS', 4006, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '227',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FATECE - FACULDADE DE TECNOLOGIA, CIÊNCIAS E EDUCAÇÃO', 4007, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1357',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA ESTÁCIO DE CURITIBA', 4009, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '134',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO METODISTA', 4010, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '257',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGUERA DE RIO CLARO', 4013, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1543',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO NACIONAL DE EDUCAÇÃO DE SURDOS', 4016, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '476',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO PADRE ANCHIETA', 4017, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '820',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE BOTUCATU', 4020, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '620',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE GARÇA', 4021, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '884',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE JUNDIAÍ', 4022, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '816',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE MOCOCA', 4024, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '729',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE SÃO JOSÉ DO RIO PRETO', 4025, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '641',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA ZONA LESTE', 4026, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '296',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ITAPECERICA DA SERRA', 4028, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1989',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO FLUMINENSE', 4030, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2526',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE TECNOLOGIA EDUVALE - AVARÉ', 4043, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1044',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA FAMA', 4064, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '188',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE BATISTA DO ESTADO DO RIO DE JANEIRO - FABERJ', 4066, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2532',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ICESP', 4068, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '55',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE TECNOLÓGICA INAP', 4079, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2465',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA JARDIM', 4086, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '808',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ROSEIRA', 4090, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1528',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA PEDRO ROGÉRIO GARCIA', 4092, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2110',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE CURITIBA', 4093, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '159',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Estácio da Paraíba', 4094, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1497',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO FEDERAL DE EDUCAÇÃO, CIÊNCIA E TECNOLOGIA FARROUPILHA', 4098, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1472',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI ÍTALO BOLOGNA', 4100, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1244',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI DE DESENVOLVIMENTO GERENCIAL', 4101, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1243',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR DE ENGENHARIA E GESTÃO DE SÃO PAULO - ESEG', 4104, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '378',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI PORTO ALEGRE', 4107, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '272',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO CATÓLICO DE ESTUDOS SUPERIORES DO PIAUÍ', 4108, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1150',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS SOCIAIS APLICADAS E DE TECNOLOGIAS DE AGUA BOA', 4126, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2219',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGUERA DE SANTA BÁRBARA', 4138, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2313',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO BARRIGA VERDE', 4163, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1761',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO DE ENSINO SUPERIOR DE UBERABA', 4166, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1180',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE NOSSA CIDADE', 4169, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '37938',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE JK DE TECNOLOGIA', 4173, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '74',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE NAZARENA DO BRASIL', 4179, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '241',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PERUIBE', 4185, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1700',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ENSINO SUPERIOR DO NORDESTE', 4201, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1495',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA INED - UNIDADE IPATINGA', 4204, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1408',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PEDRO LEOPOLDO', 4218, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1692',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO PROFESSORA NAIR FORTES ABU-MERHY', 4219, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1390',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PITÁGORAS DE TECNOLOGIA DE BELO HORIZONTE', 4251, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2469',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DE CACOAL', 4255, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1851',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS PITÁGORAS', 4256, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1511',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE FILOSOFIA E TEOLOGIA DE GOIÁS', 4257, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1246',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE INHUMAS - FAC-MAIS', 4259, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2043',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE PORTO ALEGRE', 4261, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '267',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO VALE ELVIRA DAYRELL - FAVED', 4289, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1316',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO CENTRO EDUCACIONAL MINEIRO - FACEM', 4329, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2466',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA AMÉRICA DO SUL', 4330, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1014',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE PALMAS', 4355, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1552',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS SOCIAIS DOS PALMARES', 4356, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2322',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE TERRA NORDESTE', 4367, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2123',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE JK - UNIDADE I - GAMA', 4416, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '69',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS BARROS MELO', 4420, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1185',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI BELO HORIZONTE', 4421, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2464',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PROFESSOR MIGUEL ÂNGELO DA SILVA SANTOS', 4428, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1095',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE UNIGRAN CAPITAL', 4429, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1269',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ENFERMAGEM NOVA ESPERANÇA DE MOSSORÓ - FACENE/RN', 4431, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1055',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SÃO PAULO', 4435, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1525',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE METROPOLITANA DA AMAZÔNIA', 4450, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '911',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE METROPOLITANA DE MARABÁ', 4452, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1911',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DOM PEDRO II DE TECNOLOGIA', 4460, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '957',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PASCHOAL DANTAS', 4492, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '383',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGUERA JARAGUÁ DO SUL', 4495, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2500',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DO VALE DO IVAÍ', 4496, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2299',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS CAMPO-GRANDENSES', 4502, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '466',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DO RECÔNCAVO DA BAHIA', 4503, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2010',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FUNDAÇÃO UNIVERSIDADE FEDERAL DA GRANDE DOURADOS', 4504, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1757',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE REGIONAL PALMITOS', 4518, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2291',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO TIRADENTES', 4530, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2409',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI CAMPO GRANDE', 4532, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1274',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SÃO FRANCISCO DA PARAÍBA', 4533, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1932',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE HERRERO', 4534, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '160',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESTÁCIO FATERN - FACULDADE ESTÁCIO DO RIO GRANDE DO NORTE', 4566, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1794',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CENTRO MATO-GROSSENSE', 4567, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1089',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA MACHADO DE ASSIS', 4584, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '181',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO NORTE GOIANO', 4586, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1592',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE APOGEU', 4588, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '66',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CATÓLICA DE RONDONIA', 4594, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1618',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE REGES DE RIBEIRÃO PRETO', 4596, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '608',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA ASSESSORITEC', 4610, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1086',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO E MEIO AMBIENTE', 4613, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2064',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGUERA DE CAXIAS DO SUL', 4616, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '222',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANGLO-AMERICANO DE JOÃO PESSOA', 4631, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1496',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGÜERA DE SOROCABA', 4655, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '902',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DELTA', 4669, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '956',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DELTA', 4669, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1247',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PORTO DAS ÁGUAS', 4674, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2183',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CENTRO PAULISTANO', 4681, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '427',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE NOROESTE', 4699, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1250',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Ensino Regional Alternativa', 4714, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '704',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS VIANNA JÚNIOR', 4722, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2379',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS HUMANAS DE CRUZEIRO', 4724, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '681',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA EGÍDIO JOSÉ DA SILVA', 4725, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1129',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CENECISTA DE RIO BONITO', 4729, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1650',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MESSIANICA', 4731, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '386',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAC DF', 4732, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '67',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE REGIONAL DE RIACHÃO DO JACUÍPE', 4747, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1586',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA E CIENCIAS DO NORTE DO PARANÁ', 4751, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1805',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO MUNICIPAL DE SÃO JOSÉ', 4756, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '832',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA ALFA DE UMUARAMA', 4765, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1204',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE UNA DE CONTAGEM', 4766, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2021',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE IBS', 4773, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2468',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS DA SAÚDE DE UNAÍ', 4780, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1207',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CDL', 4784, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '553',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO FEDERAL DE EDUCAÇÃO CIÊNCIA E TECNOLOGIA DE RONDÔNIA', 4785, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1619',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO FEDERAL DE EDUCAÇÃO, CIÊNCIA E TECNOLOGIA DO TOCANTINS', 4786, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1554',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA CENTEC - CARIRI', 4791, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2309',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANTÔNIO MENEGHETTI', 4810, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2489',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI FELIX GUISARD', 4814, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2348',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI ANCHIETA', 4817, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '340',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI MARIANO FERRAZ', 4819, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '337',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI ANTÔNIO ADOLPHO LOBBE', 4820, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '693',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS GERENCIAIS E EMPREENDEDORISMO - FACIGE', 4821, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1517',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA EVOLUÇÃO', 4823, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '554',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR DE ARTES CÉLIA HELENA', 4829, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '387',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE VÉRTICE', 4846, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1924',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR DE SAÚDE DE ARCOVERDE', 4858, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1059',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PITÁGORAS DE POÇOS DE CALDAS', 4863, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2111',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PITÁGORAS DE SÃO LUIZ', 4865, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1667',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia de Taubaté', 4873, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2346',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE TAUBATÉ', 4873, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2350',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CONCHAS', 4889, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2275',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE FASIPE', 4901, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '813',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE BATISTA PIONEIRA', 4902, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2318',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE INTEGRADA DAS CATARATAS', 4922, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1897',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FUNDAÇÃO UNIVERSIDADE FEDERAL DO ABC', 4925, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '809',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE PRAIA GRANDE', 4926, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '788',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CLARETIANA DE TEOLOGIA', 4938, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '5',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE INTERNACIONAL DO DELTA', 4945, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1817',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE AUM', 4950, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '9',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Integrada de Araguatins', 4961, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '690',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO DE SETE LAGOAS', 4962, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2337',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ITOP', 4969, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1553',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE METROPOLITANA DO PLANALTO NORTE', 4982, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2131',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE SÃO JOSÉ DOS CAMPOS', 4983, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '632',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA CENTEC - SERTÃO CENTRAL', 4992, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2319',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ESTAÇÃO', 5000, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '161',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO MÉDIO PARNAÍBA', 5008, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2222',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO ESTADUAL DA ZONA OESTE', 5013, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '509',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE EDUCAÇÃO PROFESSOR ALDO MUYLAERT', 5018, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2528',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade São Braz', 5025, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '177',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS SOCIAIS APLICADAS DE MARABÁ', 5038, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1912',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA PAULISTA', 5045, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2274',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE POLIS DAS ARTES', 5046, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2195',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TEOLOGIA DE SÃO PAULO DA IGREJA PRESBITERIANA INDEPENDENTE DO BRASIL', 5048, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '388',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO TECNOLÓGICA DO ESTADO DO RIO DE JANEIRO', 5053, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1782',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Educação Tecnológica do Estado do Rio de Janeiro', 5053, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1584',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PITÁGORAS DE TECNOLOGIA DE CONTAGEM', 5066, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2022',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE ESTADUAL DE RORAIMA', 5077, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1860',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FUNDAÇÃO UNIVERSIDADE DO ESTADO DE SANTA CATARINA', 5078, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1016',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE SÃO BERNARDO DO CAMPO', 5099, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '662',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE INTERNACIONAL SIGNORELLI', 5105, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '506',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SOGIPA DE EDUCAÇÃO FÍSICA', 5107, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '289',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE FACMIL', 5124, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '650',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Assis Gurgacz', 5186, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1168',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGUERA DE EDUCAÇÃO, CIÊNCIAS E TECNOLOGIA DE SOROCABA', 5216, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '901',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE RAIMUNDO MARINHO', 5228, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2408',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE ESTADUAL DE ALAGOAS - UNEAL', 5242, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '700',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Doctum de Carangola', 5276, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1424',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE FORTIUM', 5277, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '68',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DE TAQUARA', 5285, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1305',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGÜERA DE RIBEIRÃO PRETO', 5288, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '612',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGUERA DE CIÊNCIAS E TECNOLOGIA DE BRASÍLIA', 5290, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '16',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS SOCIAIS APLICADAS E HUMANAS DE GARANHUNS', 5305, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1771',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdades Unificadas de Cataguases', 5313, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1400',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdades Unificadas de Iúna', 5315, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2255',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdades Unificadas de Leopoldina', 5316, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1425',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PORTO-ALEGRENSE', 5317, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '258',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE GUILHERME GUIMBALA', 5318, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1079',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FUNDAÇÃO UNIVERSIDADE FEDERAL DO PAMPA - UNIPAMPA', 5322, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2487',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE IMPACTA DE TECNOLOGIA', 5387, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '363',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO DE ENSINO SUPERIOR INTEGRADO-IESI', 5394, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1126',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGÜERA DE BAURU', 5451, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '877',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE GUARAPUAVA', 5518, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '978',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CATHEDRAL', 5520, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1855',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGUERA DE JACAREÍ', 5555, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '828',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia de São José dos Campos - Jessen Vidal', 5581, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '627',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DO NORTE DE MINAS - FUNORTE', 5592, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1520',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('LIBERTAS - FACULDADES INTEGRADAS', 5599, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1560',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE PRESIDENTE PRUDENTE', 5627, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '695',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE BRAGANÇA PAULISTA', 5633, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '845',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE VARGEM GRANDE PAULISTA', 5663, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2273',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS HUMANAS E SOCIAIS DE ARARIPINA - FACISA', 5664, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2231',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES UNIDAS DO VALE DO ARAGUAIA', 5670, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1886',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO UNIVERSITÁRIO SÃO JOSÉ DE ITAPERUNA', 5671, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1096',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE DO ESTADO DO AMAPÁ', 5701, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1845',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MUNICIPAL DE PALHOÇA', 5706, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2374',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO TECNOLÓGICA DO ESTADO DO RIO DE JANEIRO - FAETERJ', 6182, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '99',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO TECNOLÓGICA DO ESTADO DO RIO DE JANEIRO - FAETERJ', 6182, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1589',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO TECNOLÓGICA DO ESTADO DO RIO DE JANEIRO - FAETERJ', 6182, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1097',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO TECNOLÓGICA DO ESTADO DO RIO DE JANEIRO - FAETERJ', 6182, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1194',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO TECNOLÓGICA DO ESTADO DO RIO DE JANEIRO - FAETERJ', 6182, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1456',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO TECNOLÓGICA DO ESTADO DO RIO DE JANEIRO - FAETERJ', 6182, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '493',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE OBOÉ - FACO', 10016, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '555',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE VALENÇA', 10058, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2159',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TEOLOGIA E CIÊNCIAS HUMANAS', 10071, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '250',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TEOLOGIA E CIÊNCIAS HUMANAS', 10071, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1840',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA BANDEIRANTES', 10323, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '390',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA IPPEO', 10349, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '168',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SÃO PAULO DE ESTUDOS SUPERIORES', 10385, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '385',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE SAÚDE DE PAULISTA', 10613, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1875',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE NORTE CAPIXABA DE SAO MATEUS', 10685, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2062',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE UNIÃO ARARUAMA DE ENSINO S/S Ltda.', 10836, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '731',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Santo André', 10929, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1314',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR NACIONAL DE SEGUROS DE SÃO PAULO', 11289, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '370',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGUERA DE SUMARÉ', 11308, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1101',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA ALTO MÉDIO SÃO FRANCISCO', 11428, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1770',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ESPECIALIZADA NA ÁREA DE SAÚDE DO RIO GRANDE DO SUL', 11429, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '251',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE METROPOLITANA DE ANÁPOLIS', 11544, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '590',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DA SERRA GAÚCHA - CAXIAS DO SUL', 11563, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '216',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CAL DE ARTES CÊNICAS', 11584, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '508',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES NETWORK - CAMPUS SUMARÉ', 11586, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1100',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO E CULTURA DE VILHENA', 11645, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1310',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DO ISTITUTO EUROPEO DI DESIGN', 11807, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '391',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA INSPIRAR', 11818, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '162',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE EVOLUÇÃO ALTO OESTE POTIGUAR', 11841, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1873',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO NACIONAL DE ENSINO SUPERIOR E PÓS-GRADUAÇÃO PADRE GERVÁSIO', 11860, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2361',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA E DESENVOLVIMENTO DE COMPETÊNCIAS', 11902, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '922',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO SERTÃO BAIANO', 11951, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2243',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PRISMA', 12189, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1515',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA FAESA - VILA VELHA', 12229, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1220',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE CRUZEIRO DO OESTE', 12268, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2093',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA LA SALLE - ESTRELA', 12338, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1729',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE METROPOLITANA SÃO CARLOS BJI', 12430, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '101',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MOGIANA DO ESTADO DE SÃO PAULO', 12522, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1810',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACITEN - FACULDADE DE CIÊNCIAS E TECNOLOGIAS DE NATAL', 12547, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1795',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE BRASILEIRA DE ESTUDOS AVANÇADOS', 12601, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1673',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE MÚSICA SOUZA LIMA', 12611, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '394',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SETE LAGOAS', 12620, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2343',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR DE AVIAÇÃO CIVIL', 12625, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1652',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SAINT PAUL', 12661, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '389',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA FINACI', 12723, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '392',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS HUMANAS E SOCIAIS DO XINGU E AMAZÔNIA', 12735, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1423',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES UNIDAS DE PESQUISA, CIÊNCIAS E SAÚDE LTDA', 12749, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2147',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CRISTÃ DE CURITIBA', 12754, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '158',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO E CULTURA DE PORTO VELHO', 12758, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1605',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE UNIÃO DE CAMPO MOURÃO', 12766, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2114',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAC MINAS - UNIDADE BELO HORIZONTE', 12772, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2458',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGUERA DE PINDAMONHANGABA', 12791, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '655',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAC MINAS - UNIDADE BARBACENA', 12848, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1435',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES JOÃO PAULO II', 12869, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '252',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA E CIÊNCIAS DA BAHIA', 12922, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1265',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA IPANEMA', 12923, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '898',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE BRASIL CENTRAL', 12928, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2260',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE MATO GROSSO', 12946, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '29',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TEOLOGIA DA ARQUIDIOCESE DE BRASÍLIA', 13014, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '73',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SHALOM DE ENSINO SUPERIOR', 13034, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1348',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOOLOGIA AEROTD', 13073, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1027',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA LOURENÇO FILHO', 13106, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '563',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO BRASILEIRO DE EDUCACAO SUPERIOR CONTINUADA', 13238, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1529',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ADJETIVO CETEP', 13300, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1446',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PRINCESA DO OESTE', 13417, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2174',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA EM SAÚDE CIEPH', 13467, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1025',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SÃO BASÍLIO MAGNO', 13476, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '165',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS RIO BRANCO GRANJA VIANNA', 13481, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '838',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE EUROPÉIA DE VITÓRIA', 13484, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1986',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE FACTUM', 13486, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '278',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CANÇÃO NOVA', 13527, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2137',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CARAGUÁ', 13538, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1850',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ANHANGUERA DE PORTO ALEGRE', 13620, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '287',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA NOVA PALHOÇA', 13625, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2375',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES EVANGÉLICAS INTEGRADAS CANTARES DE SALOMÃO', 13643, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '15',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA ATENEU', 13657, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2250',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ISEIB DE BETIM', 13663, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2032',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI TELÊMACO BORBA', 13674, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1125',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI CIC', 13677, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '166',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PITÁGORAS DE CONTAGEM', 13684, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2023',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA DE MATEMÁTICA APLICADA', 13695, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '454',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA GAP', 13716, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '591',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PITÁGORAS DE GOVERNADOR VALADARES', 13743, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1380',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE EDUCACIONAL ARAUCÁRIA', 13749, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '164',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Educacional Araucária', 13749, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2077',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA IBRATE', 13775, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '170',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE SANTA CRUZ DA BAHIA', 13782, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2065',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO PLANALTO CENTRAL', 13784, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2081',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUIÇÃO DE ENSINO SUPERIOR DE CACOAL', 13792, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1853',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE PORTO FELIZ', 13796, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1599',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SANTO AGOSTINHO DE SETE LAGOAS', 13809, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2340',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('TREVISAN ESCOLA SUPERIOR DE NEGÓCIOS', 13811, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '348',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('TREVISAN ESCOLA SUPERIOR DE NEGÓCIOS', 13811, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '492',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('ESCOLA SUPERIOR ABERTA DO BRASIL', 13812, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1221',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ISEIB DE BELO HORIZONTE', 13828, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2470',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SAGRADA FAMÍLIA', 13832, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1002',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Escola DIEESE de Ciências do Trabalho', 13845, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '399',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE FINOM DE PATOS DE MINAS', 13873, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1872',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MURIALDO', 13883, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '220',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ITAPURANGA', 13889, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2200',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE LABORO', 13897, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1677',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE MARÍLIA', 13938, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '602',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ADMINISTRAÇÃO E NEGÓCIOS', 13944, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2419',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Presidente Antônio Carlos de Aimorés', 14029, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1384',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA PORTO SUL', 14069, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '791',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA FUTURO', 14095, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '169',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE REFIDIM', 14097, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1087',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Presidente Antônio Carlos de Baependi', 14101, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1453',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Presidente Antônio Carlos de Ponte Nova', 14115, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1441',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Presidente Antônio Carlos de São João Nepomuceno', 14121, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1439',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Presidente Antônio Carlos de Itanhandu', 14132, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1459',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Presidente Antônio Carlos de Lambari', 14133, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1447',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Presidente Antônio Carlos de Barão de Cocais', 14147, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1438',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Presidente Antônio Carlos de Mariana', 14148, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1443',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Presidente Antônio Carlos de Nova Lima', 14151, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2492',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Presidente Antônio Carlos de Sabará', 14155, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1436',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Presidente Antônio Carlos de Teófilo Otoni', 14156, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1128',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Educação e Estudos Sociais de Uberlândia', 14157, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1342',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Presidente Antônio Carlos de Governador Valadares', 14162, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1378',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE TRÊS PONTAS', 14165, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1193',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DO COOPERATIVISMO', 14181, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '279',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Presidente Antônio Carlos de Elói Mendes', 14206, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1458',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE ÚNICA DE TIMÓTEO', 14242, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1167',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Presidente Antônio Carlos de Itabirito', 14243, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1429',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Presidente Antônio Carlos de Uberaba', 14246, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1176',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Presidente Antônio Carlos de Uberlândia', 14248, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1341',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CATÓLICA DE SANTA CATARINA', 14288, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1023',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('NOVA FACULDADE', 14313, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2026',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE REDENTOR DE CAMPOS', 14342, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2531',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE EFICAZ', 14367, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1013',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA PORTO DAS MONÇÕES', 14401, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1598',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CESUMAR', 14403, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '80',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI PERNAMBUCO', 14412, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '203',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PITÁGORAS DE MACEIÓ', 14429, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2415',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI CONDE JOSÉ VICENTE DE AZEVEDO', 14609, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '343',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADES INTEGRADAS DE SERGIPE', 14622, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2205',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PIAGET', 14715, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1107',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO FEDERAL DE EDUCAÇÃO, CIÊNCIA E TECNOLOGIA DO PARANÁ', 14724, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '171',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PROGRESSO', 14727, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '762',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI CASCAVEL', 14782, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2405',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI TOLEDO', 14783, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1169',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI CURITIBA', 14784, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '167',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI LONDRINA', 14786, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '988',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA FRANCISCO MORATO', 14858, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2057',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE TECNOLÓGICA DENTAL CEEO', 14860, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2283',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('TREVISAN ESCOLA SUPERIOR DE NEGÓCIOS-', 14878, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2272',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DOURADO', 14879, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '404',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE HORIZONTE', 14882, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '77',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PRAIA GRANDE', 14890, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '792',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS DA SAÚDE DE BARRETOS DR. PAULO PRATA', 14892, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1050',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE INTEGRADA CARAJÁS', 14901, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1642',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SÃO GABRIEL DA PALHA', 14927, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1564',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS DO TOCANTINS', 14947, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2035',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE ENGENHARIA E INOVAÇÃO TÉCNICO PROFISSI', 14951, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1015',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA EM SAÚDE - IAHCS', 14961, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '276',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA EM SAÚDE', 14969, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '609',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DO NORDESTE DA BAHIA', 14975, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2202',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE GESTAO E NEGOCIOS DE SALVADOR', 14996, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '967',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DA INTEGRAÇÃO LATINO-AMERICANA', 15001, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1899',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Universidade Estadual do Norte do Paraná', 15015, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2525',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE ALTO VALE DO RIO DO PEIXE', 15032, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2176',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DO OESTE DO PARÁ', 15059, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1451',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE MASTER DE PARAUAPEBAS - FAMAP', 15079, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1811',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DA FRONTEIRA SUL', 15121, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2334',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA ALCIDES MAYA', 15236, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '281',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA, EDUCAÇÃO SUPERIOR E PROFISSIONAL', 15272, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1154',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Brasileira de Ensino, Pesquisa e Extensão', 15280, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1500',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Presidente Antônio Carlos de Ubá', 15357, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1339',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Noroeste do Mato Grosso', 15382, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1946',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade FIPECAFI', 15401, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '393',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Ciencias Humanas e Sociais de Serra Talhada', 15410, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1731',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Direito de Ipatinga', 15451, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1410',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Presidente Antônio Carlos de Conselheiro Lafaiete', 15453, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1117',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Presidente Antônio Carlos de Visconde do Rio Branco', 15467, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1318',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Presidente Antônio Carlos de Leopoldina', 15468, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1426',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE DA INTEGRAÇÃO INTERNACIONAL DA LUSOFONIA AFRO-BRASILEIRA', 15497, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2196',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia SENAI Roberto Simonsen', 15501, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '344',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia SENAI Suiço-Brasileira Paulo Ernesto Tolle', 15502, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '339',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE IRECÊ', 15504, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2509',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO FEDERAL DE EDUCAÇÃO, CIÊNCIA E TECNOLOGIA DE MATO GROSSO DO SUL', 15520, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1275',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE CATÓLICA DE SÃO JOSÉ DOS CAMPOS', 15521, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '635',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO FEDERAL DE EDUCAÇÃO, CIÊNCIA E TECNOLOGIA DO AMAPÁ', 15522, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1847',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE GESTAO E NEGOCIOS DE FORTALEZA', 15526, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '559',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia de Mogi das Cruzes', 15576, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '723',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia Santo André', 15585, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '801',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia de Itaquaquecetuba', 15639, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '886',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE CIÊNCIAS EXATAS DE GARANHUNS', 15669, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1774',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia de Piracicaba', 15682, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '735',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE PIRACICABA', 15682, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '739',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia de Pindamonhangaba', 15687, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '651',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECONOLOGIA DA ZONA SUL', 15688, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '293',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia de Bauru', 15689, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '872',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia de Itapetininga - Prof.Antônio Belizandro Barbosa Rezende', 15693, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '616',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia Dom Amaury Castanho', 15695, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '869',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia de Sertãozinho', 15696, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '770',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia de Araçatuba', 15697, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '795',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia de Capão Bonito', 15704, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '728',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia Dr. Thomaz Novelino', 15708, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '656',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia de Osasco - Prefeito Hirant Sanazar', 15709, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '851',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Fatec Arthur Azevedo - Mogi Mirim', 15714, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '848',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia de São Caetano do Sul', 15745, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '860',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia do Ipiranga', 15746, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '295',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE JABOTICABAL', 15753, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '799',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia de Barueri', 15757, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '674',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia de Jales', 15769, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '778',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SUDOESTE PAULISTA-ITAPETININGA', 15777, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '619',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia Estudante Rafael Almeida Camarinha - Marilia', 15784, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '595',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia de São Sebastião', 15793, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '625',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA DE TATUÍ - PROF. WILSON ROBERTO RIBEIRO DE CAMARGO', 15803, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '841',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE 2001', 15833, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '204',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Católica Paulista', 15859, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '601',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Itaquá', 15873, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '887',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('SOBRESP - Faculdade de Ciências da Saúde', 15894, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1473',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Instituto Superior de Ciencias Policiais', 16037, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '85',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Gran Tietê', 16194, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1166',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia de Carapicuiba', 16395, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '638',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia de Catanduva', 16410, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '780',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE PESTALOZZI DE FRANCA', 16502, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '661',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DUARTE COELHO', 16525, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1105',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Metropolitana do Estado de São Paulo', 16543, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '610',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade do Bico do Papagaio', 16759, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2314',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Rio Sono', 16781, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2189',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Cultura Inglesa', 16864, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '409',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE EDUCAÇÃO E TECNOLOGIA DA AMAZÔNIA', 16898, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2287',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO EDUCATIE', 16901, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '410',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Leonardo da Vinci - Santa Catarina', 16914, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1967',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Melies de Tecnologia', 16934, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '411',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SENAI RIO', 16967, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '511',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('CENTRO SUPERIOR DE ESTUDOS JURÍDICOS CARLOS DRUMMOND DE ANDRADE', 17014, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '413',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Centro Universitário - Católica de Santa Catarina em Joinville', 17138, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1081',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Brasileira de Tributação', 17200, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '284',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Cesmac do Sertão', 17224, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1693',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Cesmac do Agreste', 17226, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '701',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO SUPERIOR DE INOVAÇÃO E TECNOLOGIA', 17269, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '414',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade Teológica Betânia', 17288, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '175',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE GIANNA BERETTA', 17326, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1682',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia CNA', 17401, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '87',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE SANTO AGOSTINHO DE VITÓRIA DA CONQUISTA', 17433, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1323',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE SAÚDE SANTO AGOSTINHO DE VITÓRIA DA CONQUISTA', 17498, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1322',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia do SENAI Horácio Augusto da Silveira', 17516, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '341',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI ROBERTO MANGE', 17690, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '234',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI ROBERTO MANGE', 17690, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '589',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE DE TECNOLOGIA SENAI GASPAR RICARDO JUNIOR', 17691, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '896',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Ciências da Saúde de Serra Talhada', 17775, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1733',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia do Tatuapé', 17942, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '297',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia de Pompeia - Shunji Nishimura', 17953, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '673',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia de Diadema Luigi Papaiz', 18099, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '746',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DO SUL E SUDESTE DO PARÁ', 18440, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1915',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DO OESTE DA BAHIA', 18506, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1971',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DO CARIRI', 18759, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2310',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('UNIVERSIDADE FEDERAL DO SUL DA BAHIA', 18812, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2072',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('Faculdade de Tecnologia de São Roque', 18817, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '711',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('FACULDADE RAIMUNDO MARINHO DE PENEDO', 18874, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1106',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('INSTITUTO MASTER DE ENSINO PRESIDENTE ANTÔNIO CARLOS', 19512, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '686',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('	FACULDADE DE TECNOLOGIA ESTACIO DE SA DE SANTA CATARINA	 ', 3694, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '11458',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('	FACULDADE DE TECNOLOGIA ESTACIO DE SA DE BELO HORIZONTE	 ', 3167, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '17458',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('	FACULDADE PITAGORAS DE DIVINOPOLIS	 ', 5073, null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '9478',  (select max("Id") from public."Escola"));
INSERT INTO public."Escola"("Nome", "CodigoInep", "CidadeId", "Ativo", "Key", "CriadoEm", "AlteradoEm", "TipoCategoria")
	VALUES ('	ASSOCIACAO BRASILEIRA DE ODONTOLOGIA SAO PAULO REGIONAL CATANDUVA	 ', null,null, true, gen_uuid(), current_timestamp, current_timestamp, 1);
INSERT INTO public."IntegracaoEscola"("IntegracaoSistemaId", "CodigoOrigem", "EscolaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '40558',  (select max("Id") from public."Escola"));