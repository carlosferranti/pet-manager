using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Marcas;

namespace Anima.Inscricao.Application.UseCases.Instituicoes.AtualizarInstituicao;

public class AtualizarInstituicaoCommandHandler : ICommandHandler<AtualizarInstituicaoCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMarcaRepository _marcaRepository;

    public AtualizarInstituicaoCommandHandler(
        INotificationContext notificationContext, 
        IInstituicaoRepository instituicaoRepository,
        IMarcaRepository marcaRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _instituicaoRepository = instituicaoRepository;
        _marcaRepository = marcaRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarInstituicaoCommand request, CancellationToken cancellationToken)
    {
        var instituicao = await _instituicaoRepository.GetAsync(request.Key);

        var marca = await _marcaRepository.GetAsync(request.MarcaKey);

        var campusAtualizado = instituicao
            .AtualizarInfos(request.Nome, request.Sigla, marca.Id)
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (campusAtualizado)
        {
            _instituicaoRepository.Update(instituicao);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
