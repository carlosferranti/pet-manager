using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Etapas.Entities;

namespace Anima.Inscricao.Domain.Etapas.Validators;

public class AtualizacaoEtapaTemplateDomainValidator : DomainValidator
{
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;

    public AtualizacaoEtapaTemplateDomainValidator(IEtapaTemplateRepository etapaTemplateRepository)
    {
        _etapaTemplateRepository = etapaTemplateRepository;
    }

    public bool Validate(EtapaTemplateId etapaTemplateId, string nome, string nomeArquivo)
    {
        var etapaExiste = _etapaTemplateRepository
            .GetQueryable()
            .Where(e => e.Nome.Trim().ToUpper().Equals(nome.Trim().ToUpper()) &&
            e.NomeArquivo.Trim().ToUpper().Equals(nomeArquivo.Trim().ToUpper()) &&
            e.Id != etapaTemplateId)
        .Any();

        if (etapaExiste)
        {
            Validations.Add(new InfoValidation("Etapa", "EtapaUnica", "Já existe uma etapa com o mesmo nome e arquivo."));
        }

        return !Validations.Any();
    }
}
