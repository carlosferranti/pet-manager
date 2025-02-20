using Anima.Inscricao.Domain._Shared.Specifications;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Campos.Entities;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Domain.Inscricoes.Entities;

namespace Anima.Inscricao.Domain.Fichas.Rules;

public class CriteriosSeguroFiancaInscricaoSpecification : BaseRules, ISpecification<IReadOnlyList<SeguroFiancaInscricao>>
{
    private readonly List<InfoValidation> _validations;

    public CriteriosSeguroFiancaInscricaoSpecification(
        List<InfoValidation> validations,
        List<CampoFicha> camposFicha,
        List<Campo> campos)
        : base(camposFicha, campos)
    {
        _validations = validations;
    }

    public bool IsSatisfiedBy(IReadOnlyList<SeguroFiancaInscricao> seguroFianca)
    {
        if ((CampoEhObrigatorioNaFicha("Nome Fiador") ||
            CampoEhObrigatorioNaFicha("Relacionamento Fiador") ||
            CampoEhObrigatorioNaFicha("Percentual Fiador") ||
            CampoEhObrigatorioNaFicha("Renda Média Mensal Fiador") ||
            CampoEhObrigatorioNaFicha("Documento Fiador") ||
            CampoEhObrigatorioNaFicha("Contato Fiador")) && !seguroFianca.Any())
        {
            _validations.Add(new InfoValidation("Fiador", CampoObrigatorio, "É obrigatório informar os dados do fiador."));
        }

        foreach (var item in seguroFianca)
        {
            if (CampoEhObrigatorioNaFicha("Nome Fiador") && CampoNaoEstaPreenchido<string?>(item.DadosFiador?.NomeFiador))
                    {
                _validations.Add(new InfoValidation("Nome Fiador", CampoObrigatorio, "É obrigatório informar o nome do fiador."));
            }

            if (CampoEhObrigatorioNaFicha("Relacionamento Fiador") && CampoNaoEstaPreenchido<string?>(item.DadosFiador?.TipoRelacionamentoSegurado))
            {
                _validations.Add(new InfoValidation("Relacionamento Fiador", CampoObrigatorio, "É obrigatório informar o tipo de relacionamento com o fiador."));
            }

            if (CampoEhObrigatorioNaFicha("Percentual Fiador") && CampoNaoEstaPreenchido<decimal?>(item.DadosFiador?.PercentualFiador))
            {
                _validations.Add(new InfoValidation("Percentual Fiador", CampoObrigatorio, "É obrigatório informar o percentual do fiador."));
            }

            if (CampoEhObrigatorioNaFicha("Renda Média Mensal Fiador") && CampoNaoEstaPreenchido<decimal?>(item.DadosFiador?.InfoRendaFiador?.RendaMediaMensal))
            {
                _validations.Add(new InfoValidation("Renda Média Mensal Fiador", CampoObrigatorio, "É obrigatório informar a renda média mensal do fiador."));
            }

            if (CampoEhObrigatorioNaFicha("Documento Fiador") && CampoNaoEstaPreenchido<string?>(item.DocumentosFiador.Valor))
            {
                _validations.Add(new InfoValidation("Documento Fiador", CampoObrigatorio, "É obrigatório informar um documento do fiador."));
            }

            if (CampoEhObrigatorioNaFicha("Contato Fiador") && CampoNaoEstaPreenchido<string?>(item.ContatosFiador.Valor))
            {
                _validations.Add(new InfoValidation("Contato Fiador", CampoObrigatorio, "É obrigatório informar um contato do fiador."));
            }
        }
        
        return !_validations.Any();
    }
}
