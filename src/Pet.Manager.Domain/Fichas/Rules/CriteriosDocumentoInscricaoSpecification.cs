using Anima.Inscricao.Domain._Shared.Specifications;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Campos.Entities;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Domain.Inscricoes.Entities;
using Anima.Inscricao.Domain.Inscricoes.Enums;

namespace Anima.Inscricao.Domain.Fichas.Rules;

public class CriteriosDocumentoInscricaoSpecification : BaseRules, ISpecification<IReadOnlyList<DocumentoInscricao>>
{
    private readonly List<InfoValidation> _validations;

    public CriteriosDocumentoInscricaoSpecification(
        List<InfoValidation> validations,
        List<CampoFicha> camposFicha,
        List<Campo> campos)
        : base(camposFicha, campos)
    {
        _validations = validations;
    }

    public bool IsSatisfiedBy(IReadOnlyList<DocumentoInscricao> documentosInscricao)
    {
        if (CampoEhObrigatorioNaFicha("CPF") &&
            CampoNaoEstaPreenchido<string?>(documentosInscricao?.FirstOrDefault(d => d.Tipo == TipoDocumentoInscricao.Cpf)?.Valor))
        {
            _validations.Add(new InfoValidation("CPF", CampoObrigatorio, "É obrigatório informar o CPF."));
        }

        if (CampoEhObrigatorioNaFicha("RG") &&
            CampoNaoEstaPreenchido<string?>(documentosInscricao?.FirstOrDefault(d => d.Tipo == TipoDocumentoInscricao.Rg)?.Valor))
        {
            _validations.Add(new InfoValidation("RG", CampoObrigatorio, "É obrigatório informar o RG."));
        }

        if (CampoEhObrigatorioNaFicha("CNH") &&
            CampoNaoEstaPreenchido<string?>(documentosInscricao?.FirstOrDefault(d => d.Tipo == TipoDocumentoInscricao.Cnh)?.Valor))
        {
            _validations.Add(new InfoValidation("CNH", CampoObrigatorio, "É obrigatório informar a CNH."));
        }

        return !_validations.Any();
    }
}
