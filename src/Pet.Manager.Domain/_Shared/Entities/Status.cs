namespace Anima.Inscricao.Domain._Shared.Entities;

public class Status
{
    public Status()
    {
        Ativo = true;
    }

    public bool Ativo { get; protected set; }
    public void MarcarComoExcluido() => Ativo = false;
}


