INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Instituto Ânima','INSTITUTO', true,'bca03493-ac00-4477-b647-fd9fe37351b4', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '7',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UNIFG','UNIFG', true,'272aa8cc-12a7-4eca-84b8-6740bbc1918a', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '12',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Unisul','Unisul', true,'63756a56-92bb-40a3-8a56-d23b9714e2e5', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '13',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UNIFGUA','UNIFGUA', true,'b70a24ef-082f-4274-b040-f541f630b26a', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '26',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('FPB','FPB', true,'ffa5395a-9dcc-44cb-a8fe-3c8515f2a95a', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '27',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UNIBH','UNIBH', true,'e9b1816f-45e9-4e2a-b2c6-c304dace2bd0', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UNA','UNA', true,'0d9d4465-d7d6-4a3c-a9f5-638f51ee65f4', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('USJT','USJT', true,'09980708-3b26-4056-b4a6-51f8402b4d8e', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '3',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('SOCIESC','SOCIESC', true,'4720899c-db78-4c87-8083-fce30e20916b', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '4',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('HSM','HSM', true,'5dd535f9-efbf-4b21-aa28-f1db031cfa00', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '5',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('EBRADI','EBRADI', true,'71c4cab0-3bf6-47e9-8ec8-12e8497f7058', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '6',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('AGES','AGES', true,'dd420dc7-4619-4449-81df-cc1aae5cff31', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '8',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('FASEH','FASEH', true,'0ebca44c-c414-46a6-81f2-88c781ea94bb', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '11',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('INSPIRALI','INSPIRALI', true,'846dbab0-1e6e-47ef-99c8-3079847498f9', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '17',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('MCAMPOS','MCAMPOS', true,'d81e6854-fe78-4eb1-8348-42438fe76d28', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '24',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('BSP','BSP', true,'dc66763c-131c-4b8b-9899-11e6bd40da01', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '30',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('GAMA UNIVERSITY','GAMA UNIVERSITY', true,'03306113-ce99-4f7b-97b6-a6d648d8a0c4', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '31',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('HSMU','HSMU', true,'25219fee-b2d3-410d-b312-f2c116ddcb18', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '9',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UNICURITIBA','UNICURITIBA', true,'3813a503-190c-40d4-80bc-cd7aa61c7fde', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '10',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('IBCMED','IBCMED', true,'6fc6f1f4-3beb-4eb3-b827-0e0d2bd11d4c', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '28',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('CEDEPE','CEDEPE', true,'a3beff96-72a6-42a6-a735-439746e4a958', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '29',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UAM','UAM', true,'bb348e69-b314-4d96-9672-4df9f91f6b26', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '18',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('IBMR','IBMR', true,'c614c719-543c-42aa-8837-a133d1b529cd', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '19',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UNIFACS','UNIFACS', true,'8e9e2a51-9c19-47ac-877d-a91b7bf1bbd3', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '20',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UNP','UNP', true,'32a390fd-b6fa-4e43-b492-0eadb9934e1a', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '21',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('UNIRITTER','UNIRITTER', true,'62355230-72ee-4a76-8763-078f33bcfdf7', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '22',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('FADERGS','FADERGS', true,'3ff1fb55-d02d-42c8-80c7-d5dbaed357ce', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '23',  (select max("Id") from public."Marca"));

INSERT INTO public."Marca"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('MEDPOS','MEDPOS', true,'b9f747b4-c243-450d-b8a8-dc44f177979a', current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoMarca"(
	"IntegracaoSistemaId", "CodigoOrigem", "MarcaId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '32',  (select max("Id") from public."Marca"));