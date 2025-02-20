using Anima.Inscricao.Domain.CursosExternos.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class CursoExternoConstants
{
    public static readonly CursoExterno AbiArtesVisuais = CriarCursoExternoComIntegracao("ABI - ARTES VISUAIS", "1");

    public static readonly CursoExterno Radialismo = CriarCursoExternoComIntegracao("RADIALISMO", "2");

    public static readonly CursoExterno LetrasChines = CriarCursoExternoComIntegracao("LETRAS - CHINÊS", "3");

    private static CursoExterno CriarCursoExternoComIntegracao(string nome, string codigoOrigem) 
    {
        var curso = CursoExterno.Criar(nome).ObterRetorno() ?? throw new ArgumentException($"Erro ao criar o curso {nome}");

        curso.AdicionarIntegracao(new IntegracaoSistemaId(1), codigoOrigem);
        curso.AdicionarIntegracao(new IntegracaoSistemaId(2), codigoOrigem);

        return curso;
    }
}
