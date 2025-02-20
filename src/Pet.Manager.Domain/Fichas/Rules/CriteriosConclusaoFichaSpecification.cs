using Anima.Inscricao.Domain._Shared.Specifications;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Campos.Entities;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Domain.Inscricoes.Entities;

namespace Anima.Inscricao.Domain.Fichas.Rules;

public class CriteriosConclusaoFichaSpecification : ISpecification<InscricaoCandidato>
{
    private readonly List<InfoValidation> _validations;
    private readonly List<CampoFicha> _camposFicha;
    private readonly List<Campo> _campos;

    public CriteriosConclusaoFichaSpecification(
        List<InfoValidation> validations,
        List<CampoFicha> camposFicha,
        List<Campo> campos)
    {
        _validations = validations;
        _camposFicha = camposFicha;
        _campos = campos;
    }

    public bool IsSatisfiedBy(InscricaoCandidato inscricao)
    {
        var criteriosInscricaoSpecification = new CriteriosInscricaoSpecification(_validations, _camposFicha, _campos);
        var criteriosInfoCandidatoSpecification = new CriteriosInfoCandidatoSpecification(_validations, _camposFicha, _campos);
        var criteriosInfoOfertaInscricaoSpecification = new CriteriosInfoOfertaInscricaoSpecification(_validations, _camposFicha, _campos);
        var criteriosInfoCupomInscricaoSpecification = new CriteriosInfoCupomInscricaoSpecification(_validations, _camposFicha, _campos);
        var criteriosInfoOrigemInscricaoSpecification = new CriteriosInfoOrigemInscricaoSpecification(_validations, _camposFicha, _campos);
        var criteriosContatoInscricaoSpecification = new CriteriosContatoInscricaoSpecification(_validations, _camposFicha, _campos);
        var criteriosEnderecoInscricaoSpecification = new CriteriosEnderecoInscricaoSpecification(_validations, _camposFicha, _campos);
        var criteriosDocumentoInscricaoSpecification = new CriteriosDocumentoInscricaoSpecification(_validations, _camposFicha, _campos);
        var criteriosSeguroFiancaInscricaoSpecification = new CriteriosSeguroFiancaInscricaoSpecification(_validations, _camposFicha, _campos);
        var criteriosDocumentacaoInscricaoSpecification = new CriteriosDocumentacaoInscricaoSpecification(_validations, _camposFicha, _campos);
        var criteriosAcessibilidadeInscricaoSpecification = new CriteriosAcessibilidadeInscricaoSpecification(_validations, _camposFicha, _campos);
        var criteriosDeficienciaInscricaoSpecification = new CriteriosDeficienciaInscricaoSpecification(_validations, _camposFicha, _campos);
        var criteriosEscolaridadeInscricaoSpecification = new CriteriosEscolaridadeInscricaoSpecification(_validations, _camposFicha, _campos);

        criteriosInscricaoSpecification.IsSatisfiedBy(inscricao);
        criteriosInfoCandidatoSpecification.IsSatisfiedBy(inscricao.Candidato);
        criteriosInfoOfertaInscricaoSpecification.IsSatisfiedBy(inscricao.Oferta);
        criteriosInfoCupomInscricaoSpecification.IsSatisfiedBy(inscricao.Cupons);
        criteriosInfoOrigemInscricaoSpecification.IsSatisfiedBy(inscricao.Origem);
        criteriosContatoInscricaoSpecification.IsSatisfiedBy(inscricao.Contatos);
        criteriosEnderecoInscricaoSpecification.IsSatisfiedBy(inscricao.Enderecos);
        criteriosDocumentoInscricaoSpecification.IsSatisfiedBy(inscricao.Documentos);
        criteriosSeguroFiancaInscricaoSpecification.IsSatisfiedBy(inscricao.SeguroFianca);
        criteriosDocumentacaoInscricaoSpecification.IsSatisfiedBy(inscricao.Documentacao);
        criteriosAcessibilidadeInscricaoSpecification.IsSatisfiedBy(inscricao.Acessibilidades);
        criteriosDeficienciaInscricaoSpecification.IsSatisfiedBy(inscricao.Deficiencias);
        criteriosEscolaridadeInscricaoSpecification.IsSatisfiedBy(inscricao.Escolaridades);

        return !_validations.Any();
    }
}