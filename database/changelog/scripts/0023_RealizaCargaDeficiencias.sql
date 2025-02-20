INSERT INTO public."Deficiencia"(
	"Nome", "OrdemExibicao", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Cegueira',4, true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoDeficiencia"(
	"IntegracaoSistemaId", "CodigoOrigem", "DeficienciaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '01',  (select max("Id") from public."Deficiencia"));
INSERT INTO public."Deficiencia"(
	"Nome", "OrdemExibicao", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Deficiência Física',3, true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoDeficiencia"(
	"IntegracaoSistemaId", "CodigoOrigem", "DeficienciaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '02',  (select max("Id") from public."Deficiencia"));
INSERT INTO public."Deficiencia"(
	"Nome", "OrdemExibicao", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Não portador de necessidades especiais',1, true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoDeficiencia"(
	"IntegracaoSistemaId", "CodigoOrigem", "DeficienciaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '03',  (select max("Id") from public."Deficiencia"));
INSERT INTO public."Deficiencia"(
	"Nome", "OrdemExibicao", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Deficiência Auditiva',2, true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoDeficiencia"(
	"IntegracaoSistemaId", "CodigoOrigem", "DeficienciaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '04',  (select max("Id") from public."Deficiencia"));
INSERT INTO public."Deficiencia"(
	"Nome", "OrdemExibicao", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Altas habilidades / Superdotação',5, true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoDeficiencia"(
	"IntegracaoSistemaId", "CodigoOrigem", "DeficienciaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '05',  (select max("Id") from public."Deficiencia"));
INSERT INTO public."Deficiencia"(
	"Nome", "OrdemExibicao", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Baixa Visão',6, true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoDeficiencia"(
	"IntegracaoSistemaId", "CodigoOrigem", "DeficienciaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '06',  (select max("Id") from public."Deficiencia"));
INSERT INTO public."Deficiencia"(
	"Nome", "OrdemExibicao", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Transtorno do Espectro Autista - TEA',null, true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoDeficiencia"(
	"IntegracaoSistemaId", "CodigoOrigem", "DeficienciaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '16',  (select max("Id") from public."Deficiencia"));
INSERT INTO public."Deficiencia"(
	"Nome", "OrdemExibicao", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Deficiência Intelectual/Mental',7, true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoDeficiencia"(
	"IntegracaoSistemaId", "CodigoOrigem", "DeficienciaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '08',  (select max("Id") from public."Deficiencia"));
INSERT INTO public."Deficiencia"(
	"Nome", "OrdemExibicao", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Deficiência Múltipla',9, true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoDeficiencia"(
	"IntegracaoSistemaId", "CodigoOrigem", "DeficienciaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '10',  (select max("Id") from public."Deficiencia"));
INSERT INTO public."Deficiencia"(
	"Nome", "OrdemExibicao", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Síndrome de Asperger',10, true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoDeficiencia"(
	"IntegracaoSistemaId", "CodigoOrigem", "DeficienciaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '11',  (select max("Id") from public."Deficiencia"));
INSERT INTO public."Deficiencia"(
	"Nome", "OrdemExibicao", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Síndrome de Rett',11, true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoDeficiencia"(
	"IntegracaoSistemaId", "CodigoOrigem", "DeficienciaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '13',  (select max("Id") from public."Deficiencia"));
INSERT INTO public."Deficiencia"(
	"Nome", "OrdemExibicao", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Surdez',12, true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoDeficiencia"(
	"IntegracaoSistemaId", "CodigoOrigem", "DeficienciaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '12',  (select max("Id") from public."Deficiencia"));
INSERT INTO public."Deficiencia"(
	"Nome", "OrdemExibicao", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Surdocegueira',13, true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoDeficiencia"(
	"IntegracaoSistemaId", "CodigoOrigem", "DeficienciaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '14',  (select max("Id") from public."Deficiencia"));
INSERT INTO public."Deficiencia"(
	"Nome", "OrdemExibicao", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Transtorno Desintegrativo da Infância',14, true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoDeficiencia"(
	"IntegracaoSistemaId", "CodigoOrigem", "DeficienciaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '15',  (select max("Id") from public."Deficiencia"));
INSERT INTO public."Deficiencia"(
	"Nome", "OrdemExibicao", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Portador de necessidades especiais',null, true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoDeficiencia"(
	"IntegracaoSistemaId", "CodigoOrigem", "DeficienciaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '17',  (select max("Id") from public."Deficiencia"));
INSERT INTO public."Deficiencia"(
	"Nome", "OrdemExibicao", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Transtorno de Déficit de Atenção e Hiperatividade (TDAH)',null, true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoDeficiencia"(
	"IntegracaoSistemaId", "CodigoOrigem", "DeficienciaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '18',  (select max("Id") from public."Deficiencia"));
INSERT INTO public."Deficiencia"(
	"Nome", "OrdemExibicao", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Síndrome genética (Down, Turner, entre outras)',null, true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoDeficiencia"(
	"IntegracaoSistemaId", "CodigoOrigem", "DeficienciaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '19',  (select max("Id") from public."Deficiencia"));
INSERT INTO public."Deficiencia"(
	"Nome", "OrdemExibicao", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Deficiência Física (Nanismo, Mobilidade reduzida e outras)',null, true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoDeficiencia"(
	"IntegracaoSistemaId", "CodigoOrigem", "DeficienciaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '20',  (select max("Id") from public."Deficiencia"));
INSERT INTO public."Deficiencia"(
	"Nome", "OrdemExibicao", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Transtorno de Aprendizagem (Dislexia, discalculia, disortografia)',null, true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoDeficiencia"(
	"IntegracaoSistemaId", "CodigoOrigem", "DeficienciaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '21',  (select max("Id") from public."Deficiencia"));
INSERT INTO public."Deficiencia"(
	"Nome", "OrdemExibicao", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Doença degenerativa (ELA, esclerose múltipla, Parkison, Alzheimer)',null, true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoDeficiencia"(
	"IntegracaoSistemaId", "CodigoOrigem", "DeficienciaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '22',  (select max("Id") from public."Deficiencia"));
INSERT INTO public."Deficiencia"(
	"Nome", "OrdemExibicao", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Déficit do Processamento Auditivo Central (DPAC)',null, true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoDeficiencia"(
	"IntegracaoSistemaId", "CodigoOrigem", "DeficienciaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '23',  (select max("Id") from public."Deficiencia"));
INSERT INTO public."Deficiencia"(
	"Nome", "OrdemExibicao", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Sequelas de doenças cerebrovasculares AVC.',null, true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoDeficiencia"(
	"IntegracaoSistemaId", "CodigoOrigem", "DeficienciaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '24',  (select max("Id") from public."Deficiencia"));