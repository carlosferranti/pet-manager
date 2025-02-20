using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.UseCases.Empresas.CriarEmpresa;

public class CriarEmpresaCommand : ICommand<EntityKeyDto?>
{
    public string Cnpj { get; set; } = string.Empty;

    public string? NomeFantasia { get; set; } 

    public string RazaoSocial { get; set; } = string.Empty;

    public List<CriarEnderecoEmpresaCommand>? Enderecos { get; set; }

    public SistemaIntegracaoDto? Integracao { get; set; }

    public class CriarEnderecoEmpresaCommand
    {
        public Guid CidadeKey { get; set; }

        public string? Logradouro { get; set; }

        public string? Cep { get; set; }

        public string? Numero { get; set; }

        public string? Complemento { get; set; }

        public string? Bairro { get; set; }
    }
}
