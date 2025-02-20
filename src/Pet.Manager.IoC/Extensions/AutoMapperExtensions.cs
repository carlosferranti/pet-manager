using Anima.Inscricao.Application.Mappers;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.IoC.Extensions;

internal static class AutoMapperExtensions
{
    public static IServiceCollection AdicionarMapeamentos(this IServiceCollection services) 
    {
        services
            .AddAutoMapper(typeof(InfoInscricaoCandidatoAtualizacaoEventoMapper));

        return services;
    }
}
