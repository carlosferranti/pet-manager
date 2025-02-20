using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.Modalidades.Entities;

namespace Anima.Inscricao.Application.UseCases.Modalidades.CriarModalidade;

public class CriarModalidadeCommandHandler : ICommandHandler<CriarModalidadeCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarModalidadeCommandHandler(
        INotificationContext notificationContext,
        IModalidadeRepository modalidadeRepository,
        IIntegracaoSistemaRepository sistemasIntegracaoRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _modalidadeRepository = modalidadeRepository;
        _sistemasIntegracaoRepository = sistemasIntegracaoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarModalidadeCommand request, CancellationToken cancellationToken)
    {
        var modalidade = Modalidade
            .Criar(request.Nome, request.Descricao)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (modalidade == null)
        {
            return null;
        }

        if (request.Integracao != null)
        {
            var sistema = await _sistemasIntegracaoRepository.GetAsync(s => s.Nome.ToUpper() == request.Integracao.NomeSistema.ToUpper());
            modalidade.AdicionarIntegracao(sistema.Id, request.Integracao.CodigoOrigem);
        }

        await _modalidadeRepository.InsertAsync(modalidade);

        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(modalidade.Key);
    }
}
