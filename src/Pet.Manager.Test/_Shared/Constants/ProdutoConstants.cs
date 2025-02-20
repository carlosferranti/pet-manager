using Anima.Inscricao.Domain.Campi.Entities;
using Anima.Inscricao.Domain.Cursos.Entities;
using Anima.Inscricao.Domain.Instituicoes.Entities;
using Anima.Inscricao.Domain.Produtos.Entities;
using Anima.Inscricao.Domain.Turnos.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class ProdutoConstants
{
    public static readonly Produto ProdutoTeste1 =
           Produto.Criar(new InstituicaoId(1), new CampusId(1), new CursoId(1), new TurnoId(1), "Teste1")
           .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o Produto Teste1");

    public static readonly Produto ProdutoTeste2 =
        Produto.Criar(new InstituicaoId(2), new CampusId(2), new CursoId(2), new TurnoId(2), "Teste2")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o Produto Teste2");
}
