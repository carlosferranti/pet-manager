using Anima.Inscricao.Domain.Acessibilidades.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class AcessibilidadeConstants
{
    public static readonly Acessibilidade InterpreterDeLibras = Acessibilidade.Criar("Interpreter de Libras")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a acessibilidade Interpreter de Libras");

    public static readonly Acessibilidade ProvaBraile = Acessibilidade.Criar("Prova braile")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a acessibilidade Prova braile");

    public static readonly Acessibilidade Transcritor = Acessibilidade.Criar("Transcritor")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a acessibilidade Transcritor");

    public static readonly Acessibilidade Ledor = Acessibilidade.Criar("Ledor")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a acessibilidade Ledor");
}
