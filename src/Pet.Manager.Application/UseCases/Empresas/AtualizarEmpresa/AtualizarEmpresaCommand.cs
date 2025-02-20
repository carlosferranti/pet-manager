using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Empresas.AtualizarEmpresa;

public class AtualizarEmpresaCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }

    public string Cnpj { get; set; } = string.Empty;

    public string? NomeFantasia { get; set; }

    public string RazaoSocial { get; set; } = string.Empty;

    public List<AtualizarEnderecoEmpresaCommand>? Enderecos { get; set; }

    public class AtualizarEnderecoEmpresaCommand
    {
        public Guid? Key { get; set; }

        public Guid CidadeKey { get; set; }

        public string? Logradouro { get; set; }

        public string? Cep { get; set; }

        public string? Numero { get; set; }

        public string? Complemento { get; set; }

        public string? Bairro { get; set; }
    }
}
