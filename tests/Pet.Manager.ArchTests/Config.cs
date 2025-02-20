using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.CrossCutting.Middlewares;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.UoW;

using ArchUnitNET.Domain;
using ArchUnitNET.Loader;

using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace Anima.Inscricao.ArchTests;

internal static class Config
{
    public static readonly Architecture Arquitetura;
    public static readonly IObjectProvider<IType> CamadaApi;
    public static readonly IObjectProvider<IType> CamadaAplicacao;
    public static readonly IObjectProvider<IType> CamadaDominio;
    public static readonly IObjectProvider<IType> CamadaData;
    public static readonly IObjectProvider<IType> CamadaMessaging;

    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Minor Code Smell",
        "S3963:\"static\" fields should be initialized inline",
        Justification = "Lógica de criação dos componentes depende do correto carregamento dos assemblies antes de criar as variáveis públicas")]
    static Config()
    {
        var apiAssembly = typeof(HttpResponseExceptionFilter).Assembly;
        var applicationAssembly = typeof(ApplicationRequestValidator<>).Assembly;
        var domainAssembly = typeof(Entity<>).Assembly;
        var dataAssembly = typeof(UnitOfWork).Assembly;

        CamadaApi = Types().That().ResideInAssembly(apiAssembly.FullName);
        CamadaAplicacao = Types().That().ResideInAssembly(applicationAssembly.FullName);
        CamadaDominio = Types().That().ResideInAssembly(domainAssembly.FullName);
        CamadaData = Types().That().ResideInAssembly(dataAssembly.FullName);

        Arquitetura = new ArchLoader()
            .LoadAssemblies(apiAssembly, applicationAssembly, domainAssembly, dataAssembly)
            .Build();
    }

    public static string ObterRegexClasses(string nomePasta, string nomeObjeto) =>
        $@"(?i)\.{nomePasta}\.(?:[^\.]*\.)*[^\.]*{nomeObjeto}(?:`\d+)?$";

    public static string ObterRegexInterfaces(string nomeObjeto) =>
        $@"(?i)\.(?:[^\.]*\.)*I[^\.]*{nomeObjeto}(?:`\d+)?$";

    public static string ObterRegexComVersao(string nomePasta, string nomeObjeto) =>
        $@"(?i)\.{nomePasta}(?:[^\.]*\.)*V\d+\.(?:[^\.]*\.)*[^\.]*{nomeObjeto}(?:`\d+)?$";
}
