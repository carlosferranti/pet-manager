using Serilog;
using Serilog.Core;
using Serilog.Events;
using Serilog.Extensions.Hosting;
using Serilog.Sinks.Elasticsearch;

using System.Diagnostics.CodeAnalysis;

namespace Anima.Inscricao.Extensions;

[ExcludeFromCodeCoverage]
public static class LogExtensions
{
    public static ReloadableLogger CriarLoggerInicial()
    {
        return new LoggerConfiguration()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            .MinimumLevel.Override("System", LogEventLevel.Information)
            .MinimumLevel.Override("Steeltoe", LogEventLevel.Information)
            .Enrich.FromLogContext()
            .Enrich.WithMachineName()
            .WriteTo.Console()
            .CreateBootstrapLogger();
    }

    public static void ConfigurarLogger(HostBuilderContext context, IServiceProvider services, LoggerConfiguration configuration)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(configuration);

        var config = services.GetService<IConfiguration>();
        var systemLoggingLevel = ObterNivelMinimoAmbiente(context);

        var levelSwitch = services.GetRequiredService<LoggingLevelSwitch>();
        levelSwitch.MinimumLevel = ObterNivelMinimoConfiguracoes(config) ?? systemLoggingLevel;

        var applicationName = config["Application:ApplicationName"];
        var applicationVersion = typeof(LogExtensions).Assembly.GetName().Version;
        var logElasticSource = new Uri(config.GetConnectionString("LogElasticSource"));

        configuration
            .ReadFrom.Services(services)
            .MinimumLevel.Override("Microsoft", systemLoggingLevel)
            .MinimumLevel.Override("System", systemLoggingLevel)
            .MinimumLevel.Override("Steeltoe", LogEventLevel.Information)
            .Enrich.FromLogContext()
            .Enrich.WithMachineName()
            .Enrich.WithEnvironmentName()
            .Enrich.WithProperty("Application", applicationName)
            .Enrich.WithProperty("Version", applicationVersion)
            .WriteTo.Console()
            .WriteTo.Elasticsearch(new ElasticsearchSinkOptions(logElasticSource)
            {
                AutoRegisterTemplate = true,
                AutoRegisterTemplateVersion = AutoRegisterTemplateVersion.ESv7,
                TypeName = null,
                BatchAction = ElasticOpType.Create,
                IndexFormat = "logstash-servico-inscricoes-{0:yyyy.MM.dd}",
            });
    }

    private static LogEventLevel? ObterNivelMinimoConfiguracoes(IConfiguration config)
        => Enum.TryParse(config["Serilog:MinLoggingLevel"], true, out LogEventLevel level) ? level : null;

    private static LogEventLevel ObterNivelMinimoAmbiente(HostBuilderContext context)
        => context.HostingEnvironment.EnvironmentName == "local" ? LogEventLevel.Information : LogEventLevel.Warning;
}
