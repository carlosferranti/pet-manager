using System.Text.RegularExpressions;

namespace Anima.Inscricao.Application.Utils;

public static class EmailUtils
{
    public static bool ValidarEmail(string? email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            return false;
        }

        string padraoEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, padraoEmail);
    }
}