INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES (' Português e Inglês 2º grau', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1153',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '926',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração Bacharelado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '639',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração Contábil e Financeira', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '486',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração de  Empresas - LF', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '339',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração de  Empresas - LF (Híbrido)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '547',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração de Empresas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '232',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração de Empresas e Comércio Exterior', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1014',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração de Empresas em Regime Especial', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1010',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração de Empresas INATIVO', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '226',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração de Empresas Ou Recursos Humanos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '328',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração de Empresas/Comércio Exterior/Ciências Contábeis e Ciências Econômicas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '329',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração de Recursos Humanos, Planejamento e Organização', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '545',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração e Educação Ambiental', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '484',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração Escolar', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '123',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração Escolar de 1.° e 2.° Graus', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '43',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração Escolar de 1.° e 2.° Graus/ Inspeção Escolar de 1.° e 2.° Graus/ Magistério das Matérias Pedagógicas do 2.° Grau/ Supervisão Escolar de 1.° e 2./ Graus ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '573',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração Escolar de 1.° e 2.° Graus/ Magistério das Matérias Pedagógicas do 2.° Grau', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '606',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração Escolar de 1.° e 2.° Graus/ Magistério das Matérias Pedagógicas do 2.° Grau/ Supervisão Escolar de 1.° e 2.° Graus', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '575',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração Escolar de 1º e 2º Graus/Inspeção Escolar de 1º e 2º Graus', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '199',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração Escolar de 1º e 2º Graus/Supervisão Escolar de 1º e 2º Graus', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '197',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração Escolar do Ensino Fundamental e Médio', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '251',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração Escolar do Ensino Fundamental e Médio (Habilitação)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '735',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração Escolar e Supervisão Escolar', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '325',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração Geral', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '244',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Administração Hospitalar', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '247',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Adminstração de Empresas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '976',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Análise de Sistemas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '250',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Análise de Sistemas-', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '301',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Aperfeiçoamento', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '240',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Arquitetura e Cidade', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '365',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Arquitetura e Urbanismo Bacharelado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '660',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Artes Cênicas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '345',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Artes Plásticas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '338',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Aspectos Biológicos e Funcionais do Envelhecimento', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '349',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Aspectos Educacionais Psicológicos e Sócioculturais do Envelhecimento', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '351',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('At', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '559',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Atividade de Orientação', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '560',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Atividade Física e Disfunções Orgânicas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '355',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Atividades Obrigatórias', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '556',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Bacharelado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Bacharelado e Formação de Psicólogo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1062',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Bacharelado/Licenciatura ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '117',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Banco e Finanças', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '970',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Biologia', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '337',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Biotecnologia e Meio Ambiente', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '238',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Certificado de Extensão Universitária', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '17',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Certificado de Extensão Universitária - Extensão', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '87',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Ciência dos Materiais Aplicada à Construção Civil', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '400',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Ciências Biológicas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1044',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Ciências Biológicas Licenciatura', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '661',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Ciências Contábeis Bacharelado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '649',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Ciências do Ensino Fund. e Mat. do Ensino Médio', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1102',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Ciências Econômicas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '849',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Cinema', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1099',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Cinema e Audiovisual', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '236',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Cinema e Vídeo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '230',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Clínica Comportamental', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '449',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Clínica e Saúde Mental', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '506',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Comércio  Exterior - LF', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '323',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Comércio  Exterior - LF (Híbrido)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '549',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Comércio Exterior', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '234',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Comércio Exterior -LF', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '228',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Computação Grafíca', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1131',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Comunicação Organizacional', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '260',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('COMUNICAÇÃO SOCIAL', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1038',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Comunicação Social - Publicidade e Propaganda', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '933',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Controle de Qualidade', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '187',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Controle e Automação', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '416',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Coordenação de Moda', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '859',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Coordenação de Processos Educativos Escolares (Administração /Supervisão/Orientação)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '16',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Criminologia e Direito Penal Especial', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1145',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Curso', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '709',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('De 1º Grau', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '342',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Democracia, processo e efetividade do Direito', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '757',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Desenho', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '334',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Desenho, com Concentração Curricular em Multimídia e Computação gráfica', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1135',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Desenho Técnico', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '296',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('DESIGN DIGITAL', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '922',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Desing de Moda', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1106',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Dinâmica Organizacional, Inovação e Sociedade', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '280',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Docência para os Anos Iniciais do Ensino Fundamental', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '164',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Docência para os Anos Iniciais do Ensino Fundamental / Gestão e Coordenação de Processos Educativos(Administração Escolar, Supervisão Escolar e Orientação Educ)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '635',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Docência para os Anos Iniciais do EnsinoFundamental/ Gestão e Coordenação de Processos Educativos ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '632',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Doenças Associadas ao Envelhecimento;', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '592',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Doutorado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '313',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Doutorado - Análises de Produtos Audiovisuais', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '795',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Doutorado - Atividade Empresarial e Constituição: Inclusão e Sustentabilidade', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '669',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Doutorado - Obrigações e Contratos Empresariais: Responsabilidade Social e Efetividade', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '668',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Doutorado - Processos Midiáticos na Cultura Audiovisual', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '797',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Educação', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '311',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Educação a Distancia', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '847',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Educação e Desenvolvimento Local', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '439',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Educação Física - Licenciatura', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '750',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Educação Física Bacharelado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '644',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Educação Física Educação Física Bacharelado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '637',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Educação Física, Escola e Sociedade', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '357',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Educação Física Licenciatura', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '636',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Educação Infantil', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '266',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Educação Infantil e Ensino Fundamental-Séries Inicias', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '766',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Educação Infantil e Ensino Fundamental-Séries Inicias (Habilitação)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '799',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Educação Infantil e Ensino Fundamental-Séries Inicias (Modalidade)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '803',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Elétrica', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1110',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Eletrônica', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '158',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Eletrotécnica', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '414',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Ênfase em Processos de Gestão', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '496',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Enfermagem Bacharelado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '664',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Engenharia Agronômica Bacharelado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '659',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Engenharia Ambiental ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '845',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Engenharia Civil', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '324',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Engenharia Civil Bacharelado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '665',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Engenharia da Computação', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '317',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Engenharia de Sistemas de Produção', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '500',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Engenharia Elétrica/Mecânica/Civil', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '566',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Engenharia Industrial Elétrica', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '319',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Engenharia Mecânica', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '322',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Engenheiro Eletricista', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '380',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Engenheiro Mecânico', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '382',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Ensino Fundamental', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '472',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Ensino Médio', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '473',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Ensino Superior', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '527',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Escola, Esporte, Atividade Física e Saúde', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '369',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Espanhol', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '10',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Especialização', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '32',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Especializado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '49',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Estilismo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1104',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Ética, autonomia e fundamentos do Direito ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '755',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Eventos - Bacharelado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1056',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Executivo Bancário', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '303',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Extensão Universitária', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '51',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Farmaceutico', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1036',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Farmacêutico Bioquímico', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '320',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Farmacêutico Industrial', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '316',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Farmácia Bacharelado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '645',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Fenômeno Esportivo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '359',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Finanças Empresariais', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '615',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Física Licenciatura', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '646',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Fisioterapia Bacharelado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '643',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Fisioterapia Cardiovascular e Terapia Intensiva', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '209',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Fisioterapia em Cardiologia e Angiologia', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '166',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Fisioterapia em Gerontologia', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '211',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Fisioterapia em Gerontologia e Reumatologia', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '168',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Fisioterapia em Ginecologia e Urologia', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '213',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Fisioterapia em Ginecologia, Obstetrícia e Urologia', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '170',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Fisioterapia em Neurologia e Neuropediatria', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '172',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Fisioterapia em Ortopedia e Esportes', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '215',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Fisioterapia em Ortopedia e Traumatologia', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '176',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Fisioterapia em Pneumologia e Terapia Intensiva', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '174',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Fisioterapia em Saúde Coletiva: Promoção e Prevenção à Saúde', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '217',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Fisioterapia Ortopédica e Espot. - reing', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '272',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Flauta', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '336',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Formação de Professores para a Educação Infantil', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '318',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Formação de Professores para os Anos Iniciais do Ensino Fundamental ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '471',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Francês', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '56',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Francês(Cursos Antigos)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '62',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Gastronomia Tecnólogo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '658',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Geografia - História', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1016',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Geografia Licenciatura', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '642',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Gerência de Produto', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1012',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Gerenciamento de Informações e Empreendimentos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '20',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Gestão Ambiental', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '445',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Gestão Ambiental e Ecoturismo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '23',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Gestão de Empreendimentos e Negócios em Hotelaria ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '21',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Gestão de Negócios', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '740',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Gestão de Práticas Educativas Extra-Escolares', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '25',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Gestão de Serviços e Informações', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '22',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Gestão do Espaço Urbano', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '363',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Gestão e Coordenação de Processos Educativos(Administração Escolar, Supervisão Escolar e Orientação Educ)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '183',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Gestão Hoteleira', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1022',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Gestão Social', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '309',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Gestão Social e Desenvolvimento Local', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '441',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Habilitação', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1120',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Habilitação em Matemática Bacharelado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '880',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Habilitação em Matemática Licenciatura Plena', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '878',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Habilitação Profissional Plena para Magistério de 1º Grau da 1ª à 4ª Série', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '994',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('História', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '837',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('História - Licenciatura', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '835',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('História Licenciatura', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '663',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Inglês', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '11',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Inglês(Cursos Antigos)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '61',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Inovação e Dinâmica Organizacional', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '404',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Inovação, Redes Empresariais e Competitividade', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '278',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Inovações Sociais, Educação e  Desenvolvimento Local', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '437',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Inspeção Escolar de 1.° e 2.° Graus', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '8',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Inspeção/Supervisão', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '201',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Interpretação', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '433',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Jornalismo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '3',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Jornalismo / Publicidade e Propaganda / Relações Públicas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '712',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Letras', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '809',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Letras-', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '307',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Letras - Licenciatura', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1042',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Letras - Tradutor ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '892',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Letras Licenciatura', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '654',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Letras Português-Inglês e Respectivas Literaturas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1097',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '195',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura.', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '185',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura de 1º Grau', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '376',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura em Ciências Biológicas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '388',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura em Ciências Econômicas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '498',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura em Comunicação Social', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '406',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura em Educação Física', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '390',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura em Filosofia', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '488',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura em Letras', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '529',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura em Processamento de Dados', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '467',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura em Psicologia', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '464',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura em 1º Grau', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '968',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura Magistério das Séries Iniciais do Ensino Fundamental', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1000',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura Plena', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '2',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura Plena*', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '564',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura Plena - Educação Infantil e Magistério dos Anos Iniciais do Ensino Fundamental', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '972',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura Plena - Lc', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '268',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura Plena - Português-Inglês', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '964',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura Plena - Português/Inglês', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '959',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura Plena - Português/Inglês - Intérprete', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '949',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura Plena - Tradutor', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '935',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura Plena Educação Infantil e Magistério dos Anos Iniciais do Ensino Fundamental', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '974',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura Plena em Educação Física', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '423',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura Plena em Letras', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '427',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura Plena em Matemática', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '590',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura Plena em Psicologia', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '469',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura Plena na Área de Letras', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '827',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Licenciatura-Português/Inglês', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1133',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Língua e Literatura Portuguesas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1149',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('LP 2 - Aspectos Socioculturais e Pedagógicos da Educação Física', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '622',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Magistério da Educação Infantil', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '76',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Magistério da Educação Infantil e dos anos Iniciais do Ensino Fundamental', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1026',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Magistério das Matérias Pedagógicas do Ensino de 2º Grau e das Séries Iniciais do Ensino de 1º Grau', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1143',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Magistério das Matérias Pedagógicas do Ensino Médio', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '343',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Magistério das Matérias Pedagógicas do Ensino Médio.', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '4',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Magistério das Matérias Pedagógicas do Ensino Médio. / Orientação Educacional / Supervisão Escolar de 1.° e 2.º Graus', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '667',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Magistério das Matérias Pedagógicas do Ensino Médio e em Adm Escolar', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1020',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Magistério das Matérias Pedagógicas do Ensino Médio e Supervisão Escolar ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1048',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Magistério das Matérias Pedagógicas do Ensino Médio/Orientação Educacional', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '207',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Magistério das Matérias Pedagógicas do Ensino Médio/Supervisão Escolar', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '205',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Magistério das Matérias Pedagógicas do Ensino Médio/Supervisão Escolar.', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '122',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('MAGISTÉRIO DAS MATÉRIAS PEDAGÓGICAS DO 2 GRAU', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1060',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Magistério das Matérias Pedagógicas do 2.° Grau/Supervisão Escolar do 1.° e 2.° Graus', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '571',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Magistério das Séries Iniciais do Ensino Fundamental', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '77',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Magistério dos Anos Iniciais do Ensino Fundamental', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '608',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Magistério dos Anos Iniciais do Ensino Fundamental.', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '775',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Magistério Para Educação Infantil', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '609',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Magistério para os anos iniciais do ensino fundamental', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1147',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Marketing', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '462',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Marketing.', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '24',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Marketing de Moda', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '815',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Marketing e Gestão de Negócios', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '106',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Marketing Interno', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '95',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Matemática', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '331',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Matemática do Ensino Médio', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '996',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Matemática Licenciatura', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '662',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Mba', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '738',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('MBA em Logística e Comércio Exterior', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '371',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('MBA Executivo em Administração de Empresas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '829',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Medicina Bacharelado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '657',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Medicina Bacharelado Em Medicina', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '648',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Medicina Veterinária Bacharelado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '653',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Médico', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '315',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Mercadologia', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '910',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Mestrado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '270',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Mestrado - Análises de Produtos Audiovisuais', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '791',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Mestrado - Atividade Empresarial e Constituição: Inclusão e Sustentabilidade', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '670',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Mestrado - O Direito Empresarial na Ordem Econômica Brasileira e Internacional', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '787',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Mestrado - Obrigações e Contratos Empresariais: Responsabilidade Social e Efetividade', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '671',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Mestrado - Processos Midiáticos na Cultura Audiovisual', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '793',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Mestrado - Relações Econômicas e Sociais, Estado Democrático de Direito e Políticas Públicas e Internacionais', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '789',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Mestrado em Administração', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '418',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('MESTRADO EM DIREITO EMPRESARIAL E CIDADANIA', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '728',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('MESTRADO EM DIREITO EMPRESARIAL E CIDADANIA.', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '731',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('MESTRADO EM DIREITO NAS RELAÇÕES ECONÔMICAS E SOCIAIS', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '825',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Mestrado em História', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '96',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Mestrado H', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '50',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Módulo A - Ênfase em Criação, Produção e Difusão em Propaganda', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '986',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Módulo A - Ênfase em Criação, Produção e Difusão em Propaganda (Habilitação)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '988',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Módulo A - Ênfase em Criação, Produção e Difusão em Propaganda (Habilitação) (Ênfase)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '990',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Módulo B - Ênfase em Mercadologia e Planejamento ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1028',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Multimídia', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '262',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Música', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '332',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Negócios Internacionais', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '855',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Novas Tecnologias em Educação e Treinamento', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '40',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Núcleo Comum', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '162',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Nutrição Bacharelado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '638',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Nutricionista', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '378',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Odontologia Bacharelado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '640',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Orientação', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '203',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Orientação Educacional', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '7',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Patrimonio Cultural', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '242',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Pedagogia', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '705',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Pedagogia Licenciatura', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '651',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Piano', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '333',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Pisicologo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '674',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Planejamento e Desenvolvimento do Turismo Sustentável', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '447',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Português', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '9',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Português / Inglês e Suas Respectivas Literaturas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1008',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Português e Inglês e respectivas Literaturas 1º grau', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1151',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Português e Literaturas  da Lingua Portuguesa', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '722',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Português/Espanhol', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '111',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Português/Francês', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '193',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Português/Inglês', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '66',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Pós-Graduação em Engenharia da Decisão ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '479',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Presencial', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '710',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Processos de Fabricação', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '521',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Processos de Fabricação e Materiais', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '519',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Processos de Prevenção e Promoção da Saúde', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '494',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Processos Educacionais: Tecnologias Sociais e Desenvolvimento Local', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '282',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Processos Educacionais: tecnologias sociais e desenvolvimento local.', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '290',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Processos Político-sociais: articulações institucionais e desenvolvimento local.', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '292',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Processos Político-sociais: Articulações Institucionais e Desenvolvimento Local ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '284',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Produção, Conservação e Segurança de Alimentos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '219',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Produção Editorial', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '12',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Programação Visual', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '335',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Projeto do Produto', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '327',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Projeto, Produção e Representação', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '361',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Promoção e Prevenção em Saúde', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '353',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Propaganda e Marketing', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '248',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Psicologia', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '513',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Psicologia Bacharelado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '656',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Psicologia Clínica - Abordagem Comportamental Cognitiva', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '396',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Psicologia Clínica - Abordagem Psicanalítica', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '531',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Psicologia Clínica - Abordagem Psicodinâmica', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '394',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Psicologia Clínica e Saúde', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '511',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Psicologia e Processos Clínicos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '805',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Psicologia e Processos de Gestão', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '398',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Psicologia e Processos Educativos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '392',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Psicologia e Processos Jurídicos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '807',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Psicologia Escolar e Educacional', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '410',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Psicologia nas Organizações', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '504',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Psicologia Organizacional', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '412',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Psicologia Trabalho', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '509',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Psicólogo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '456',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Psicólogo - LF', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '299',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Psicólogo-INATIVO', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '374',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Publicidade e Propaganda', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '13',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Publicidade e Propaganda - Módulo A - Ênfase em Criação, Produção e Dif. em Propaganda', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '982',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Publicidade e Propaganda - Módulo A - Ênfase em Criação, Produção e Difusão em Propaganda', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '984',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Publicidade e Propaganda - Módulo B', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1108',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Publicidade e Propaganda - Módulo B - Ênfase em Mercadologia e Planejamento', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '861',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Publicidade e Propaganda - Módulo B: Ênfase em Técnicas de ADM e Mercadologia em Publicidade e Propaganda', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '992',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('PUBLICIDADE E PROPAGANDA (Módulo B - Ênfase em Mercadologia e em Planejamento e Gerência de Propaganda) ', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '998',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Publicidade e Propaganda-Módulo B- Ênfase em Mercadologia e Planejamento', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1032',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Qualificação Profissional em Estética Facial e Corporal', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '523',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Química Licenciatura', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '650',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Radialismo (Rádio e Televisão)', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '341',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Rádio e TV', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '243',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Recursos Humanos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '249',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Recursos Humanos - LF', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '344',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Relações Públicas', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '14',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Saúde e Funcionalidade no Envelhecimento', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '594',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Saúde, Educação e Qualidade de Vida', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '367',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Secretariado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1137',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Secretariado Executivo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1058',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Sequencial', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1024',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Seqüencial', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '84',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Serviço Social Bacharelado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '641',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Sistemas Construtivos: Tecnologia dos Materiais, Produtos e Aplicações', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '402',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Sistemas de Informação Bacharelado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '652',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Sistemas de Informações Gerenciais', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '246',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Sistemas Informação', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '901',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Supervisão de Ensino e Treinamento de Pessoal', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '340',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Supervisão Escolar', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '326',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Supervisão Escolar de 1.° e 2.º Graus', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '6',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Supervisão Escolar nos anos iniciais do Ensino Fundamental', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '245',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tecnico', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '541',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Técnico', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '305',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tecnico - Pronatec', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '708',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Técnico em Informática', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '386',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tecnologia', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '147',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tecnologia - hhh', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '19',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tecnologia e Desenvolvimento de Produtos', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '189',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tecnologia Educacional', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '874',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tecnologia Educacional - Bacharel', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '886',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tecnologia Educacional - Bacharelado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '882',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tecnologia Educacional - Licenciatura Plena', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '863',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tecnólogo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '916',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tecnólogo Em Gestão de Recursos Humanos Bacharelado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '647',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tecnólogo Em Logística', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '633',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tecnólogo Em Sistemas Para Internet', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '607',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tecnólogo Em Sistemas Para Internet.', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '720',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Telecomunicações', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '160',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Telecomunicações e Eletrônica Industrial', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '451',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Trabalho Social com Famílias no Âmbito Público e Privado', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '347',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tradutor', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '888',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tradutor e Intérprete', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '330',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tradutor-Portiguês/Inglês', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '912',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tradutor-Português/Inglês', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '914',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Trompete', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '321',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Tronco Comum', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '918',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Turismo', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '1040',  (select max("Id") from public."NivelCurso"));
INSERT INTO public."NivelCurso"(
	"Nome", "Ativo", "Key", "CriadoEm", "AlteradoEm")
	VALUES ('Turismo e Meio Ambiente', true,  gen_uuid(), current_timestamp, current_timestamp);
	INSERT INTO public."IntegracaoNivel"(
	"IntegracaoSistemaId", "CodigoOrigem", "NivelCursoId")
	VALUES ((select "Id" from "SistemaIntegracao" where "Nome" = 'Vestib'), '443',  (select max("Id") from public."NivelCurso"));