using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.DTOs.Empresas;

public class EmpresaDto
{
    public Guid Key { get; set; }

    public string Cnpj { get; set; } = string.Empty;

    public string NomeFantasia { get; set; } = string.Empty;

    public string RazaoSocial { get; set; } = string.Empty;

    public SistemaIntegracaoDto? Integracao { get; set; }

    public List<EmpresaEnderecoDto>? Enderecos { get; set; }
}