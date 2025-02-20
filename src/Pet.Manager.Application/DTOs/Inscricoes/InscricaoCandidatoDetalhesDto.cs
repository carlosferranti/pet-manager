using Anima.Inscricao.Application.DTOs.Acessibilidades;
using Anima.Inscricao.Application.DTOs.Deficiencias;
using Anima.Inscricao.Application.DTOs.Fichas;
using Anima.Inscricao.Domain.Inscricoes.Enums;

namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class InscricaoCandidatoDetalhesDto
{
    public int Numero { get; set; }

    public Guid Key { get; set; }

    public DateTimeOffset? CriadoEm { get; set; }

    public DateTimeOffset? AlteradoEm { get; set; }

    public StatusInscricaoDto? Status { get; set; }

    public InscricaoMarcaDto? InfosMarca { get; set; }

    public InscricaoFichaDto? InfosFicha { get; set; }

    public InfosPessoaisDto? InfosPessoais { get; set; }

    public InscricaoOfertaDto? InfosOferta { get; set; }

    public EtapaFichaDto? InfosEtapa { get; set; }

    public InscricaoOrigemDto? InfosOrigem { get; set; }

    public InscricaoEmpresaDto? InfosEmpresa { get; set; }

    public List<InscricaoContatoDto>? InfosContato { get; set; }

    public List<InscricaoCupomDto>? InfosCupons { get; set; }

    public List<InscricaoEnderecoDto>? InfosEndereco { get; set; }

    public List<InscricaoDocumentoDto>? InfosDocumento { get; set; }

    public List<InscricaoMatriculaDto>? InfosMatriculas { get; set; }

    public List<AcessibilidadeDto> InfosAcessibilidade { get; set; } = new();

    public List<DeficienciaDto> InfosDeficiencia { get; set; } = new();

    public List<InscricaoEscolaridadeDto> InfosEscolaridade { get; set; } = new();

    public List<InscricaoDocumentacaoDto>? InfosDocumentacoes { get; set; }

    public List<InscricaoOpcaoAcessoDto>? InfosOpcoesAcesso { get; set; }

    public List<InscricaoSeguroFiancaDto>? InfosSeguroFianca { get; set; }

    public List<InscricaoFiliacaoDto>? InfosFiliacao { get; set; }

    public record InfosPessoaisDto
    {
        public string? Nome { get; set; }

        public DateOnly? DataNascimento { get; set; }

        public int? Sexo { get; set; }

        public bool? NecessidadeEspecial { get; set; }

        public string? NomeSocial { get; set; }
    }
}
