namespace Anima.Inscricao.Application.DTOs.Cupons;

public class ValidarCupomResultadoDto
{
    public bool Valido { get; set; }
    public string Mensagem { get; set; }

    public ValidarCupomResultadoDto(bool valido, string mensagem)
    {
        Valido = valido;
        Mensagem = mensagem;
    }

    public static ValidarCupomResultadoDto Success() => new ValidarCupomResultadoDto(true, "Cupom válido!");

    public static ValidarCupomResultadoDto Fail(string mensagem) => new ValidarCupomResultadoDto(false, mensagem);
}
