using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Acessibilidades;
using Anima.Inscricao.Domain.Acessibilidades.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas;

namespace Anima.Inscricao.Application.UseCases.Acessibilidades.CriarAcessibilidade;

public class CriarAcessibilidadeCommandHandler : ICommandHandler<CriarAcessibilidadeCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly IAcessibilidadeRepository _acessibilidadeRepository;
    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarAcessibilidadeCommandHandler(
        INotificationContext notificationContext, 
        IAcessibilidadeRepository acessibilidadeRepository, 
        IIntegracaoSistemaRepository sistemasIntegracaoRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _acessibilidadeRepository = acessibilidadeRepository;
        _sistemasIntegracaoRepository = sistemasIntegracaoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarAcessibilidadeCommand request, CancellationToken cancellationToken)
    {
        var acessibilidade = Acessibilidade.Criar(request.Nome)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (acessibilidade == null)
        {
            return null;
        }

        if (request.Integracao != null)
        {
            var sistema = await _sistemasIntegracaoRepository.GetAsync(s => s.Nome.ToUpper() == request.Integracao.NomeSistema.ToUpper());
            acessibilidade.AdicionarIntegracao(sistema.Id, request.Integracao.CodigoOrigem);
        }

        await _acessibilidadeRepository.InsertAsync(acessibilidade);

        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(acessibilidade.Key);
    }
}
