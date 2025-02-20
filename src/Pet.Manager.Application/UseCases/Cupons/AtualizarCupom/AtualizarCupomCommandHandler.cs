using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Cupons;

namespace Anima.Inscricao.Application.UseCases.Cupons.AtualizarCupom;

public class AtualizarCupomCommandHandler : ICommandHandler<AtualizarCupomCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly IConcursoRepository _concursoRepository;
    private readonly ICupomRepository _cupomRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarCupomCommandHandler(
        INotificationContext notificationContext, 
        IConcursoRepository concursoRepository, 
        ICupomRepository cupomRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _concursoRepository = concursoRepository;
        _cupomRepository = cupomRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarCupomCommand request, CancellationToken cancellationToken)
    {
        var concurso = await _concursoRepository.GetAsync(request.ConcursoKey);

        var cupom = await _cupomRepository.GetAsync(request.Key);

        var cupomAtualizado = cupom.AtualizarInfos(
            concurso.Id,
            request.Codigo,
            request.Descricao,
            request.ValorDesconto,
            request.TipoDesconto,
            request.DataValidade
        ).NotificarFalhas(_notificationContext).IsSuccess;

        if (cupomAtualizado)
        {
            _cupomRepository.Update(cupom);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
