using Anima.Inscricao.Domain._Shared.Specifications;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Campos.Entities;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Domain.Inscricoes.Entities;

namespace Anima.Inscricao.Domain.Fichas.Rules;

public class CriteriosAcessibilidadeInscricaoSpecification : BaseRules, ISpecification<IReadOnlyList<AcessibilidadeInscricao>>
{
    private readonly List<InfoValidation> _validations;

    public CriteriosAcessibilidadeInscricaoSpecification(
        List<InfoValidation> validations,
        List<CampoFicha> camposFicha,
        List<Campo> campos)
        : base(camposFicha, campos)
    {
        _validations = validations;
    }

    public bool IsSatisfiedBy(IReadOnlyList<AcessibilidadeInscricao> acessibilidadesInscricao)
    {
        if ((CampoEhObrigatorioNaFicha("Acessibilidade") || CampoEhObrigatorioNaFicha("Comprovante de Acessibilidade")) && 
            !acessibilidadesInscricao.Any())
        {
            _validations.Add(new InfoValidation("Acessibilidade", CampoObrigatorio, "É obrigatório informar a acessibilidade do candidato."));
        }

        foreach (var acessibilidade in acessibilidadesInscricao)
        {
            if (CampoEhObrigatorioNaFicha("Acessibilidade") && CampoNaoEstaPreenchido<int?>(acessibilidade.AcessibilidadeId?.Id))
            {
                _validations.Add(new InfoValidation("Acessibilidade", CampoObrigatorio, "É obrigatório informar a acessibilidade do candidato."));
            }
        }

        return !_validations.Any();
    }
}