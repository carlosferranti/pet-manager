using Anima.Inscricao.Domain._Shared.Validations;

namespace Anima.Inscricao.Domain.Etapas.Validators;

public class NovaEtapaTemplateDomainValidator : DomainValidator
{
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;

    public NovaEtapaTemplateDomainValidator(IEtapaTemplateRepository etapaTemplateRepository)
    {
        _etapaTemplateRepository = etapaTemplateRepository;
    }

    public bool Validate(string nome, string nomeArquivo)
    {
        var etapaExiste = _etapaTemplateRepository
            .GetQueryable()
            .Where(o => o.Nome.Trim().ToUpper().Equals(nome.Trim().ToUpper()) &&
            o.NomeArquivo.Trim().ToUpper().Equals(nomeArquivo.Trim().ToUpper()))
        .Any();

        if (etapaExiste)
        {
            Validations.Add(new InfoValidation("Etapa", "EtapaUnica", "Já existe uma etapa com o mesmo nome e arquivo."));
        }

        return !Validations.Any();
    }
}