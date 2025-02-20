using Anima.Inscricao.Application.DTOs.OfertaConcursos;

namespace Anima.Inscricao.Application.DTOs.Concursos;

public class ConcursosPorOfertaDto
{
    public int OrdemExibicao { get; set; }

    public Guid FormaEntradaKey { get; set; }

    public string NomeFormaEntrada { get; set; } = string.Empty;

    public string DescricaoFormaEntrada { get; set; } = string.Empty;

    public List<ConcursosFormaEntradaDto> Concursos { get; set; } = new();

    public class ConcursosFormaEntradaDto
    {
        public Guid ConcursoKey { get; set; }

        public Guid OfertaConcursoKey { get; set; }

        public string NomeConcurso { get; set; } = string.Empty;

        public DateTimeOffset? DataInicioProva { get; set; }

        public DateTimeOffset? DataTerminoProva { get; set; }

        public string? HoraInicioProva { get; set; }

        public string? HoraTerminoProva { get; set; }

        public string Modalidade { get; set; } = string.Empty;

        public string? NomeModalidadeAvaliacao { get; set; }

        public List<OpcaoAcessoDto>? OpcaoAcessos { get; set; }
    }
}
