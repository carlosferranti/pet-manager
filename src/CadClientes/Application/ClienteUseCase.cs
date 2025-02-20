// 📌 Aplicação: Caso de uso (Use Case) para criar um cliente
public class CriarClienteUseCase
{
    private readonly IClienteRepository _clienteRepository;

    public ClienteUseCase(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    public void Executar(int id, string nome)
    {
        var cliente = new Cliente(id, nome);
        _clienteRepository.Adicionar(cliente);
    }
}
