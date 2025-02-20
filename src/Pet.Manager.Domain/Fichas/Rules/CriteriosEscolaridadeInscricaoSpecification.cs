using Anima.Inscricao.Domain._Shared.Specifications;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Campos.Entities;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Domain.Inscricoes.Entities;

namespace Anima.Inscricao.Domain.Fichas.Rules;

public class CriteriosEscolaridadeInscricaoSpecification : BaseRules, ISpecification<IReadOnlyList<EscolaridadeInscricao>>
{
    private readonly List<InfoValidation> _validations;

    public CriteriosEscolaridadeInscricaoSpecification(
        List<InfoValidation> validations,
        List<CampoFicha> camposFicha,
        List<Campo> campos)
        : base(camposFicha, campos)
    {
        _validations = validations;
    }

    public bool IsSatisfiedBy(IReadOnlyList<EscolaridadeInscricao> escolaridadeInscricao)
    {
        if ((CampoEhObrigatorioNaFicha("Ano de Conclusão do Ensino Médio") ||
            CampoEhObrigatorioNaFicha("Estado da escola do Ensino Médio") ||
            CampoEhObrigatorioNaFicha("Cidade da escola do Ensino Médio") ||
            CampoEhObrigatorioNaFicha("Escola do Ensino Médio")) && 
            !escolaridadeInscricao.Any())
        {
            _validations.Add(new InfoValidation("Escola do Ensino Médio", CampoObrigatorio, "É obrigatório informar os dados do ensino médio."));
        }

        foreach (var escolaridade in escolaridadeInscricao)
        {
            if (CampoEhObrigatorioNaFicha("Ano de Conclusão do Ensino Médio") && CampoNaoEstaPreenchido<int?>(escolaridade.AnoConclusao))
            {
                _validations.Add(new InfoValidation("Ano de Conclusão do Ensino Médio", CampoObrigatorio, "É obrigatório informar o ano de conclusão do ensino médio."));
            }

            if (CampoEhObrigatorioNaFicha("Estado da escola do Ensino Médio") && CampoNaoEstaPreenchido<int?>(escolaridade.EstadoId?.Id))
            {
                _validations.Add(new InfoValidation("Estado da escola do Ensino Médio", CampoObrigatorio, "É obrigatório informar o estado da escola do ensino médio."));
            }

            if (CampoEhObrigatorioNaFicha("Cidade da escola do Ensino Médio") && CampoNaoEstaPreenchido<int?>(escolaridade.CidadeId?.Id))
            {
                _validations.Add(new InfoValidation("Cidade da escola do Ensino Médio", CampoObrigatorio, "É obrigatório informar a cidade da escola do ensino médio."));
            }

            if (CampoEhObrigatorioNaFicha("Escola do Ensino Médio") && 
                (CampoNaoEstaPreenchido<int?>(escolaridade.EscolaId?.Id) ||
                 CampoNaoEstaPreenchido<string?>(escolaridade.OutraEscola)))
            {
                _validations.Add(new InfoValidation("Escola do Ensino Médio", CampoObrigatorio, "É obrigatório informar a escola do ensino médio."));
            }
        }

        return !_validations.Any();
    }
}
