using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;

using Anima.Inscricao.Application.Interfaces.Services;

using Microsoft.Extensions.Options;

using AmazonS3Config = Anima.Inscricao.Application.Config.AmazonS3Config;

namespace Anima.Inscricao.Infra.Http.Services;

public class AmazonS3Service : IAmazonS3Service
{
    private readonly AmazonS3Client _amazonS3Client;
    private readonly AmazonS3Config _amazonS3Config;

    public AmazonS3Service(IOptions<AmazonS3Config> amazonS3Config)
    {
        _amazonS3Config = amazonS3Config.Value;
        _amazonS3Client = new AmazonS3Client(_amazonS3Config.AccessKey, _amazonS3Config.SecretKey, RegionEndpoint.GetBySystemName(_amazonS3Config.RegionEndpoint));
    }

    public async Task RemoverArquivoAsync(string chaveS3, CancellationToken cancellationToken)
    {
        var request = new DeleteObjectRequest
        {
            BucketName = _amazonS3Config.BucketName,
            Key = chaveS3,
        };

        await _amazonS3Client.DeleteObjectAsync(request);
    }

    public async Task<string> UploadArquivoAsync(byte[] arquivo, string nomeArquivo, Guid inscricaoKey, CancellationToken cancellationToken)
    {
        var transferUtility = new TransferUtility(_amazonS3Client);
        string nomeArquivoS3 = Guid.NewGuid().ToString();
        string extensao = Path.GetExtension(nomeArquivo);

        using (var stream = new MemoryStream())
        {
            await stream.ReadAsync(arquivo.AsMemory(0, arquivo.Length));
            await stream.WriteAsync(arquivo.AsMemory(0, arquivo.Length));

            var uploadRequest = new TransferUtilityUploadRequest
            {
                InputStream = stream,
                Key = $"{_amazonS3Config.FilePath}/{nomeArquivoS3}{extensao}",
                BucketName = _amazonS3Config.BucketName,
            };

            await transferUtility.UploadAsync(uploadRequest, cancellationToken);

            return uploadRequest.Key;
        }
    }
}