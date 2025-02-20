using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.NiveisCurso.Entities;

namespace Anima.Inscricao.Application.UseCases.NiveisCurso.CriarNivelCurso;

public class CriarNivelCursoCommandHandler : ICommandHandler<CriarNivelCursoCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly INivelCursoRepository _nivelCursoRepository;
    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarNivelCursoCommandHandler(
        INotificationContext notificationContext, 
        INivelCursoRepository nivelCursoRepository, 
        IIntegracaoSistemaRepository sistemasIntegracaoRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _nivelCursoRepository = nivelCursoRepository;
        _sistemasIntegracaoRepository = sistemasIntegracaoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarNivelCursoCommand request, CancellationToken cancellationToken)
    {
        var nivelCurso = NivelCurso
            .Criar(request.Nome)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (nivelCurso == null)
        {
            return null!;
        }

        if (request.Integracao != null)
        {
            var sistema = await _sistemasIntegracaoRepository.GetAsync(s => s.Nome.Trim().ToUpper() == request.Integracao.NomeSistema.Trim().ToUpper());
            nivelCurso.AdicionarIntegracao(sistema.Id, request.Integracao.CodigoOrigem);
        }

        await _nivelCursoRepository.InsertAsync(nivelCurso);
        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(nivelCurso.Key);
    }
}
