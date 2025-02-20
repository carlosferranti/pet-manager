public class Cliente
{
    public int Id { get; private set; }
    public string Nome { get; private set; }

    public Cliente(int id, string nome)
    {
        if (string.IsNullOrEmpty(nome))
            throw new ArgumentException("Nome do cliente é obrigatório.");

        Id = id;
        Nome = nome;
    }
}
