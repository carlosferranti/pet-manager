using Anima.Inscricao.Domain._Shared.Specifications;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Campos.Entities;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Domain.Inscricoes.Entities;
using Anima.Inscricao.Domain.Inscricoes.Enums;

namespace Anima.Inscricao.Domain.Fichas.Rules;

public class CriteriosEnderecoInscricaoSpecification : BaseRules, ISpecification<IReadOnlyList<EnderecoInscricao>>
{
    private readonly List<InfoValidation> _validations;

    public CriteriosEnderecoInscricaoSpecification(
        List<InfoValidation> validations,
        List<CampoFicha> camposFicha,
        List<Campo> campos)
        : base(camposFicha, campos)
    {
        _validations = validations;
    }

    public bool IsSatisfiedBy(IReadOnlyList<EnderecoInscricao> enderecos)
    {
        ValidarEnderecoPorTipo(enderecos, TipoEnderecoInscricao.Residencial, "Residencial");
        ValidarEnderecoPorTipo(enderecos, TipoEnderecoInscricao.Cobranca, "Cobrança");
        ValidarEnderecoPorTipo(enderecos, TipoEnderecoInscricao.Comercial, "Comercial");

        return !_validations.Any();
    }

    private void ValidarEnderecoPorTipo(IReadOnlyList<EnderecoInscricao> enderecos, TipoEnderecoInscricao tipo, string descricaoTipo)
    {
        if (CampoEhObrigatorioNaFicha($"Endereço {descricaoTipo} (Rua)") &&
            CampoNaoEstaPreenchido<string?>(enderecos?.FirstOrDefault(e => e.Tipo == tipo)?.Rua))
        {
            _validations.Add(new InfoValidation($"Endereço {descricaoTipo} (Rua)", CampoObrigatorio, $"É obrigatório informar a rua do endereço {descricaoTipo.ToLower()}."));
        }

        if (CampoEhObrigatorioNaFicha($"Endereço {descricaoTipo} (Número)") &&
            CampoNaoEstaPreenchido<string?>(enderecos?.FirstOrDefault(e => e.Tipo == tipo)?.Numero))
        {
            _validations.Add(new InfoValidation($"Endereço {descricaoTipo} (Número)", CampoObrigatorio, $"É obrigatório informar o número do endereço {descricaoTipo.ToLower()}."));
        }

        if (CampoEhObrigatorioNaFicha($"Endereço {descricaoTipo} (Cep)") &&
            CampoNaoEstaPreenchido<string?>(enderecos?.FirstOrDefault(e => e.Tipo == tipo)?.Cep))
        {
            _validations.Add(new InfoValidation($"Endereço {descricaoTipo} (Cep)", CampoObrigatorio, $"É obrigatório informar o cep do endereço {descricaoTipo.ToLower()}."));
        }

        if (CampoEhObrigatorioNaFicha($"Endereço {descricaoTipo} (Complemento)") &&
            CampoNaoEstaPreenchido<string?>(enderecos?.FirstOrDefault(e => e.Tipo == tipo)?.Complemento))
        {
            _validations.Add(new InfoValidation($"Endereço {descricaoTipo} (Complemento)", CampoObrigatorio, $"É obrigatório informar o complemento do endereço {descricaoTipo.ToLower()}."));
        }

        if (CampoEhObrigatorioNaFicha($"Endereço {descricaoTipo} (Bairro)") &&
            CampoNaoEstaPreenchido<string?>(enderecos?.FirstOrDefault(e => e.Tipo == tipo)?.Bairro))
        {
            _validations.Add(new InfoValidation($"Endereço {descricaoTipo} (Bairro)", CampoObrigatorio, $"É obrigatório informar o bairro do endereço {descricaoTipo.ToLower()}."));
        }

        if (CampoEhObrigatorioNaFicha($"Endereço {descricaoTipo} (Cidade)") &&
            CampoNaoEstaPreenchido<string?>(enderecos?.FirstOrDefault(e => e.Tipo == tipo)?.Cidade))
        {
            _validations.Add(new InfoValidation($"Endereço {descricaoTipo} (Cidade)", CampoObrigatorio, $"É obrigatório informar a cidade do endereço {descricaoTipo.ToLower()}."));
        }

        if (CampoEhObrigatorioNaFicha($"Endereço {descricaoTipo} (Estado)") &&
            CampoNaoEstaPreenchido<string?>(enderecos?.FirstOrDefault(e => e.Tipo == tipo)?.Estado))
        {
            _validations.Add(new InfoValidation($"Endereço {descricaoTipo} (Estado)", CampoObrigatorio, $"É obrigatório informar o estado do endereço {descricaoTipo.ToLower()}."));
        }
    }
}