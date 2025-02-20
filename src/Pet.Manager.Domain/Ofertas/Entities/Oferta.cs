using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Intakes.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Domain.Ofertas.Events;
using Anima.Inscricao.Domain.Ofertas.Validators;
using Anima.Inscricao.Domain.Produtos.Entities;

namespace Anima.Inscricao.Domain.Ofertas.Entities;

public class Oferta : AggregateEntity<OfertaId>, ISoftDelete, IAuditable, IHasAlternateKey
{

    protected Oferta() 
    {
        Key = Guid.Empty;
        Status = new Status();
        IntegracaoOferta = null;
        ProdutoId = 0;
        IntakeId = 0;
    }

    private Oferta(Status status, ProdutoId produtoId, IntakeId intakeId)
        : base()
    {
        Key = Guid.NewGuid();
        Status = status;
        ProdutoId = produtoId;
        IntakeId = intakeId;

        RegisterEvent(new OfertaCriadaEvent(this.Key, this.ProdutoId, this.IntakeId));
    }

    public ProdutoId ProdutoId { get; protected set; }

    public IntakeId IntakeId { get; protected set; }

    public Status Status { get; protected set; }

    public Guid Key { get; protected set; }

    public Audit Auditoria { get; protected set; } = new Audit();

    public IntegracaoOferta? IntegracaoOferta { get; protected set; }

    public static ReturnWithValidation<Oferta?> Criar(ProdutoId produtoId, IntakeId intakeId)
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<NovaOfertaDomainValidator>();

        if(!validator.Validate(produtoId, intakeId))
        {
            return ReturnWithValidation<Oferta?>
                .Fail(validator.Validations);
        }
        else
        {
            return ReturnWithValidation<Oferta?>
                .Success(new Oferta(new Status(), produtoId, intakeId));
        }
    }

    public ReturnWithValidation AtualizarInfos(ProdutoId produtoId, IntakeId intakeId)
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<AtualizacaoOfertaDomainValidator>();

        if (!validator.Validate(Id, produtoId, intakeId))
        {
            return ReturnWithValidation
                .Fail(validator.Validations);
        }
        else
        {
            ProdutoId = produtoId;
            IntakeId = intakeId;

            RegisterEvent(new OfertaAtualizadaEvent(Key, produtoId, intakeId));

            return ReturnWithValidation.Success();
        }
    }

    public ReturnWithValidation Remover()
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<RemoverOfertaDomainValidator>();

        if(validator.Validate(Id))
        {
            return ReturnWithValidation
                .Fail(validator.Validations);
        }
        else
        {
            RegisterEvent(new OfertaRemovidaEvent(Key));

            return ReturnWithValidation.Success();
        }
    }

    public void AdicionarIntegracao(IntegracaoSistemaId sistemaIntegracaoId, string codigoOrigem)
    {
        IntegracaoOferta = new IntegracaoOferta(sistemaIntegracaoId, codigoOrigem);
    }

}
