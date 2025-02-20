using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Concursos.Entities;
using Anima.Inscricao.Domain.Cupons.Events;
using Anima.Inscricao.Domain.Cupons.Validators;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;

namespace Anima.Inscricao.Domain.Cupons.Entities;

public class Cupom : AggregateEntity<CupomId>, ISoftDelete, IHasAlternateKey, IAuditable
{
    protected Cupom()
    {
        ConcursoId = 0;
        Codigo = string.Empty;
        Descricao = string.Empty;
        ValorDesconto = 0;
        TipoDesconto = 0;
        Status = new Status();
        DataValidade = null;
        Key = Guid.Empty;
        IntegracaoCupom = null;
    }

    private Cupom(ConcursoId concursoId, string codigo, string descricao, float valorDesconto, int tipoDesconto, DateTime? dataValidade)
        : base()
    {
        ConcursoId = concursoId;
        Codigo = codigo;
        Descricao = descricao;
        ValorDesconto = valorDesconto;
        TipoDesconto = tipoDesconto;
        DataValidade = dataValidade;
        Status = new Status();
        Key = Guid.NewGuid();
        IntegracaoCupom = null;

        RegisterEvent(new CupomCriadoEvent(this.Key, this.ConcursoId, this.Codigo, this.Descricao, this.TipoDesconto, this.ValorDesconto, this.DataValidade));
    }

    public ConcursoId ConcursoId { get; protected set; }

    public string Codigo { get; protected set; }

    public string Descricao { get; protected set; }

    public float ValorDesconto { get; protected set; }

    public int TipoDesconto { get; protected set; }

    public DateTime? DataValidade { get; protected set; }

    public Status Status { get; protected set; }

    public Guid Key { get; protected set; }

    public Audit Auditoria { get; protected set; } = new Audit();

    public IntegracaoCupom? IntegracaoCupom { get; set; }

    public static ReturnWithValidation<Cupom?> Criar(ConcursoId concursoId, string codigo, string descricao, float valorDesconto, int tipoDesconto, DateTime? dataValidade)
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<NovoCupomDomainValidator>();

        if (!validator.Validate(codigo, concursoId))
        {
            return ReturnWithValidation<Cupom?>
                .Fail(validator.Validations);
        }
        else
        {
            return ReturnWithValidation<Cupom?>
                .Success(new Cupom(concursoId, codigo, descricao, valorDesconto, tipoDesconto, dataValidade));
        }
    }

    public ReturnWithValidation AtualizarInfos(ConcursoId concursoId, string codigo, string descricao, float valorDesconto, int tipoDesconto, DateTime? dataValidade)
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<AtualizacaoCupomDomainValidator>();

        if (!validator.Validate(Id, concursoId, codigo))
        {
            return ReturnWithValidation
                .Fail(validator.Validations);
        }

        ConcursoId = concursoId;
        Codigo = codigo;
        Descricao = descricao;
        ValorDesconto = valorDesconto;
        TipoDesconto = tipoDesconto;
        DataValidade = dataValidade;

        RegisterEvent(new CupomAtualizadoEvent(Key, ConcursoId, Codigo, Descricao, TipoDesconto,ValorDesconto, DataValidade));

        return ReturnWithValidation.Success();
    } 

    public ReturnWithValidation Remover()
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<RemoverCupomDomainValidator>();

        if (!validator.Validate(Id))
        {
            return ReturnWithValidation
                .Fail(validator.Validations);
        }
        else
        {
            RegisterEvent(new CupomRemovidoEvent(Key));
            return ReturnWithValidation.Success();
        }
    }

    public void AdicionarIntegracao(IntegracaoSistemaId integracaoSistemaId, string codigo)
    {
        IntegracaoCupom = new IntegracaoCupom(integracaoSistemaId, codigo);
    }
}
