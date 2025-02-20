using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application.Constants;
using Anima.Inscricao.Application.DTOs.Inscricoes;
using Anima.Inscricao.Application.DTOs.Instituicao;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.UseCases.Inscricoes.CalcularMotorCoi;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Campos;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.CursosExternos;
using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Domain.Escolas.Entities;
using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.FormasEntrada.Entities;
using Anima.Inscricao.Domain.FormasEntrada.Enums;
using Anima.Inscricao.Domain.Inscricoes.Entities;
using Anima.Inscricao.Domain.Inscricoes.Enums;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Instituicoes.Entities;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Matriculas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Domain.Turnos;
using Anima.Inscricoes.Domain.Inscricoes;

using MediatR;

using Microsoft.EntityFrameworkCore;

using static Anima.Inscricao.Application.UseCases.Inscricoes.CalcularMotorCoi.CalcularMotorCoiCommand;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.ConcluirInscricaoCandidato;

public class ConcluirInscricaoCandidatoCommandHandler : ICommandHandler<ConcluirInscricaoCandidatoCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly IInscricaoRepository _inscricaoRepository;
    private readonly IFichaRepository _fichaRepository;
    private readonly ICampoRepository _campoRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMediator _mediator;
    private readonly IMatriculaRepository _matriculaRepository;
    private readonly IConcursoRepository _concursoRepository;
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly IIntakeRepository _intakeRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly IEscolaRepository _escolaRepository;
    private readonly ICursoExternoRepository _cursoExternoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly ICursoRepository _cursoRepository;
    private readonly ITurnoRepository _turnoRepository;
    private readonly ICampusRepository _campusRepository;
    private readonly IProdutoRepository _produtoRepository;
    private readonly IInstituicaoRepository _instituicaoRepository;

    public ConcluirInscricaoCandidatoCommandHandler(
        INotificationContext notificationContext,
        IInscricaoRepository inscricaoRepository,
        IFichaRepository fichaRepository,
        ICampoRepository campoRepository,
        IUnitOfWork unitOfWork,
        IMediator mediator,
        IMatriculaRepository matriculaRepository,
        IConcursoRepository concursoRepository,
        IOfertaConcursoRepository ofertaConcursoRepository,
        IOfertaRepository ofertaRepository,
        IModalidadeRepository modalidadeRepository,
        IIntakeRepository intakeRepository,
        IFormaEntradaRepository formaEntradaRepository,
        IEscolaRepository escolaRepository,
        ICursoExternoRepository cursoExternoRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository,
        ICursoRepository cursoRepository,
        ITurnoRepository turnoRepository,
        ICampusRepository campusRepository,
        IProdutoRepository produtoRepository,
        IInstituicaoRepository instituicaoRepository)
    {
        _notificationContext = notificationContext;
        _inscricaoRepository = inscricaoRepository;
        _fichaRepository = fichaRepository;
        _campoRepository = campoRepository;
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        _matriculaRepository = matriculaRepository;
        _concursoRepository = concursoRepository;
        _ofertaConcursoRepository = ofertaConcursoRepository;
        _ofertaRepository = ofertaRepository;
        _modalidadeRepository = modalidadeRepository;
        _intakeRepository = intakeRepository;
        _formaEntradaRepository = formaEntradaRepository;
        _escolaRepository = escolaRepository;
        _cursoExternoRepository = cursoExternoRepository;
        _integracaoSistemaRepository = integracaoSistemaRepository;
        _cursoRepository = cursoRepository;
        _turnoRepository = turnoRepository;
        _campusRepository = campusRepository;
        _produtoRepository = produtoRepository;
        _instituicaoRepository = instituicaoRepository;
    }

    public async Task Handle(ConcluirInscricaoCandidatoCommand request, CancellationToken cancellationToken)
    {
        var inscricao = await _inscricaoRepository.GetAsyncWithDetails(request.Key, x => x.Documentacao.Where(d => d.Status.Ativo));
        var ficha = await _fichaRepository.GetAsync(inscricao.FichaId);
        var campos = await _campoRepository.GetListAsync();

        var inscricaoConcluida = inscricao
            .ConcluirInscricao(ficha.Campos.ToList(), campos.ToList())
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (!inscricaoConcluida)
        {
            return;
        }

        var inscricaoFormaEntradaManual = inscricao.FormasEntrada?.FirstOrDefault(x => x.CodigoTipoSelecao == TipoSelecaoFormaEntrada.Manual && x.Atual);
        if (inscricaoFormaEntradaManual != null)
        {
            var formaEntradaInscricao = await _formaEntradaRepository.GetAsync(inscricaoFormaEntradaManual.FormaEntradaId);

            if (formaEntradaInscricao.Key == FormaEntradaConstants.DestrancamentoRetorno ||
                formaEntradaInscricao.Key == FormaEntradaConstants.Transferencia ||
                formaEntradaInscricao.Key == FormaEntradaConstants.SegundaGraduacao ||
                formaEntradaInscricao.Key == FormaEntradaConstants.Reopcao)
            {
                var formaEntradaCoi = await ObterFormaEntradaCoi(inscricao, formaEntradaInscricao);

                if (formaEntradaCoi.HasValue)
                {
                    var formaEntradacalculada = await _formaEntradaRepository.GetAsync(formaEntradaCoi.Value);
                    inscricao.DefinirFormaEntrada(TipoSelecaoFormaEntrada.Calculado, formaEntradacalculada.Id);
                }
            }
        }

        _inscricaoRepository.Update(inscricao);

        await _unitOfWork.CommitAsync(cancellationToken);
    }

    private async Task<Guid?> ObterFormaEntradaCoi(InscricaoCandidato inscricaoCandidato, FormaEntrada formaEntradaManual)
    {
        var matricula = await ObterMatriculasInscricao(inscricaoCandidato).FirstOrDefaultAsync();
        var escolaridade = ObterEscolaridadeSuperiorInscricao(inscricaoCandidato.Key);
        var oferta = await ObterOfertaInscricao(inscricaoCandidato).FirstAsync();
        InstituicaoDto? instituicaoAnimaDaEscola = null;
        if (escolaridade?.Escola?.InstituicaoKey != null)
        {
            instituicaoAnimaDaEscola = await ObterInstituicaoAnimaDaEscola(escolaridade.Escola.InstituicaoKey.Value).FirstOrDefaultAsync();
        }

        return await _mediator.Send(new CalcularMotorCoiCommand()
        {
            CpfCandidato = inscricaoCandidato.Documentos!.ToList().Find(x => x.Tipo == TipoDocumentoInscricao.Cpf)!.Valor,
            RaVinculo = matricula?.Ra,
            Modalidade = oferta!.Concurso!.Modalidade!.Nome!,
            AnoCaptacao = int.TryParse(oferta.PeriodoLetivo!.Split('/')[0], out var ano) ? ano : 0,
            SemestreCaptacao = int.TryParse(oferta.PeriodoLetivo!.Split('/')[1], out var semestre) ? semestre : 0,
            FormaIngressoEscolhida = formaEntradaManual.Key,
            CursoOrigem = new InstituicaoOrigemCommand()
            {
                CodigoInstituicao = instituicaoAnimaDaEscola?.Integracoes?.FirstOrDefault()?.CodigoOrigem,
                NomeCurso = escolaridade?.Curso?.Nome
            },
            CursoDestino = new InstituicaoDestinoCommand()
            {
                CodigoCampus = oferta.Campus?.Integracao?.CodigoOrigem ?? string.Empty,
                NomeCampus = oferta.Campus?.Nome ?? string.Empty,
                NomeCurso = oferta.Curso?.Nome ?? string.Empty,
                NomeTurno = oferta.Turno?.Nome ?? string.Empty,
                CodigoInstituicao = oferta.Instituicao?.Integracoes?.Find(x => x.NomeSistema == IntegracaoSistemaConstants.Vestib)?.CodigoOrigem ?? string.Empty,
            }
        });
    }

    private IQueryable<InscricaoMatriculaDto> ObterMatriculasInscricao(InscricaoCandidato inscricaoCandidato)
    {
        var matriculasInscricao = inscricaoCandidato.Matriculas.Select(a => a.MatriculaId).ToList();

        return from matricula in _matriculaRepository.GetQueryable().AsNoTracking()
               where matriculasInscricao.Contains(matricula.Id)
               select new InscricaoMatriculaDto()
               {
                   CodigoAluno = matricula.CodigoAluno,
                   Ra = matricula.Ra,
                   Key = matricula.Key,
                   StatusMatricula = matricula.StatusMatricula,
               };
    }

    private InscricaoEscolaridadeDto? ObterEscolaridadeSuperiorInscricao(Guid inscricaoCandidatoKey)
    {
        var query = from inscricao in _inscricaoRepository.GetQueryable().AsNoTracking()
                    from inscricaoEscolaridade in inscricao.Escolaridades.DefaultIfEmpty()
                    join escola in _escolaRepository.GetQueryable().AsNoTracking().DefaultIfEmpty()
                     on inscricaoEscolaridade.EscolaId equals escola.Id into escolas
                    from escola in escolas.DefaultIfEmpty()
                    join curso in _cursoExternoRepository.GetQueryable().AsNoTracking().DefaultIfEmpty()
                     on inscricaoEscolaridade.CursoExternoId equals curso.Id into cursos
                    from curso in cursos.DefaultIfEmpty()
                    where inscricaoEscolaridade.Nivel == TipoEscolaridadeInscricao.EnsinoSuperior && 
                    inscricao.Key == inscricaoCandidatoKey
                    select new InscricaoEscolaridadeDto()
                    {
                        AnoConclusao = inscricaoEscolaridade.AnoConclusao,
                        Curso = curso != null ? new()
                        {
                            Key = curso.Key,
                            Nome = curso.Nome,
                        } : null,
                        Escola = new()
                        {
                            Key = escola != null ? escola.Key : null,
                            Nome = escola != null ? escola.Nome : null,
                            InstituicaoKey = escola != null && escola.InstituicaoId != null ? 
                            (from instituicao in _instituicaoRepository.GetQueryable().AsNoTracking()
                             where instituicao.Id == escola.InstituicaoId
                             select instituicao.Key).First() : null,
                            Integracao = escola != null && escola.IntegracaoEscola != null ?
                                        (from sistema in _integracaoSistemaRepository.GetQueryable()
                                         where sistema.Id == escola.IntegracaoEscola!.IntegracaoSistemaId
                                         select new SistemaIntegracaoDto()
                                         {
                                             CodigoOrigem = escola.IntegracaoEscola!.CodigoOrigem,
                                             NomeSistema = sistema.Nome,
                                         }).FirstOrDefault() : null
                        },
                    };

        return query.FirstOrDefault();
    }

    private IQueryable<InscricaoOfertaDto> ObterOfertaInscricao(InscricaoCandidato inscricaoCandidato)
{
    return from ofertaConcurso in _ofertaConcursoRepository.GetQueryable().AsNoTracking()
           join oferta in _ofertaRepository.GetQueryable().AsNoTracking()
            on ofertaConcurso.OfertaId equals oferta.Id
           join produto in _produtoRepository.GetQueryable().AsNoTracking()
            on oferta.ProdutoId equals produto.Id
           join curso in _cursoRepository.GetQueryable().AsNoTracking()
            on produto.CursoId equals curso.Id
           join turno in _turnoRepository.GetQueryable().AsNoTracking()
            on produto.TurnoId equals turno.Id
           join campus in _campusRepository.GetQueryable().AsNoTracking()
               on produto.CampusId equals campus.Id
           join instituicao in _instituicaoRepository.GetQueryable().AsNoTracking()
               on produto.InstituicaoId equals instituicao.Id
           join concurso in _concursoRepository.GetQueryable().AsNoTracking()
            on ofertaConcurso.ConcursoId equals concurso.Id
           from modalidade in _modalidadeRepository.GetQueryable().AsNoTracking()
           join intake in _intakeRepository.GetQueryable().AsNoTracking()
            on oferta.IntakeId equals intake.Id
           from integracaoCampus in _integracaoSistemaRepository.GetQueryable().AsNoTracking()
             .Where(i => i.Id == campus.IntegracaoCampus!.IntegracaoSistemaId).DefaultIfEmpty()
           where ofertaConcurso.Id == inscricaoCandidato.Oferta!.OfertaConcursoId &&
           concurso.Modalidades.Any(m => m.ModalidadeId == modalidade.Id)
           select new InscricaoOfertaDto()
           {
               OfertaConcursoKey = ofertaConcurso.Key,
               OfertaKey = oferta.Key,
               PeriodoLetivo = concurso.PeriodoLetivo,
               Curso = new()
               {
                   Key = curso.Key,
                   Nome = curso.Nome
               },
               Turno = new()
               {
                   Key = turno.Key,
                   Nome = turno.Nome,
               },
               Campus = new()
               {
                   Key = campus.Key,
                   Nome = campus.Nome,
                   Integracao = new()
                   {
                       CodigoOrigem = campus.IntegracaoCampus!.CodigoOrigem,
                       NomeSistema = integracaoCampus.Nome
                   }
               },
               Concurso = new()
               {
                   Key = concurso.Key,
                   Nome = concurso.Nome,
                   Modalidade = new()
                   {
                       Key = modalidade.Key,
                       Nome = modalidade.Nome,
                   },
               },
               Instituicao = new()
               {
                   Key = instituicao.Key,
                   Nome = instituicao.Nome,
                   Integracoes = (from integracao in instituicao.IntegracaoInstituicao
                                  join sistema in _integracaoSistemaRepository.GetQueryable()
                                  on integracao.IntegracaoSistemaId equals sistema.Id
                                  select new SistemaIntegracaoDto()
                                  {
                                      CodigoOrigem = integracao.CodigoOrigem,
                                      NomeSistema = sistema.Nome,
                                  }).ToList()
               },
           };
}

private IQueryable<InstituicaoDto> ObterInstituicaoAnimaDaEscola(Guid instituicaoKey)
{
    return from instituicao in _instituicaoRepository.GetQueryable().AsNoTracking()
           where instituicao.Key == instituicaoKey
           select new InstituicaoDto()
           {
               Key = instituicao.Key,
               Nome = instituicao.Nome,
               Integracoes = (from integracao in instituicao.IntegracaoInstituicao
                              join sistema in _integracaoSistemaRepository.GetQueryable()
                                on integracao.IntegracaoSistemaId equals sistema.Id
                              where sistema.Nome.ToUpper() == IntegracaoSistemaConstants.Vestib.ToUpper()
                              select new SistemaIntegracaoDto()
                              {
                                  CodigoOrigem = integracao.CodigoOrigem,
                                  NomeSistema = sistema.Nome,
                              }).ToList()
           };
}
}