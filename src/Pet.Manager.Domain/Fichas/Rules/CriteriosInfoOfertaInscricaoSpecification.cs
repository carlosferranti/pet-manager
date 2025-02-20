using Anima.Inscricao.Domain._Shared.Specifications;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Campos.Entities;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Domain.Inscricoes.Entities;

namespace Anima.Inscricao.Domain.Fichas.Rules;

public class CriteriosInfoOfertaInscricaoSpecification : BaseRules, ISpecification<InfoOfertaInscricao>
{
    private readonly List<InfoValidation> _validations;

    public CriteriosInfoOfertaInscricaoSpecification(
        List<InfoValidation> validations,
        List<CampoFicha> camposFicha,
        List<Campo> campos)
        : base(camposFicha, campos)
    {
        _validations = validations;
    }

    public bool IsSatisfiedBy(InfoOfertaInscricao infoOfertaInscricao)
    {
        if (CampoEhObrigatorioNaFicha("Oferta") && CampoNaoEstaPreenchido<int?>(infoOfertaInscricao?.OfertaId?.Id))
        {
            _validations.Add(new InfoValidation("Oferta", CampoObrigatorio, "É obrigatório informar a oferta da inscrição."));
        }

        if (CampoEhObrigatorioNaFicha("Oferta-Concurso") && CampoNaoEstaPreenchido<int?>(infoOfertaInscricao?.OfertaConcursoId?.Id))
        {
            _validations.Add(new InfoValidation("Oferta-Concurso", CampoObrigatorio, "É obrigatório informar a oferta-concurso da inscrição."));
        }

        return !_validations.Any();
    }
}