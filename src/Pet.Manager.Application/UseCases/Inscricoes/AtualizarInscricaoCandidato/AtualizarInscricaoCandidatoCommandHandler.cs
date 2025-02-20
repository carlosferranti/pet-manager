using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain.Acessibilidades;
using Anima.Inscricao.Domain.Campos.Entities;
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
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.FormasEntrada.Entities;
using Anima.Inscricao.Domain.Inscricoes.Entities;
using Anima.Inscricao.Domain.Inscricoes.Enums;
using Anima.Inscricao.Domain.Matriculas;
using Anima.Inscricao.Domain.Matriculas.Entities;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.OfertaConcursos.Entities;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Ofertas.Entities;
using Anima.Inscricoes.Domain.Inscricoes;

using MediatR;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.AtualizarInscricaoCandidato;

public class AtualizarInscricaoCandidatoCommandHandler : ICommandHandler<AtualizarInscricaoCandidatoCommand>
{
    private readonly IInscricaoRepository _inscricaoRepository;
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IFichaRepository _fichaRepository;
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;
    private readonly ICupomRepository _cupomRepository;
    private readonly IAcessibilidadeRepository _acessibilidadeRepository;
    private readonly IDeficienciaRepository _deficienciaRepository;
    private readonly IEstadoRepository _estadoRepository;
    private readonly ICidadeRepository _cidadeRepository;
    private readonly IEscolaRepository _escolaRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly IOfertaConcursoOpcaoAcessoRepository _ofertaConcursoOpcaoAcessoRepository;
    private readonly IEmpresaRepository _empresaRepository;
    private readonly ICursoExternoRepository _cursoExternoRepository;
    private readonly IMatriculaRepository _matriculaRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarInscricaoCandidatoCommandHandler(
        IInscricaoRepository inscricaoRepository,
        IOfertaConcursoRepository ofertaConcursoRepository,
        IOfertaRepository ofertaRepository,
        IFichaRepository fichaRepository,
        IEtapaTemplateRepository etapaTemplateRepository,
        ICupomRepository cupomRepository,
        IAcessibilidadeRepository acessibilidadeRepository,
        IDeficienciaRepository deficienciaRepository,
        IEstadoRepository estadoRepository,
        ICidadeRepository cidadeRepository,
        IEscolaRepository escolaRepository,
        IFormaEntradaRepository formaEntradaRepository,
        IOfertaConcursoOpcaoAcessoRepository ofertaConcursoOpcaoAcessoRepository,
        IEmpresaRepository empresaRepository,
        ICursoExternoRepository cursoExternoRepository,
        IMatriculaRepository matriculaRepository,
        IUnitOfWork unitOfWork)
    {
        _inscricaoRepository = inscricaoRepository;
        _ofertaConcursoRepository = ofertaConcursoRepository;
        _ofertaRepository = ofertaRepository;
        _fichaRepository = fichaRepository;
        _etapaTemplateRepository = etapaTemplateRepository;
        _cupomRepository = cupomRepository;
        _acessibilidadeRepository = acessibilidadeRepository;
        _deficienciaRepository = deficienciaRepository;
        _estadoRepository = estadoRepository;
        _cidadeRepository = cidadeRepository;
        _escolaRepository = escolaRepository;
        _formaEntradaRepository = formaEntradaRepository;
        _ofertaConcursoOpcaoAcessoRepository = ofertaConcursoOpcaoAcessoRepository;
        _empresaRepository = empresaRepository;
        _cursoExternoRepository = cursoExternoRepository;
        _matriculaRepository = matriculaRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarInscricaoCandidatoCommand request, CancellationToken cancellationToken)
    {
        var inscricao = InscricaoCandidato
            .Atualizar(request.InscricaoKey);

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

            await _inscricaoRepository.AtualizarOferta(inscricao.Key, inscricao.Oferta, cancellationToken);

            if (request.InfosOferta.FormaEntradaKey.HasValue)
            {
                var formaEntrada = await _formaEntradaRepository.GetAsync(request.InfosOferta.FormaEntradaKey!.Value);

                var inscricaoFormaEntrada = inscricao.DefinirFormaEntrada(TipoSelecaoFormaEntrada.Manual, formaEntrada.Id);

                await _inscricaoRepository.DesatualizarInscricaoFormaEntradaCandidatoAsync(inscricao.Key, TipoSelecaoFormaEntrada.Manual, cancellationToken);
                await _inscricaoRepository.InserirInscricaoFormaEntradaCandidatoAsync(inscricao.Key, inscricaoFormaEntrada, cancellationToken);
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

            await _inscricaoRepository.AtualizarInformacaoCandidato(inscricao.Key, inscricao.Candidato, cancellationToken);
        }

        if (request.InfosContato != null)
        {
            await _inscricaoRepository.ExcluirContatos(inscricao.Key, cancellationToken);

            if (request.InfosContato.Any())
            {
                foreach (var contato in request.InfosContato.Where(c => !string.IsNullOrWhiteSpace(c.Valor)))
                {
                    var contatoInscricao = inscricao.DefinirContatos(contato.Tipo ?? TipoContatoInscricao.NaoDefinido, contato.Valor!);

                    await _inscricaoRepository.InserirContatos(inscricao.Key, contatoInscricao, cancellationToken);
                }
            }
        }

        if (request.InfosCupons != null)
        {
            await _inscricaoRepository.ExcluirCupons(inscricao.Key, cancellationToken);

            if (request.InfosCupons.Any())
            {
                var concursoInscricaoId = await _inscricaoRepository.ObterConcursoInscricaoCandidatoIdAsync(inscricao.Key);

                foreach (var cupom in request.InfosCupons.Where(c => !string.IsNullOrWhiteSpace(c.Codigo)))
                {
                    var cuponsAtivos = await _cupomRepository.GetListAsync(c =>
                    c.Codigo == cupom.Codigo &&
                    c.ConcursoId == concursoInscricaoId &&
                    (c.DataValidade >= DateTime.UtcNow || c.DataValidade == null));

                    foreach (var cupomAtivo in cuponsAtivos)
                    {
                        var cupomInscricao = inscricao.DefinirCupom(cupomAtivo.Id, true);
                        await _inscricaoRepository.InserirCupons(inscricao.Key, cupomInscricao, cancellationToken);
                    }
                }
            }
        }

        if (request.InfosEndereco != null)
        {
            await _inscricaoRepository.ExcluirEndereco(inscricao.Key, cancellationToken);

            if (request.InfosEndereco.Any())
            {
                foreach (var endereco in request.InfosEndereco!)
                {
                    var enderecoInscricao = inscricao.DefinirEndereco(
                        endereco.Tipo,
                        endereco.Cep,
                        endereco.Rua,
                        endereco.Numero,
                        endereco.Complemento,
                        endereco.Bairro,
                        endereco.Cidade,
                        endereco.Estado);

                    await _inscricaoRepository.InserirEndereco(inscricao.Key, enderecoInscricao, cancellationToken);
                }
            }
        }

        if (request.InfosDocumento != null)
        {
            await _inscricaoRepository.ExcluirDocumentos(inscricao.Key, cancellationToken);

            if (request.InfosDocumento.Any())
            {
                foreach (var documento in request.InfosDocumento)
                {
                    var documentoInscricao = inscricao.DefinirDocumentos(documento.Tipo, documento.Valor);

                    await _inscricaoRepository.InserirDocumento(inscricao.Key, documentoInscricao, cancellationToken);
                }
            }
        }

        if (request.InfosSeguroFianca != null)
        {
            await _inscricaoRepository.ExcluirSeguroFianca(inscricao.Key, cancellationToken);

            if (request.InfosSeguroFianca.Any())
            {
                foreach (var seguroFianca in request.InfosSeguroFianca)
                {
                    var seguroFiancaInscricao = inscricao.DefinirSeguroFianca(
                        seguroFianca.NomeFiador,
                        seguroFianca.TipoRelacionamentoSegurado,
                        seguroFianca.PercentualFiador,
                        seguroFianca.RendaMediaMensal,
                        seguroFianca.TipoDocumento,
                        seguroFianca.ValorDocumento,
                        seguroFianca.TipoContato,
                        seguroFianca.ValorContato);

                    await _inscricaoRepository.InserirSeguroFianca(inscricao.Key, seguroFiancaInscricao, cancellationToken);
                }
            }
        }

        if (request.InfosFicha != null)
        {
            var ficha = await _fichaRepository.GetAsync(request.InfosFicha.FichaKey);
            var etapa = await _etapaTemplateRepository.GetAsync(request.InfosFicha.EtapaKey);

            var etapaFicha = ficha.Etapas.First(e => e.EtapaTemplateId == etapa.Id);
            var etapaFichaKey = inscricao.DefinirEtapas(etapaFicha.Id);

            await _inscricaoRepository.InserirEtapas(inscricao.Key, etapaFichaKey, cancellationToken);
        }

        if (request.InfosAcessibilidade != null)
        {
            await _inscricaoRepository.ExcluirAcessibilidade(inscricao.Key, cancellationToken);

            if (request.InfosAcessibilidade.Any())
            {
                foreach (var acessibilidade in request.InfosAcessibilidade.Where(a => a.AcessibilidadeKey.HasValue))
                {
                    var entidadeAcessibilidade = await _acessibilidadeRepository.GetAsync(acessibilidade.AcessibilidadeKey!.Value);

                    var acessibilidadeInscricao = inscricao.DefinirAcessibilidade(entidadeAcessibilidade.Id);

                    await _inscricaoRepository.InserirAcessibilidade(inscricao.Key, acessibilidadeInscricao, cancellationToken);
                }
            }
        }

        if (request.InfosDeficiencia != null)
        {
            await _inscricaoRepository.ExcluirDeficiencia(inscricao.Key, cancellationToken);

            if (request.InfosDeficiencia.Any())
            {
                foreach (var deficiencia in request.InfosDeficiencia.Where(a => a.DeficienciaKey.HasValue))
                {
                    var entidadeDeficiencia = await _deficienciaRepository.GetAsync(deficiencia.DeficienciaKey!.Value);

                    var deficienciaInscricao = inscricao.DefinirDeficiencia(entidadeDeficiencia.Id);

                    await _inscricaoRepository.InserirDeficiencia(inscricao.Key, deficienciaInscricao, cancellationToken);
                }
            }
        }

        if (request.InfosEscolaridade != null)
        {
            await _inscricaoRepository.ExcluirEscolaridade(inscricao.Key, cancellationToken);

            if (request.InfosEscolaridade.Any())
            {
                foreach (var escolaridade in request.InfosEscolaridade)
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

                    var escolaridadeInscricao = inscricao.DefinirEscolaridade(escolaridade.Nivel ?? TipoEscolaridadeInscricao.NaoDefinido, escolaridade.AnoConclusao, estado?.Id, cidade?.Id, escola?.Id, escolaridade.OutraEscola, cursoExterno?.Id, escolaridade.InstituicaoEstrangeira);

                    await _inscricaoRepository.InserirEscolaridade(inscricao.Key, escolaridadeInscricao, cancellationToken);
                }
            }            
        }

        if (request.InfosOferta != null && request.InfosOferta.OfertaConcursoOpcaoAcessos != null)
        {
            await _inscricaoRepository.ExcluirOfertaConcursoOpcaoEntrada(inscricao.Key, cancellationToken);

            if (request.InfosOferta.OfertaConcursoOpcaoAcessos.Any())
            {
                foreach (var opcaoAcesso in request.InfosOferta.OfertaConcursoOpcaoAcessos)
                {
                    var ofertaConcursoOpcaoAcesso = await _ofertaConcursoOpcaoAcessoRepository.GetAsync(opcaoAcesso.Key);
                    var ofertaConcursoOpcaoAcessoIncricao = inscricao.DefinirOpcaoAcesso(ofertaConcursoOpcaoAcesso.Id, opcaoAcesso.Percentual);
                    await _inscricaoRepository.InserirOfertaConcursoOpcaoEntrada(inscricao.Key, ofertaConcursoOpcaoAcessoIncricao, cancellationToken);
                }
            }
        }

        if (request.InfosEmpresa != null)
        {
            Empresa? empresa = null;

            if (request.InfosEmpresa.EmpresaKey.HasValue)
            {
                empresa = await _empresaRepository.GetAsync(request.InfosEmpresa.EmpresaKey.Value);
            }

            var empresaInscricao = inscricao.DefinirEmpresa(empresa?.Id, request.InfosEmpresa.OutraEmpresa);

            await _inscricaoRepository.ExcluirEmpresa(inscricao.Key, cancellationToken);
            await _inscricaoRepository.InserirEmpresa(inscricao.Key, empresaInscricao, cancellationToken);
        }

        if (request.InfosMatricula != null)
        {
            await _inscricaoRepository.ExcluirMatricula(inscricao.Key, cancellationToken);

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

            var inscricaoMatricula = inscricao.DefinirMatricula(matricula.Id);

            await _inscricaoRepository.InserirMatricula(inscricao.Key, inscricaoMatricula, cancellationToken);
        }

        if (request.InfosFiliacao != null)
        {
            await _inscricaoRepository.ExcluirFiliacao(inscricao.Key, cancellationToken);

            foreach (var filiacao in request.InfosFiliacao)
            {
                var inscricaoFiliacao = inscricao.DefinirFiliacao(filiacao.Nome, filiacao.Tipo);
                await _inscricaoRepository.InserirFiliacao(inscricao.Key, inscricaoFiliacao, cancellationToken);
            }
        }

        inscricao.RegistrarEventoInscricaoAlterada(request);

        await _unitOfWork.PublishDomainEventsAsync(inscricao, cancellationToken);
    }
}