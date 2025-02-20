using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.FormasEntrada.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas;

namespace Anima.Inscricao.Application.UseCases.FormasEntrada.CriarFormaEntrada;

public class CriarFormaEntradaCommandHandler : ICommandHandler<CriarFormaEntradaCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarFormaEntradaCommandHandler(
        INotificationContext notificationContext,
        IFormaEntradaRepository formaEntradaRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _formaEntradaRepository = formaEntradaRepository;
        _sistemasIntegracaoRepository = integracaoSistemaRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarFormaEntradaCommand request, CancellationToken cancellationToken)
    {
        FormaEntrada? formaEntradaPai = null;

        if (request.FormaEntradaPaiKey.HasValue)
        {
            formaEntradaPai = await _formaEntradaRepository.GetAsync(request.FormaEntradaPaiKey.Value);
        }

        var formaEntrada = FormaEntrada
            .Criar(request.Nome, request.Descricao, request.OrdemExibicao, request.ExibeCard!.Value, formaEntradaPai?.Id, request.UltimoNivel)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (formaEntrada == null)
        {
            return null;
        }

        if (request.Integracao != null)
        {
            foreach (var integracao in request.Integracao)
            {
                var sistema = await _sistemasIntegracaoRepository.GetAsync(s => s.Nome.ToUpper() == integracao.NomeSistema.ToUpper());
                formaEntrada.AdicionarIntegracao(sistema.Id, integracao.CodigoOrigem);
            }
        }

        await _formaEntradaRepository.InsertAsync(formaEntrada);

        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(formaEntrada.Key);
    }
}