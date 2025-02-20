using Anima.Inscricao.Application.DTOs.Fichas;
using Anima.Inscricao.Application.DTOs.Marcas;

namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class InscricaoCandidatoCriadaEventDto
{
    public Guid? InscricaoKey { get; set; }

    public InscricaoFichaDto? InscricaoFicha { get; set; }

    public List<InscricaoContatoDto> InscricaoContatos { get; set; } = new();

    public InscricaoCandidatoDto? InscricaoCandidato { get; set; }

    public MarcaDto? InscricaoMarca { get; set; }

    public InscricaoOrigemDto? InscricaoOrigem { get; set; }

    public List<InscricaoEscolaridadeDto> Escolaridades { get; set; } = new();

    public List<InscricaoDocumentoDto> InfosDocumento { get; set; } = new();

    public EtapaFichaDto? InscricaoEtapa { get; set; }
}
