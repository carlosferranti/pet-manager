[ApiController]
[Route("api/clientes")]
public class ClienteController : ControllerBase
{
    private readonly CriarClienteUseCase _criarClienteUseCase;

    public ClienteController(CriarClienteUseCase criarClienteUseCase)
    {
        _criarClienteUseCase = criarClienteUseCase;
    }

    [HttpPost]
    public IActionResult CriarCliente(int id, string nome)
    {
        _criarClienteUseCase.Executar(id, nome);
        return Ok("Cliente criado com sucesso!");
    }
}
