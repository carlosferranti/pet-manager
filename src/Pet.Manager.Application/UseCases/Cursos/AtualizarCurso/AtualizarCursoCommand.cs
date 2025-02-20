using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Cursos.AtualizarCurso;

public class AtualizarCursoCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string? NomeComercial { get; set; }

    public Guid ModalidadeKey { get; set; }

    public Guid TipoFormacaoKey { get; set; }

    public Guid NivelCursoKey { get; set; }

    public Guid InstituicaoKey { get; set; }
}
