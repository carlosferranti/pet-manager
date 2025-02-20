using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.TiposFormacao;

namespace Anima.Inscricao.Application.UseCases.Cursos.AtualizarCurso;

public class AtualizarCursoCommandHandler : ICommandHandler<AtualizarCursoCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly ICursoRepository _cursoRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly INivelCursoRepository _nivelCursoRepository;
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarCursoCommandHandler(
        INotificationContext notificationContext,
        ICursoRepository cursoRepository,
        IModalidadeRepository modalidadeRepository,
        ITipoFormacaoRepository tipoFormacaoRepository,
        INivelCursoRepository nivelCursoRepository,
        IInstituicaoRepository instituicaoRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _cursoRepository = cursoRepository;
        _modalidadeRepository = modalidadeRepository;
        _tipoFormacaoRepository = tipoFormacaoRepository;
        _nivelCursoRepository = nivelCursoRepository;
        _instituicaoRepository = instituicaoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarCursoCommand request, CancellationToken cancellationToken)
    {
        var modalidade = await _modalidadeRepository.GetAsync(request.ModalidadeKey);

        var tipoFormacao = await _tipoFormacaoRepository.GetAsync(request.TipoFormacaoKey);

        var nivelCurso = await _nivelCursoRepository.GetAsync(request.NivelCursoKey);

        var instituicao = await _instituicaoRepository.GetAsync(request.InstituicaoKey);

        var curso = await _cursoRepository.GetAsync(request.Key);

        var cursoAtualizado = curso.AtualizarInfos(request.Nome, request.NomeComercial, modalidade.Id, tipoFormacao.Id, nivelCurso.Id, instituicao.Id)
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (cursoAtualizado)
        {
            _cursoRepository.Update(curso);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}