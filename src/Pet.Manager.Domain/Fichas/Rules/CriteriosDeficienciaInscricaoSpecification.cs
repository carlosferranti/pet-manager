using Anima.Inscricao.Domain._Shared.Specifications;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Campos.Entities;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Domain.Inscricoes.Entities;

namespace Anima.Inscricao.Domain.Fichas.Rules;

public class CriteriosDeficienciaInscricaoSpecification : BaseRules, ISpecification<IReadOnlyList<DeficienciaInscricao>>
{
    private readonly List<InfoValidation> _validations;

    public CriteriosDeficienciaInscricaoSpecification(
        List<InfoValidation> validations,
        List<CampoFicha> camposFicha,
        List<Campo> campos)
        : base(camposFicha, campos)
    {
        _validations = validations;
    }

    public bool IsSatisfiedBy(IReadOnlyList<DeficienciaInscricao> deficienciasInscricao)
    {
        foreach (var deficiencia in deficienciasInscricao)
        {
            if (CampoEhObrigatorioNaFicha("Deficiência") && CampoNaoEstaPreenchido<int?>(deficiencia.DeficienciaId?.Id))
            {
                _validations.Add(new InfoValidation("Deficiência", CampoObrigatorio, "É obrigatório informar a deficiência do candidato."));
            }
        }

        return !_validations.Any();
    }
}