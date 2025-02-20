public interface IClienteRepository
{
    void Adicionar(Cliente cliente);
}

public class ClienteRepository : IClienteRepository
{
    public void Adicionar(Cliente cliente)
    {
        Console.WriteLine($"Cliente {cliente.Nome} salvo no banco.");
    }
}
