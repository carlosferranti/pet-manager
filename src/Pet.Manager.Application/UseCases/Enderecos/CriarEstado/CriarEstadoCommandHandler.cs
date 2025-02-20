using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas;

namespace Anima.Inscricao.Application.UseCases.Enderecos.CriarEstado;

public class CriarEstadoCommandHandler : ICommandHandler<CriarEstadoCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly IPaisRepository _paisRepository;
    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;
    private readonly IEstadoRepository _estadoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarEstadoCommandHandler(
        INotificationContext notificationContext,
        IPaisRepository paisRepository,
        IIntegracaoSistemaRepository sistemasIntegracaoRepository,
        IEstadoRepository estadoRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _paisRepository = paisRepository;
        _sistemasIntegracaoRepository = sistemasIntegracaoRepository;
        _estadoRepository = estadoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarEstadoCommand request, CancellationToken cancellationToken)
    {
        var pais = await _paisRepository.GetAsync(request.PaisKey);

        var estado = Estado
            .Criar(request.Nome, request.Sigla, pais.Id)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (estado == null)
        {
            return null;
        }

        if (request.Integracao != null)
        {
            var sistema = await _sistemasIntegracaoRepository.GetAsync(s => s.Nome.ToUpper() == request.Integracao.NomeSistema.ToUpper());
            estado.AdicionarIntegracao(sistema.Id, request.Integracao.CodigoOrigem);
        }

        await _estadoRepository.InsertAsync(estado);

        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(estado.Key);
    }
}
