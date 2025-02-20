using Microsoft.AspNetCore.Authorization;

namespace Anima.Inscricao.Authentications.Basic.Attributes;

public class BasicAuthorizeAttribute : AuthorizeAttribute
{
    public BasicAuthorizeAttribute()
    {
        AuthenticationSchemes = BasicAuthenticationDefaults.AuthenticationSchemes;
    }
}
