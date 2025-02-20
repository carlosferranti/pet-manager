﻿namespace Anima.Inscricao.Application.DTOs.Empresas;

public class EmpresaEnderecoDto
{
    public Guid Key { get; set; }

    public Guid CidadeKey { get; set; }

    public string? Logradouro { get; set; }

    public string? Cep { get; set; }

    public string? Numero { get; set; }

    public string? Complemento { get; set; }

    public string? Bairro { get; set; }
}