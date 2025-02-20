using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain._Shared.ValueObjects;
using Anima.Inscricao.Domain.Concursos.Events;
using Anima.Inscricao.Domain.Concursos.Validators;
using Anima.Inscricao.Domain.FormasEntrada.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Domain.Modalidades.Entities;
using Anima.Inscricao.Domain.ModalidadesAvaliacao.Entities;
using Anima.Inscricao.Domain.TiposFormacao.Entities;

namespace Anima.Inscricao.Domain.Concursos.Entities;

public class Concurso : AggregateEntity<ConcursoId>, ISoftDelete, IAuditable, IHasAlternateKey
{
    private List<ConcursoTipoFormacao> _tiposFormacao;
    private List<ConcursoFormaEntrada> _formasEntrada;
    private List<ConcursoModalidade> _modalidades;
    private List<IntegracaoConcursoFormaProva> _integracoesFormasProva;

    protected Concurso()
    {
        Nome = string.Empty;
        PeriodoLetivo = string.Empty;
        VigenciaInscricao = null!;
        DivulgacaoResultado = null;
        ConcursoParametros = null!;
        Key = Guid.Empty;
        Status = new Status();
        IntegracaoConcurso = null;
        _tiposFormacao= new List<ConcursoTipoFormacao>();
        _formasEntrada = new List<ConcursoFormaEntrada>();
        _modalidades = new List<ConcursoModalidade>();
        _integracoesFormasProva = new List<IntegracaoConcursoFormaProva>();
    }

    private Concurso(
        string nome,
        string periodoLetivo,
        Vigencia vigenciaInscricao,
        DateTimeOffset? inicioProva,
        DateTimeOffset? terminoProva,
        DateTime? divulgacaoResultado,
        Status status,
        ModalidadeAvaliacaoId? modalidadeAvaliacaoId)
        : base()
    {
        Key = Guid.NewGuid();
        Nome = nome;
        PeriodoLetivo = periodoLetivo;
        VigenciaInscricao = vigenciaInscricao;
        InicioProva = inicioProva;
        TerminoProva = terminoProva;
        DivulgacaoResultado = divulgacaoResultado;
        Status = status;
        ConcursoParametros = null!;
        IntegracaoConcurso = null;
        ModalidadeAvaliacaoId = modalidadeAvaliacaoId;

        _tiposFormacao = new List<ConcursoTipoFormacao>();
        _formasEntrada = new List<ConcursoFormaEntrada>();
        _modalidades = new List<ConcursoModalidade>();
        _integracoesFormasProva = new List<IntegracaoConcursoFormaProva>();

        RegisterEvent(new ConcursoCriadoEvent(Key, Nome, PeriodoLetivo, VigenciaInscricao, InicioProva, TerminoProva, DivulgacaoResultado, ModalidadeAvaliacaoId));
    }

    public string Nome { get; protected set; }

    public string PeriodoLetivo { get; protected set; }

    public Vigencia VigenciaInscricao { get; protected set; }

    public DateTimeOffset? InicioProva { get; protected set; }

    public DateTimeOffset? TerminoProva { get; protected set; }

    public DateTime? DivulgacaoResultado { get; protected set; }

    public ConcursoParametros? ConcursoParametros { get; protected set; }

    public IReadOnlyList<ConcursoTipoFormacao> TiposFormacao { get => _tiposFormacao; protected set => _tiposFormacao = value.ToList(); }

    public IReadOnlyList<ConcursoFormaEntrada> FormasEntrada { get => _formasEntrada; protected set => _formasEntrada = value.ToList(); }
    
    public IReadOnlyList<ConcursoModalidade> Modalidades { get => _modalidades; protected set => _modalidades = value.ToList(); }

    public IntegracaoConcurso? IntegracaoConcurso { get; protected set; }

    public IReadOnlyList<IntegracaoConcursoFormaProva> IntegracoesFormaProva { get => _integracoesFormasProva; protected set => _integracoesFormasProva = value.ToList(); }

    public Status Status { get; protected set; }

    public Guid Key { get; protected set; }

    public Audit Auditoria { get; protected set; } = new Audit();

    public ModalidadeAvaliacaoId? ModalidadeAvaliacaoId { get; set; }

    public static ReturnWithValidation<Concurso?> Criar(string nome, string periodoLetivo, Vigencia vigenciaInscricao, DateTimeOffset? inicioProva, DateTimeOffset? terminoProva, DateTime? dataDivulgacaoResultado, ModalidadeAvaliacaoId? modalidadeAvaliacaoId)
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<NovoConcursoDomainValidator>();

        if (!validator.Validate(nome, periodoLetivo))
        {
            return ReturnWithValidation<Concurso?>
               .Fail(validator.Validations);
        }
        else
        {
            return ReturnWithValidation<Concurso?>
                .Success(new Concurso(nome, periodoLetivo, vigenciaInscricao, inicioProva, terminoProva, dataDivulgacaoResultado, new Status(), modalidadeAvaliacaoId));
        }
    }

    public ReturnWithValidation AtualizarInfos(string nome, string periodoLetivo, Vigencia vigenciaInscricao, DateTimeOffset? inicioProva, DateTimeOffset? terminoProva, DateTime? divulgacaoResultado, ModalidadeAvaliacaoId? modalidadeAvaliacaoId)
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<AtualizacaoConcursoDomainValidator>();

        if (!validator.Validate(Id, nome, periodoLetivo))
        {
            return ReturnWithValidation
               .Fail(validator.Validations);
        }
        else
        {
            Nome = nome;
            PeriodoLetivo = periodoLetivo;
            VigenciaInscricao = vigenciaInscricao;
            InicioProva = inicioProva;
            TerminoProva = terminoProva;
            DivulgacaoResultado = divulgacaoResultado;
            ModalidadeAvaliacaoId = modalidadeAvaliacaoId;

            RegisterEvent(new ConcursoAtualizadoEvent(Key, Nome, PeriodoLetivo, VigenciaInscricao, InicioProva, TerminoProva, DivulgacaoResultado, ModalidadeAvaliacaoId));

            return ReturnWithValidation.Success();
        }
    }

    public ReturnWithValidation Remover()
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<RemoverConcursoDomainValidator>();

        if (!validator.Validate(Id))
        {
            return ReturnWithValidation
               .Fail(validator.Validations);
        }
        else
        {
            RegisterEvent(new ConcursoRemovidoEvent(Key));

            return ReturnWithValidation.Success();
        }
    }

    public void AdicionarIntegracao(IntegracaoSistemaId sistemaIntegracaoId, string codigoOrigem)
    {
        IntegracaoConcurso = new IntegracaoConcurso(sistemaIntegracaoId, codigoOrigem);
    }

    public void AdicionarIntegracaoFormaProva(IntegracaoSistemaId sistemaIntegracaoId, string codigoOrigem)
    {
        _integracoesFormasProva.Add(new IntegracaoConcursoFormaProva(sistemaIntegracaoId, codigoOrigem));
    }

    public void RemoverIntegracaoFormaProva(IntegracaoConcursoFormaProvaId integracaoConcursoFormaProvaId)
    {
        _integracoesFormasProva.RemoveAll(x => x.Id == integracaoConcursoFormaProvaId);
    }

    public void AdicionarTipoFormacao(TipoFormacaoId tipoFormacaoId)
    {
        _tiposFormacao.Add(new ConcursoTipoFormacao(tipoFormacaoId));
    }

    public void AdicionarFormaEntrada(FormaEntradaId formaEntradaId)
    {
        _formasEntrada.Add(new ConcursoFormaEntrada(formaEntradaId));
    }

    public void AdicionarModalidade(ModalidadeId modalidadeId)
    {
        _modalidades.Add(new ConcursoModalidade(modalidadeId));
    }

    public void RemoverTipoFormacao(TipoFormacaoId tipoFormacaoId)
    {
        var tipoFormacao = _tiposFormacao.Find(x => x.TipoFormacaoId == tipoFormacaoId);

        if (tipoFormacao is not null)
        {
            _tiposFormacao.Remove(tipoFormacao);
        }
    }

    public void RemoverFormaEntrada(FormaEntradaId formaEntradaId)
    {
        var formaEntrada = _formasEntrada.Find(x => x.FormaEntradaId == formaEntradaId);

        if (formaEntrada is not null)
        {
            _formasEntrada.Remove(formaEntrada);
        }
    }

    public void RemoverModalidade(ModalidadeId modalidadeId)
    {
        var modalidade = _modalidades.Find(x => x.ModalidadeId == modalidadeId);

        if (modalidade is not null)
        {
            _modalidades.Remove(modalidade);
        }
    }

    public void AtualizarParametros(ConcursoParametros parametros)
    {
        ConcursoParametros = parametros;
    }
}