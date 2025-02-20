using Anima.Inscricao.Application.DTOs._Shared;

namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class InscricaoOfertaDto
{
    public Guid? OfertaKey { get; set; }

    public Guid? OfertaConcursoKey { get; set; }

    public ItemListaIntegracaoDto? Instituicao { get; set; }

    public InscricaoOfertaConcursoDto? Concurso { get; set; }

    public ItemDto? Turno { get; set; }

    public ItemDto? Campus { get; set; }

    public InscricaoCursoDto? Curso { get; set; }

    public ItemDto? Intake { get; set; }

    public string? PeriodoLetivo { get; set; }

    public List<InscricaoFormaEntradaDto>? FormasEntrada { get; set; }
}