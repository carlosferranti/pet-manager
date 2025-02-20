using Anima.Inscricao.Domain._Shared.Specifications;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Campos.Entities;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Domain.Inscricoes.Entities;
using Anima.Inscricao.Domain.Inscricoes.Enums;

namespace Anima.Inscricao.Domain.Fichas.Rules;

public class CriteriosDocumentacaoInscricaoSpecification : BaseRules, ISpecification<IReadOnlyList<DocumentacaoInscricao>>
{
    private readonly List<InfoValidation> _validations;

    public CriteriosDocumentacaoInscricaoSpecification(
        List<InfoValidation> validations,
        List<CampoFicha> camposFicha,
        List<Campo> campos)
        : base(camposFicha, campos)
    {
        _validations = validations;
    }

    public bool IsSatisfiedBy(IReadOnlyList<DocumentacaoInscricao> documentacao)
    {
        if (CampoEhObrigatorioNaFicha("Certificado Ensino Médio") &&
            CampoNaoEstaPreenchido<string?>(documentacao?.FirstOrDefault(c => c.Tipo == TipoDocumentacaoInscricao.HistoricoEscolar)?.Arquivo?.Chave))
        {
            _validations.Add(new InfoValidation("Certificado Ensino Médio", CampoObrigatorio, "É obrigatório informar o certificado do ensino médio."));
        }

        if ((CampoEhObrigatorioNaFicha("Comprovante de Acessibilidade") || CampoEhObrigatorioNaFicha("Comprovante de Deficiência")) &&
           CampoNaoEstaPreenchido<string?>(documentacao?.FirstOrDefault(c => c.Tipo == TipoDocumentacaoInscricao.LaudoNecessidadesEspeciais)?.Arquivo?.Chave))
        {
            _validations.Add(new InfoValidation("Comprovante de Deficiência ou Acessibilidade.", CampoObrigatorio, "É obrigatório informar o comprovante de deficiência ou acessibilidade."));
        }

        return !_validations.Any();
    }
}