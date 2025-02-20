using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net.Mime;
using System.Text;
using System.Text.Json;

using Anima.Inscricao.Application.Config;
using Anima.Inscricao.Application.DTOs.Enem;
using Anima.Inscricao.Application.Interfaces.Services;

using Microsoft.Extensions.Logging;

using Microsoft.Extensions.Options;

namespace Anima.Inscricao.Infra.Http.Services;

public class EnemService : IEnemService
{
    private readonly HttpClient _httpClient;
    private readonly IAzureAdTokenService _azureAdTokenService;
    private readonly ApiProvaEnemConfig _apiProvaEnemConfig;
    private readonly ILogger<EnemService> _logger;

    public EnemService(
        HttpClient httpClient,
        IAzureAdTokenService azureAdTokenService,
        IOptions<ApiProvaEnemConfig> apiProvaEnemConfig,
        ILogger<EnemService> logger)
    {
        _httpClient = httpClient;
        _azureAdTokenService = azureAdTokenService;
        _apiProvaEnemConfig = apiProvaEnemConfig.Value;
        _logger = logger;
    }

    public async Task<ClassificacaoEnemDto?> ObterClassificacaoEnemAsync(ObterClassificacaoResquestDto request)
    {
        var token = await _azureAdTokenService.ObterTokenAzureAdAsync();

        var requestHttp = new HttpRequestMessage(HttpMethod.Put, $"{_apiProvaEnemConfig.BaseUrl}/api/classificacoes");
        requestHttp.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
        requestHttp.Content = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, MediaTypeNames.Application.Json);

        var response = await _httpClient.SendAsync(requestHttp);

        if (!response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            _logger.LogError($"Erro ao obter classificação do ENEM: {content}");
            return null;
        }

        return await response.Content.ReadFromJsonAsync<ClassificacaoEnemDto>();
    }


    public async Task SolicitarClassificacaoEnemAsync(SolicitarClassificacaoRequestDto request)
    {
        var token = await _azureAdTokenService.ObterTokenAzureAdAsync();

        var requestHttp = new HttpRequestMessage(HttpMethod.Post, $"{_apiProvaEnemConfig.BaseUrl}/api/solicitacoes");
        requestHttp.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
        requestHttp.Content = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, MediaTypeNames.Application.Json);

        var response = await _httpClient.SendAsync(requestHttp);

        if (!response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            _logger.LogError($"Erro ao solicitar classificação do ENEM: {content}");
        }
    }
}