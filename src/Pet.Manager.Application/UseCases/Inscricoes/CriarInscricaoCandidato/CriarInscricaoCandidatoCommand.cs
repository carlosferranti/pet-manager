using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.Enums;
using Anima.Inscricao.Domain.Inscricoes.Enums;
namespace Anima.Inscricao.Application.UseCases.Inscricoes.CriarInscricaoCandidato;

public class CriarInscricaoCandidatoCommand : ICommand<EntityKeyDto?>
{
    public Guid? FichaKey { get; set; }

    public Guid? EtapaKey { get; set; }

    public Guid MarcaKey { get; set; }

    public CriarInfosOfertaCommand? InfosOferta { get; set; }

    public CriarInfosPessoaisCommand? InfosPessoais { get; set; }

    public List<CriarInfosContatoCommand> InfosContato { get; set; } = new();

    public List<CriarInfosCupomCommand> InfosCupons { get; set; } = new();

    public List<CriarInfosEnderecoCommand> InfosEndereco { get; set; } = new();

    public List<CriarInfosDocumentoCommand> InfosDocumento { get; set; } = new();

    public CriarInfosOrigemCommand InfoOrigem { get; set; } = new();

    public List<CriarInfosSeguroFiancaCommand> InfosSeguroFianca { get; set; } = new();

    public List<CriarInfosAcessibilidadeCommand> InfosAcessibilidade { get; set; } = new();

    public List<CriarInfosDeficienciaCommand> InfosDeficiencia { get; set; } = new();

    public List<CriarInfosEscolaridadeCommand> InfosEscolaridade { get; set; } = new();

    public CriarInfosEmpresaCommand? InfosEmpresa { get; set; }

    public CriarInfosMatriculaCommand? InfosMatricula { get; set; }

    public List<CriarInfosFiliacaoCommand> InfosFiliacao { get; set; } = new();
    
    public record CriarInfosFiliacaoCommand
    {
        public string Nome { get; set; } = string.Empty;

        public TipoFiliacaoInscricao Tipo { get; set; }
    }

    public record CriarInfosMatriculaCommand
    {
        public string CodigoAluno { get; set; } = string.Empty;

        public string? Ra { get; set; }

        public StatusMatricula CodigoStatusAluno { get; set; }
    }

    public record CriarInfosOfertaCommand
    {
        public Guid? OfertaConcursoKey { get; set; }

        public Guid? OfertaKey { get; set; }

        public Guid? FormaEntradaKey { get; set; }

        public List<CriarInfoOfertaOpcaoAcessoCommand>? OfertaConcursoOpcaoAcessos { get; set; } = new();
    }

    public record CriarInfoOfertaOpcaoAcessoCommand
    {
        public Guid Key { get; set; }

        public decimal? Percentual { get; set; }
    }

    public record CriarInfosPessoaisCommand
    {
        public string? Nome { get; set; }

        public DateTime? DataNascimento { get; set; }

        public int? Sexo { get; set; }

        public bool? NecessidadeEspecial { get; set; }

        public string? NomeSocial { get; set; }
    }

    public record CriarInfosContatoCommand
    {
        public TipoContatoInscricao? Tipo { get; set; }

        public string? Valor { get; set; }
    }

    public record CriarInfoVoucherCommand
    {
        public string? Codigo { get; set; }
    }

    public record CriarInfosEnderecoCommand
    {
        public TipoEnderecoInscricao? Tipo { get; set; }

        public string? Cep { get; set; }

        public string? Rua { get; set; }

        public string? Numero { get; set; }

        public string? Complemento { get; set; }

        public string? Bairro { get; set; }

        public string? Cidade { get; set; }

        public string? Estado { get; set; }
    }

    public record CriarInfosDocumentoCommand
    {
        public string? Valor { get; set; }

        public TipoDocumentoInscricao? Tipo { get; set; }
    }

    public record CriarInfosOrigemCommand
    {
        public TipoOrigemInscricao Tipo { get; set; }

        public string? Url { get; set; }

        [JsonIgnore]
        public string? clientHost { get; set; }
    }

    public record CriarInfosSeguroFiancaCommand
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

    public record CriarInfosCupomCommand
    {
        public string? Codigo { get; set; }
    }

    public record CriarInfosAcessibilidadeCommand
    {
        public Guid? AcessibilidadeKey { get; set; }
    }

    public record CriarInfosDeficienciaCommand
    {
        public Guid? DeficienciaKey { get; set; }
    }

    public record CriarInfosEscolaridadeCommand
    {
        public int? AnoConclusao { get; set; }

        public Guid? EstadoKey { get; set; }

        public Guid? CidadeKey { get; set; }

        public Guid? EscolaKey { get; set; }

        public string? OutraEscola { get; set; }
        
        public TipoEscolaridadeInscricao? Nivel {  get; set; }

        public Guid? CursoExternoKey { get; set; }

        public bool InstituicaoEstrangeira { get; set; }
    }

    public record CriarInfosEmpresaCommand
    {
        public Guid? EmpresaKey { get; set; }

        public string? OutraEmpresa { get; set; }

        public TipoEscolaridadeInscricao? Nivel {  get; set; }
    }
}