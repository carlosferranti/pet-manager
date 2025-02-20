using Anima.Inscricao.Domain._Shared.Validations;

using FluentValidation.Results;

namespace Anima.Inscricao.Domain._Shared.Notifications;

public interface INotificationContext
{
    IReadOnlyCollection<Notification> Notifications { get; }

    bool HasNotifications { get; }

    void AddNotification(string propertyName, string errorCode, string message);
    void AddNotification(Notification notification);
    void AddNotifications(ValidationResult validationResult);
    void AddNotifications(IEnumerable<Notification> notifications);
    void AddNotifications(IEnumerable<InfoValidation> infoValidations);
    void ClearNotifications();
}

public class NotificationContext : INotificationContext
{
    private readonly List<Notification> _notifications;

    public NotificationContext()
    {
        _notifications = new List<Notification>();
    }

    public IReadOnlyCollection<Notification> Notifications => _notifications;

    public bool HasNotifications => _notifications.Any();

    public void AddNotification(string propertyName, string errorCode, string message) => _notifications.Add(new Notification(propertyName, errorCode, message));

    public void AddNotification(Notification notification) => _notifications.Add(notification);

    public void AddNotifications(IEnumerable<Notification> notifications)
    {
        _notifications.AddRange(notifications);
    }

    public void AddNotifications(ValidationResult validationResult)
    {
        foreach (var error in validationResult.Errors)
        {
            AddNotification(error.PropertyName, error.ErrorCode, error.ErrorMessage);
        }
    }

    public void AddNotifications(IEnumerable<InfoValidation> infoValidations)
    {
        foreach (var infoValidation in infoValidations)
        {
            AddNotification(infoValidation.Atributo, infoValidation.Regra, infoValidation.Mensagem);
        }
    }

    public void ClearNotifications()
    {
        _notifications.Clear();
    }
}
