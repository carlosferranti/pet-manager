using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Campi.Entities;
using Anima.Inscricao.Domain.Concursos.Events;
using Anima.Inscricao.Domain.Cursos.Entities;
using Anima.Inscricao.Domain.Instituicoes.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Domain.Produtos.Events;
using Anima.Inscricao.Domain.Produtos.Validators;
using Anima.Inscricao.Domain.Turnos.Entities;

namespace Anima.Inscricao.Domain.Produtos.Entities;

public class Produto : AggregateEntity<ProdutoId>, ISoftDelete, IAuditable, IHasAlternateKey
{
    protected Produto()
    {
        Key = Guid.Empty;
        Status = new Status();
        InstituicaoId = 0;
        CampusId = 0;
        CursoId = 0;
        TurnoId = 0;
        Sku = string.Empty;
        IntegracaoProduto = null;
    }

    private Produto(
        Status status,
        InstituicaoId instituicaoId, 
        CampusId campusId, 
        CursoId cursoId, 
        TurnoId turnoId, 
        string sku
        ) : base()
    {
        Key = Guid.NewGuid();
        Status = status;
        InstituicaoId = instituicaoId;
        CampusId = campusId;
        CursoId = cursoId;
        TurnoId = turnoId;
        Sku = sku;
        IntegracaoProduto = null;

        RegisterEvent(new ProdutoCriadoEvent(
            this.Key, 
            this.InstituicaoId, 
            this.CampusId, 
            this.CursoId, 
            this.TurnoId, 
            this.Sku ));
    }

    public InstituicaoId InstituicaoId { get; protected set; }

    public CampusId CampusId { get; protected set; }

    public CursoId CursoId { get; protected set; }

    public TurnoId TurnoId { get; protected set; }

    public string Sku {  get; protected set; }

    public IntegracaoProduto? IntegracaoProduto { get; protected set; }

    public Status Status { get; protected set; }

    public Guid Key { get; protected set; }

    public Audit Auditoria { get; protected set; } = new Audit();


    public static ReturnWithValidation<Produto?> Criar( 
        InstituicaoId instituicaoId, 
        CampusId campusId,
        CursoId cursoId,
        TurnoId turnoId,
        string sku)
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<NovoProdutoDomainValidator>();

        if (!validator.Validate(instituicaoId, campusId, cursoId, turnoId, sku))
        {
            return ReturnWithValidation<Produto?>
               .Fail(validator.Validations);
        }
        else
        {
            return ReturnWithValidation<Produto?>
                .Success(new Produto(new Status(), instituicaoId, campusId, cursoId, turnoId, sku));
        }
    }

    public ReturnWithValidation AtualizarInfos(
        InstituicaoId instituicaoId,
        CampusId campusId,
        CursoId cursoId,
        TurnoId turnoId,
        string sku)
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<AtualizarProdutoDomainValidator>();
        
        if(!validator.Validate(Id, instituicaoId, campusId, cursoId, turnoId, sku))
        {
            return ReturnWithValidation
                .Fail(validator.Validations);
        }
        else
        {
            InstituicaoId = instituicaoId;
            CampusId = campusId;
            CursoId = cursoId;
            TurnoId = turnoId;
            Sku = sku;

            RegisterEvent(new ProdutoAtualizadoEvent(Key, instituicaoId,  campusId, cursoId, turnoId, sku));

            return ReturnWithValidation.Success();
        }
    }

    public ReturnWithValidation Remover()
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<RemoverProdutoDomainValidator>();

        if (!validator.Validate(Id))
        {
           return ReturnWithValidation .Fail(validator.Validations);


        }
        else
        {
            RegisterEvent(new ProdutoRemovidoEvent(Key));

            return ReturnWithValidation.Success();
        }
    }

    public void AdicionarIntegracao(IntegracaoSistemaId integracaoSistemaId, string codigoOrigem)
    {
        IntegracaoProduto = new IntegracaoProduto(integracaoSistemaId, codigoOrigem);
    }

}
