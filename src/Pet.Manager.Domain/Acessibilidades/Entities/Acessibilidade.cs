using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Acessibilidades.Events;
using Anima.Inscricao.Domain.Acessibilidades.Validators;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;

namespace Anima.Inscricao.Domain.Acessibilidades.Entities;

public class Acessibilidade : AggregateEntity<AcessibilidadeId>, ISoftDelete, IHasAlternateKey, IAuditable
{
    protected Acessibilidade()
    {
        Nome = string.Empty;
        Key = Guid.Empty;
        Status = new Status();
        IntegracaoAcessibilidade = null;
    }

    private Acessibilidade(string nome, Status status) 
        : base() 
    {
        Nome = nome;
        Status = status;
        Key = Guid.NewGuid();
        IntegracaoAcessibilidade = null;

        RegisterEvent(new AcessibilidadeCriadaEvent(this.Key, this.Nome));
    }

    public string Nome { get; protected set; }

    public Status Status { get; protected set; }

    public Guid Key { get; protected set; }

    public Audit Auditoria { get; protected set; } = new Audit();

    public IntegracaoAcessibilidade? IntegracaoAcessibilidade { get; protected set; }

    public static ReturnWithValidation<Acessibilidade?> Criar(string nome)
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<NovaAcessibilidadeDomainValidator>();

        if (!validator.Validate(nome))
        {
            return ReturnWithValidation<Acessibilidade?>
                .Fail(validator.Validations);
        }
        else
        {
            return ReturnWithValidation<Acessibilidade?>
                .Success(new Acessibilidade(nome, new Status()));
        }
    }

    public ReturnWithValidation AtualizarInfos(string nome)
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<AtualizacaoAcessibilidadeDomainValidator>();

        if (!validator.Validate(Id, nome))
        {
            return ReturnWithValidation
               .Fail(validator.Validations);
        }

        Nome = nome;

        RegisterEvent(new AcessibilidadeAtualizadaEvent(this.Key, this.Nome));

        return ReturnWithValidation.Success();
    }

    public ReturnWithValidation Remover()
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<RemoverAcessibilidadeDomainValidator>();

        if(!validator.Validate(Id))
        {
            return ReturnWithValidation
                .Fail(validator.Validations);
        }
        else
        {
            RegisterEvent(new AcessibilidadeRemovidaEvent(this.Key));

            return ReturnWithValidation.Success();
        }
    }

    public void AdicionarIntegracao(IntegracaoSistemaId integracaoSistemaId, string codigo)
    {
        IntegracaoAcessibilidade = new IntegracaoAcessibilidade(integracaoSistemaId, codigo);
    }
}
