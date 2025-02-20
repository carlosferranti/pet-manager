using System.ComponentModel;
using System.Reflection;

namespace Anima.Inscricao.Application.Extensions;

/// <summary>
/// Classe de extensão responsável por manipular Enums.
/// </summary>
public static class EnumExtensions
{
    /// <summary>
    /// Método utilizado para recuperar o valor do atributo Description de um enum.
    /// </summary>
    /// <param name="value">Valor do enum.</param>
    /// <returns>String com o valor do atributo Description.</returns>
    public static string Description(this Enum value)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        var campo = value.GetType().GetField(value.ToString());
        var atributos = (DescriptionAttribute[])campo!.GetCustomAttributes(typeof(DescriptionAttribute), false);

        if (atributos == null || atributos.Length == 0)
        {
            return value.ToString();
        }

        return atributos[0].Description;
    }

    public static bool GetEnumValueFromDescription<T>(string description) where T : System.Enum
    {
       var fields = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static);
        
        // Itera sobre os campos procurando a descrição
        foreach (var field in fields)
        {
            var attribute = field.GetCustomAttribute<DescriptionAttribute>();
            
            // Verifica se o campo possui o atributo e se a descrição corresponde
            if (attribute != null && attribute.Description.Equals(description, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }
        
        return false;
    }
}
