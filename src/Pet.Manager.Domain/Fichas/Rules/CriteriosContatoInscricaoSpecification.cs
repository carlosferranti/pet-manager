using Anima.Inscricao.Domain._Shared.Specifications;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Campos.Entities;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Domain.Inscricoes.Entities;
using Anima.Inscricao.Domain.Inscricoes.Enums;

namespace Anima.Inscricao.Domain.Fichas.Rules;

public class CriteriosContatoInscricaoSpecification : BaseRules, ISpecification<IReadOnlyList<ContatoInscricao>>
{
    private readonly List<InfoValidation> _validations;

    public CriteriosContatoInscricaoSpecification(
        List<InfoValidation> validations,
        List<CampoFicha> camposFicha,
        List<Campo> campos)
        : base(camposFicha, campos)
    {
        _validations = validations;
    }

    public bool IsSatisfiedBy(IReadOnlyList<ContatoInscricao> contatos)
    {
        if (CampoEhObrigatorioNaFicha("Telefone Celular") && 
            CampoNaoEstaPreenchido<string?>(contatos?.FirstOrDefault(c => c.Tipo == TipoContatoInscricao.TelefoneCelular)?.Valor))
        {
            _validations.Add(new InfoValidation("Telefone Celular", CampoObrigatorio, "É obrigatório informar o telefone celular."));
        }

        if (CampoEhObrigatorioNaFicha("E-mail") &&
            CampoNaoEstaPreenchido<string?>(contatos?.FirstOrDefault(c => c.Tipo == TipoContatoInscricao.Email)?.Valor))
        {
            _validations.Add(new InfoValidation("E-mail", CampoObrigatorio, "É obrigatório informar o e-mail."));
        }

        if (CampoEhObrigatorioNaFicha("Telefone Fixo") &&
            CampoNaoEstaPreenchido<string?>(contatos?.FirstOrDefault(c => c.Tipo == TipoContatoInscricao.TelefoneFixo)?.Valor))
        {
            _validations.Add(new InfoValidation("Telefone Fixo", CampoObrigatorio, "É obrigatório informar o telefone fixo."));
        }

        if (CampoEhObrigatorioNaFicha("Telefone Comercial") &&
            CampoNaoEstaPreenchido<string?>(contatos?.FirstOrDefault(c => c.Tipo == TipoContatoInscricao.TelefoneComercial)?.Valor))
        {
            _validations.Add(new InfoValidation("Telefone Comercial", CampoObrigatorio, "É obrigatório informar o telefone comercial."));
        }

        if (CampoEhObrigatorioNaFicha("Telefone Contato") &&
            CampoNaoEstaPreenchido<string?>(contatos?.FirstOrDefault(c => c.Tipo == TipoContatoInscricao.TelefoneContato)?.Valor))
        {
            _validations.Add(new InfoValidation("Telefone Contato", CampoObrigatorio, "É obrigatório informar o telefone de contato."));
        }

        return !_validations.Any();
    }
}