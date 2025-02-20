namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class InscricaoCandidatoDto
{
    public int Id { get; set; }
    public int FichaId { get; set; }
    public int OfertaId { get; set; }
    public int OfertaConcursoId { get; set; }
    public string? Nome { get; set; }
    public DateOnly? DataNascimento { get; set; }
    public int? Sexo { get; set; }
    public bool? NecessidadeEspecial { get; set; }
    public string? NomeSocial { get;  set; }
    public Guid? Key { get; set; }
    public DateTime? CriadoEm { get; set; }
    public DateTime? AlteradoEm { get; set; }
    public int? MarcaId { get; set; }
    public int? FormaEntradaId { get; set; }
}