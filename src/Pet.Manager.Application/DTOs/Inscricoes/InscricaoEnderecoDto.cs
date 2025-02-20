using Anima.Inscricao.Application.DTOs._Shared;

namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class InscricaoEnderecoDto
{
    public string? Tipo { get; set; }

    public string? Cep { get; set; }

    public string? Rua { get; set; }

    public string? Numero { get; set; }

    public string? Complemento { get; set; }

    public string? Bairro { get; set; }

    public ItemDto? Cidade { get; set; }

    public ItemDto? Estado { get; set; }
}