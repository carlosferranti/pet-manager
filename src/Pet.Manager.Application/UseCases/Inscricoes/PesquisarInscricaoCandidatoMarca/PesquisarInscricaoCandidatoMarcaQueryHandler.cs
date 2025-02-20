using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.Constants;
using Anima.Inscricao.Application.DTOs._Shared;
using Anima.Inscricao.Application.DTOs.Acessibilidades;
using Anima.Inscricao.Application.DTOs.Deficiencias;
using Anima.Inscricao.Application.DTOs.Fichas;
using Anima.Inscricao.Application.DTOs.Inscricoes;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.Extensions;
using Anima.Inscricao.Application.Interfaces.Repositories;
using Anima.Inscricao.Application.UseCases.Inscricoes.PesquisarInscricaoAnteriorCandidato;
using Anima.Inscricao.Application.UseCases.Instituicoes.PesquisarLinkRedirecionamentoCandidato;
using Anima.Inscricao.Domain.Acessibilidades;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Cupons;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.CursosExternos;
using Anima.Inscricao.Domain.Deficiencias;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Inscricoes;
using Anima.Inscricao.Domain.Inscricoes.Enums;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.Matriculas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Domain.Turnos;
using Anima.Inscricao.Domain.Utils;
using Anima.Inscricoes.Domain.Inscricoes;

using MediatR;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.PesquisarInscricaoCandidatoMarca;

public class PesquisarInscricaoCandidatoMarcaQueryHandler : IQueryHandler<PesquisarInscricaoCandidatoMarcaQuery, List<InscricaoDto>>
{
    private const string StatusInscricaoConcluida = "Confirmada";
    private const string StatusInscricaoIncompleta = "Incompleta";

    private readonly IInscricaoRepository _inscricaoRepository;
    private readonly IMarcaRepository _marcaRepository;
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IProdutoRepository _produtoRepository;
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly IFichaRepository _fichaRepository;
    private readonly IConcursoRepository _concursoRepository;
    private readonly ITurnoRepository _turnoRepository;
    private readonly ICampusRepository _campusRepository;
    private readonly ICursoRepository _cursoRepository;
    private readonly IAcessibilidadeRepository _acessibilidadeRepository;
    private readonly IDeficienciaRepository _deficienciaRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;
    private readonly IIntakeRepository _intakeRepository;
    private readonly ICupomRepository _cupomRepository;
    private readonly IInscricaoDocumentacaoRepository _inscricaoDocumentacaoRepository;
    private readonly IEscolaRepository _escolaRepository;
    private readonly ICidadeRepository _cidadeRepository;
    private readonly IEstadoRepository _estadoRepository;
    private readonly IMediator _mediator;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly INivelCursoRepository _nivelCursoRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly IMatriculaRepository _matriculaRepository;
    private readonly ICursoExternoRepository _cursoExternoRepository;
    private readonly ICandidatoRepository _candidatoRepository;
    private readonly ILogger<PesquisarInscricaoCandidatoMarcaQueryHandler> _logger;

    public PesquisarInscricaoCandidatoMarcaQueryHandler(
        IInscricaoRepository inscricaoRepository,
        IMarcaRepository marcaRepository,
        IOfertaConcursoRepository ofertaConcursoRepository,
        IOfertaRepository ofertaRepository,
        IProdutoRepository produtoRepository,
        IInstituicaoRepository instituicaoRepository,
        IFichaRepository fichaRepository,
        IConcursoRepository concursoRepository,
        ITurnoRepository turnoRepository,
        ICampusRepository campusRepository,
        ICursoRepository cursoRepository,
        IAcessibilidadeRepository acessibilidadeRepository,
        IDeficienciaRepository deficienciaRepository,
        IFormaEntradaRepository formaEntradaRepository,
        IEtapaTemplateRepository etapaTemplateRepository,
        IIntakeRepository intakeRepository,
        ICupomRepository cupomRepository,
        IInscricaoDocumentacaoRepository inscricaoDocumentacaoRepository,
        IEscolaRepository escolaRepository,
        IEstadoRepository estadoRepository,
        ICidadeRepository cidadeRepository,
        IMediator mediator,
        IIntegracaoSistemaRepository integracaoSistemaRepository,
        INivelCursoRepository nivelCursoRepository,
        IModalidadeRepository modalidadeRepository,
        IMatriculaRepository matriculaRepository,
        ICursoExternoRepository cursoExternoRepository,
        ICandidatoRepository candidatoRepository,
        ILogger<PesquisarInscricaoCandidatoMarcaQueryHandler> logger)
    {
        _inscricaoRepository = inscricaoRepository;
        _marcaRepository = marcaRepository;
        _ofertaConcursoRepository = ofertaConcursoRepository;
        _ofertaRepository = ofertaRepository;
        _produtoRepository = produtoRepository;
        _instituicaoRepository = instituicaoRepository;
        _fichaRepository = fichaRepository;
        _concursoRepository = concursoRepository;
        _turnoRepository = turnoRepository;
        _campusRepository = campusRepository;
        _cursoRepository = cursoRepository;
        _acessibilidadeRepository = acessibilidadeRepository;
        _deficienciaRepository = deficienciaRepository;
        _formaEntradaRepository = formaEntradaRepository;
        _etapaTemplateRepository = etapaTemplateRepository;
        _intakeRepository = intakeRepository;
        _cupomRepository = cupomRepository;
        _inscricaoDocumentacaoRepository = inscricaoDocumentacaoRepository;
        _escolaRepository = escolaRepository;
        _estadoRepository = estadoRepository;
        _cidadeRepository = cidadeRepository;
        _mediator = mediator;
        _integracaoSistemaRepository = integracaoSistemaRepository;
        _nivelCursoRepository = nivelCursoRepository;
        _modalidadeRepository = modalidadeRepository;
        _matriculaRepository = matriculaRepository;
        _cursoExternoRepository = cursoExternoRepository;
        _candidatoRepository = candidatoRepository;
        _logger = logger;
    }

    public async Task<List<InscricaoDto>> Handle(PesquisarInscricaoCandidatoMarcaQuery request, CancellationToken cancellationToken)
    {        
        var query = from inscricao in _inscricaoRepository.GetQueryable().AsNoTracking()
                    join marca in _marcaRepository.GetQueryable().AsNoTracking()
                        on inscricao.MarcaId equals marca.Id
                    join ficha in _fichaRepository.GetQueryable().AsNoTracking()
                        on inscricao.FichaId equals ficha.Id
                    join oferta in _ofertaRepository.GetQueryable().AsNoTracking()
                       on inscricao.Oferta.OfertaId equals oferta.Id
                    join intake in _intakeRepository.GetQueryable().AsNoTracking()
                        on oferta.IntakeId equals intake.Id
                    join ofertaConcurso in _ofertaConcursoRepository.GetQueryable().AsNoTracking().DefaultIfEmpty()
                        on inscricao.Oferta.OfertaConcursoId equals ofertaConcurso.Id into ofertaConcursoGroup
                    from ofertaConcurso in ofertaConcursoGroup.DefaultIfEmpty()
                    join produto in _produtoRepository.GetQueryable().AsNoTracking().DefaultIfEmpty()
                        on oferta.ProdutoId equals produto.Id into produtoGroup
                    from produto in produtoGroup.DefaultIfEmpty()
                    join instituicao in _instituicaoRepository.GetQueryable().AsNoTracking().DefaultIfEmpty()
                        on produto.InstituicaoId equals instituicao.Id into instituicaoGroup
                    from instituicao in instituicaoGroup.DefaultIfEmpty()
                    join campus in _campusRepository.GetQueryable().AsNoTracking().DefaultIfEmpty()
                        on produto.CampusId equals campus.Id into campusGroup
                    from campus in campusGroup.DefaultIfEmpty()
                    join turno in _turnoRepository.GetQueryable().AsNoTracking().DefaultIfEmpty()
                        on produto.TurnoId equals turno.Id into turnoGroup
                    from turno in turnoGroup.DefaultIfEmpty()
                    join curso in _cursoRepository.GetQueryable().AsNoTracking().DefaultIfEmpty()
                        on produto.CursoId equals curso.Id into cursoGroup
                    from curso in cursoGroup.DefaultIfEmpty()
                    join nivel in _nivelCursoRepository.GetQueryable().AsNoTracking()
                        on curso.NivelCursoId equals nivel.Id into nivelGroup
                    from nivel in nivelGroup.DefaultIfEmpty()
                    join concurso in _concursoRepository.GetQueryable().AsNoTracking().DefaultIfEmpty()
                        on ofertaConcurso.ConcursoId equals concurso.Id into concursoGroup
                    from concurso in concursoGroup.DefaultIfEmpty()
                    from integracaoConcurso in _integracaoSistemaRepository.GetQueryable().AsNoTracking()
                    .Where(i => i.Id == concurso.IntegracaoConcurso!.IntegracaoSistemaId).DefaultIfEmpty()
                    select new InscricaoDto()
                    {
                        Numero = inscricao.Id,
                        Key = inscricao.Key,
                        CriadoEm = inscricao.Auditoria.CriadoEm,
                        AlteradoEm = inscricao.Auditoria.AlteradoEm,
                        Candidato = new InscricaoInfosPessoaisDto()
                        {
                            DataNascimento = inscricao.Candidato.DataNascimento != null ? DateOnly.FromDateTime(inscricao.Candidato.DataNascimento!.Value) : null,
                            Nome = inscricao.Candidato.Nome,
                            Sexo = inscricao.Candidato.Sexo,
                            NecessidadeEspecial = inscricao.Candidato.NecessidadeEspecial,
                            NomeSocial = inscricao.Candidato.NomeSocial,
                        },
                        Marca = new()
                        {
                            Key = marca.Key,
                            Nome = marca.Nome,
                        },
                        Ficha = new()
                        {
                            Key = ficha.Key,
                            Nome = ficha.Nome,
                        },
                        Oferta = new()
                        {
                            Intake = new()
                            {
                                Key = intake.Key,
                                Nome = intake.Nome,
                            },
                            Instituicao = new()
                            {
                                Key = instituicao.Key,
                                Nome = instituicao.Nome,
                            },
                            Campus = new()
                            {
                                Key = campus.Key,
                                Nome = campus.Nome,
                            },
                            Turno = new()
                            {
                                Key = turno.Key,
                                Nome = turno.Nome,
                            },
                            Curso = new()
                            {
                                Key = curso.Key,
                                Nome = curso.NomeComercial ?? curso.Nome,
                                Nivel = new()
                                {
                                    Key = nivel.Key,
                                    Nome = nivel.Nome,
                                },
                            },
                            Concurso = new()
                            {
                                Key = concurso.Key,
                                Nome = concurso.Nome,
                                Prova = new InscricaoOfertaConcursoDto.InscricaoConcursoDataProvaDto()
                                {
                                    DataInicioProva = concurso.InicioProva,
                                    HoraInicioProva = concurso.InicioProva.HasValue ? concurso.InicioProva.Value.ToString("HH:mm") : null,
                                    DataTerminoProva = concurso.TerminoProva,
                                    HoraTerminoProva = concurso.TerminoProva.HasValue ? concurso.TerminoProva.Value.ToString("HH:mm") : null,
                                },
                                Integracao = concurso.IntegracaoConcurso != null ? new SistemaIntegracaoDto()
                                {
                                    CodigoOrigem = concurso.IntegracaoConcurso!.CodigoOrigem,
                                    NomeSistema = integracaoConcurso.Nome,
                                } : null,
                                Modalidade = (from modalidadeConcurso in concurso.Modalidades.DefaultIfEmpty()
                                              join modalidade in _modalidadeRepository.GetQueryable().DefaultIfEmpty()
                                              on modalidadeConcurso.ModalidadeId equals modalidade.Id
                                              select new ItemDto()
                                              {
                                                  Key = modalidade.Key,
                                                  Nome = modalidade.Nome,
                                              }).FirstOrDefault(),
                            },
                            FormasEntrada = (from inscricaoFormaEntrada in inscricao.FormasEntrada.DefaultIfEmpty()
                                             join formaEntrada in _formaEntradaRepository.GetQueryable()
                                                on inscricaoFormaEntrada.FormaEntradaId equals formaEntrada.Id
                                             where inscricaoFormaEntrada.Atual
                                             select new InscricaoFormaEntradaDto()
                                             {
                                                 FormaEntradaKey = formaEntrada.Key,
                                                 FormaEntradaNome = formaEntrada.Nome,
                                                 TipoSelecao = inscricaoFormaEntrada.CodigoTipoSelecao,
                                                 CodigoTipoSelecao = inscricaoFormaEntrada.CodigoTipoSelecao.ToString(),
                                             }).ToList(),
                            PeriodoLetivo = concurso.PeriodoLetivo,
                            OfertaConcursoKey = ofertaConcurso.Key,
                            OfertaKey = oferta.Key,
                        },
                        Acessibilidades = (from inscricaoAcessibilidade in inscricao.Acessibilidades
                                           join acessibilidade in _acessibilidadeRepository.GetQueryable()
                                            on inscricaoAcessibilidade.AcessibilidadeId equals acessibilidade.Id
                                           select new AcessibilidadeDto()
                                           {
                                               Key = acessibilidade.Key,
                                               Nome = acessibilidade.Nome,
                                           }).ToList(),
                        Deficiencias = (from inscricaoDeficiencia in inscricao.Deficiencias
                                        join deficiencia in _deficienciaRepository.GetQueryable()
                                             on inscricaoDeficiencia.DeficienciaId equals deficiencia.Id
                                        select new DeficienciaDto()
                                        {
                                            Key = deficiencia.Key,
                                            Nome = deficiencia.Nome,
                                        }).ToList(),
                        Contatos = (from inscricaoContato in inscricao.Contatos
                                    select new InscricaoContatoDto()
                                    {
                                        CodigoTipo = (int)inscricaoContato.Tipo,
                                        Tipo = inscricaoContato.Tipo.ToString(),
                                        Valor = inscricaoContato.Valor,
                                    }).ToList(),
                        Documentos = (from inscricaoDocumento in inscricao.Documentos
                                      select new InscricaoDocumentoDto()
                                      {
                                          CodigoTipo = (int)inscricaoDocumento.Tipo,
                                          Tipo = inscricaoDocumento.Tipo.ToString(),
                                          Valor = inscricaoDocumento.ValorFormatado,
                                      }).ToList(),
                        Etapa = (from etapaFicha in ficha.Etapas
                                 join etapa in _etapaTemplateRepository.GetQueryable()
                                    on etapaFicha.EtapaTemplateId equals etapa.Id
                                 where inscricao.Etapas.Any(x => x.Atual && x.EtapaFichaId == etapa.Id)
                                 select new EtapaFichaDto()
                                 {
                                     Key = etapa.Key,
                                     Nome = etapa.Nome,
                                     Sequencia = etapaFicha.Sequencia,
                                 }).FirstOrDefault(),
                        Cupons = (from inscricaoCupom in inscricao.Cupons
                                  join cupom in _cupomRepository.GetQueryable()
                                    on inscricaoCupom.CupomId equals cupom.Id
                                  select new InscricaoCupomDto()
                                  {
                                      Key = inscricaoCupom.Key,
                                      Codigo = cupom.Codigo,
                                  }).ToList(),
                        Documentacoes = (from inscricaoDocumentacao in _inscricaoDocumentacaoRepository.GetQueryable()
                                         where inscricaoDocumentacao.InscricaoCandidatoId == inscricao.Id &&
                                         inscricaoDocumentacao.Status.Ativo
                                         select new InscricaoDocumentacaoDto()
                                         {
                                             Key = inscricaoDocumentacao.Key,
                                             NomeArquivo = inscricaoDocumentacao.Arquivo.Informacoes.Nome,
                                             Observacoes = inscricaoDocumentacao.Observacoes,
                                             ExtensaoArquivo = inscricaoDocumentacao.Arquivo.Informacoes.Extensao,
                                             TamanhoArquivo = inscricaoDocumentacao.Arquivo.Informacoes.Tamanho,
                                             ChaveArquivo = inscricaoDocumentacao.Arquivo.Chave,
                                             Tipo = inscricaoDocumentacao.Tipo.ToString(),
                                             CodigoTipo = (int)inscricaoDocumentacao.Tipo,
                                         }).ToList(),
                        Escolaridades = (from inscricaoEscolaridade in inscricao.Escolaridades
                                         join escola in _escolaRepository.GetQueryable().DefaultIfEmpty()
                                            on inscricaoEscolaridade.EscolaId equals escola.Id into escolaGroup
                                         from escola in escolaGroup.DefaultIfEmpty()
                                         join cidade in _cidadeRepository.GetQueryable().DefaultIfEmpty()
                                            on escola.CidadeId equals cidade.Id into cidadeGroup
                                         from cidade in cidadeGroup.DefaultIfEmpty()
                                         join estado in _estadoRepository.GetQueryable().DefaultIfEmpty()
                                             on cidade.EstadoId equals estado.Id into estadoGroup
                                         from estado in estadoGroup.DefaultIfEmpty()
                                         join cursoExterno in _cursoExternoRepository.GetQueryable().DefaultIfEmpty()
                                                on inscricaoEscolaridade.CursoExternoId equals cursoExterno.Id into cursoExternoGroup
                                         from cursoExterno in cursoExternoGroup.DefaultIfEmpty()
                                         select new InscricaoEscolaridadeDto()
                                         {
                                             AnoConclusao = inscricaoEscolaridade.AnoConclusao,
                                             Nivel = inscricaoEscolaridade.Nivel,
                                             CodigoNivel = (int)inscricaoEscolaridade.Nivel,
                                             InstituicaoEstrangeira = inscricaoEscolaridade.InstituicaoEstrangeira,
                                             Escola = new()
                                             {
                                                 Key = inscricaoEscolaridade.EscolaId != null ? escola.Key : null,
                                                 Nome = escola.Nome ?? inscricaoEscolaridade.OutraEscola,
                                             },
                                             Estado = inscricaoEscolaridade.EstadoId != null ? new()
                                             {
                                                 Key = estado.Key,
                                                 Nome = estado.Nome,
                                             } : null,
                                             Cidade = inscricaoEscolaridade.CidadeId != null ? new()
                                             {
                                                 Key = cidade.Key,
                                                 Nome = cidade.Nome,
                                             } : null,
                                             Curso = inscricaoEscolaridade.CursoExternoId != null ? new()
                                             {
                                                 Key = cursoExterno.Key,
                                                 Nome = cursoExterno.Nome,
                                             } : null,
                                         }).ToList(),
                        OpcoesAcesso = (from opcaoAcessoInscricao in inscricao.OpcoesAcesso
                                        join opcaoAcessoConcurso in ofertaConcurso.OpcaoAcessos
                                         on opcaoAcessoInscricao.OfertaConcursoOpcaoAcessoId equals opcaoAcessoConcurso.Id
                                        select new InscricaoOpcaoAcessoDto()
                                        {
                                            Key = opcaoAcessoInscricao.Key,
                                            Percentual = opcaoAcessoInscricao.Percentual,
                                            Nome = opcaoAcessoConcurso.TipoOpcaoAcesso.Description(),
                                            Tipo = (int)opcaoAcessoConcurso.TipoOpcaoAcesso,
                                        }).ToList(),
                        Enderecos = (from enderecoInscricao in inscricao.Enderecos
                                     join estado in _estadoRepository.GetQueryable().DefaultIfEmpty()
                                         on enderecoInscricao.Estado equals estado.Nome into estadoGroup
                                     from estado in estadoGroup.DefaultIfEmpty()
                                     join cidade in _cidadeRepository.GetQueryable().DefaultIfEmpty()
                                            on new
                                            {
                                                Cidade = enderecoInscricao.Cidade,
                                                Estado = estado.Id,
                                            }
                                            equals
                                            new
                                            {
                                                Cidade = cidade.Nome,
                                                Estado = cidade.EstadoId,
                                            } into cidadeGroup
                                     from cidade in cidadeGroup.DefaultIfEmpty()
                                     select new InscricaoEnderecoDto()
                                     {
                                         Tipo = enderecoInscricao.Tipo.ToString(),
                                         Rua = enderecoInscricao.Rua,
                                         Numero = enderecoInscricao.Numero,
                                         Complemento = enderecoInscricao.Complemento,
                                         Bairro = enderecoInscricao.Bairro,
                                         Cep = enderecoInscricao.Cep,
                                         Cidade = new()
                                         {
                                             Key = cidade != null ? cidade.Key : null,
                                             Nome = cidade != null ? cidade.Nome : enderecoInscricao.Cidade,
                                         },
                                         Estado = new()
                                         {
                                             Key = estado != null ? estado.Key : null,
                                             Nome = estado != null ? estado.Nome : enderecoInscricao.Estado,
                                         },
                                     }).ToList(),
                        Status = (from inscricaoStatus in inscricao.Status.DefaultIfEmpty()
                                  where inscricaoStatus.Tipo == TipoStatusInscricao.TotalmenteConcluida
                                  select StatusInscricaoConcluida).FirstOrDefault() ?? StatusInscricaoIncompleta,
                        Matriculas = (from matriculaInscricao in inscricao.Matriculas.DefaultIfEmpty()
                                      from matricula in _matriculaRepository.GetQueryable().DefaultIfEmpty()
                                      where matriculaInscricao.MatriculaId == matricula.Id
                                      select new InscricaoMatriculaDto()
                                      {
                                          Key = matricula.Key,
                                          CodigoAluno = matricula.CodigoAluno,
                                          Ra = matricula.Ra,
                                          StatusMatricula = matricula.StatusMatricula,
                                      }).ToList(),
                        Integracoes = (from integracaoInscricao in inscricao.IntegracoesInscricao
                                       join sistema in _integracaoSistemaRepository.GetQueryable().AsNoTracking()
                                       on integracaoInscricao.IntegracaoSistemaId equals sistema.Id
                                       select new SistemaIntegracaoDto()
                                       {
                                           CodigoOrigem = integracaoInscricao.CodigoOrigem,
                                           NomeSistema = sistema.Nome,
                                       })
                    };

        if (request.MarcaKey != Guid.Empty)
        {
            query = query.Where(x => x.Marca!.Key == request.MarcaKey);
        }

        if (!string.IsNullOrEmpty(request.Cpf))
        {
            int codigoTipoDocumentoCpf = (int)TipoDocumentoInscricao.Cpf;
            string cpfFormatado = CpfFormater.FormatarCPF(request.Cpf);
            query = query.Where(x => x.Documentos!.Any(d => d.CodigoTipo == codigoTipoDocumentoCpf && d.Valor == cpfFormatado));
        }

        var inscricoes = await query
            .OrderByDescending(x => x.CriadoEm)
            .ToListAsync(cancellationToken);

        foreach (var inscricao in inscricoes)
        {
            try
            {
                var codigoIntegracaoConcurso =  inscricao.Oferta?.Concurso?.Integracao?.CodigoOrigem;
                var codigoInscricao = inscricao.Integracoes?.FirstOrDefault(x => x.NomeSistema == IntegracaoSistemaConstants.Vestib)?.CodigoOrigem;

                if (!string.IsNullOrWhiteSpace(codigoInscricao) && !string.IsNullOrWhiteSpace(codigoIntegracaoConcurso))
                {
                    inscricao.InscricaoCancelada = await _candidatoRepository.VerificarInscricaoCancelada(codigoIntegracaoConcurso, codigoInscricao);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao verificar se a inscrição foi cancelada");
            } 

            if(inscricao.Status == StatusInscricaoConcluida)
            {
                inscricao.LinkRedireconamentoInstituicao = await _mediator.Send(new PesquisarLinkRedireconamentoInstituicaoQuery()
                {
                    key = inscricao.Key,
                }, cancellationToken);
            }
        }

        return inscricoes.Where(i => !i.InscricaoCancelada).ToList();
    }
}
