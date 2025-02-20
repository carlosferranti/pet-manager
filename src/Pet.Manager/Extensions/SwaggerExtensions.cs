using System.Diagnostics.CodeAnalysis;

using Anima.Inscricao.Authentications.Basic;
using Anima.Inscricao.CrossCutting.Filters;

using Microsoft.OpenApi.Models;

namespace Anima.Inscricao.Extensions;

[ExcludeFromCodeCoverage]
public static class SwaggerExtensions
{
    public static IServiceCollection AddAnimaSwaggerGen(this IServiceCollection services, IConfiguration configuration)
    {
        return services.AddSwaggerGen(options =>
        {
            var applicationSection = configuration.GetSection("Application");
            var applicationName = applicationSection.GetValue<string>("ApplicationName");
            var applicationDescription = applicationSection.GetValue<string>("ApplicationDescription");

            options.OperationFilter<UnauthorizedResponseOperationFilter>();

            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = applicationName,
                Description = applicationDescription,
                Version = "v1"
            });

            options.SwaggerDoc("v2", new OpenApiInfo
            {
                Title = applicationName,
                Description = applicationDescription,
                Version = "v2"
            });

            options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Description = "Inclua no campo abaixo a palavra 'Bearer' seguida de espaço e do token JWT",
                Name = "Authorization",
                Scheme = "Bearer",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey
            });

            options.AddSecurityDefinition(BasicAuthenticationDefaults.AuthenticationSchemes, new OpenApiSecurityScheme
            {
                Description = "Inclua nos campos o usuário e senha",
                Name = "Authorization",
                Scheme = BasicAuthenticationDefaults.AuthenticationSchemes,
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.Http,
            });

            options.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    Array.Empty<string>()
                }
            });

            options.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = BasicAuthenticationDefaults.AuthenticationSchemes,
                        }
                    },
                    new string[] { BasicAuthenticationDefaults.AuthenticationSchemes }
                },
            });

            options.EnableAnnotations();
        });
    }

    public static IApplicationBuilder UseAnimaSwagger(this IApplicationBuilder app, IConfiguration configuration)
    {
        var basePath = Environment.GetEnvironmentVariable("VIRTUAL_PATH") ?? "";
        var applicationName = configuration.GetValue<string>("Application:ApplicationName");

        return app
            .UseSwagger(c =>
            {
                c.RouteTemplate = "swagger/{documentName}/swagger.json";
                c.PreSerializeFilters.Add((swagger, request) =>
                {
                    var scheme = request.Host.Host is "localhost" or "127.0.0.1" ? "http" : "https";
                    swagger.Servers = new List<OpenApiServer> { new OpenApiServer { Url = $"{scheme}://{request.Host.Value}{basePath}" } };
                });

            })
            .UseSwaggerUI(swaggerOptions =>
            {
                swaggerOptions.SwaggerEndpoint(
                    $"{basePath}/swagger/v1/swagger.json",
                    $"{applicationName} v1"
                );
                swaggerOptions.SwaggerEndpoint(
                    $"{basePath}/swagger/v2/swagger.json",
                    $"{applicationName} v2");
            });
    }
}
