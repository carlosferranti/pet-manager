using System.Globalization;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

using Anima.IdentityProvider.Sdk.AspNetCore.Authentication;
using Anima.Inscricao.Application.Config;
using Anima.Inscricao.Authentications.Basic;
using Anima.Inscricao.CrossCutting.Filters;
using Anima.Inscricao.CrossCutting.Middlewares;
using Anima.Inscricao.Extensions;
using Anima.Inscricao.IoC;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Identity.Web;

using Serilog;
using Serilog.Core;
using Serilog.Events;

using Steeltoe.Extensions.Configuration.ConfigServer;

Log.Logger = LogExtensions.CriarLoggerInicial();

#region Informacoes ao iniciar a POD

Console.WriteLine($"Runtime identifier: {RuntimeInformation.RuntimeIdentifier}");
Console.WriteLine($"Versao: {typeof(Program).Assembly.GetName().Version}");

var environmentName = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") ?? "desenvolvimento";
#if DEBUG
Console.WriteLine($"Ambiente: {environmentName} - executando modo DEBUG");
#else
Console.WriteLine($"Ambiente: {environmentName} - executando modo RELEASE");
#endif

Console.WriteLine($"Cultura: {CultureInfo.CurrentUICulture.Name}.");
Console.WriteLine($"Data e Hora do Sistema: {TimeProvider.System.GetLocalNow()}.");

#endregion

try
{
    var builder = WebApplication.CreateBuilder(args);
    builder.Configuration.AddConfigServer(environmentName);

    builder
        .Services
            .RegistraDependencias(builder.Configuration)
            .AddSingleton(new LoggingLevelSwitch(LogEventLevel.Warning))
            .AddControllers(options =>
            {
                options.Filters.Add<NotificationFilter>();
                options.Filters.Add<HttpResponseExceptionFilter>();
            })
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault;
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            })
        .Services
            .AddHealthChecks()
        .Services
            .AddEndpointsApiExplorer()
            .AddMicrosoftIdentityWebApiAuthentication(builder.Configuration, jwtBearerScheme: AzureAdConstants.AzureAdJwtBearerScheme)
            .EnableTokenAcquisitionToCallDownstreamApi()
            .AddInMemoryTokenCaches()
        .Services
            .AddOptions<OpenIdConnectOptions>()
            .Configure<AzureAdConfig>((options, azureAdConfig) =>
            {
                var instance = azureAdConfig.Instance;
                var clientId = azureAdConfig.ClientId;

                options.Authority = $"{instance}{clientId}/v2.0";
            })
        .Services
            .AddAuthentication()
            .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>(
                BasicAuthenticationDefaults.AuthenticationSchemes, null)
        .Services
            .AddEndpointsApiExplorer();       

    builder.Services.AddAnimaClaimsTypeMapping();

    if (environmentName != "producao")
    {
        builder.Services.AddAnimaSwaggerGen(builder.Configuration);
    }

    builder.Host.UseSerilog(LogExtensions.ConfigurarLogger);

    var app = builder.Build();

    if (environmentName != "producao")
    {
        app.UseAnimaSwagger(builder.Configuration);
    }

    app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().WithExposedHeaders("Content-Disposition"));

    app.UseHealthChecks("/hc");

    app.UseAuthentication();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, $"Aplicação finalizada de forma inesperada: {ex.Message}");
}
finally
{
    Log.CloseAndFlush();
}
