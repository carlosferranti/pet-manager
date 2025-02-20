namespace Anima.Inscricao.CrossCutting.Middlewares;

public class ErroResponse
{
    public ErroResponse(string codigo, string mensagem)
    {
        Codigo = codigo;
        Mensagem = mensagem;
    }

    public string Codigo { get; set; }

    public string Mensagem { get; set; }
}

