using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Anima.Inscricao.Infra.Data.Utils;

public static class DateTimeFormatUtils
{
    /// <summary>
    /// Método responsável por realizar a conversão de datas para o tipo UTC esperadas no banco de dados.
    /// </summary>
    /// <param name="input">data a ser convertida.</param>
    /// <returns>Retorna a data convertida.</returns>
    public static DateTime ConverterParaUtcDate(this DateTime input)
    {
        return input.ToUniversalTime();
    }

    /// <summary>
    /// Método responsável por realizar a conversão de datas para o tipo UTC esperadas no banco de dados.
    /// </summary>
    /// <param name="input">data a ser convertida.</param>
    /// <returns>Retorna a data convertida.</returns>
    public static DateTime? ConverterParaUtcDate(this DateTime? input)
    {
        if (input == null)
        {
            return null;
        }

        return ConverterParaUtcDate(input.Value);
    }

    /// <summary>
    /// Método responsável por realizar a conversão de datas do tipo UTC para Local.
    /// </summary>
    /// <param name="input">data a ser convertida.</param>
    /// <returns>Retorna a data convertida.</returns>
    public static DateTime ConverterParaLocalDate(this DateTime input)
    {
        return input.ToLocalTime();
    }

    /// <summary>
    /// Método responsável por realizar a conversão de datas do tipo UTC para Local.
    /// </summary>
    /// <param name="input">data a ser convertida.</param>
    /// <returns>Retorna a data convertida.</returns>
    public static DateTime? ConverterParaLocalDate(this DateTime? input)
    {
        if (input == null)
        {
            return null;
        }

        return ConverterParaLocalDate(input.Value);
    }

    /// <summary>
    /// Método responsável por realizar a conversão de datas para o tipo UTC esperadas no banco de dados.
    /// </summary>
    /// <param name="input">data a ser convertida.</param>
    /// <returns>Retorna a data convertida.</returns>
    public static DateTimeOffset ConverterParaUtcDate(this DateTimeOffset input)
    {
        return input.ToUniversalTime();
    }

    /// <summary>
    /// Método responsável por realizar a conversão de datas para o tipo UTC esperadas no banco de dados.
    /// </summary>
    /// <param name="input">data a ser convertida.</param>
    /// <returns>Retorna a data convertida.</returns>
    public static DateTimeOffset? ConverterParaUtcDate(this DateTimeOffset? input)
    {
        if (input == null)
        {
            return null;
        }

        return ConverterParaUtcDate(input.Value);
    }

    /// <summary>
    /// Método responsável por realizar a conversão de datas do tipo UTC para Local.
    /// </summary>
    /// <param name="input">data a ser convertida.</param>
    /// <returns>Retorna a data convertida.</returns>
    public static DateTimeOffset ConverterParaLocalDate(this DateTimeOffset input)
    {
        return input.ToLocalTime();
    }

    /// <summary>
    /// Método responsável por realizar a conversão de datas do tipo UTC para Local.
    /// </summary>
    /// <param name="input">data a ser convertida.</param>
    /// <returns>Retorna a data convertida.</returns>
    public static DateTimeOffset? ConverterParaLocalDate(this DateTimeOffset? input)
    {
        if (input == null)
        {
            return null;
        }

        return ConverterParaLocalDate(input.Value);
    }
}