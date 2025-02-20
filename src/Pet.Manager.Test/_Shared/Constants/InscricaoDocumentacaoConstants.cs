using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Enums;
using Anima.Inscricao.Domain.Inscricoes.Entities;
using Anima.Inscricao.Domain.Inscricoes.Enums;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class InscricaoDocumentacaoConstants
{
    public static readonly DocumentacaoInscricao DocumentacaoLaudoNecessidadesEspeciais = DocumentacaoInscricao
        .Criar(
            new InscricaoCandidatoId(1),
            InscricaoConstants.InscricaoCorreta.Key,
            null,
            TipoDocumentacaoInscricao.LaudoNecessidadesEspeciais,
            new Arquivo(new Arquivo.InfoArquivo("comprovante_residencia.pdf", "pdf", 1024), TipoLocalArquivo.S3, "chave"))
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a DocumentacaoLaudoNecessidadesEspeciais");

    public static readonly DocumentacaoInscricao DocumentacaoHistoricoEscolarS3 = CriarDocumentacaoHistoricoEscolarS3();

    public static readonly DocumentacaoInscricao DocumentacaoHistoricoEscolarSmartShare = DocumentacaoInscricao
          .Criar(
              new InscricaoCandidatoId(1),
              InscricaoConstants.InscricaoCorreta.Key,
              null,
              TipoDocumentacaoInscricao.HistoricoEscolar,
              new Arquivo(new Arquivo.InfoArquivo("historico.pdf", "pdf", 1024), TipoLocalArquivo.SmartShare, "chave"))
          .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a DocumentacaoHistoricoEscolarSmartShare");

    private static DocumentacaoInscricao CriarDocumentacaoHistoricoEscolarS3()
    {
        var documentacao = DocumentacaoInscricao
            .Criar(
            new InscricaoCandidatoId(1),
            InscricaoConstants.InscricaoCorreta.Key,
            null,
            TipoDocumentacaoInscricao.HistoricoEscolar,
            new Arquivo(new Arquivo.InfoArquivo("historico.pdf", "pdf", 1024), TipoLocalArquivo.S3, "chave"))
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a DocumentacaoHistoricoEscolarS3");

        documentacao.Status.MarcarComoExcluido();

        return documentacao;
    }
}