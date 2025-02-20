using Anima.Inscricao.Application.DTOs.Acessibilidades;
using Anima.Inscricao.Application.DTOs.Deficiencias;
using Anima.Inscricao.Application.DTOs.Marcas;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class InscricaoCandidatoEventoDto
{
    public Guid InscricaoKey { get; set; }

    public DateTimeOffset? CriadoEm { get; set; }

    public DateTimeOffset? AlteradoEm { get; set; }

    public InscricaoCandidatoDto? Candidato { get; set; }

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

    public IEnumerable<SistemaIntegracaoDto>? InfoOrigens { get; set; }

    public IEnumerable<InscricaoOpcaoAcessoDto>? OpcaoAcesso { get; set; }

    public IEnumerable<InscricaoCupomDto>? Cupons { get; set; }

    public IEnumerable<InscricaoMatriculaDto>? Matriculas { get; set; }
}