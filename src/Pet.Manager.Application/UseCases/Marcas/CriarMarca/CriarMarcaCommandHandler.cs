using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.Marcas.Entities;

namespace Anima.Inscricao.Application.UseCases.Marcas.CriarMarca;

public class CriarMarcaCommandHandler : ICommandHandler<CriarMarcaCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly IMarcaRepository _marcaRepository;
    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarMarcaCommandHandler(
        INotificationContext notificationContext, 
        IMarcaRepository marcaRepository, 
        IIntegracaoSistemaRepository sistemasIntegracaoRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _marcaRepository = marcaRepository;
        _sistemasIntegracaoRepository = sistemasIntegracaoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarMarcaCommand request, CancellationToken cancellationToken)
    {
        var marca = Marca
            .Criar(request.Nome, request.Sigla)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (marca == null)
        {
            return null;
        }

        if (request.Integracao != null)
        {
            var sistema = await _sistemasIntegracaoRepository.GetAsync(s => s.Nome.ToUpper() == request.Integracao.NomeSistema.ToUpper());
            marca.AdicionarIntegracao(sistema.Id, request.Integracao.CodigoOrigem);
        }

        await _marcaRepository.InsertAsync(marca);
        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(marca.Key);
            
    }
}
