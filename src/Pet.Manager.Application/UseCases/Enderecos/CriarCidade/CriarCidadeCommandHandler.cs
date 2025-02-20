using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas;

namespace Anima.Inscricao.Application.UseCases.Enderecos.CriarCidade;

public class CriarCidadeCommandHandler : ICommandHandler<CriarCidadeCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly IEstadoRepository _estadoRepository;
    private readonly ICidadeRepository _cidadeRepository;
    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarCidadeCommandHandler(INotificationContext notificationContext, IEstadoRepository estadoRepository, ICidadeRepository cidadeRepository, IIntegracaoSistemaRepository sistemasIntegracaoRepository, IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _estadoRepository = estadoRepository;
        _cidadeRepository = cidadeRepository;
        _sistemasIntegracaoRepository = sistemasIntegracaoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarCidadeCommand request, CancellationToken cancellationToken)
    {
        var estado = await _estadoRepository.GetAsync(request.EstadoKey);

        var cidade = Cidade
            .Criar(request.Nome, estado.Id, request.Ddd, request.CodigoMunicipio)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (cidade == null)
        {
            return null;
        }

        if (request.Integracao != null)
        {
            var sistema = await _sistemasIntegracaoRepository.GetAsync(s => s.Nome.ToUpper() == request.Integracao.NomeSistema.ToUpper());
            cidade.AdicionarIntegracao(sistema.Id, request.Integracao.CodigoOrigem);
        }

        await _cidadeRepository.InsertAsync(cidade);

        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(cidade.Key);
    }
}

