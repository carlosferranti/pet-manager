CREATE TABLE "DeficienciaAcessibilidade" (
    "Id" SERIAL PRIMARY KEY,
    "DeficienciaId" INT NOT NULL,
    "AcessibilidadeId" INT NOT NULL,
    CONSTRAINT FK_Deficiencia FOREIGN KEY ("DeficienciaId") REFERENCES "Deficiencia"("Id"),
    CONSTRAINT FK_Acessibilidade FOREIGN KEY ("AcessibilidadeId") REFERENCES "Acessibilidade"("Id")
);
