using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Cofiguracao;

namespace Anima.Inscricao.Application.UseCases.Configuracoes.ObterConfiguracao;

public class ObterConfiguracaoQuery : IQuery<ConfiguracaoDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
