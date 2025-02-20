INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Sábado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'A9',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Extensão', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'EX',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('08:20 às 16:50', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'LF',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('6ª e sábado - Integral', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Q1',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Diurno', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'SD',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('10h30 às 13h', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Z1',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Sábado - 8h10 às 15h50', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Z10',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('6ª Feira - 13h50 às 17h20', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Z2',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('4 ª Feira -   14h às 17h40', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Z3',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('5ª feira - 13h às 16h20', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Z4',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('6ª feira - 14h50 às 18h20', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Z5',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª Feira e 4ª Feira - 19h10 às 20h50', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Z6',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª Feira e 4ª Feira - 21h00 às 22h40', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Z7',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª Feira e 5ª Feira - 17h20 às 19h10', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Z8',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('5ª Feira - 9h às 12h40', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), 'Z9',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('-', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '00',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Manhã', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '01',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tarde', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '02',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noite - 2ª, 3ª e 4ª', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '025',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noite - 2ª (Tarde e Noite) e 3ª (Noite)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '026',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noite', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '03',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Diurno Integral', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '04',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noturno', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '05',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tarde 2', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '06',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Pública', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '07',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª feira - 9h10 às 12h40 I', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '071',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Turno Único', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '08',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Particular', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '09',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('5ª feira - 14h às 17h20', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1AZ',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Durante Semana', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '10',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª e 4ª (19:10 às 22:40)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '100',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES (' - ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '101',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES (' - ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '102',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª e 5ª (19:10 às 22:40) ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '103',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Quinzenal - 6ª (19:10 às 22:40) e Sáb (08:30 às 16:30)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '104',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Manhã - 3ª e 5ª feira (8:30 as 12:00)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '105',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Semanal - 6ª (19:10 às 22:40) e Sáb (08:30 às 16:30) ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '106',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª, 4ª, 5ª e 6ª(19h10 às 22h40)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '107',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES (' - ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '108',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noite - 2ª e 4ª (19:10 às 22:40)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '109',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Aos Sábados', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '11',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noite - 3ª e 5ª (19:10 às 22:40) ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '110',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noite 2ª, 3ª, 4ª, 5ª', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '111',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noite - 3ª e 5ª feira (19h10 as 22h50)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '112',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noite - 2ª e 4ª feira (19h10 as 22h50)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '113',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES (' - ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '114',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noite - 2ª a 6ª feira (19h10 as 22h50)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '115',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª E 4ª (19h às 20h15)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '116',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noite - 3ª, 4ª e 5ª', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '117',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª e 4ª (19:00 às 22:30)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '118',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª e 5ª (19:00 às 22:30)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '119',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Matutino', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '12',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª, 3ª, 4ª e 5ª (19h10 às 22h40)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '120',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª a 5ª (19:10 às 22:40) ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '123',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Diurno/Vespertino', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '13',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noite - 3ª e 5ª feira.', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '133',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noite - 2ª e 4ª feira.', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '134',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES (' - ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '135',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Sexta (noite) e Sábado (manhã)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '137',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noturno', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '14',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noite - 2ª a 6ª feira', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '140',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noite - 4ª e sábado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '144',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Integral', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '15',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª, 5ª feira e Sábado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '159',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Segundas, terças e quartas.', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '16',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('5ª feira - 09h10 às 12h40', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '160',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('6ª feira - 7h20min às 10h50min', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '161',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('6ª feira - 9h às 12h20', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '162',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª feira -14h30 às 18h', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '163',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('4ª feira - 09h10 às 12h40', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '164',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª feira -12h50 às 16h10', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '165',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª feira - 08h10 às 11h50', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '166',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('4ª feira - 08h10 às 11h50', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '167',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª feira - 14h30 às 18h', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '168',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª feira - 9h10 às 12h40', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '169',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Quartas, quintas e sextas.', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '17',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('4ª feira - 13h40 às 16h10', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '170',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('4ª feira - 09h10 às 12h40', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '171',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('5ª feira - 14h30 às 18h', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '172',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noite - 4ª, 5ª e 6ª (19h às 22h)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '173',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES (' - ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '174',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª feira - 12h50 às 16h10', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '175',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('5ª feira - 9h10 às 11h50', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '176',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('5ª feira - 07h20 às 10h50', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '177',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª feira - 17h20 às 20h50', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '178',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('4ª feira - 19h10min às 22h40min', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '179',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Sexta à noite e sábado integral.', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '18',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('5ª feira - 7h20min às 09h', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '180',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª feira - 21h às 22h40', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '185',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Terças, quartas e quintas.', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '19',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('-', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '191',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('.', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '192',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Único', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '199',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('5ª feira - 09h50 às 13h10', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2AZ',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª e 4ª (19:25 às 22:55)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '20',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noite - 2ª e 3ª (19:10 às 22:40) ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '201',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noite - 4ª e 5ª (19:10 às 22:40) ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '202',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª, 3ª, 4ª, 5ª - (19h10 às 22h40)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '203',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Sábado integral (manhã e tarde) (8h30 às 12h/ 13h às 17h30) *semanal', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '205',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('6ª e Sábado - Quinzenal', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '206',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('6ª e Sábado - (a cada 3 semanas)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '207',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('6ª e Sábado - Semanal', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '208',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noite 3ª, 4ª, 5ª, 6ª', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '209',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª e 5ª (19:25 às 22:55) ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '21',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Dinâmico (Segunda a Quinta - 19:25 às 22:55)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '22',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Semanal - 6ª (19:25 às 22:55) e Sáb (08:30 às 16:30) ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '23',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Sábados (08:30 à 16:30) ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '24',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Quinzenal -  6ª (14:00 às 17:30) e Sáb (08:30 às 16:30)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '25',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª a 5ª (19:25 às 22:55)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '26',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª, 4ª (19:25 às 22:55) e Sábado (08:30 às 12:00) ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '27',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª, 4ª e 5ª (7:00 às 09:30)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '28',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Sábado - Quinzenal (08h as 17h)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '283',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Quinzenal - Sábados (08:30 às 16:30)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '29',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('6ª feira -  08h10 às 18h e Sáb 09h às 13h50', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '3AZ',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('4ª (19:25 às 22:55) e Sábado (08:30 às 16:30)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '30',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noite - 2ª e 3ª feira', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '300',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('De 14 a 18 de setembro - 9h10min às 12h40min', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '301',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª feira - 15h10min às 16h50min', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '302',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª feira - 17h às 18h40min', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '303',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª feira - 13h40min às 17h', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '304',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª e 6ª (08:30 às 12:00) e Event. 5ª (08:30 às 12:00)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '31',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Quinzenal - 6ª (19:25 às 22:55) e Sáb (08:30 às 16:30)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '32',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª, 3ª e 4ª', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '33',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noite - Live', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '330',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Digital', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '331',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Especial', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '333',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Alternativo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '334',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('5ª feira - 8h10min às 11h30min', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '335',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('5ª feira - 13h40 às 17h10', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '336',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tarde/Noite', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '337',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2°, 3°(19:25 às 22:55) e Sábado (08:30 às 12:00)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '34',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Semanal - 6ª (13h às 16:30) e Sáb (08:30 às 16:30)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '35',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Dinâmico (Seg, Qua e Sext - 19:25 às 22:55)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '36',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('5ª (19h10 as 22h50) e sábado (8h30 as 12h30)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '37',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noite - 4ª (19h10 as 22h50) e sábado (8h30 as 12h30)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '38',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('4ª feira - 21h às 22h40', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '386',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('5ª feira - 12h50 às 16h10', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '389',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES (' - ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '39',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('4ª feira - 08h30 às 11h50', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '4AZ',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('EXCP', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '40',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Manhã/Tarde/Noite', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '41',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Sábado - 10h30 - 13h', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '42',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Sábado - 8h -10h30', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '43',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('5ª (19:25 às 22:55) e Sábado (08:30 às 16:30)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '44',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('6ª e Sábado.', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '444',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª a 6ª (19:25 às 22:55)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '45',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª e 4ª - 12h - 13h15', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '46',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª e 4ª - 17h30 - 18h45', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '47',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª e 5ª - 12h - 13h15', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '48',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª e 5ª - 17h30 - 18h45', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '49',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('4ª feira - 13h às 16h20', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '5AZ',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª e 4ª - 12h15 - 13h30', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '50',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Sábado.', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '51',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª e 4ª - 17h15 - 18h30', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '52',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('6ª feira - 14h30 às 18h', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '525',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('6ª feira - 14h50 às 18h10', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '526',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('6ª feira - 12h50 às 14h30', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '527',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª e 5ª - 12h15 - 13h30', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '53',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª e 5ª - 17h15 - 18h30', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '54',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('4ª feira - Noite e Quinzenal aos Sábados - Manhã e Tarde', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '55',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Quinzanal - Sábado - 08h30 às 12h00 e das 13h00 às 16h30', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '56',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('5ª feira - 19h10 às 22h40', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '563',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª feira - Noite e Sábados - Manhã e Tarde', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '57',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Sábado - 08h00 às 12h00 e das 13h00 às 17h00', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '58',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('4ª feira - 14h30 às 18h', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '585',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('.', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '59',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª feira - 13h às 16h20', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '6AZ',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('.', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '60',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noite - 2ª a 5ª feira.', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '61',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª feira - 19h10 às 20h50', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '670',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('4ª (19:10 às 22:50) e Sábado (08:00 às 12:00)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '68',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª feira - 9h10 às 12h40', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '680',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('6ª feira -  08h10 às 18h e Sáb 09h às 13h40', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '681',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('6ª feira - 13h às 14h40', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '682',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª feira - 16h às 17h40', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '683',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª feira - 14h20 às 15h40', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '684',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('5ª feira - 8h10 às 11h50', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '685',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª feira - 13h40 às 17h10', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '686',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('4ª feira - 9h10 às 12h40', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '687',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª feira - 14h30 às 18h M', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '688',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('4ª feira - 19h10 às 20h50', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '689',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noturno/Diurno', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '69',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('6ª feira - 19h10 às 22h50', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '690',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª feira - 19h10 às 22h40', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '692',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('3ª feira - 14h30 às 18h I', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '699',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('4ª feira - 09h às 10h40', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '7AZ',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES (' - ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '71',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Quinzenal - 6ª (19:10 às 22:50) e Sáb (08:00 às 17:00)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '72',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Mensal - 6ª, Sábado e Domingo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '73',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('EAD', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '77',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Sábado - 8h', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '79',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('6ª feira - 09h50 às 13h10', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '8AZ',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Sábado - 10h30min', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '80',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Sábado - Semanal', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '842',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('4ª Noite e Sábado Manhã', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '854',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('A definir', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '86',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('9h às 13h', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '87',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('19 horas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '88',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noite (19:00 a 22:35)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '89',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('5ª feira - 14h50 às 18h10', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '896',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Indefinido', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '897',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Final de Semana', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '898',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Único - Lep', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '899',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('2ª feira - 08h30 às 11h50', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '9AZ',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES (' - ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '90',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Madrugada', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '900',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('10h30 às 13h', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '91',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('08h às 10:30', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '92',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES (' - ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '93',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('-', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '94',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Noite - 4ª e 5ª feira', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '95',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('17h30 às 18h45', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '96',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Quinzenal - Sábados e Domingos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '97',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Manhã - 2ª e 4ª feira', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '98',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Manhã - 3ª e 5ª feira', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '99',  (select max("Id") from public."Turno"));
INSERT INTO public."Turno"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('13h às 18h30', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoTurno"(
	"IntegracaoSistemaId", "CodigoOrigem", "TurnoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '999',  (select max("Id") from public."Turno"));