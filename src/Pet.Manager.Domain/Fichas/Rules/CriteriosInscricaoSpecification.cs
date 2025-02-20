using Anima.Inscricao.Domain._Shared.Specifications;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Campos.Entities;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Domain.Inscricoes.Entities;
using Anima.Inscricao.Domain.Inscricoes.Enums;

namespace Anima.Inscricao.Domain.Fichas.Rules;

public class CriteriosInscricaoSpecification : BaseRules, ISpecification<InscricaoCandidato>
{
    private readonly List<InfoValidation> _validations;

    public CriteriosInscricaoSpecification(
        List<InfoValidation> validations,
        List<CampoFicha> camposFicha,
        List<Campo> campos)
        : base(camposFicha, campos)
    {
        _validations = validations;
    }

    public bool IsSatisfiedBy(InscricaoCandidato inscricaoCandidato)
    {
        if(CampoEhObrigatorioNaFicha("Marca") && inscricaoCandidato.MarcaId == 0)
        {
            _validations.Add(new InfoValidation("Marca", CampoObrigatorio, "É obrigatório informar a marca da inscrição."));
        }

        if (CampoEhObrigatorioNaFicha("Ficha") && inscricaoCandidato.FichaId == 0)
        {
            _validations.Add(new InfoValidation("Ficha", CampoObrigatorio, "É obrigatório informar a ficha da inscrição."));
        }

        if (CampoEhObrigatorioNaFicha("Forma de entrada") && CampoNaoEstaPreenchido<int?>(inscricaoCandidato?.FormasEntrada?.FirstOrDefault(x => x.CodigoTipoSelecao == TipoSelecaoFormaEntrada.Manual)?.FormaEntradaId?.Id))
        {
            _validations.Add(new InfoValidation("Forma de entrada", CampoObrigatorio, "É obrigatório informar a forma de entrada da inscrição."));
        }

        return !_validations.Any();
    }
}