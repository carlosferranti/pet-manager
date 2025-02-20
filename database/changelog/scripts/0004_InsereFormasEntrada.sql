INSERT INTO public."FormaEntrada"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Vestibular tradicional', true, gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoFormaEntrada"(
	"IntegracaoSistemaId", "CodigoOrigem", "FormaEntradaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'GCX'), '2',  (select max("Id") from public."FormaEntrada"));

INSERT INTO public."FormaEntrada"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Entrada simplificada', true, gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoFormaEntrada"(
	"IntegracaoSistemaId", "CodigoOrigem", "FormaEntradaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'GCX'), '3',  (select max("Id") from public."FormaEntrada"));

INSERT INTO public."FormaEntrada"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Decisão Judicial', true, gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoFormaEntrada"(
	"IntegracaoSistemaId", "CodigoOrigem", "FormaEntradaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'GCX'), '5',  (select max("Id") from public."FormaEntrada"));

INSERT INTO public."FormaEntrada"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Obtenção de Novo Título', true, gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoFormaEntrada"(
	"IntegracaoSistemaId", "CodigoOrigem", "FormaEntradaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'GCX'), '7',  (select max("Id") from public."FormaEntrada"));

INSERT INTO public."FormaEntrada"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Reopção de Curso', true, gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoFormaEntrada"(
	"IntegracaoSistemaId", "CodigoOrigem", "FormaEntradaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'GCX'), '9',  (select max("Id") from public."FormaEntrada"));

INSERT INTO public."FormaEntrada"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Retorno', true, gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoFormaEntrada"(
	"IntegracaoSistemaId", "CodigoOrigem", "FormaEntradaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'GCX'), '10',  (select max("Id") from public."FormaEntrada"));

INSERT INTO public."FormaEntrada"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Mérito Enem', true, gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoFormaEntrada"(
	"IntegracaoSistemaId", "CodigoOrigem", "FormaEntradaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'GCX'), '6',  (select max("Id") from public."FormaEntrada"));

INSERT INTO public."FormaEntrada"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Transferência Externa', true, gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoFormaEntrada"(
	"IntegracaoSistemaId", "CodigoOrigem", "FormaEntradaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'GCX'), '11',  (select max("Id") from public."FormaEntrada"));

INSERT INTO public."FormaEntrada"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Enem', true, gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoFormaEntrada"(
	"IntegracaoSistemaId", "CodigoOrigem", "FormaEntradaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'GCX'), '1',  (select max("Id") from public."FormaEntrada"));

INSERT INTO public."FormaEntrada"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('COI', true, gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoFormaEntrada"(
	"IntegracaoSistemaId", "CodigoOrigem", "FormaEntradaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'GCX'), '4',  (select max("Id") from public."FormaEntrada"));

INSERT INTO public."FormaEntrada"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Pós-Graduação', true, gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoFormaEntrada"(
	"IntegracaoSistemaId", "CodigoOrigem", "FormaEntradaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'GCX'), '8',  (select max("Id") from public."FormaEntrada"));