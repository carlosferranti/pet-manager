using System.Diagnostics.CodeAnalysis;
using System.Net;

using Anima.Inscricao.Domain._Shared.Exceptions;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Anima.Inscricao.CrossCutting.Middlewares;

[ExcludeFromCodeCoverage]
public class HttpResponseExceptionFilter : IActionFilter, IOrderedFilter
{
    private readonly ILogger<HttpResponseExceptionFilter> _logger;
    private const int OrderOffset = 10;

    public int Order => int.MaxValue - OrderOffset;

    public HttpResponseExceptionFilter(ILogger<HttpResponseExceptionFilter> logger)
    {
        _logger = logger;
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        // Nenhuma ação necessária
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        if (context.Exception != null)
        {
            if (context.Exception is EntityNotFoundException)
            {
                context.Result = new ObjectResult(new ErroResponse("recurso-nao-encontrado", "O recurso solicitado não encontrada."))
                {
                    StatusCode = (int)HttpStatusCode.NotFound
                };
                context.ExceptionHandled = true;
            }
            else
            {
                _logger.LogError(context.Exception, "Ocorreu um erro interno no servidor.");

                context.Result = new ObjectResult(new ErroResponse(String.Empty, "Ocorreu um erro interno no servidor."))
                {
                    StatusCode = (int)HttpStatusCode.InternalServerError
                };

                context.ExceptionHandled = true;
            }
        }
    }
}
