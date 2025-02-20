using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Domain.Escolas;

namespace Anima.Inscricao.Application.UseCases.Escolas.AtualizarEscola;

public class AtualizarEscolaCommandHandler : ICommandHandler<AtualizarEscolaCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly ICidadeRepository _cidadeRepository;
    private readonly IEscolaRepository _escolaRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarEscolaCommandHandler(
        INotificationContext notificationContext, 
        ICidadeRepository cidadeRepository, 
        IEscolaRepository escolaRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _cidadeRepository = cidadeRepository;
        _escolaRepository = escolaRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarEscolaCommand request, CancellationToken cancellationToken)
    {
        Cidade? cidade = null;
        if(request.CidadeKey.HasValue)
        {
            cidade = await _cidadeRepository.GetAsync(request.CidadeKey.Value);
        }

        var escola = await _escolaRepository.GetAsync(request.Key);

        var escolaAtualizada = escola
            .AtualizarInfos(request.Nome, request.CodigoInep, cidade?.Id, request.TipoCategoria)
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (escolaAtualizada)
        {
            _escolaRepository.Update(escola);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
