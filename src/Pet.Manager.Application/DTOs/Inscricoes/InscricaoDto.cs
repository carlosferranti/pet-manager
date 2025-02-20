using Anima.Inscricao.Application.DTOs.Acessibilidades;
using Anima.Inscricao.Application.DTOs.Deficiencias;
using Anima.Inscricao.Application.DTOs.Fichas;
using Anima.Inscricao.Application.DTOs.Instituicao;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Domain.Inscricoes.Enums;

namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class InscricaoDto
{
    public int Numero { get; set; }

    public Guid Key { get; set; }

    public DateTimeOffset? CriadoEm { get; set; }

    public DateTimeOffset? AlteradoEm { get; set; }

    public InscricaoInfosPessoaisDto? Candidato { get; set; }

    public InscricaoOfertaDto? Oferta { get; set; }

    public InscricaoFichaDto? Ficha { get; set; }

    public InscricaoMarcaDto? Marca { get; set; }

    public IEnumerable<InscricaoContatoDto>? Contatos { get; set; }

    public IEnumerable<InscricaoEnderecoDto>? Enderecos { get; set; }

    public IEnumerable<InscricaoDocumentoDto>? Documentos { get; set; }

    public IEnumerable<InscricaoDocumentacaoDto>? Documentacoes { get; set; }

    public IEnumerable<AcessibilidadeDto>? Acessibilidades { get; set; }

    public IEnumerable<DeficienciaDto>? Deficiencias { get; set; }

    public IEnumerable<InscricaoEscolaridadeDto>? Escolaridades { get; set; }

    public IEnumerable<InscricaoOpcaoAcessoDto>? OpcoesAcesso { get; set; }

    public IEnumerable<InscricaoCupomDto>? Cupons { get; set; }

    public IEnumerable<InscricaoMatriculaDto>? Matriculas { get; set; }

    public EtapaFichaDto? Etapa { get; set; }

    public string Status { get; set; } = string.Empty;

    public InstituicaoLinkDto? LinkRedireconamentoInstituicao { get; set; }

    public IEnumerable<SistemaIntegracaoDto>? Integracoes { get; set; }

    public bool InscricaoCancelada { get; set; }
}
