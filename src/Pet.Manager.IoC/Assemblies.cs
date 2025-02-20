using System.Reflection;

using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Infra.Http.Services;
using Anima.Inscricao.Infra.Messaging.Publishes.Shared;

namespace Anima.Inscricao.IoC;

internal static class Assemblies
{
    internal static readonly Assembly Application = typeof(ApplicationRequestValidator<>).Assembly;
    internal static readonly Assembly Messageing = typeof(BaseKafkaEventHandler).Assembly;
    internal static readonly Assembly Http = typeof(AzureAdTokenService).Assembly;
}

