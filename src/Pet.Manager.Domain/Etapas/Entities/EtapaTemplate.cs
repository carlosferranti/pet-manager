using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Etapas.Events;
using Anima.Inscricao.Domain.Etapas.Validators;

namespace Anima.Inscricao.Domain.Etapas.Entities;

public class EtapaTemplate : AggregateEntity<EtapaTemplateId>, IEtapa, IAuditable, IHasAlternateKey
{
    public EtapaTemplate(string nome, string descricao, string nomeArquivo, Status status)
    {
        Nome = nome;
        Descricao = descricao;
        Status = status;
        Key = Guid.NewGuid();
        NomeArquivo = nomeArquivo;

        RegisterEvent(new EtapaTemplateCriadaEvent(this.Key, this.Nome, this.Descricao, this.NomeArquivo));
    }

    protected EtapaTemplate()
    {
        Nome = string.Empty;
        Descricao = string.Empty;
        NomeArquivo = string.Empty;
        Status = new Status();
        Key = Guid.Empty;
    }

    public string Nome { get; protected set; }

    public string Descricao { get; protected set; }

    public string NomeArquivo { get; protected set; }

    public Status Status { get; protected set; }

    public Guid Key { get; protected set; }

    public Audit Auditoria { get; protected set; } = new Audit();

    public static ReturnWithValidation<EtapaTemplate?> Criar(string nome, string descricao, string nomeArquivo)
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<NovaEtapaTemplateDomainValidator>();

        if (!validator.Validate(nome, nomeArquivo))
        {
            return ReturnWithValidation<EtapaTemplate?>
                .Fail(validator.Validations);
        }
        else
        {
            return ReturnWithValidation<EtapaTemplate?>
                .Success(new EtapaTemplate(nome, descricao, nomeArquivo, new Status()));
        }
    }

    public ReturnWithValidation AtualizarInfos(string nome, string descricao, string nomeArquivo)
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<AtualizacaoEtapaTemplateDomainValidator>();

        if (!validator.Validate(Id, nome, nomeArquivo))
        {
            return ReturnWithValidation
               .Fail(validator.Validations);
        }
        else
        {
            Nome = nome;
            Descricao = descricao;
            NomeArquivo = nomeArquivo;

            RegisterEvent(new EtapaTemplateAtualizadaEvent(Key, Nome, Descricao, NomeArquivo));

            return ReturnWithValidation.Success();
        }
    }

    public ReturnWithValidation Remover()
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<RemoverEtapaTemplateDomainValidator>();

        if (!validator.Validate(Id))
        {
            return ReturnWithValidation
               .Fail(validator.Validations);
        }
        else
        {
            RegisterEvent(new EtapaTemplateRemovidaEvent(Key));

            return ReturnWithValidation.Success();
        }
    }
}

