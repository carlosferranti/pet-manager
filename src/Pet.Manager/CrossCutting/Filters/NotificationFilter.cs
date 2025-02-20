using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain._Shared.Extensions;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;
using System.Text.Json;

namespace Anima.Inscricao.CrossCutting.Filters;

public class NotificationFilter : IAsyncResultFilter
{
    private readonly INotificationContext _notificationContext;

    public NotificationFilter(INotificationContext notificationContext)
    {
        _notificationContext = notificationContext;
    }

    public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
    {
        if (_notificationContext.HasNotifications)
        {
            var httpStatusCode = _notificationContext.Notifications
                .OfType<NotificationWithStatusCode>()
                .ToList()
                .MaxValue(o => (int)o.HttpCode) ?? (int)HttpStatusCode.BadRequest;

            context.HttpContext.Response.StatusCode = httpStatusCode;
            context.HttpContext.Response.ContentType = "application/json";

            var erros = new { errors = _notificationContext.Notifications };

            var notifications = JsonSerializer.Serialize(erros);
            await context.HttpContext.Response.WriteAsync(notifications);

            return;
        }

        await next();
    }
}
