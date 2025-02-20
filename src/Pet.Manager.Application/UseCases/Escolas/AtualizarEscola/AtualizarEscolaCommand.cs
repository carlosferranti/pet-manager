using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain.Escolas.Enums;

namespace Anima.Inscricao.Application.UseCases.Escolas.AtualizarEscola;

public class AtualizarEscolaCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public int? CodigoInep { get; set; }

    public Guid? CidadeKey { get; set; }

    public TipoCategoriaEscola TipoCategoria { get; set; }
}
