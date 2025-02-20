INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Contagem/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AA',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Curitiba/PR - Parceiro Una', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AB',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Curvelo/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AC',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Divinópolis/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AD',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Florianopolis/SC - Parceiro Una', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AE',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Frutal/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AF',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Governador Valadares/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AG',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Ipatinga/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AH',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Itabira/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AI',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Itajubá/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AJ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Itaúna/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AK',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Ituiutaba/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AL',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Iturama/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AM',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Janaúba/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AN',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Januária/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AO',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo João Monlevade/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AP',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Joinville/SC - Parceiro Una', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AQ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Juiz De Fora/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AR',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Lavras/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AS',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Manhuaçu/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AT',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Montes Claros/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AU',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Muriaé/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AV',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Conselheiro Lafaiete - IMEC', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AW',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Nova Lima/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AX',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Conselheiro Lafaiete - FACEB', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AY',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Oliveira/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'AZ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Park Shopping ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'A1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Laguna', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'a1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Verde', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'A2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Imbituba', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'a2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Cubatão', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'A3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Descontinuado - Unidade Acadêmica Trajano', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'a3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Balneário Camboriú', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'A4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Aimorés', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'A5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('HSMU - São Judas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'A6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Anita Garibaldi/SC', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'A9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Ouro Preto/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BA',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Pará De Minas/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BB',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Paracatú/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BC',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Passos/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BD',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Patos de Minas/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BE',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Patrocínio/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BF',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Pedro Leopoldo/MG -Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BG',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Pirapora/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BH',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Poços de Caldas/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BI',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Ponte Nova/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BJ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Pouso Alegre/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BK',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo São Sebastião do Paraíso/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BL',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Salinas/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BM',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo São João Del Rei/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BN',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo São Lourenço/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BO',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Sete Lagoas/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BP',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Teófilo Otoni/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BQ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Uberaba/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BR',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Uberlândia/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BS',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Varginha/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BT',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Belo Horizonte/MG - Parceiro Una', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BU',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Betim/MG - Parceiro Una', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BV',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Conselheiro Lafaiete - Brasil Educação', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BW',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Campinas/SP - Parceiro Una', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BX',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Avenida Paulista', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BY',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Contagem/MG - Parceiro Una', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'BZ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Una Cristiano Machado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'B1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Milton Campos - Adm', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'b1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Cristiano Machado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'B2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica IA (Una)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'B3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Jacobina', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'B4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Jeremoabo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'B5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Lagarto', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'B6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Senhor do Bonfim', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'B7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Paripiranga', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'B8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tucano', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'B9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Divinópolis/MG - Parceiro Una', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'CA',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Santos/SP - Parceiro Una', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'CB',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica UniBH', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ÇB',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo São Paulo/SP - Parceiro Una', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'CC',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Pouso Alegre - pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ÇC',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Sete Lagoas/MG - Parceiro Una', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'CD',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Unisociesc', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ÇD',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Sorocaba/SP - Parceiro Una', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'CE',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Unicuritiba', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ÇE',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Boa Vista - Campus Park', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'CF',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Florianópolis', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ÇF',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Anita Garibaldi', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'CG',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Balneário Camboriú', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'CH',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Pinheirinho', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'CI',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Unifacs', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ÇI',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Descontinuado - Florianópolis - Faculdade', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'CJ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Blumenau', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'CK',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica São Judas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ÇK',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Florianópolis/SC - Sociesc  ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'CL',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Ilha - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'çl',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Joaçaba/SC - Ceb - Cursos E Consultoria ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'CM',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Catalão - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ÇM',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Maringa/PR - Opcao Tec', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'CN',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Contagem - pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ÇN',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Açailandia/MA - Ati Treinamento E Qualificação    ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'CO',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Anhembi Morumbi', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ÇO',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Guanambi - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ço',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Alegrete/RS - Futura Centro Educacional  - Censupeg', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'CP',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tambiá - pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ÇP',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Vila Mathias - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'çp',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Altamira/PA - Norte Rios Consultoria ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'CQ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Fpb', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ÇQ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Anita Garibaldi/SC - Cen. Ed. Sonho Meu  - Censupeg', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'CR',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Ibmr', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ÇR',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Aracaju/SE - Conjuntos Edu Multidiscip - Censupeg', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'CS',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Unisul', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ÇS',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Araguari/MG - Escola Educare       ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'CT',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica UniFG (PE)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ÇT',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Arapiraca/AL - Nca - Nucleo De Cultura Avancada    ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'CU',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Ararangua/SC - Censupeg        ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'CV',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Ages', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ÇV',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Uniritter', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ÇW',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Arcos/MG - Eldorado Sistema De Ensino         ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'CX',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Unp', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ÇY',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Arcoverde/PE - Foco Comercial - Solucoes Em Educacao ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'CZ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Cajazeiras', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'C0',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Milton Campos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Ç0',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Irecê', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'C1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Uam Ead', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'c1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Jacobina - Medicina', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'C2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Vale do Anhangabaú', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'c2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Milton Vianna Filho', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'C3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('In Company', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'c3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('São Judas Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'C4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisul Florianópolis Ilha Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'C5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Florianópolis Ilha', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'C6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Florianópolis Ilha', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'C7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Florianópolis Ilha - Faculdade', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'C8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Milton Vianna Filho - Rebouças', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'C9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Bage/RS - Rede Tc Cursos    ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DA',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Balneario Camboriu/SC - Flc/Sociesc    ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DB',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Barra De São Francisco/ES - União De Ensino São Fran', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DC',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Barra Velha/SC - Instituto Priamo - Anexo Apae     ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DD',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Barreiras/BA - Censupeg     ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DE',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Barretos/SP - Censupeg         ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DF',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Bauru/SP - Censupeg      ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DG',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Belem/PA - Censupeg          ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DH',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Belo Horizonte/MG - Centro Universitário Una  ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DI',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Belo Horizonte/MG - Ieb-Instituto Educacional Bh   ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DJ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Belo Horizonte/MG - Unibh Centro Universitário BH', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DK',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Belo Jardim/PE - Colégio Exito - Grupo Acesso      ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DL',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Betim/MG - Eldorado Sistema De Ensino         ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DM',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Botucatu/SP - Rosa Elena Seabra Gaspar - Censupeg  ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DN',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Brasilia/DF - Qualittas - Unisociesc   ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DO',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Brumadinho/MG - Ame Brumadinho     ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DP',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Caçapava Do Sul/RS - Rede Tc Cursos         ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DQ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Campinas/SP - Caep - Centro A. Do Ensino Profissi. ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DR',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Campinas/SP - Qualittas - Unisociesc         ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DS',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Campo Grande/MS-Centro Informática Para Crianças   ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DT',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Campos Novos/SC - Online Cursos E Treinamentos Ceb ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DU',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Canela/RS - Censupeg          ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DV',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Canoas/RS - Associação Educacional Rui Barbosa        ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DX',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Canoinhas/SC - Dama Centro Regional De Ensino Tecnico ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DY',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Caxias Do Sul/RS - Instituto Paideia   ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'DZ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Una Cristiano Machado Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'D0',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Faseh', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'D1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('In Company Ead', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'd1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Una Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'D2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Una Aimorés Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'D3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Una Barreiro Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'D4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Una Betim Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'D5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Una Bom Despacho Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'D6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Una Catalão Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'D7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Una Conselheiro Lafaiete Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'D8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Una Contagem Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'D9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Chalé/MG - Centro Universitário De Chalé  ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'EA',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Conselheiro Lafaiete/MG - Cmrx Cons. Treinamento    ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'EB',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Contagem/MG - Eldorado Sistema De Ensino         ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'EC',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Corupa/SC - Unisociesc Sao Bento Do Sul          ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ED',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Criciuma/SC - Maria Estela Buss  - Censupeg    ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'EE',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Cruz Alta/RS - Censupeg      ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'EF',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Cuiabá/MT - Censupeg  ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'EG',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Curitiba/PR - Sociesc      ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'EH',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Divinopolis/MG - Eldorado Sistema De Ensino        ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'EI',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Feira De Santana/BA - Ibex Edu       ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'EJ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Formiga/MG - Eldorado Sistema De Ensino    ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'EK',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Fortaleza/CE - Dnc Denacon Desenv. Prof. E Empres', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'EL',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Francisco Beltrão/PR - Colégio Aliança      ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'EM',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Garanhuns/PE - Col. Xv De Novembro Acesso Nordeste ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'EN',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Goiânia/GO - Colégio Aristóteles   ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'EO',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Goiania/GO - Qualittas - Unisociesc         ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'EP',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Governador Valadares/MG - Censupeg       ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'EQ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Gramado/RS - Acvm Cursos E Concursos   ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ER',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Guanhaes/MG - Iesge - Inst. De Ens. E Gest. Educa. ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ES',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Guarulhos/SP - Censupeg  ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ET',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Imbituba/SC - Instituto Foco - Coopeimb      ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'EU',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Imperatriz/MA - Censupeg   ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'EV',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Irineópolis/SC  - Censupeg        ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'EW',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Indaiatuba/SP - Centro Educacional Indaiatuba      ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'EX',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Itajuba/MG - Inedita      ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'EY',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Itapema/SC - Centro De Estudos Unilas Itapema Ltda ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'EZ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Una Uberlândia Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'E0',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Nascimento de Castro', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'é0',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Una Divinópolis Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'E1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Floriano Peixoto', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'é1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Parnamirim', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'è1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Guajajaras', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'E2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Floriano Peixoto', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'é2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Parnamirim', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'è2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Una Itabira Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'E3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Fortaleza', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'é3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Caicó', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'è3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Una Itumbiara Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'E4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Canoas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'é4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Caicó', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'è4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Una Jataí Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'E5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Recife', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'é5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Currais Novos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'è5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Una Liberdade Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'E6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Uninorte', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'é6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Limoeiro do Norte', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'è6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Una Linha Verde Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'E7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Porto Alegre', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'é7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Pau dos Ferros', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'è7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Una Pouso Alegre Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'E8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Nascimento de Castro', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'è8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Una Sete Lagoas Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'E9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Parnamirim', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'è9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Itauna/MG - Eldorado Sistema De Ensino', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FA',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Jaragua Do Sul/SC - Acijs            ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FB',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Jaragua Do Sul/SC - Censupeg  ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FC',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Joinville/SC - Unisociesc - Anita Garibaldi', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FD',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Juiz De Fora/MG - Eldorado Sistema De Ensino       ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FE',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Juquiá/SP  - Censupeg      ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FF',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Lages/SC - Mário Cesar Costa Dos Santos Silva', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FG',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Lajeado/RS  - Censupeg            ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FH',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Lauro De Freitas/BA - Ibex Edu           ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FI',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Maceio/AL - Nca - Nucleo De Cultura Avancada     ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FJ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Mairinque/SP - Censupeg   ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FK',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Manaus/AM - Instituto Abare-Ete            ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FL',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Marabá/PA - B R Viana Serviços Escola Disneylândia ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FM',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Marília/SP - Gw7 Educacional        ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FN',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Martinho Campos/MG - Criatividade Centro Educacion ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FO',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Maua/SP -  Censupeg           ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FP',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Monte Alegre/PA - B R Viana Serviços - Me   ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FQ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Montes Claros/MG - Durães E Câmara Ltda           ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FR',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Niteroi/RJ - Curso Vitec ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FS',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Nova Petrópolis/RS - Censupeg        ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FT',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Nova Prata/RS - Master Treinamentos E Idiomas     ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FU',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Novo Hamburgo/RS - Escola Conquistadora          ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FV',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Oriximina/PA - Escola Balão Mágico', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FW',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Oriximina/PA - B R Viana - Colégio Magia Do Saber  ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FX',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Osasco/SP - Censupeg             ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FY',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Ouro/SC - Centro Educar Brasil   ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'FZ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Uniages Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'F0',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Uniages Jacobina Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'F1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('São Bento do Sul', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'F2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Uniages Lagarto Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'F3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Uniages Paripiranga Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'F4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Uniages Senhor Do Bonfim Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'F5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Uniages Tucano Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'F6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('São Judas Butantã Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'F7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('São Judas Guarulhos Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'F8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Conselheiro Lafaiete - Faculdade de Agronomia', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'F9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Palmas/TO - Skill Idiomas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'GA',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Passos/MG - Polo Ead (Karina Olineira)       ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'GB',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Pelotas/RS - Valente Balreira Ltda         ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'GC',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Petrolina/PE  - Censupeg                            ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'GD',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Petropolis/RJ - Interativa - Vale e Valle           ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'GE',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Conselheiro Lafaiete - Escola Superior', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'GG',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Porto Velho/RO - Multi Service Apoio Educ. Pedag. ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'GH',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Presidente Prudente/SP - Gw7 Educacional        ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'GI',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Quedas Do Iguaçú/PR - Esc.Mun. Santos Dumont (Priamo) ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'GJ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Recife/PE - BIT2D TECNOLOGIA LTDA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'GK',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Regente Feijo/SP - Colégio Exito De Ensino Fundamt ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'GL',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Ribeirao Preto/SP - Qualittas - Unisociesc       ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'GM',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Rio De Janeiro/RJ  - Censupeg            ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'GO',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Jataí/GO', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Go',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Rio De Janeiro/RJ - Clube De Engen. Rio De Janeiro ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'GP',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Rio De Janeiro/RJ - Eldorado Sistema De Ensino    ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'GR',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Rio De Janeiro/RJ - Qualittas - Unisociesc           ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'GS',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Salvador/BA - Censupeg                   ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'GT',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Salvador/BA - Ibex Edu          ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'GU',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Santa Luzia/MG - Eldorado Sistema De Ensino  ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'GV',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Santa Rosa/RS -Censupeg        ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'GX',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Santarem/PA - B R Viana Serviços - Me              ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'GZ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('São Judas Jabaquara Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'G0',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Jataí', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'G1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisul - Campus Pedra Branca', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'G2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('São Judas Mooca Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'G3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('São Judas Paulista Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'G4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('São Judas Santana Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'G5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('São Judas Santo Amaro Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'G6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('São Judas São Bernardo Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'G7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('São Judas Santos Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'G8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('São Judas Vila Leopoldina Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'G9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Santiago/RS - Ibex            ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HA',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Santo André/SP - Censupeg               ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HB',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Santos/SP - Centro Universitário Monte Serrat   ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HC',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo São Bernardo do Campo/SP - Juri Assessoria       ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HD',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Sao Fidelis/RJ - Censupeg                           ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HE',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo São Gabriel/RS - Rede Tc Cursos  ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HF',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo São José Do Rio Preto/SP - Alameda Cursos    ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HG',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo São José Do Rio Preto/SP - Masa Cursos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HH',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Sao Jose Dos Campos/SP - Censupeg            ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HI',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Sao Jose Dos Campos/SP - Recovale Treinamentos     ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HJ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Sao Jose Dos Pinhais/PR - Tcc Treinamento Ead S/A  ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HK',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Sao Jose/SC - Unisociesc Continente Park Shopping  ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HL',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Sao Luis/MA - Censupeg  ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HM',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo São Miguel Do Oeste/SC - Cursos Local X           ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HN',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Negocios         ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HO',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Sao Paulo/SP - Qualittas - Unisociesc          ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HP',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Sao Vicente/SP - Alameda Cursos       ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HQ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Sapucaia Do Sul/RS - Educar Ead        ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HR',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Serafina Correa/RS - Censupeg                      ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HS',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Sobral/CE - Ceprosu - Executivo                    ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HT',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Sobral/CE - Rede Ares Serviços  ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HU',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Sonora/MS - Censupeg    ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HV',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Teresina/PI - Censupeg    ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HX',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Tijucas/SC - Centro De Estudos Unilas Tijucas      ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HY',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Tres Lagoas/MS - Educameschi Tutoria Em Educacao   ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'HZ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisociesc Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'H0',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisociesc Anita Garibaldi Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'H1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisociesc Balneário Camboriú Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'H2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisociesc Blumenau Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'H3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisociesc Florianópolis Continente Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'H4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisociesc Florianópolis Ilha Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'H5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisociesc Itajaí Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'H6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisociesc Jaraguá do Sul Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'H7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisociesc São Bento do Sul Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'H8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Guanambi - São Sebastião', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'H9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Uberlândia/MG - Eldorado Sistema De Ensino  ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'IA',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Varginha/MG - Integra Soluções A. E C - Censupeg ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'IB',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Vera Cruz/RS - Marcia Gewehr - Censupeg', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'IC',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Vitoria Da Conquista/BA - Unisociesc - Hf Educacional ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ID',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Vitoria/ES - Centro Educacional Dom Fernando   ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'IE',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Bituruna/PR', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'IF',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Blumenau/SC', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'IG',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Capivari de Baixo/SC', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'IH',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Carlópolis/PR', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'II',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Cascavel/PR', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'IJ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Castro/PR', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'IK',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Chapecó/SC', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'IL',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Cruzeiro do Oeste/PR', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'IM',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Curitiba/PR', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'IN',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Florianópolis/SC', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'IO',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo São Gotardo/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'IP',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Itajaí/SC', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'IQ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Joaçaba/SC ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'IR',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Maringá/PR', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'IS',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Matinhos/PR', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'IT',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Ortigueira/PR', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'IU',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Paranavai/PR', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'IV',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Porto Alegre/RS', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'IW',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Pato Branco/PR', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'IX',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo São Bento do Sul/SC', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'IY',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica IA (Usjt)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'IZ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Botafogo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'I1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica São José Dos Campos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'I2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Jaraguá do Sul - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JA',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('São Bento do Sul - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JB',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Rio do Sul', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JC',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Itajaí - Faculdade', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JD',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Joinville', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JE',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Joinville/SC - Sociesc', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JF',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Petropolis/RJ - Interativa', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JG',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Arcos/MG - Eldorado Sistema de Ensino', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JH',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Mafra', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JI',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Corupa/SC - Marisa Kuhl Judachewsky', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JJ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Betim/MG - Elan Empreendimentos Culturais L. A. Nunes', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JK',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Campo Grande/MS-DMT Serv. Tecnicos Especializados e Dig', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JL',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Campos Novos/SC - CEB - Cursos e Consultoria ltda - ME', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JM',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Carlopolis/PR - Escola Maggic Lan 2', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JN',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Concórdia/SC - CEB - Cursos e Consultoria ltda - ME', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JO',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Cruzeiro D''Oeste/PR- L.M. da Silva Francisco & CIA LTDA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JP',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Curitiba/PR- IBED Inst. Bras. de EAD LTDA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JQ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Dourados/MS - CENSUPEG', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JR',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Francisco Beltrão/PR - Instituto Priamo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JS',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Garanhuns/PE - Foco Comercial', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JT',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Guanhães/MG - Sociedade Educacional Cidade de Guanhães', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JU',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Indaiatuba/SP- CAEP', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JV',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Paranavaí/PR - TCC Educacional', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JW',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Matinhos/PR - Andrea Cristina Mendes Gomes ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JX',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Oriximina/PA - B R VIANA - Distrito Porto Trombetas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JY',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Barro Preto/MG - Noite', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'JZ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Itajaí - Centro de Ensino', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'J1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisul - Campus Tubarão', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'J2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisul - Campus Araranguá', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'J3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisul - Campus Braço do Norte', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'J4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisul - Campus Içara', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'J5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisul - Campus Florianópolis', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'J6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Ebradi - São Judas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'J7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('IBCMED', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'J8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisul Araranguá Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '!K',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Itumbiara - Faculdade', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '.K',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Contagem/MG - Noite', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'KA',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Santos/SP - Noite', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'KB',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Santos/SP - Manhã', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'KC',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Pato Branco/PR - Instituto Priamo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'KD',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Pinhais/PR - Jose de Freitas Trancoso - Escola Peter PA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'KE',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Quedas do Iguaçú/PR - Instituto Priamo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'KF',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Ribeirão Preto/SP - SISTEMA DE ENSINO D.ALCANCE', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'KG',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo São Gabriel/RS - Gonçalves e Ferreira - Rede TC', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'KH',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo São Jorge D''Oeste/PR - Instituto Priamo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'KI',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo São José/SC - SOCIESC - UNIDADE SÃO JOSÉ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'KJ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo São Leopoldo/RS - Escola Conquistadora', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'KK',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Uberlândia/MG - UBER - Empreendimentos Culturais LTDA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'KL',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Blumenau/SC - Noite', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'KM',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo São Bento do Sul/SC - Noite', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'KN',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Florianópolis Ilha/SC - Noite', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'KO',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Brasilia/ DF - Centro Educacional de Inteligência Unive', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'KP',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Pouso Alegre', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'KQ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Foz do Iguaçu/PR -  Cursos a Distância Telessala', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'KR',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Capivari de Baixo/SC - APAE ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'KS',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo São Paulo/SP - São Judas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'KT',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Pinheirinho/PR - Noite', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'KU',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Jaraguá do Sul/SC - Unisociesc', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'KV',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Florianópolis Continente', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'KW',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Recife/PE', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'KZ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Perini', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'K1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Curitiba - Pr - Sociesc', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'K2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Porto Alegre\Rs - Colégio Método', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'K3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Paranavai/Pr - Brasil do Saber - Po', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'K4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Matinhos/Pr - Centro de Apoio Em Ea', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'K5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Castro\Pr - Cdi Infomática', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'K6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Ortigueira/Pr - Academia Washington', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'K7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo São Bento do Sul - Sc - Sociesc', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'K8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Florianópolis - Sociesc', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'K9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Divinópolis/MG - Noite', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LA',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Nova Serrana/MG', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LB',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Ebradi - Una', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LC',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Una', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LÇ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Aracaju/SE - CCM Cursos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LD',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo São João Batista/SC - Educomp', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LE',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Karaíba', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LF',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Uberlândia - Centro', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LG',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Catalão', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LH',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Ubá/MG - Seletra Treinamento e Consultoria Ltda', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LI',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Estoril', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'li',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Cataguases/MG - Possani Basiliio Corretora de Seguros', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LJ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Barbacena/MG - Imppacto Cursos e Concursos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LK',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Leopoldina/MG - Curso Razão', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LL',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Itajaí/SC - Noite', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LM',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Karaíba/Noite', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LN',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Sete Lagoas/Noite', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LO',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Pouso Alegre/Noite', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LP',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Divinópolis - Noite', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LQ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Milton Campos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Lq',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Santo Antônio/Noite', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LR',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Itabira/MG - Noite', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LS',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Jataí/GO - Noite', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LT',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Jataí/GO - Manhã', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LU',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Linha Verde/MG - Noite', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LV',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Itabira - Instituto', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LW',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Itabira', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LX',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Itabira - Escola Superior', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LZ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Capivari de Baixo - Master Educação', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'L0',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Cascavel\Pr - Fundação Iguaçú', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'L1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Joaçaba/Sc - Ceb - Cursos e Consult', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'L2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Carlópolis\Pr - Centro Educacional', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'L3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Joinville - Sociesc', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'L4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Bituruna - Escola Frei Tiago Luches', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'L5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Pato Branco/Pr - Colegio Carlos Alm', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'L6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Francisco Beltrão - Colégio Aliança', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'L7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Itajaí/Sc - Icped Inst. Capac. Prof', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'L8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Blumenau - Sc - Sociesc', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'L9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Nova Serrana - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'MA',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Florianópolis Ilha/SC - Manhã', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'MB',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Blumenau/SC - Manhã', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'MC',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Palácio Avenida', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'MD',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Jaraguá do Sul/SC - Noite', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ME',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Jaraguá do Sul/SC - Manhã', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'MF',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Itajaí/SC - Manhã', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'MG',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Santos/Manhã', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'MH',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Santos/Noite', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'MI',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unimonte', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'MJ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Nova Serrana', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'MK',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Faced - Divinópolis', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'MM',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Jataí - Centro de Estudos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'MN',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Contagem - Centro de Ensino', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'MO',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Catalão - Centro de Ensino', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'MP',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Divinópolis - Centro de Ensino', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'MQ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Nova Serrana - Centro de Ensino', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'MR',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Sete Lagoas - Centro de Ensino', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'MS',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Pouso Alegre - Escola Superior', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'MT',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Catalão - Escola Superior', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'MU',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Mooca - Instituto', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'MX',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Butantã - Instituto', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'MY',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Itabira - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'MZ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Chapeco/Sc - Hcjb Assessoria Pedagó', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'M0',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Cruzeiro do Oeste/Pr- Escola Mundo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'M1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Maringa/Pr - Opcao Tec', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'M2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Catete', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'M3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Canoas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'M4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Cavalhada', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'M5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Fapa', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'M6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Zona Sul', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'M7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Tambiá', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'M8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Conselheiro Lafaiete', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'NA',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Faseh', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'NZ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Caicó', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'N1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('São José', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'N2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Currais Novos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'N3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Limoeiro do Norte', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'N4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Mossoró', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'N5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Pau dos Ferros', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'N6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Roberto Freire', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'N7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Salgado Filho', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'N8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Zona Norte', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'N9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Santo Amaro', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'OA',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Paulista', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'OB',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Jabaquara', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'OC',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Bom Despacho', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'OD',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Zona Norte - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'OL',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Campus Park - Boa Vista', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'OP',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Zona Norte - João Medeiros', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'O1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Comércio', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'O2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Lapa', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'O3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Centro', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'O4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Cavalhada', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'O5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Santa Mônica', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'O6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Betim/MG - Noite', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PA',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Limeira', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PB',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Guarulhos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PC',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica São Bernardo do Campo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PD',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Conselheiro Lafaiete', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PE',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Itumbiara', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PF',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Catalão - Centro Superior', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PG',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Catalão - Instituto', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PH',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Catalão', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PI',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Blumenau', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PJ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Florianópolis Continente', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PK',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Itajaí', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PL',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Jaraguá do Sul (Park Shopping)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PM',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Anita Garibaldi', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PN',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Palácio Avenida', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PO',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Pinheirinho', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PP',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica São Bento do Sul', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PQ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Barreiro', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PR',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Betim', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PS',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Bom Despacho', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PT',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Santo Antônio', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PU',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Itabira', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PV',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Guarulhos - Centro Universitário', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PW',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Jataí', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PX',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Sete Lagoas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PY',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Uberlândia - Centro', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'PZ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Canoas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'P1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Cavalhada', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'P2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Fapa', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'P3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Iguatemi', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'P4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Zona Sul', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'P5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('FADERGS Centro', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'P6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('FPB', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'P7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Barra', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'P8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Botafogo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'P9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Pouso Alegre', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QA',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Butantã', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QB',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Jabaquara', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QC',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Mooca', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QD',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Paulista', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QE',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Santo Amaro', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QF',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Vila Leopoldina', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QG',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Fadergs', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Qg',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Conselheiro Lafaiete - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QH',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Itumbiara - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QI',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Curitiba/PR - Pinheirinho', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QJ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Curitiba/PR - Palácio Avenida', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QK',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Jaraguá do Sul/SC', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QL',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Balneário Camboriú/SC', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QM',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Contagem', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QN',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Divinópolis', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QO',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Linha Verde', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QP',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Nova Serrana/MG', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QQ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('HSMU - Una', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QR',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Butantã - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QS',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Mooca - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QT',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Guarulhos - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QU',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Jabaquara - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QV',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Paulista - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QX',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Karaíba', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QY',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica UniBH Cristiano Machado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'QZ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Catete', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Q1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Milton Campos - Direito', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Q2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Avenida Paulista', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Q3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Centro (Mooca)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Q4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Morumbi', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Q5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Paulista II', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Q6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Piracicaba', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Q7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('São José dos Campos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Q8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Vila Olímpia', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Q9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Santana - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'RA',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Santo Amaro - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'RB',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Santos - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'RC',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica São Bernardo do Campo - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'RD',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Vila Leopoldina - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'RE',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Buritis - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'RF',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica João Pinheiro I', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'RG',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Bom Despacho - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'RH',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Jataí - 2', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'RI',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Itacorubi', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'RJ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Paripiranga', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'RK',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Jacobina', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'RL',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Jeremoabo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'RM',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Lagarto', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'RN',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Senhor do Bonfim', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'RO',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Tucano', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'RP',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Milton Vianna Filho', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'RQ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Pinheirinho - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'RS',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Liberdade', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'RT',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Buritis', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'RZ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Comércio', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'R1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Getúlio Vargas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'R2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Lapa', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'R3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Avenida Paulista', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'R4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Rio Vermelho', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'R5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Santa Mônica', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'R6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tancredo Neves', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'R7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Boa Vista', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'R8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Irecê', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'R9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Santana', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ST',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Santana', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'SU',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Aimorés - BD', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'SX',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Piedade', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'S1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Mossoró', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'S2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Roberto Freire', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'S3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Salgado Filho', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'S4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Zona Norte', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'S5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Professor Barros', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'S6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tucuruí', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'TU',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Rio Vermelho', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'T1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Getúlio Vargas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'T2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Jacobina - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Ui',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Milton Campos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'UK',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Descontinuado - Unidade Acadêmica Florianópolis Ilha', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'UY',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Criciúma', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'U6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Criciúma - Instituto', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'U7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Criciúma - Faculdade', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'U8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Criciúma - Escola Superior', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'U9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Vila Leopoldina', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'VL',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Guarulhos - Universidade São Judas Tadeu', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'VM',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('São Bernardo do Campo - Universidade São Judas Tadeu', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'VN',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Guarulhos - Escola Superior São Judas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'VO',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Guarulhos - Faculdade São Judas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'VP',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('São Bernardo do Campo - Faculdade São Judas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'VQ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('São Bernardo do Campo - Escola Superior São Judas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'VR',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Guarulhos - Instituto Universitário São Judas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'VS',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('São Bernardo do Campo - Instituto Universitário São Judas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'VT',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Limeira - Faculdade São Judas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'VU',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Limeira - Escola Superior São Judas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'VV',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Limeira - Instituto Universitário São Judas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'VX',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Pouso Alegre - Faculdade', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'VZ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UAM Avenida Paulista Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'V1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Vila Olimpia', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'V2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Centro (Mooca)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'V3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Piracicaba', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'V4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Boa Vista', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'V5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Piedade', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'V6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Professor Barros', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'V7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Centro', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'V8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Barra', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'V9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Campus Park', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'WA',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Inspirali', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'WH',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Conselheiro Lafaiete - Instituto', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'WQ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Sete Lagoas - Faculdade de Educação Superior', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'WW',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Itumbiara', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'WY',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Park Shopping - Instituto', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'WZ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Araranguá', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'W1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Braço do Norte', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'W2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Dib Mussi', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'W3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Içara', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'W4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Pedra Branca', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'W5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Tubarão', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'W6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Florianópolis Continente Grad', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'W8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Araranguá', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'W9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unifacs Rio Vermelho Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XA',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unifacs Santa Mônica Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XB',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unifacs Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XC',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unifacs Tancredo Neves Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XD',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unifacs Getúlio Vargas Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XE',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UNP Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XF',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UNIFG (PE) Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XG',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('FPB Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XH',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('IBMR Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XI',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UAM Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XJ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Uniritter Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XK',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Fadergs Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XL',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unifacs Professor Barros Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XM',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UNP Roberto Freire Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XN',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UNP Mossoró Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XO',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UNP Zona Norte - João Medeiros Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XP',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UNP Salgado Filho Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XR',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UNP Caicó Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XS',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UNP Currais Novos Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XT',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UNP Limoeiro do Norte Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XU',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UNP Pau dos Ferros Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XV',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UNIFG (PE) Boa Vista Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XW',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UNIFG (PE) Piedade Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XX',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('FPB Tambiá Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XY',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('IBMR Barra Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'XZ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Itajaí Faculdade', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '.Y',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('IBMR Botafogo Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'YA',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('IBMR Catete Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'YB',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UAM Centro (Mooca) Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'YC',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UAM Paulista II Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'YD',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UAM Piracicaba Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'YE',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UAM São José Dos Campos Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'YF',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UAM Vila Olimpia Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'YG',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Uniritter Canoas Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'YH',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Uniritter Fapa Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'YI',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Uniritter Zona Sul Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'YJ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Fadergs Centro Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'YK',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UniBH Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'YL',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UniBH Buritis Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'YM',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unicuritiba Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'YN',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisul Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'YO',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unicuritiba Milton Vianna Filho Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'YP',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unicuritiba Pinheirinho Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'YQ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisul Tubarão Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'YR',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisul Balneário Camboriú Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'YS',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisul Florianópolis Continente Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'YT',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Descontinuado - Unisul Florianópolis Ilha Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'YU',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisul Itajaí Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'YV',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Descontinuado - Unisul Trajano Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'YW',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisul Pedra Branca Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'YX',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Avenida Paulista - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'yy',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Itumbiara - Faculdade de Agronomia', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Y7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('E.E. Senador Teotônio Vilela', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ZA',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('E.E. Senador Teotônio Vilela', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ZB',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Gama University', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ZÇ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Karaíba - BD', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ZG',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Sete Lagoas - BD', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ZI',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Pouso Alegre - BD', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ZJ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Linha Verde - BD', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ZK',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica João Pinheiro I - BD', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ZL',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Jataí - BD', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ZM',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Itumbiara - BD', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ZN',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Itabira - BD', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ZO',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Divinópolis - BD', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ZP',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Catalão - BD', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ZQ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Cristiano Machado - BD', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ZT',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('São Bento do Sul - Centro de Ensino', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ZU',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Contagem - BD', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ZV',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Conselheiro Lafaiete - BD', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ZW',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Betim - BD', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ZX',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Bom Despacho - BD', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ZY',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Barreiro - BD', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'ZZ',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Divinópolis - Faculdade', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Z0',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Base Aérea de Santos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Z1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Hospital Irmã Dulce', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Z2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('BTP', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Z3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('EAD - Ensino a Distância USJT', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Z5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Jaraguá do Sul - Centro de Ensino', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Z6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Guajajaras - BD', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Z7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Catalão - Faculdade', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Z8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Itajaí Grad', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Z9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Vila Leopoldina - USJT', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '*0',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unid. Univ. Norte da Ilha', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), ']0',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Santa Rosa do Sul', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '^0',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unid. Univ. Colég. Catarinense', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '_0',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Lages', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '`0',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Antônio Carlos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '01',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Lourdes', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '02',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Buritis', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '03',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('PÓS-GRADUAÇÃO', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '04',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('CAMPUS NOVA FLORESTA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '05',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('FEDERAÇÃO DOS TRABALHADORES METALURGICOS', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '06',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('BARREIRO', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '07',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('BETIM.', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '08',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('CONTAGEM', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '09',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Butantã - USJT', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '*1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Cesuc', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '[1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Dib Mussi', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '\1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unid. Univ. Colég. Cora. Jesus', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), ']1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Laguna_Ead', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '^1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Anitápolis', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '_1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Senai - Tubarão', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '`1',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Park Shopping - Centro de Ensino', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1A',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Butantã - USJT SEMI', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1B',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Morumbi', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1C',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Guarulhos - USJT SEMI', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1D',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tambiá', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1E',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Jabaquara - USJT SEMI', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1F',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Mooca - USJT SEMI', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1G',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Paulista - USJT SEMI', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1H',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Santana - USJT SEMI', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1I',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Santo Amaro - USJT SEMI', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1J',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Santos - USJT SEMI', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1K',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica São Bernardo do Campo - USJT SEMI', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1L',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Vila Leopoldina - USJT SEMI', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1M',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('BELO HORIZONTE', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '10',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('MARATONA - SETE LAGOAS', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '11',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('BRASÍLIA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '12',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('CURITIBA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '13',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('PORTO ALEGRE', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '14',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('RECIFE', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '15',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('SÃO PAULO', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '16',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('RIO DE JANEIRO', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '17',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('FLORIANOPOLISx', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '18',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Aimorés', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '19',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Guarulhos - USJT', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '*2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisul Virtual', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '\2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tubarão_Ead', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), ']2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('P.Branca_Ead', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '^2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unid. Univ. Ponte do Imaruim', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '_2',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Tancredo Neves', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2C',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Brumado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2E',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('São Bento do Sul - Faculdade de Educação', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2F',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Itajaí - Instituto', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2J',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Afonso Pena ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '20',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Barreiro', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '21',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Guajajaras', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '22',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Liberdade', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '23',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Barro Preto', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '24',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Raja', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '25',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Contagem', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '26',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Faculdade de Ciências  Médicas de Minas Gerais', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '27',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Vila Mathias', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '28',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('São Paulo - Wtc', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '29',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Jabaquara - USJT', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '*3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('São João do Sul', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '\3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Orleans', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), ']3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Morro da Fumaça', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '^3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unid. Univ. Esc. Cat. de Gast.', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '_3',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Betim', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '30',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Brasília', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '31',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('João Pinheiro', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '32',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Linha Verde', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '33',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('CAMPO LARGO', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '34',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Campus Raja (Rajinha)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '35',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('The Hub - São Paulo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '36',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('EAD - Ensino a Distância UNIBH', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '37',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('EAD - Ensino a Distância UNA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '38',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('EAD - Ensino a Distância UNIMONTE', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '39',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Mooca - USJT', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '*4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Armazem', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '\4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unid. Univ. Colég. Dom Bosco', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), ']4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unid. Univ. Urussanga', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '^4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unid. Univ. Padre Roma', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '_4',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('A definir', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '40',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('A definir', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '41',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('A definir', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '42',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Raja/MG', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '43',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Belo Horizonte/MG', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '44',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Contagem/MG', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '45',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Viçosa/MG', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '46',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Juiz de Fora/MG', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '47',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Formiga/MG', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '48',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Aracaju/SE', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '49',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Paulista - USJT', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '*5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Jacinto Machado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '\5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unid. Univ. Laguna', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '^5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Instituto do Saber', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '_5',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tubarão', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '5Q',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Antônio  Carlos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '50',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo João Pessoa/PB', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '51',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('CAMPUS LOURDES', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '52',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UniBH Cristiano Machado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '53',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('TESTE COPE', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '54',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('CONTAGEM II', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '55',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Campo Grande/MS', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '56',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Santos/SP', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '57',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Araçatuba/SP', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '58',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Campinas/SP', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '59',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Santana - USJT', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '*6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Garopaba', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '\6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Joinville', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), ']6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('B.Norte_Ead', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '^6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Jaguaruna', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '_6',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Pedra Branca', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '6Q',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Sorocaba/SP', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '60',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Catalão - INATIVO UNIBH', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '61',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Sete Lagoas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '62',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Mooca', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '63',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Butantã', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '64',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Betim/MG', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '65',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Sete Lagoas/MG', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '66',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo São Paulo/SP', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '67',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Sete Lagoas - Pós', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '68',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Divinópolis/MG', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '69',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Santo Amaro - USJT', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '*7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Içara_Ead', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '\7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Concórdia', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), ']7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Curitibanos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '^7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Passo de Torres', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '_7',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Içara', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '7Q',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Divinópolis', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '70',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Bituruna/PR - Escola Frei Tiago Luchese     ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '71',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Blumenau/SC  - Sociesc           ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '72',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Capivari de Baixo/SC - Master Educação     ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '73',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Carlópolis/PR- Centro Educacional Unischool', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '74',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Cascavel/PR - Fundação Iguaçú     ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '75',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Castro/PR- Cdi Infomática          ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '76',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Chapecó/SC - Hcjb Assessoria Pedagó. Universitaria ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '77',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Cruzeiro do Oeste/PR Escola Mundo Encantado       ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '78',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Curitiba/PR - Ibed - Educação           ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '79',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Criciúma', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '%8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Santos - USJT', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '*8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Araranguá_Ead', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '\8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Dib Mussi_Ead', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), ']8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unid. Univ. Senai São José', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '^8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Turvo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '_8',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Descontinuado - Trajano', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '8Q',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisul Braço do Norte Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '8W',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Francisco Beltrão/PR', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '80',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Joinville/SC', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '81',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Matinhos/PR - Centro De Apoio Em Ead', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '82',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Ortigueira/PR - Academia Washington        ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '83',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Paranavai/PR - Brasil Do Saber - Polo       ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '84',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Pato Branco/PR - Colegio Carlos Almeida - Apae     ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '85',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Porto Alegre/RS - Colégio Método         ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '86',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo São Bento do Sul/SC - Sociesc                    ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '87',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Itajai/SC- Unisociesc     ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '88',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Alfenas/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '89',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisul Criciúma Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '%9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica São Bernardo do Campo - USJT', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '*9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unidade Acadêmica Santos - Centro Universitário - USJT', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '+9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Imbituba_Ead', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '\9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unid. Univ. Imbituba', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), ']9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unid. Univ. Colég. Meni. Jesus', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '^9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Canoinhas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '_9',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Park Shopping - Faculdade de Educação', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '9L',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Braço do Norte', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '9Q',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisul Içara Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '9W',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Almenara/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '90',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Andradas/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '91',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Araçuaí/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '92',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Araxá/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '93',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Arcos/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '94',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Barbacena/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '95',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Blumenau/SC - Parceiro Una', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '96',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Bom Despacho/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '97',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Caratinga/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '98',  (select max("Id") from public."Campus"));
INSERT INTO public."Campus"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Polo Cataguases/MG - Parceiro FAEA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoCampus"(
	"IntegracaoSistemaId", "CodigoOrigem", "CampusId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '99',  (select max("Id") from public."Campus"));