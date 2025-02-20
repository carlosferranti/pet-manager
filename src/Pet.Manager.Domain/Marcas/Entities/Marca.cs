using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Domain.Marcas.Events;
using Anima.Inscricao.Domain.Marcas.Validators;

namespace Anima.Inscricao.Domain.Marcas.Entities;

public class Marca : AggregateEntity<MarcaId>, ISoftDelete, IHasAlternateKey, IAuditable
{
    private List<IntegracaoMarca> _integracaoMarcas;

    protected Marca()
    {
        Nome = string.Empty;
        Sigla = string.Empty;
        Key = Guid.Empty;
        Status = new Status();

        _integracaoMarcas = new List<IntegracaoMarca>();
    }

    private Marca(string nome, string sigla, Status status)
    {
        Nome = nome;
        Sigla = sigla;
        Status = status;
        Key = Guid.NewGuid();

        _integracaoMarcas = new List<IntegracaoMarca>();

        RegisterEvent(new MarcaCriadaEvent(this.Key, this.Nome, this.Sigla));
    }

    public string Nome { get; protected set; }

    public string Sigla { get; protected set; }

    public Status Status { get; protected set; }

    public Guid Key { get; protected set; }

    public Audit Auditoria { get; protected set; } = new Audit();

    public IReadOnlyList<IntegracaoMarca> IntegracoesMarcas { get => _integracaoMarcas; protected set => _integracaoMarcas = value.ToList(); }

    public static ReturnWithValidation<Marca?> Criar(string nome, string sigla)
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<NovaMarcaDomainValidator>();

        if (!validator.Validate(nome, sigla))
        {
            return ReturnWithValidation<Marca?>
                .Fail(validator.Validations);
        }
        else
        {
            return ReturnWithValidation<Marca?>
                .Success(new Marca(nome, sigla, new Status()));
        }
    }

    public ReturnWithValidation AtualizarInfos(string nome, string? sigla)
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<AtualizacaoMarcaDomainValidator>();

        string siglaValidate = sigla ?? Sigla;

        if (!validator.Validate(Id, nome, siglaValidate))
        {
            return ReturnWithValidation.Fail(validator.Validations);
        }

        Nome = nome;
        Sigla = siglaValidate;

        RegisterEvent(new MarcaAtualizadaEvent(Key, Nome, Sigla));

        return ReturnWithValidation.Success();
    }

    public ReturnWithValidation Remover()
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<RemoverMarcaDomainValidator>();

        if (!validator.Validate(Id))
        {
            return ReturnWithValidation
                .Fail(validator.Validations);
        }
        else
        {
            RegisterEvent(new MarcaRemovidaEvent(Key));

            return ReturnWithValidation.Success();
        }
    }

    public ReturnWithValidation AdicionarIntegracao(IntegracaoSistemaId integracaoSistemaId, string codigo)
    {
        var validador = ValidatorProvider.Instance
            .GetValidator<NovaIntegracaoMarcaDomainValidator>();

        if (!validador.Validate(this, integracaoSistemaId))
        {
            return ReturnWithValidation
               .Fail(validador.Validations);
        }
        else
        {
            var novaIntegracao = new IntegracaoMarca(integracaoSistemaId, codigo);
            _integracaoMarcas.Add(novaIntegracao);

            return ReturnWithValidation.Success();
        }
    }
}
