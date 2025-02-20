namespace Anima.Inscricao.Domain._Shared.Formaters;

public static class CnpjFormater
{
    public static string RemoverFormatacao(string cnpj)
    {
        return cnpj.Replace(".", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty).Trim();
    }
}