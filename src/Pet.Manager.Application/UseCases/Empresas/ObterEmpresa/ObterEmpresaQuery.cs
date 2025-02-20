using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Empresas;

namespace Anima.Inscricao.Application.UseCases.Empresas.ObterEmpresa;

public class ObterEmpresaQuery : IQuery<EmpresaDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}