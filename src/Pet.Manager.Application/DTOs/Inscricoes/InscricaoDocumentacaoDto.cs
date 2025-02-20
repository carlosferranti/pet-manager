namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class InscricaoDocumentacaoDto
{
    public Guid Key { get; set; }

    public string? Tipo { get; set; }

    public int? CodigoTipo { get; set; }

    public string? Observacoes { get; set; }

    public int? TipoLocalArquivo { get; set; }

    public string? ChaveArquivo { get; set; }

    public string? NomeArquivo { get; set; }

    public string? ExtensaoArquivo { get; set; }

    public long? TamanhoArquivo { get; set; }
}
