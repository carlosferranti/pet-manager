using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application.DTOs.Concursos;

namespace Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoInscricaoAtiva;

public class ProcessarRegraConcursoInscricaoAtivaCommand : ICommand<List<ConcursosPorOfertaDto>>
{
    public List<ConcursosPorOfertaDto> FormasEntrada { get; set; } = new();

    public Guid IntakeKey { get; set; }

    public Guid MarcaKey { get; set; }

    public string Cpf { get; set; } = string.Empty;
}