INSERT INTO public."Modalidade"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Presencial', true, gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoModalidade"(
	"IntegracaoSistemaId", "CodigoOrigem", "ModalidadeId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'GCX'), '1',  (select max("Id") from public."Modalidade"));

INSERT INTO public."Modalidade"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Semipresencial', true, gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoModalidade"(
	"IntegracaoSistemaId", "CodigoOrigem", "ModalidadeId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'GCX'), '2',  (select max("Id") from public."Modalidade"));

INSERT INTO public."Modalidade"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Live', true, gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoModalidade"(
	"IntegracaoSistemaId", "CodigoOrigem", "ModalidadeId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'GCX'), '3',  (select max("Id") from public."Modalidade"));

INSERT INTO public."Modalidade"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Live 30/70', true, gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoModalidade"(
	"IntegracaoSistemaId", "CodigoOrigem", "ModalidadeId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'GCX'), '4',  (select max("Id") from public."Modalidade"));

INSERT INTO public."Modalidade"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('E2A', true, gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoModalidade"(
	"IntegracaoSistemaId", "CodigoOrigem", "ModalidadeId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'GCX'), '5',  (select max("Id") from public."Modalidade"));

INSERT INTO public."Modalidade"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('100% Digital', true, gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoModalidade"(
	"IntegracaoSistemaId", "CodigoOrigem", "ModalidadeId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'GCX'), '6',  (select max("Id") from public."Modalidade"));

INSERT INTO public."Modalidade"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Integra +', true, gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoModalidade"(
	"IntegracaoSistemaId", "CodigoOrigem", "ModalidadeId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'GCX'), '7',  (select max("Id") from public."Modalidade"));

