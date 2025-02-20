using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.NiveisCurso.AtualizarNivelCurso;

public class AtualizarNivelCursoCommand : ICommand
{
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;
}
