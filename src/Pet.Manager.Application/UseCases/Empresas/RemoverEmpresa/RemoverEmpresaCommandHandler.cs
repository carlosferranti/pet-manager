using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Empresas;

namespace Anima.Inscricao.Application.UseCases.Empresas.RemoverEmpresa;

public class RemoverEmpresaCommandHandler : ICommandHandler<RemoverEmpresaCommand>
{
    public readonly INotificationContext _notificationContext;
    public readonly IEmpresaRepository _empresaRepository;
    public readonly IUnitOfWork _unitOfWork;

    public RemoverEmpresaCommandHandler(
        INotificationContext notificationContext,
        IEmpresaRepository empresaRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _empresaRepository = empresaRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverEmpresaCommand request, CancellationToken cancellationToken)
    {
        var empresa = await _empresaRepository.GetAsync(request.Key);

        var empresaRemovida = empresa.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (empresaRemovida)
        {
            _empresaRepository.Delete(empresa);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
