using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campos;
using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Domain.Fichas;

namespace Anima.Inscricao.Application.UseCases.Fichas.AtualizarFicha;

public class AtualizarFichaCommandHandler : ICommandHandler<AtualizarFichaCommand>
{
    private readonly IFichaRepository _fichaRepository;
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly INotificationContext _notificationContext;
    private readonly ICampoRepository _campoRepository;

    public AtualizarFichaCommandHandler(
        IFichaRepository fichaRepository,
        IEtapaTemplateRepository etapaTemplateRepository,
        IUnitOfWork unitOfWork,
        INotificationContext notificationContext,
        ICampoRepository campoRepository)
    {
        _fichaRepository = fichaRepository;
        _etapaTemplateRepository = etapaTemplateRepository;
        _unitOfWork = unitOfWork;
        _notificationContext = notificationContext;
        _campoRepository = campoRepository;
    }

    public async Task Handle(AtualizarFichaCommand request, CancellationToken cancellationToken)
    {
        var ficha = await _fichaRepository.GetAsync(request.Key);

        var fichaAtualizada = ficha
            .AtualizarInfos(request.Nome, request.Descricao, request.Padrao)
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (fichaAtualizada)
        {
            if (request.Etapas != null)
            {
                ficha.RemoverEtapas();

                foreach (var etapa in request.Etapas)
                {
                    var etapaTemplate = await _etapaTemplateRepository.GetAsync(etapa.EtapaKey);

                    ficha.AdicionarEtapa(etapaTemplate.Id, etapa.Sequencia);
                }
            }

            if (request.Campos != null)
            {
                ficha.RemoverCampos();

                foreach (var campo in request.Campos)
                {
                    var campoFicha = await _campoRepository.GetAsync(campo.CampoKey);

                    ficha.AdicionarCampo(campoFicha.Id, campo.ObrigatorioNaFicha, campo.ObrigatorioNoComplemento);
                }
            }

            _fichaRepository.Update(ficha);

            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}