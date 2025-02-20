using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.FormasEntrada.Entities;
using Anima.Inscricao.Domain.Links.Events;
using Anima.Inscricao.Domain.Links.Validators;

namespace Anima.Inscricao.Domain.Links.Entities;

public class Link : AggregateEntity<LinkId>, ISoftDelete, IAuditable, IHasAlternateKey
{
    private List<LinkFormaEntrada> _formasEntrada;

    protected Link()
    {
        Nome = string.Empty;
        Key = Guid.Empty;
        Status = new Status();

        _formasEntrada = new List<LinkFormaEntrada>();
    }

    private Link(string nome, Status status)
        : this()
    {
        Nome = nome;
        Status = status;
        Key = Guid.NewGuid();

        RegisterEvent(new LinkCriadoEvent(Key, Nome));
    }

    public string Nome { get; protected set; }

    public Status Status { get; protected set; }

    public Guid Key { get; protected set; }

    public Audit Auditoria { get; protected set; } = new Audit();

    public IReadOnlyList<LinkFormaEntrada> FormasEntrada { get => _formasEntrada; protected set => _formasEntrada = value.ToList(); }

    public static ReturnWithValidation<Link?> Criar(string nome)
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<NovoLinkDomainValidator>();

        if (!validator.Validate(nome))
        {
            return ReturnWithValidation<Link?>
               .Fail(validator.Validations);
        }
        else
        {
            return ReturnWithValidation<Link?>
                .Success(new Link(nome, new Status()));
        }
    }

    public ReturnWithValidation AtualizarInfos(string nome)
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<AtualizacaoLinkDomainValidator>();

        if (!validator.Validate(Id, nome))
        {
            return ReturnWithValidation
               .Fail(validator.Validations);
        }
        else
        {
            Nome = nome;

            RegisterEvent(new LinkAtualizadoEvent(Key, Nome));

            return ReturnWithValidation.Success();
        }
    }

    public ReturnWithValidation Remover()
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<RemoverLinkDomainValidator>();

        if (!validator.Validate(Id))
        {
            return ReturnWithValidation
               .Fail(validator.Validations);
        }
        else
        {
            RegisterEvent(new LinkRemovidoEvent(Key));

            return ReturnWithValidation.Success();
        }
    }

    public void AdicionarFormaEntrada(FormaEntradaId formaEntradaId)
    {
        _formasEntrada.Add(new LinkFormaEntrada(formaEntradaId));
    }

    public void RemoverFormaEntrada(FormaEntradaId formaEntradaId)
    {
        var formaEntrada = _formasEntrada.Find(x => x.FormaEntradaId == formaEntradaId);

        if (formaEntrada is not null)
        {
            _formasEntrada.Remove(formaEntrada);
        }
    }
}