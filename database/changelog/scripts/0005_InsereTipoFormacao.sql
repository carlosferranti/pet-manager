INSERT INTO public."TipoFormacao"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Graduação', true, gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTipoFormacao"(
	"IntegracaoSistemaId", "CodigoOrigem", "TipoFormacaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'GCX'), '1',  (select max("Id") from public."TipoFormacao"));

INSERT INTO public."TipoFormacao"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Graduação Medicina', true, gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTipoFormacao"(
	"IntegracaoSistemaId", "CodigoOrigem", "TipoFormacaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'GCX'), '2',  (select max("Id") from public."TipoFormacao"));

INSERT INTO public."TipoFormacao"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Pós-Graduação', true, gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTipoFormacao"(
	"IntegracaoSistemaId", "CodigoOrigem", "TipoFormacaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'GCX'), '3',  (select max("Id") from public."TipoFormacao"));