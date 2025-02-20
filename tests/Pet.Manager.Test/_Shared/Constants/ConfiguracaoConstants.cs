using Anima.Inscricao.Domain.Configuracoes.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class ConfiguracaoConstants
{
    public static readonly Configuracao ConfiguracaoPadrao =
        Configuracao.Criar("dataPrimeiraExecução", "05/09/2024 14:52:14")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a configuração padrão");

    public static readonly Configuracao ConfiguracaoPadrao2 =
        Configuracao.Criar("dataUltimaExecução", "05/09/2024 14:52:14")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a configuração padrão 2");

    public static readonly Configuracao ConfiguracaoPadrao3 =
        Configuracao.Criar("dataExecuçãoIntermediaria", "05/09/2024 14:52:14")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a configuração padrão 2");
}
