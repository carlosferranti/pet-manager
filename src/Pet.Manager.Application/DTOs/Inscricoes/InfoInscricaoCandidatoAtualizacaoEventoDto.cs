using System.Text.Json.Serialization;

using Anima.Inscricao.Application.DTOs._Shared;
using Anima.Inscricao.Application.DTOs.Marcas;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Domain.Inscricoes.Enums;

using Microsoft.AspNetCore.Http;

namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class InfoInscricaoCandidatoAtualizacaoEventoDto
{
    public Guid InscricaoKey { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public MarcaDto? InfoMarca { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IEnumerable<SistemaIntegracaoDto>? InfoOrigens { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public AtualizarInfosFichaDto? InfosFicha { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public AtualizarInfosPessoaisDto? InfosPessoais { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public AtualizarInfosOfertaDto? InfosOferta { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<AtualizarInfosContatoDto>? InfosContato { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<AtualizarInfosCupomDto>? InfosCupons { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public AtualizarInfosConcursoDto? InfosConcurso { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<AtualizarInfosEnderecoDto>? InfosEndereco { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<AtualizarInfosDocumentoDto>? InfosDocumento { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public AtualizarInfosOrigemDto? InfoOrigem { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<AtualizarInfosSeguroFiancaDto>? InfosSeguroFianca { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<AtualizarInfosDocumentacaoDto>? InfosDocumentacao { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<AtualizarInfosAcessibilidadeDto> InfosAcessibilidade { get; set; } = new();

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<AtualizarInfosDeficienciaDto> InfosDeficiencia { get; set; } = new();

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<AtualizarInfosEscolaridadeDto> InfosEscolaridade { get; set; } = new();

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public AtualizarEtapaDto? InfosEtapa { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public InfoFormaEntradaDto? InfosFormaEntrada { get; set; }

    public record InfoFormaEntradaDto
    {
        public Guid Key { get; set; }

        public string Nome { get; set; } = string.Empty;
    }

    public record AtualizarInfosOfertaDto
    {
        public Guid? OfertaKey { get; set; }

        public AtualizarInfosProdutoDto? Produto { get; set; }
    }

    public record AtualizarInfosProdutoDto
    {
        public string? Campus { get; set; }
        
        public string? Turno { get; set; }

        public AtualizarInfosCursoDto? Curso { get; set; }
    }

    public record AtualizarInfosCursoDto
    {
        public string? Nome { get; set; }

        public IEnumerable<SistemaIntegracaoDto>? SistemaIntegracao { get; set; }
    }

    public record AtualizarInfosPessoaisDto
    {
        public string? Nome { get; set; }

        public DateTime? DataNascimento { get; set; }

        public int? Sexo { get; set; }

        public bool? NecessidadeEspecial { get; set; }

        public string? NomeSocial { get; set; }
    }

    public record AtualizarInfosContatoDto
    {
        public string? Tipo { get; set; }

        public string? Valor { get; set; }
    }

    public record AtualizarInfosCupomDto
    {
        public string? Codigo { get; set; }
        
        public IEnumerable<SistemaIntegracaoDto>? SistemaIntegracao { get; set; }
    }

    public record AtualizarInfosConcursoDto
    {
        public string? Nome { get; set; }

        public IEnumerable<SistemaIntegracaoDto>? SistemaIntegracao { get; set; }
    }

    public record AtualizarInfosEnderecoDto
    {
        public TipoEnderecoInscricao? Tipo { get; set; }

        public string? Cep { get; set; }

        public string? Rua { get; set; }

        public string? Numero { get; set; }

        public string? Complemento { get; set; }

        public string? Bairro { get; set; }

        public string? Cidade { get; set; }

        public string? Estado { get; set; }

        public string? Pais { get; set; }
    }

    public record AtualizarInfosDocumentoDto
    {
        public string? Valor { get; set; }

        public string? Tipo { get; set; }
    }

    public record AtualizarInfosOrigemDto
    {
        public TipoOrigemInscricao? Origem { get; set; }
    }

    public record AtualizarInfosSeguroFiancaDto
    {
        public string? NomeFiador { get; init; }

        public string? TipoRelacionamentoSegurado { get; init; }

        public decimal? PercentualFiador { get; init; }

        public decimal? RendaMediaMensal { get; init; }

        public TipoDocumentoInscricao? TipoDocumento { get; init; }

        public string? ValorDocumento { get; init; }

        public TipoContatoInscricao? TipoContato { get; init; }

        public string? ValorContato { get; init; }
    }

    public record AtualizarInfosDocumentacaoDto
    {
        public string? Observacoes { get; set; }

        public TipoDocumentacaoInscricao? Tipo { get; set; }

        public IFormFile? Arquivo { get; init; }
    }

    public record AtualizarInfosFichaDto
    {
        public Guid FichaKey { get; set; }

        public Guid EtapaKey { get; set; }
    }

    public record AtualizarInfosAcessibilidadeDto
    {
        public Guid? AcessibilidadeKey { get; set; }
    }

    public record AtualizarInfosDeficienciaDto
    {
        public Guid? DeficienciaKey { get; set; }
    }

    public record AtualizarInfosEscolaridadeDto
    {
        public int? AnoConclusao { get; set; }

        public Guid? EstadoKey { get; set; }

        public Guid? CidadeKey { get; set; }

        public Guid? EscolaKey { get; set; }

        public string? OutraEscola { get; set; }

        public TipoEscolaridadeInscricao? Nivel { get; set; }

        public Guid? CursoExternoKey { get; set; }

        public string? CidadeNome { get; set; }

        public ItemDto? Escola { get; set; }
    }

    public record AtualizarEtapaDto
    {
        public Guid Key { get; set; }

        public string Nome { get; set; } = string.Empty;

        public int? Sequencia { get; set; }
    }
}
