using Anima.Inscricao.Domain.Etapas.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class EtapaConstants
{
    public static readonly EtapaTemplate EtapaDadosPessoais = 
        EtapaTemplate.Criar("Dados pessoais", "Solicitação dos dados pessoais.", "arquivo.yaml")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a etapa Dados Pessoais");

    public static readonly EtapaTemplate EtapaDadosContato =
        EtapaTemplate.Criar("Dados de contato", "Solicitação dos dados de contato.", "arquivo.yaml")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a etapa Dados de Contato");

    public static readonly EtapaTemplate EtapaEndereco =
        EtapaTemplate.Criar("Dados de endereço", "Solicitação dos dados de endereço.", "arquivo.yaml")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a etapa Dados de endereço");
}