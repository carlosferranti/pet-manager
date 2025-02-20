using System.Text.Json.Serialization;

using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Application.DTOs.Cursos;
using Anima.Inscricao.Application.DTOs.Marcas;
using Anima.Inscricao.Application.DTOs.Turnos;
using Anima.Inscricao.Domain._Shared.Enums;
using Anima.Inscricao.Domain.Inscricoes.Enums;

namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class InscricaoCandidatoDocumentacaoAtualizacaoEventoDto
{
    public int NumeroInscricao { get; set; }

    public Guid InscricaoKey { get; set; }

    public MarcaDto? InfoMarca { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public InscricaoCandidatoDocumentacaoInfosPessoaisDto? InfosPessoais { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public InscricaoCandidatoDocumentacaoInfosOfertaDto? InfosOferta { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<InscricaoCandidatoDocumentacaoInfosDocumentoDto>? InfosDocumento { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<InscricaoCandidatoDocumentacaoInfosDocumentacaoDto>? InfosDocumentacao { get; set; }

    public record InscricaoCandidatoDocumentacaoInfosOfertaDto
    {
        public CursoDto? Curso { get; set; }

        public TurnoDto? Turno { get; set; }

        public ConcursoEventoDto? Concurso { get; set; }

        public IEnumerable<InscricaoFormaEntradaDto>? FormasEntrada { get; set; }

        public record OfertaFormaEntrada(int Id, string Nome);
    }

    public record InscricaoCandidatoDocumentacaoInfosPessoaisDto
    {
        public string? Nome { get; set; }

        public DateTime? DataNascimento { get; set; }

        public int? Sexo { get; set; }

        public bool? NecessidadeEspecial { get; set; }

        public string? NomeSocial { get; set; }
    }

    public record InscricaoCandidatoDocumentacaoInfosDocumentoDto
    {
        public string? Valor { get; set; }

        public TipoDocumentoInscricao? Tipo { get; set; }
    }

    public record InscricaoCandidatoDocumentacaoInfosDocumentacaoDto
    {
        public Guid Key { get; set; }

        public string? Observacoes { get; set; }

        public string Tipo { get; set; } = string.Empty;

        public TipoLocalArquivo TipoLocalArquivo { get; set; }

        public string ChaveArquivo { get; set; } = string.Empty;

        public string NomeArquivo { get; set; } = string.Empty;

        public string ExtensaoArquivo { get; set; } = string.Empty;

        public long TamanhoArquivo { get; set; }

        public TipoAcaoRegistro Acao { get; set; }
    }
}
