using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Campos.Events;
using Anima.Inscricao.Domain.Campos.Validators;

namespace Anima.Inscricao.Domain.Campos.Entities;

public class Campo : AggregateEntity<CampoId>, ISoftDelete, IAuditable, IHasAlternateKey
{
    protected Campo()
    {
        Nome = string.Empty;
        Key = Guid.Empty;
        Status = new Status();
    }

    private Campo(string nome, Status status)
        : base()
    {
        Nome = nome;
        Status = status;
        Key = Guid.NewGuid();

        RegisterEvent(new CampoCriadoEvent(this.Key, this.Nome));
    }

    public string Nome { get; protected set; }

    public Status Status { get; protected set; }

    public Guid Key { get; protected set; }

    public Audit Auditoria { get; protected set; } = new Audit();

    public static ReturnWithValidation<Campo?> Criar(string nome)
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<NovoCampoDomainValidator>();

        if (!validator.Validate(nome))
        {
            return ReturnWithValidation<Campo?>
                .Fail(validator.Validations);
        }
        else
        {
            return ReturnWithValidation<Campo?>
                .Success(new Campo(nome, new Status()));
        }
    }

    public ReturnWithValidation AtualizarInfos(string nome)
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<AtualizacaoCampoDomainValidator>();

        if (!validator.Validate(Id, nome))
        {
            return ReturnWithValidation
                .Fail(validator.Validations);
        }

        Nome = nome;

        RegisterEvent(new CampoAtualizadoEvent(Key, Nome));

        return ReturnWithValidation.Success();
    }

    public ReturnWithValidation Remover()
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<RemoverCampoDomainValidator>();

        if (!validator.Validate(Id))
        {
            return ReturnWithValidation
                .Fail(validator.Validations);
        }
        else
        {
            RegisterEvent(new CampoRemovidoEvent(Key));

            return ReturnWithValidation.Success();
        }
    }
}