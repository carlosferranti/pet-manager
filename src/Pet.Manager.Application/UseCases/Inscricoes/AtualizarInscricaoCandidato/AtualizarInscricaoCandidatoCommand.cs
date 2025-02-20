using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application.Enums;
using Anima.Inscricao.Domain.Inscricoes.Enums;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.AtualizarInscricaoCandidato;

public class AtualizarInscricaoCandidatoCommand : ICommand
{
    [JsonIgnore]
    public Guid InscricaoKey { get; set; }

    public AtualizarInfosFichaCommand? InfosFicha { get; set; }

    public AtualizarInfosPessoaisCommand? InfosPessoais { get; set; }

    public AtualizarInfosOfertaCommand? InfosOferta { get; set; }

    public List<AtualizarInfosContatoCommand>? InfosContato { get; set; }

    public List<AtualizarInfosCupomCommand>? InfosCupons { get; set; }

    public List<AtualizarInfosEnderecoCommand>? InfosEndereco { get; set; }

    public List<AtualizarInfosDocumentoCommand>? InfosDocumento { get; set; }

    public AtualizarInfosOrigemCommand? InfoOrigem { get; set; }

    public List<AtualizarInfosSeguroFiancaCommand>? InfosSeguroFianca { get; set; }

    public List<AtualizarInfosAcessibilidadeCommand>? InfosAcessibilidade { get; set; }

    public List<AtualizarInfosDeficienciaCommand>? InfosDeficiencia { get; set; }

    public List<AtualizarInfosEscolaridadeCommand>? InfosEscolaridade { get; set; }

    public AtualizarInfosEmpresaCommand? InfosEmpresa { get; set; }

    public AtualizarInfosMatriculaCommand? InfosMatricula { get; set; }

    public List<AtualizarInfosFiliacaoCommand> InfosFiliacao { get; set; } = new();

    public record AtualizarInfosFiliacaoCommand
    {
        public string Nome { get; set; } = string.Empty;

        public TipoFiliacaoInscricao Tipo { get; set; }
    }

    public record AtualizarInfosMatriculaCommand
    {
        public string CodigoAluno { get; set; } = string.Empty;

        public string? Ra { get; set; }

        public StatusMatricula CodigoStatusAluno { get; set; }
    }

    public record AtualizarInfosOfertaCommand
    {
        public Guid? OfertaConcursoKey { get; set; }

        public Guid? OfertaKey { get; set; }

        public Guid? FormaEntradaKey { get; set; }

        public List<AtualizarInfoOfertaOpcaoAcessoCommand>? OfertaConcursoOpcaoAcessos { get; set; }
    }

    public record AtualizarInfoOfertaOpcaoAcessoCommand
    {
        public Guid Key { get; set; }

        public decimal? Percentual { get; set; }
    }

    public record AtualizarInfosPessoaisCommand
    {
        public string? Nome { get; set; }

        public DateTime? DataNascimento { get; set; }

        public int? Sexo { get; set; }

        public bool? NecessidadeEspecial { get; set; }

        public string? NomeSocial { get; set; }
    }

    public record AtualizarInfosContatoCommand
    {
        public TipoContatoInscricao? Tipo { get; set; }

        public string? Valor { get; set; }
    }

    public record AtualizarInfosCupomCommand
    {
        public string? Codigo { get; set; }
    }

    public record AtualizarInfosEnderecoCommand
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

    public record AtualizarInfosDocumentoCommand
    {
        public string? Valor { get; set; }

        public TipoDocumentoInscricao? Tipo { get; set; }
    }

    public record AtualizarInfosOrigemCommand
    {
        public TipoOrigemInscricao? Origem { get; set; }
    }

    public record AtualizarInfosSeguroFiancaCommand
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

    public record AtualizarInfosFichaCommand
    {
        public Guid FichaKey { get; set; }

        public Guid EtapaKey { get; set; }
    }

    public record AtualizarInfosAcessibilidadeCommand
    {
        public Guid? AcessibilidadeKey { get; set; }
    }

    public record AtualizarInfosDeficienciaCommand
    {
        public Guid? DeficienciaKey { get; set; }
    }

    public record AtualizarInfosEscolaridadeCommand
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

    public record AtualizarInfosEmpresaCommand
    {
        public Guid? EmpresaKey { get; set; }

        public string? OutraEmpresa { get; set; }
    }
}