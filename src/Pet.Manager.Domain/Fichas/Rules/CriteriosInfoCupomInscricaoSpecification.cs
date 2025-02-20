using Anima.Inscricao.Domain._Shared.Specifications;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Campos.Entities;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Domain.Inscricoes.Entities;

namespace Anima.Inscricao.Domain.Fichas.Rules;

public class CriteriosInfoCupomInscricaoSpecification : BaseRules, ISpecification<IReadOnlyList<CupomInscricao>>
{
    private readonly List<InfoValidation> _validations;

    public CriteriosInfoCupomInscricaoSpecification(
        List<InfoValidation> validations,
        List<CampoFicha> camposFicha,
        List<Campo> campos)
        : base(camposFicha, campos)
    {
        _validations = validations;
    }

    public bool IsSatisfiedBy(IReadOnlyList<CupomInscricao> infoCupomInscricao)
    {
        if (CampoEhObrigatorioNaFicha("Cupom") && 
            (!infoCupomInscricao.Any() || CampoNaoEstaPreenchido<string?>(infoCupomInscricao.FirstOrDefault()?.CupomId)))
        {
            _validations.Add(new InfoValidation("Cupom", CampoObrigatorio, "É obrigatório informar o cupom da inscrição."));
        }

        return !_validations.Any();
    }
}