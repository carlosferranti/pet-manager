using System.Text.RegularExpressions;

namespace Anima.Inscricao.Domain.Utils;

public static class TelefoneFormater
{
    // Função para formatar o número de celular
    public static string FormatarTelefoneCelular(string numero)
    {
        if (numero.Length == 11) 
        {
            // Formata o número no formato (XX) XXXXX-XXXX
            return String.Format("({0}) {1}-{2}",
                                 numero.Substring(0, 2),     // DDD
                                 numero.Substring(2, 5),     // Primeiros 5 dígitos
                                 numero.Substring(7, 4));    // Últimos 4 dígitos
        }
        else
        {
            return "Número inválido";
        }
    }

    // Função para remover a formatação de um número de celular
    public static string RemoverFormatacao(string numero)
    {
        // Usa Regex para remover todos os caracteres não numéricos
        return Regex.Replace(numero, @"[^\d]", "");
    }
}