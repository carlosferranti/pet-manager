using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Cupons;
using Anima.Inscricao.Domain.Cupons.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas;

namespace Anima.Inscricao.Application.UseCases.Cupons.CriarCupom;

public class CriarCupomCommandHandler : ICommandHandler<CriarCupomCommand, EntityKeyDto?>
{
    private readonly ICupomRepository _cupomRepository;
    private readonly IConcursoRepository _concursoRepository;
    private readonly INotificationContext _notificationContext;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarCupomCommandHandler(
        ICupomRepository cupomRepository, 
        IConcursoRepository concursoRepository, 
        INotificationContext notificationContext, 
        IIntegracaoSistemaRepository integracaoSistemaRepository, 
        IUnitOfWork unitOfWork)
    {
        _cupomRepository = cupomRepository;
        _concursoRepository = concursoRepository;
        _notificationContext = notificationContext;
        _integracaoSistemaRepository = integracaoSistemaRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarCupomCommand request, CancellationToken cancellationToken)
    {
        var concurso = await _concursoRepository.GetAsync(request.ConcursoKey);

        var cupom = Cupom
            .Criar(
                concurso.Id, 
                request.Codigo, 
                request.Descricao, 
                request.ValorDesconto, 
                request.TipoDesconto, 
                request.DataValidade)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if(cupom == null)
        {
            return null;
        }

        if(request.Integracao != null)
        {
            var sistema = await _integracaoSistemaRepository.GetAsync(s => s.Nome.ToUpper() == request.Integracao.NomeSistema.ToUpper());
            cupom.AdicionarIntegracao(sistema.Id, request.Integracao.CodigoOrigem);
        }

        await _cupomRepository.InsertAsync(cupom);
        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(cupom.Key);
    }
}
