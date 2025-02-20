using Anima.Inscricao.Domain._Shared.Specifications;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Campos.Entities;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Domain.Inscricoes.Entities;

namespace Anima.Inscricao.Domain.Fichas.Rules;

public class CriteriosInfoOrigemInscricaoSpecification : BaseRules, ISpecification<InscricaoOrigem>
{
    private readonly List<InfoValidation> _validations;

    public CriteriosInfoOrigemInscricaoSpecification(
        List<InfoValidation> validations,
        List<CampoFicha> camposFicha,
        List<Campo> campos)
        : base(camposFicha, campos)
    {
        _validations = validations;
    }

    public bool IsSatisfiedBy(InscricaoOrigem infoOrigemInscricao)
    {
        if (CampoEhObrigatorioNaFicha("Origem") && CampoNaoEstaPreenchido<int?>((int?)infoOrigemInscricao?.Tipo))
        {
            _validations.Add(new InfoValidation("Origem", CampoObrigatorio, "É obrigatório informar a origem da inscrição."));
        }

        return !_validations.Any();
    }
}