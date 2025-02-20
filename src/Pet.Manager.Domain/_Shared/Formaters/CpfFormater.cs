using System.Text.RegularExpressions;

namespace Anima.Inscricao.Domain.Utils;

public static class CpfFormater
{
    public static string FormatarCPF(string cpf)
    {
        // Remove qualquer caractere não numérico
        cpf = Regex.Replace(cpf, @"\D", "");

        // Verifica se o CPF tem 11 dígitos
        if (cpf.Length != 11)
        {
            throw new ArgumentException("O CPF deve ter 11 dígitos.");
        }

        // Formata o CPF
        return string.Format("{0}.{1}.{2}-{3}",
            cpf.Substring(0, 3),
            cpf.Substring(3, 3),
            cpf.Substring(6, 3),
            cpf.Substring(9, 2));
    }

    public static string RemoverFormatacao(string cpf)
    {
        // Remove qualquer caractere não numérico
        return Regex.Replace(cpf, @"\D", "");
    }
}
