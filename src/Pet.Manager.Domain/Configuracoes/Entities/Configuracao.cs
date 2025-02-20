using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Configuracoes.Events;
using Anima.Inscricao.Domain.Configuracoes.Validators;

namespace Anima.Inscricao.Domain.Configuracoes.Entities;

public class Configuracao : AggregateEntity<ConfiguracaoId>, IAuditable, ISoftDelete, IHasAlternateKey
{
    protected Configuracao()
    {
        ChaveGenerica = string.Empty;
        Valor = string.Empty;
        Key = Guid.Empty;
        Status = new Status();
    }

    private Configuracao(string chave, string valor, Status status)
        : base()
    {
        ChaveGenerica = chave;
        Valor = valor;
        Key = Guid.NewGuid();
        Status = status;

        RegisterEvent(new ConfiguracaoCriadaEvent(this.Key, this.ChaveGenerica, this.Valor));
    }

    public string ChaveGenerica { get; protected set; }

    public string Valor { get; protected set; }

    public Guid Key { get; protected set; }

    public Audit Auditoria { get; protected set; } = new Audit();

    public Status Status { get; protected set; }

    public static ReturnWithValidation<Configuracao?> Criar(string ChaveGenerica, string valor)
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<NovaConfiguracaoDomainValidator>();

        if (!validator.Validate(ChaveGenerica))
        {
            return ReturnWithValidation<Configuracao?>
                .Fail(validator.Validations);
        }
        else
        {
            return ReturnWithValidation<Configuracao?>
                .Success(new Configuracao(ChaveGenerica, valor, new Status()));
        }
    }

    public ReturnWithValidation AtualizarInfos(string chaveGenerica, string valor)
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<AtualizacaoConfiguracaoDomainValidator>();

        if (!validator.Validate(Id, chaveGenerica))
        {
            return ReturnWithValidation.Fail(validator.Validations);
        }

        ChaveGenerica = chaveGenerica;
        Valor = valor;

        RegisterEvent(new ConfiguracaoAtualizadaEvent(this.Key, this.ChaveGenerica, this.Valor));

        return ReturnWithValidation.Success();
    }

    public ReturnWithValidation Remover()
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<RemoverConfiguracaoDomainValidator>();

        if (!validator.Validate(Id))
        {
            return ReturnWithValidation
                .Fail(validator.Validations);
        }
        else
        {
            RegisterEvent(new ConfiguracaoRemovidaEvent(this.Key));
            return ReturnWithValidation.Success();
        }
    }
}
