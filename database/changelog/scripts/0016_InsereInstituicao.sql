INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro Universitário de Belo Horizonte','UniBH', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '1'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro Universitário Una','Una', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '3',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro Universitário Una de Contagem','UnaConta', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '4',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro Universitário São Judas Tadeu','UNIMONTE', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '3'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '5',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('HSM Escola Superior de Administração','HSM', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '5'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '7',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro Universitário Una de Betim','UNABetim', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '6',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro Universitário Sociesc','SOCJoin', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '4'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '12',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade UniSul de Balneário Camboriú','UniSBaln', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '13'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '13',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro Universitário SOCIESC de Blumenau','SOCBlu', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '4'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '15',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade UniSul de Florianópolis','UniSFlor', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '13'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '16',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro Universitário Unicuritiba','UniCurit', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '10'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '17',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade de Tecnologia Tupy de São Bento do Sul','SOCSBSul', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '4'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '18',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade Una de Pouso Alegre','UNAPouso', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '11',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade Una de Divinópolis','UNADivi', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '10',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Universidade São Judas Tadeu','USJT', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '3'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '8',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade UNA de Sete Lagoas','UNASete', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '9',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Inativa - Centro Universitário UniCuritiba - Sem aluno','Inativa', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '10'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '110',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('CENTRO UNIVERSITÁRIO IBMR','IBMR', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '19'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '126',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('UNIVERSIDADE SALVADOR','UNIFACS', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '20'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '127',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade Una Nova Serrana','UNANS', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '22',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Instituto Universitário Una de Catalão','CATALANA', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '49',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro Superior Una de Catalão','UNACAT', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '50',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Instituto Una de Jataí','InstJata', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '56',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro de Ensino Superior de Catalão','UNACESCAT', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '63',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade UniSul de Itajaí','UniSItaj', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '13'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '65',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade UniSul de Itajaí (Inativo)','FUniSIta', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '13'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '69',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade Una de Itabira','UNAItabira', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '71',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro Universitário FG','UNIFG', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '12'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '101',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Instituto Una de Itabira','INSTITAB', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '103',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade de Educação Superior de Itabira','FACESITAB', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '104',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade de Educação Superior de Catalão','FACESCAT', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '105',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro de Ensino Superior SOCIESC de Jaraguá do Sul','CESJARAG', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '4'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '106',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Universidade do Sul de Santa Catarina','Unisul', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '13'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '107',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('UNIVERSIDADE POTIGUAR','UNP', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '21'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '128',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('CENTRO UNIVERSITÁRIO RITTER DOS REIS','UNR', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '22'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '129',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('CENTRO UNIVERSITÁRIO FADERGS','FAD', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '23'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '130',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('FACULDADE MILTON CAMPOS','FMC', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '24'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '132',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('FACULDADE MILTON CAMPOS.','FAMC', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '24'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '133',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro Universitário dos Guararapes','UNIFGUA', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '26'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '135',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade Internacional da Paraíba','FPB', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '27'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '136',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Universidade São Judas Tadeu','USJTHS', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '9'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '138',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Escola Superior Una de Itumbiara','ESUNAITU', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '40',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Instituto do Sul de Santa Catarina','InstCriciuma', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '13'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '152',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade Una de Jataí','UNAJATAI', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '51',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade Divinópolis','FACED', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '46',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Instituto Ânima','INSTITUTO', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '7'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '54',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro de Ensino Superior de Contagem','UNACESCON', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '58',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Escola Superior de Itabira','UNAESITAB', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '70',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro Universitario UNA','HSMU', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '9'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '73',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Escola Superior de Pouso Alegre','UnaESPOUSO', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '74',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Escola Superior de Catalão','UnaESCAT', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '75',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade da Saúde e Ecologia Humana','FASEH', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '11'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '97',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade UNA de Tucuruí','UnaTucuruí', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '99',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Universidade São Judas','INSPIRALI', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '17'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '114',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Universidade São Judas Tadeu','USJTEB', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '6'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '116',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Escola de Referência em Ensino Médio José Lopes de Siqueira','EREMJLS', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '27'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '151',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Escola Superior do Sul de Santa Catarina','UnisulESCRIC', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '13'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '153',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade do Sul de Santa Catarina','UniSCric', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '13'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '154',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro de Estudos Superiores de Jataí','UNACESJAT', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '60',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro Universitário dos Guararapes','CEDEPE', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '29'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '157',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro Universitário Una de Uberlândia','PoliUber', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '20',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade Una de Catalão','PoliGoi', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '21',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro Universitário Una','EBRADI', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '6'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '44',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro de Ensino Superior de Divinópolis','UNACESDIV', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '59',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro de Ensino Superior de Sete Lagoas','UNACESSET', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '62',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Instituto Sociesc de Jaraguá do Sul','INSTJARG', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '4'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '64',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro de Ensino Superior Sociesc de São Bento do Sul','CESSBSul', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '4'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '66',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro Universitário AGES','PARIPIRANGA', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '8'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '72',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade de Educação Superior de Jataí','FACESJATAÍ', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '83',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro de Ensino Superior de Itabira','UNACESITA', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '84',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade de Educação Superior de Nova Serrana','FACESNS', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '85',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade de Educação Superior de Divinópolis','FACESDIVI', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '86',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade de Educação Superior de Pouso Alegre','FACESPOUSO', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '87',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade de Educação Superior de Sete Lagoas','FACESSETE', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '88',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade de Educação Superior de Contagem','FACESCONT', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '89',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Instituto de Educação Superior Unisul de Itajaí','InstUniS', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '13'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '90',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade SOCIESC de Educação de Jaraguá do Sul','FACUJARAG', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '4'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '91',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade UniSul de Educação de Itajaí','FACUITAJAÍ', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '13'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '92',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade SOCIESC de Educação de São Bento do Sul','FACUSBSUL', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '4'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '93',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro Universitário Curitiba','UNICURITIBA', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '10'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '94',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('INSTITUTO BRASILEIRO DE CIÊNCIAS MÉDICAS - IBCMED','IBCMED', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '28'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '149',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Business School São Paulo','BSP', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '30'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '158',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('GAMA UNIVERSITY','GAMA UNIVERSITY', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '31'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '159',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Universidade São Judas Tadeu','USJTGA', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '31'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '165',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('MEDPOS','MEDPOS', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '32'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '166',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro Universitário Una de Bom Despacho','FACEB', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '19',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Escola Superior São Judas de Guarulhos','ESSJ GUARULHOS', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '3'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '23',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade São Judas de Guarulhos','FACSJ GUARULHOS', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '3'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '24',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Instituto Universitário São Judas de Guarulhos','IUSJ GUARULHOS', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '3'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '25',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Escola Superior São Judas de Limeira','ESSJ LIMEIRA', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '3'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '26',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade São Judas de Limeira','FACSJ LIMEIRA', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '3'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '27',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Instituto Universitário São Judas de Limeira','IUSJ LIMEIRA', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '3'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '28',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Escola Superior São Judas de São Bernardo do Campo','ESSJ SÃO BERNARDO', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '3'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '29',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade São Judas de São Bernardo do Campo','FACSJ SÃO BERNARDO', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '3'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '30',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Instituto Universitário São Judas de São Bernardo do Campo','IUSJ SÃO BERNARDO', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '3'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '31',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Escola Superior Una de Barreiras','E.S. UNA BARRREIAS', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '32',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade de Agronomia Una de Barreiras','FAGRO UNA BARRREIAS', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '33',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade Una de Barreiras','FACUNA BARREIRAS', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '34',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Instituto Universitário Una de Barreiras','IUUNA BARREIRAS', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '35',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Escola Superior Una de Conselheiro Lafaiete','ESUNALAF', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '36',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade de Agronomia Una de Conselheiro Lafaiete','FAGRO UNA LAFAIETE', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '37',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade Una de Conselheiro Lafaiete','FACUNA LAFAIETE', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '38',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Instituto Universitário Una de Conselheiro Lafaiete','INSTLAFA', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '39',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade de Agronomia Una de Itumbiara','FAGITUM', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '41',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade Una de Itumbiara','FACUNA ITUMBIARA', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '42',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Instituto Universitário Una de Itumbiara','INSTITUM', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '43',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade Sociesc de Jaraguá do Sul','SOCJarag', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '4'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '45',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade de Tecnologia de Catalão','FATECA', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '57',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Centro de Ensino Superior de Nova Serrana','UNACESNO', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '2'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '61',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade One Learning','One Lear', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '8'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '76',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade Ages de Tucano','TUCANO', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '8'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '77',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade Ages de Senhor do Bonfim','BONFIM', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '8'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '78',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade Ages de Jeremoabo','JEREMOABO', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '8'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '79',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade Ages de Jacobina','JACOBINA', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '8'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '80',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade Ages de Medicina','MEDJACOBINA', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '8'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '81',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('Faculdade Ages de Medicina de Irecê','MEDIRECE', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '8'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '82',  (select max("Id") from public."Instituicao"));
INSERT INTO public."Instituicao"(
	"Nome", "Sigla", "Ativo", "Key", "CriadoEm", "AlteradoEm", "MarcaId")
	VALUES ('UNIVERSIDADE ANHEMBI MORUMBI','UAM', true,  gen_uuid(), current_timestamp, current_timestamp, (select "MarcaId" from public."IntegracaoMarca" where "CodigoOrigem" = '18'));
	INSERT INTO public."IntegracaoInstituicao"(
	"IntegracaoSistemaId", "CodigoOrigem", "InstituicaoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '125',  (select max("Id") from public."Instituicao"));