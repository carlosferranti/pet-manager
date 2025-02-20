using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class IntegracaoSistemaConstants
{
    public static readonly IntegracaoSistema IntegracaoSistemaPortfolio =
      IntegracaoSistema.Criar("Portfólio")
      .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o sistema de integração Portfólio.");

    public static readonly IntegracaoSistema IntegracaoSistemaSalesforce =
      IntegracaoSistema.Criar("Salesforce")
      .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o sistema de integração Salesforce.");

    public static readonly IntegracaoSistema IntegracaoSistemaVestib =
        IntegracaoSistema.Criar("Vestib")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o sistema de integração Vestib.");
}
