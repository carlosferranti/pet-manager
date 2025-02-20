using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas;

namespace Anima.Inscricao.Application.UseCases.Enderecos.CriarPais;

public class CriarPaisCommandHandler : ICommandHandler<CriarPaisCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly IPaisRepository _paisRepository;
    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarPaisCommandHandler(
        INotificationContext notificationContext,
        IPaisRepository paisRepository,
        IIntegracaoSistemaRepository sistemasIntegracaoRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _paisRepository = paisRepository;
        _sistemasIntegracaoRepository = sistemasIntegracaoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarPaisCommand request, CancellationToken cancellationToken)
    {
        var pais = Pais
            .Criar(request.Nome, request.Sigla, request.SiglaAbreviada, request.Tipo)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (pais == null)
        {
            return null;
        }

        if (request.Integracao != null)
        {
            var sistema = await _sistemasIntegracaoRepository.GetAsync(s => s.Nome.ToUpper() == request.Integracao.NomeSistema.ToUpper());
            pais.AdicionarIntegracao(sistema.Id, request.Integracao.CodigoOrigem);
        }

        await _paisRepository.InsertAsync(pais);

        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(pais.Key);
    }
}
