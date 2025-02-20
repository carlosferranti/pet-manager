using Anima.Inscricao.Domain._Shared.Specifications;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Campos.Entities;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Domain.Inscricoes.Entities;

namespace Anima.Inscricao.Domain.Fichas.Rules;

public class CriteriosInfoCandidatoSpecification : BaseRules, ISpecification<InfoCandidato>
{
    private readonly List<InfoValidation> _validations;

    public CriteriosInfoCandidatoSpecification(
        List<InfoValidation> validations,
        List<CampoFicha> camposFicha,
        List<Campo> campos)
        : base(camposFicha, campos)
    {
        _validations = validations;
    }

    public bool IsSatisfiedBy(InfoCandidato? infoCandidato)
    {
        if (CampoEhObrigatorioNaFicha("Nome") && CampoNaoEstaPreenchido<string?>(infoCandidato?.Nome))
        {
            _validations.Add(new InfoValidation("Nome", CampoObrigatorio, "É obrigatório informar o nome do candidato."));
        }

        if (CampoEhObrigatorioNaFicha("Data de Nascimento") && CampoNaoEstaPreenchido<DateTime?>(infoCandidato?.DataNascimento))
        {
            _validations.Add(new InfoValidation("Data de Nascimento", CampoObrigatorio, "É obrigatório informar a data de nascimento do candidato."));
        }

        if (CampoEhObrigatorioNaFicha("Sexo") && CampoNaoEstaPreenchido<int?>(infoCandidato?.Sexo))
        {
            _validations.Add(new InfoValidation("Sexo", CampoObrigatorio, "É obrigatório informar o sexo do candidato."));
        }

        if (CampoEhObrigatorioNaFicha("Necessidade Especial") && CampoNaoEstaPreenchido<bool?>(infoCandidato?.NecessidadeEspecial))
        {
            _validations.Add(new InfoValidation("Necessidade Especial", CampoObrigatorio, "É obrigatório informar se o candidado tem necessidades especiais."));
        }

        if (CampoEhObrigatorioNaFicha("Nome Social") && CampoNaoEstaPreenchido<string?>(infoCandidato?.NomeSocial))
        {
            _validations.Add(new InfoValidation("Nome Social", CampoObrigatorio, "É obrigatório informar o nome social do candidato."));
        }

        return !_validations.Any();
    }
}
