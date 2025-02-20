using System.Net;

using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

using Swashbuckle.AspNetCore.SwaggerGen;

namespace Anima.Inscricao.CrossCutting.Filters
{
    public class UnauthorizedResponseOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (context.MethodInfo.DeclaringType.BaseType == typeof(ControllerBase)
                || context.MethodInfo.ReflectedType.BaseType == typeof(Controller))
            {
                operation.Responses.Add(((int)HttpStatusCode.Unauthorized).ToString(), new OpenApiResponse 
                { 
                    Description = "Usuário não autenticado." 
                });
            }
        }
    }

}