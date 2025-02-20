namespace Anima.Inscricao.Application.Interfaces.Services;

public interface IAmazonS3Service
{
    Task<string> UploadArquivoAsync(byte[] arquivo, string nomeArquivo, Guid inscricaoKey, CancellationToken cancellationToken);

    Task RemoverArquivoAsync(string chaveS3, CancellationToken cancellationToken);
}
