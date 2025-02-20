using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Domain.Escolas.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas;

namespace Anima.Inscricao.Application.UseCases.Escolas.CriarEscola;

public class CriarEscolaCommandHandler : ICommandHandler<CriarEscolaCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly ICidadeRepository _cidadeRepository;
    private readonly IEscolaRepository _escolaRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;

    public CriarEscolaCommandHandler(
        INotificationContext notificationContext, 
        ICidadeRepository cidadeRepository, 
        IEscolaRepository escolaRepository, 
        IUnitOfWork unitOfWork, 
        IIntegracaoSistemaRepository sistemasIntegracaoRepository)
    {
        _notificationContext = notificationContext;
        _cidadeRepository = cidadeRepository;
        _escolaRepository = escolaRepository;
        _unitOfWork = unitOfWork;
        _sistemasIntegracaoRepository = sistemasIntegracaoRepository;
    }

    public async Task<EntityKeyDto?> Handle(CriarEscolaCommand request, CancellationToken cancellationToken)
    {
        Cidade? cidade = null;
        if (request.CidadeKey.HasValue)
        {
            cidade = await _cidadeRepository.GetAsync(request.CidadeKey.Value);
        }

        var escola = Escola
            .Criar(request.Nome, request.CodigoInep, cidade?.Id, request.TipoCategoria)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (escola == null)
        {
            return null;
        }

        if(request.Integracao != null)
        {
            var sistema = await _sistemasIntegracaoRepository.GetAsync(s => s.Nome.Trim().ToUpper() == request.Integracao.NomeSistema.Trim().ToUpper());
            escola.AdicionarIntegracao(sistema.Id, request.Integracao.CodigoOrigem);
        }

        await _escolaRepository.InsertAsync(escola);
        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(escola.Key);
    }
}
