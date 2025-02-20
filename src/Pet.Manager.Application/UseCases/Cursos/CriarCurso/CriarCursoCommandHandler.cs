using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Cursos.Entities;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.TiposFormacao;

namespace Anima.Inscricao.Application.UseCases.Cursos.CriarCurso;

public class CriarCursoCommandHandler : ICommandHandler<CriarCursoCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly ICursoRepository _cursoRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly INivelCursoRepository _nivelCursoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemasRepository;
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarCursoCommandHandler(
        INotificationContext notificationContext,
        ICursoRepository cursoRepository,
        IModalidadeRepository modalidadeRepository,
        ITipoFormacaoRepository tipoFormacaoRepository,
        INivelCursoRepository nivelCursoRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository,
        IInstituicaoRepository instituicaoRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _cursoRepository = cursoRepository;
        _modalidadeRepository = modalidadeRepository;
        _tipoFormacaoRepository = tipoFormacaoRepository;
        _nivelCursoRepository = nivelCursoRepository;
        _integracaoSistemasRepository = integracaoSistemaRepository;
        _instituicaoRepository = instituicaoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarCursoCommand request, CancellationToken cancellationToken)
    {
        var modalidade = await _modalidadeRepository.GetAsync(request.ModalidadeKey);

        var tipoFormacao = await _tipoFormacaoRepository.GetAsync(request.TipoFormacaoKey);

        var nivelCurso = await _nivelCursoRepository.GetAsync(request.NivelCursoKey);

        var instituicao = await _instituicaoRepository.GetAsync(request.InstituicaoKey);

        var cursoCriado = Curso.Criar(request.Nome, request.NomeComercial, modalidade.Id, tipoFormacao.Id, nivelCurso.Id, instituicao.Id)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (cursoCriado == null)
        {
            return null;
        }

        if (request.Integracao != null)
        {
            var sistema = await _integracaoSistemasRepository.GetAsync(s => s.Nome.ToUpper() == request.Integracao.NomeSistema.ToUpper());
            cursoCriado.AdicionarIntegracao(sistema.Id, request.Integracao.CodigoOrigem);
        }

        await _cursoRepository.InsertAsync(cursoCriado);

        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(cursoCriado.Key);
    }
}
