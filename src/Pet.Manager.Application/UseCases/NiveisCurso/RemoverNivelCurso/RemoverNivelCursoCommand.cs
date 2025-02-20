using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.NiveisCurso.RemoverNivelCurso;

public class RemoverNivelCursoCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
