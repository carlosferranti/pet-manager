using FluentValidation.Results;

namespace Anima.Inscricao.Domain._Shared.Validations;

public class InfoValidation
{
    public string Atributo { get; set; }
    public string Regra { get; set; }
    public string Mensagem { get; set; }
    public object? Valor { get; set; }
    public int? Nivel { get; set; }
    public string? CodigoErro { get; set; }

    public InfoValidation(string atributo, string mensagem, object valor, int nivel, string codigoErro)
    {
        Atributo = atributo;
        Mensagem = mensagem;
        Valor = valor;
        Nivel = nivel;
        CodigoErro = codigoErro;
    }

    public InfoValidation(string atributo, string regra, string mensagem)
    {
        Atributo = atributo;
        Regra = regra;
        Mensagem = mensagem;
    }

    public static implicit operator InfoValidation?(ValidationResult? id)
        => null;

    public static explicit operator InfoValidation?(ValidationFailure? validationFailure)
        => new InfoValidation(validationFailure?.PropertyName ?? string.Empty, validationFailure?.ErrorCode ?? string.Empty, validationFailure?.ErrorMessage ?? string.Empty);
}
