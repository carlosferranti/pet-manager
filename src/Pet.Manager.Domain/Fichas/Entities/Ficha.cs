using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Campos.Entities;
using Anima.Inscricao.Domain.Etapas.Entities;
using Anima.Inscricao.Domain.Fichas.Events;
using Anima.Inscricao.Domain.Fichas.Validators;

namespace Anima.Inscricao.Domain.Fichas.Entities;

public class Ficha : AggregateEntity<FichaId>, ISoftDelete, IAuditable, IHasAlternateKey
{
    private List<EtapaFicha> _etapas;
    private List<CampoFicha> _campos;

    protected Ficha()
    {
        Nome = string.Empty;
        Descricao = string.Empty;
        Key = Guid.Empty;
        Status = new Status();
        Padrao = false;
        _etapas = new List<EtapaFicha>();
        _campos = new List<CampoFicha>();
    }

    public Ficha(string nome, string descricao, bool padrao, Status status)
        : base()
    {
        Key = Guid.NewGuid();
        Nome = nome;
        Descricao = descricao;
        Padrao = padrao;
        Status = status;

        _etapas = new List<EtapaFicha>();
        _campos = new List<CampoFicha>();

        RegisterEvent(new FichaCriadaEvent(Key, Nome, Descricao, Padrao));
    }

    public string Nome { get; protected set; }

    public string Descricao { get; protected set; }

    public bool Padrao { get; protected set; }

    public Status Status { get; protected set; }

    public Guid Key { get; protected set; }

    public Audit Auditoria { get; protected set; } = new Audit();

    public IReadOnlyList<EtapaFicha> Etapas { get => _etapas; protected set => _etapas = value.ToList(); }
    
    public IReadOnlyList<CampoFicha> Campos { get => _campos; protected set => _campos = value.ToList(); }

    public static ReturnWithValidation<Ficha?> Criar(string nome, string descricao, bool padrao)
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<NovaFichaDomainValidator>();

        if (!validator.Validate(nome, padrao))
        {
            return ReturnWithValidation<Ficha?>
               .Fail(validator.Validations);
        }
        else
        {
            return ReturnWithValidation<Ficha?>
                .Success(new Ficha(nome, descricao, padrao, new Status()));
        }
    }

    public ReturnWithValidation AtualizarInfos(string nome, string descricao, bool padrao)
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<AtualizacaoFichaDomainValidator>();

        if (!validator.Validate(Id, nome, padrao))
        {
            return ReturnWithValidation
               .Fail(validator.Validations);
        }
        else
        {
            Nome = nome;
            Descricao = descricao;
            Padrao = padrao;

            RegisterEvent(new FichaAtualizadaEvent(Key, Nome, Descricao, Padrao));

            return ReturnWithValidation.Success();
        }
    }

    public ReturnWithValidation Remover()
    {
        var validator = ValidatorProvider.Instance
            .GetValidator<RemoverFichaDomainValidator>();

        if (!validator.Validate(Id))
        {
            return ReturnWithValidation
               .Fail(validator.Validations);
        }
        else
        {
            RegisterEvent(new FichaRemovidaEvent(Key));

            return ReturnWithValidation.Success();
        }
    }

    public void AdicionarEtapa(EtapaTemplateId etapaTemplateId, int sequencia)
    {
        if(!_etapas.Exists(x => x.EtapaTemplateId == etapaTemplateId))
        {
            _etapas.Add(new EtapaFicha(etapaTemplateId, sequencia));
        }
    }

    public void RemoverEtapas()
    {
        _etapas.Clear();
    }

    public void AdicionarCampo(CampoId campoId, bool obrigatorioNaFicha, bool obrigatorioNoComplemento)
    {
        if (!_campos.Exists(x => x.CampoId == campoId))
        {
            _campos.Add(new CampoFicha(campoId, obrigatorioNaFicha, obrigatorioNoComplemento));
        }
    }

    public void RemoverCampos()
    {
        _etapas.Clear();
    }
}
