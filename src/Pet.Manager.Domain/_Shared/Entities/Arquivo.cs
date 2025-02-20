using Anima.Inscricao.Domain._Shared.Enums;

namespace Anima.Inscricao.Domain._Shared.Entities;

public class Arquivo
{
    protected Arquivo()
    {
        Chave = string.Empty;
        Informacoes = new InfoArquivo(string.Empty, string.Empty, 0);
    }

    public Arquivo(InfoArquivo informacoes, TipoLocalArquivo tipoLocalArquivo, string chave)
    {
        Informacoes = informacoes;
        TipoLocalArquivo = tipoLocalArquivo;
        Chave = chave;
    }

    public InfoArquivo Informacoes { get; protected set; }

    public TipoLocalArquivo TipoLocalArquivo { get; protected set; }

    public string Chave { get; protected set; }

    public record InfoArquivo
    {
        public InfoArquivo(string nome, string extensao, long tamanho)
        {
            Nome = nome;
            Extensao = extensao;
            Tamanho = tamanho;
        }

        public string Nome { get; protected set; }

        public string Extensao { get; protected set; }

        public long Tamanho { get; protected set; }
    }
}
