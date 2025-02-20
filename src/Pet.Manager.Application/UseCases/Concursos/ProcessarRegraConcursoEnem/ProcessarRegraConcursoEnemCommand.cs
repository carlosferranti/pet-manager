using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application.DTOs.Concursos;

namespace Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoEnem;

public class ProcessarRegraConcursoEnemCommand : ICommand<List<ConcursosPorOfertaDto>>
{
    public List<ConcursosPorOfertaDto> Concursos { get; set; } = new();

    public string Cpf { get; set; } = null!;

    public Guid IntakeKey { get; set; }

    public Guid MarcaKey { get; set; }

    public Guid ModalidadeKey { get; set; }
}