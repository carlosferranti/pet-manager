using Anima.Inscricao.Domain._Shared.Notifications;

namespace Anima.Inscricao.Domain._Shared.Validations;

public class ReturnWithValidation<TReturn>
{
    public ReturnWithValidation(TReturn? valueReturn, List<InfoValidation> validations)
    {
        ValueReturn = valueReturn;
        Validations = validations;
        ValidationSuccess = !validations.Any();
    }

    public bool ValidationSuccess { get; set; }

    private TReturn? ValueReturn { get; set; }

    private List<InfoValidation> Validations { get; set; }

    public static ReturnWithValidation<TReturn> Success(TReturn valueReturn)
    {
        return new ReturnWithValidation<TReturn>(valueReturn, new List<InfoValidation>());
    }

    public static ReturnWithValidation<TReturn> Fail(List<InfoValidation> validations)
    {
        return new ReturnWithValidation<TReturn>(default, validations);
    }

    public ReturnWithValidation<TReturn> NotificarFalhas(INotificationContext notificationContext)
    {
        if (Validations.Any())
        {
            notificationContext
                .AddNotifications(Validations);
        }

        return this;
    }

    public TReturn? ObterRetorno()
    {
        return ValueReturn;
    }
}

public class ReturnWithValidation
{
    public ReturnWithValidation(List<InfoValidation> validations)
    {
        Validations = validations;
        IsSuccess = !validations.Any();
    }

    public bool IsSuccess { get; protected set; }

    private List<InfoValidation> Validations { get; set; }

    public static ReturnWithValidation Success()
    {
        return new ReturnWithValidation(new List<InfoValidation>());
    }

    public static ReturnWithValidation Fail(List<InfoValidation> validations)
    {
        return new ReturnWithValidation(validations);
    }

    public ReturnWithValidation NotificarFalhas(INotificationContext notificationContext)
    {
        if (Validations.Any())
        {
            notificationContext
                .AddNotifications(Validations);
        }

        return this;
    }
}
