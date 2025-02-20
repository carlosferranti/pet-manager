using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Acessibilidades;
using Anima.Inscricao.Domain.Cupons;
using Anima.Inscricao.Domain.CursosExternos;
using Anima.Inscricao.Domain.CursosExternos.Entities;
using Anima.Inscricao.Domain.Deficiencias;
using Anima.Inscricao.Domain.Empresas;
using Anima.Inscricao.Domain.Empresas.Entities;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Domain.Escolas.Entities;
using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.FormasEntrada.Entities;
using Anima.Inscricao.Domain.Inscricoes.Entities;
using Anima.Inscricao.Domain.Inscricoes.Enums;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.Matriculas;
using Anima.Inscricao.Domain.Matriculas.Entities;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.OfertaConcursos.Entities;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Ofertas.Entities;
using Anima.Inscricoes.Domain.Inscricoes;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.CriarInscricaoCandidato;

public class CriarInscricaoCandidatoCommandHandler : ICommandHandler<CriarInscricaoCandidatoCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly IInscricaoRepository _inscricaoRepository;
    private readonly IFichaRepository _fichaRepository;
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IMarcaRepository _marcaRepository;
    private readonly ICupomRepository _cupomRepository;
    private readonly IAcessibilidadeRepository _acessibilidadeRepository;
    private readonly IDeficienciaRepository _deficienciaRepository;
    private readonly IEstadoRepository _estadoRepository;
    private readonly ICidadeRepository _cidadeRepository;
    private readonly IEscolaRepository _escolaRepository;
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly IOfertaConcursoOpcaoAcessoRepository _ofertaConcursoOpcaoAcessoRepository;
    private readonly IEmpresaRepository _empresaRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICursoExternoRepository _cursoExternoRepository;
    private readonly IMatriculaRepository _matriculaRepository;

    private const string fichaUrlPath = "/inscricoes/";

    public CriarInscricaoCandidatoCommandHandler(
        INotificationContext notificationContext,
        IInscricaoRepository inscricaoRepository,
        IFichaRepository fichaRepository,
        IOfertaConcursoRepository ofertaConcursoRepository,
        IOfertaRepository ofertaRepository,
        IMarcaRepository marcaRepository,
        ICupomRepository cupomRepository,
        IDeficienciaRepository deficienciaRepository,
        IAcessibilidadeRepository acessibilidadeRepository,
        IEstadoRepository estadoRepository,
        ICidadeRepository cidadeRepository,
        IEscolaRepository escolaRepository,
        IEtapaTemplateRepository etapaTemplateRepository,
        IFormaEntradaRepository formaEntradaRepository,
        IOfertaConcursoOpcaoAcessoRepository ofertaConcursoOpcaoAcessoRepository,
        IEmpresaRepository empresaRepository,
        IUnitOfWork unitOfWork,
        ICursoExternoRepository cursoExternoRepository,
        IMatriculaRepository matriculaRepository)
    {
        _notificationContext = notificationContext;
        _inscricaoRepository = inscricaoRepository;
        _fichaRepository = fichaRepository;
        _ofertaConcursoRepository = ofertaConcursoRepository;
        _ofertaRepository = ofertaRepository;
        _marcaRepository = marcaRepository;
        _cupomRepository = cupomRepository;
        _deficienciaRepository = deficienciaRepository;
        _acessibilidadeRepository = acessibilidadeRepository;
        _estadoRepository = estadoRepository;
        _cidadeRepository = cidadeRepository;
        _escolaRepository = escolaRepository;
        _etapaTemplateRepository = etapaTemplateRepository;
        _formaEntradaRepository = formaEntradaRepository;
        _ofertaConcursoOpcaoAcessoRepository = ofertaConcursoOpcaoAcessoRepository;
        _empresaRepository = empresaRepository;
        _unitOfWork = unitOfWork;
        _cursoExternoRepository = cursoExternoRepository;
        _matriculaRepository = matriculaRepository;
    }

    public async Task<EntityKeyDto?> Handle(CriarInscricaoCandidatoCommand request, CancellationToken cancellationToken)
    {
        Ficha fichaInscricao = null!;
        if (request.FichaKey == null)
        {
            fichaInscricao = await _fichaRepository.GetAsync(f => f.Padrao);
        }
        else
        {
            fichaInscricao = await _fichaRepository.GetAsync(request.FichaKey.Value);
        }

        var marca = await _marcaRepository.GetAsync(request.MarcaKey);

        var inscricao = InscricaoCandidato
            .Criar(fichaInscricao.Id, marca.Id)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (inscricao == null)
        {
            return null;
        }

        if (request.InfosOferta != null)
        {
            OfertaId? ofertaId = null;
            OfertaConcursoId? ofertaConcursoId = null;

            if (request.InfosOferta.OfertaKey.HasValue)
            {
                var oferta = await _ofertaRepository.GetAsync(request.InfosOferta.OfertaKey!.Value);
                ofertaId = oferta.Id;
            }

            if (request.InfosOferta.OfertaConcursoKey.HasValue)
            {
                var ofertaConcurso = await _ofertaConcursoRepository.GetAsync(request.InfosOferta.OfertaConcursoKey!.Value);
                ofertaConcursoId = ofertaConcurso.Id;
            }

            inscricao.DefinirOferta(ofertaId, ofertaConcursoId);

            if (request.InfosOferta.FormaEntradaKey.HasValue)
            {
                var formaEntrada = await _formaEntradaRepository.GetAsync(request.InfosOferta.FormaEntradaKey!.Value);
                inscricao.DefinirFormaEntrada(TipoSelecaoFormaEntrada.Manual, formaEntrada.Id);
            }
        }

        if (request.InfosPessoais != null)
        {
            inscricao.DefinirInformacaoCandidato(
                request.InfosPessoais.Nome,
                request.InfosPessoais.DataNascimento,
                request.InfosPessoais.Sexo,
                request.InfosPessoais.NecessidadeEspecial,
                request.InfosPessoais.NomeSocial);
        }

        foreach (var cupom in request.InfosCupons.Where(c => !string.IsNullOrWhiteSpace(c.Codigo)))
        {
            var entidadeCupom = await _cupomRepository.GetAsync(c => c.Codigo == cupom.Codigo);

            inscricao.DefinirCupom(entidadeCupom.Id, true);
        }

        if (string.IsNullOrEmpty(request.InfoOrigem.Url))
        {
            request.InfoOrigem.Url = $"{request.InfoOrigem.clientHost}{fichaUrlPath}{request.MarcaKey}/";
        }

        inscricao.DefinirOrigem(request.InfoOrigem.Tipo, request.InfoOrigem.Url);

        foreach (var contato in request.InfosContato.Where(c => !string.IsNullOrWhiteSpace(c.Valor)))
        {
            inscricao.DefinirContatos(contato.Tipo ?? TipoContatoInscricao.NaoDefinido, contato.Valor!);
        }

        foreach (var endereco in request.InfosEndereco)
        {
            inscricao.DefinirEndereco(
                endereco.Tipo,
                endereco.Cep,
                endereco.Rua,
                endereco.Numero,
                endereco.Complemento,
                endereco.Bairro,
                endereco.Cidade,
                endereco.Estado);
        }

        foreach (var documento in request.InfosDocumento)
        {
            inscricao.DefinirDocumentos(documento.Tipo, documento.Valor);
        }

        foreach (var seguroFianca in request.InfosSeguroFianca)
        {
            inscricao.DefinirSeguroFianca(
                seguroFianca.NomeFiador,
                seguroFianca.TipoRelacionamentoSegurado,
                seguroFianca.PercentualFiador,
                seguroFianca.RendaMediaMensal,
                seguroFianca.TipoDocumento,
                seguroFianca.ValorDocumento,
                seguroFianca.TipoContato,
                seguroFianca.ValorContato);
        }

        foreach (var acessibilidade in request.InfosAcessibilidade.Where(x => x.AcessibilidadeKey.HasValue))
        {
            var entidadeAcessibilidade = await _acessibilidadeRepository.GetAsync(acessibilidade.AcessibilidadeKey!.Value);
            inscricao.DefinirAcessibilidade(entidadeAcessibilidade.Id);
        }

        foreach (var deficiencia in request.InfosDeficiencia.Where(x => x.DeficienciaKey.HasValue))
        {
            var entidadeDeficiencia = await _deficienciaRepository.GetAsync(deficiencia.DeficienciaKey!.Value);
            inscricao.DefinirDeficiencia(entidadeDeficiencia.Id);
        }

        foreach (var escolaridade in request.InfosEscolaridade.Where(x => x.EscolaKey.HasValue))
        {
            Escola? escola = null!;
            Estado? estado = null!;
            Cidade? cidade = null!;
            CursoExterno? cursoExterno = null!;

            if (escolaridade.EstadoKey.HasValue)
            {
                estado = await _estadoRepository.GetAsync(escolaridade.EstadoKey.Value);
            }

            if (escolaridade.CidadeKey.HasValue)
            {
                cidade = await _cidadeRepository.GetAsync(escolaridade.CidadeKey.Value);
            }

            if (escolaridade.EscolaKey.HasValue)
            {
                escola = await _escolaRepository.GetAsync(escolaridade.EscolaKey.Value);
            }

            if (escolaridade.CursoExternoKey.HasValue)
            {
                cursoExterno = await _cursoExternoRepository.GetAsync(escolaridade.CursoExternoKey.Value);
            }

            inscricao.DefinirEscolaridade(escolaridade.Nivel ?? TipoEscolaridadeInscricao.NaoDefinido, escolaridade.AnoConclusao, estado?.Id, cidade?.Id, escola?.Id, escolaridade.OutraEscola, cursoExterno?.Id, escolaridade.InstituicaoEstrangeira);
        }

        if (request.InfosOferta != null && request.InfosOferta.OfertaConcursoOpcaoAcessos != null)
        {
            foreach (var opcaoAcesso in request.InfosOferta.OfertaConcursoOpcaoAcessos)
            {
                var ofertaConcursoOpcaoAcesso = await _ofertaConcursoOpcaoAcessoRepository.GetAsync(opcaoAcesso.Key);
                inscricao.DefinirOpcaoAcesso(ofertaConcursoOpcaoAcesso.Id, opcaoAcesso.Percentual);
            }
        }

        if (request.InfosEmpresa != null)
        {
            Empresa? empresa = null;

            if (request.InfosEmpresa.EmpresaKey.HasValue)
            {
                empresa = await _empresaRepository.GetAsync(request.InfosEmpresa.EmpresaKey.Value);
            }

            inscricao.DefinirEmpresa(empresa?.Id, request.InfosEmpresa.OutraEmpresa);
        }

        if (request.InfosMatricula != null)
        {
            Matricula? matricula;

            matricula = Matricula
                .Criar(request.InfosMatricula.CodigoAluno, request.InfosMatricula.Ra, request.InfosMatricula.CodigoStatusAluno)
                .ObterRetorno();

            if (matricula != null)
            {
                await _matriculaRepository.InsertAsync(matricula);
                await _unitOfWork.CommitAsync(cancellationToken);
            }
            else
            {
                matricula = await _matriculaRepository.GetAsync(m =>
                m.CodigoAluno == request.InfosMatricula.CodigoAluno &&
                m.StatusMatricula == request.InfosMatricula.CodigoStatusAluno &&
                m.Ra == request.InfosMatricula.Ra);
            }

            inscricao.DefinirMatricula(matricula.Id);
        }

        inscricao.DefinirStatus(TipoStatusInscricao.EmAndamento);

        if (request.EtapaKey != null)
        {
            var etapa = await _etapaTemplateRepository.GetAsync(request.EtapaKey.Value);
            var etapaFicha = fichaInscricao.Etapas.First(e => e.EtapaTemplateId == etapa.Id);
            inscricao.DefinirEtapas(etapaFicha.Id);
        }

        if (request.InfosFiliacao != null)
        {
            foreach (var filiacao in request.InfosFiliacao)
            {
                inscricao.DefinirFiliacao(filiacao.Nome, filiacao.Tipo);
            }
        }

        inscricao.DefinirStatus(TipoStatusInscricao.EmAndamento);

        await _inscricaoRepository.InsertAsync(inscricao);

        inscricao.RegistrarEventoCriacaoInscricao(inscricao);

        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(inscricao.Key);
    }
}