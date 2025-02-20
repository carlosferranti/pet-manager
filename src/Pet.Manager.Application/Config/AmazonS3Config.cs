namespace Anima.Inscricao.Application.Config;

public class AmazonS3Config
{
    public string AccessKey { get; set; } = string.Empty;

    public string SecretKey { get; set; } = string.Empty;

    public string RegionEndpoint { get; set; } = string.Empty;

    public string BucketName { get; set; } = string.Empty;

    public string FilePath { get; set; } = string.Empty;

    public string FileUrl { get; set; } = string.Empty;
}
