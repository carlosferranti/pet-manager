using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campos;
using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Domain.Fichas.Entities;

namespace Anima.Inscricao.Application.UseCases.Fichas.CriarFicha;

public class CriarFichaCommandHandler : ICommandHandler<CriarFichaCommand, EntityKeyDto?>
{
    private readonly IFichaRepository _fichaRepository;
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly INotificationContext _notificationContext;
    private readonly ICampoRepository _campoRepository;

    public CriarFichaCommandHandler(
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

    public async Task<EntityKeyDto?> Handle(CriarFichaCommand request, CancellationToken cancellationToken)
    {
        var ficha = Ficha
            .Criar(request.Nome, request.Descricao, request.Padrao)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (ficha == null)
        {
            return null;
        }

        foreach (var etapa in request.Etapas)
        {
            var etapaTemplate = await _etapaTemplateRepository.GetAsync(etapa.EtapaKey);

            ficha.AdicionarEtapa(etapaTemplate.Id, etapa.Sequencia);
        }

        if(request.Campos != null && request.Campos.Any())
        {
            foreach (var campo in request.Campos)
            {
                var campoFicha = await _campoRepository.GetAsync(campo.CampoKey);

                ficha.AdicionarCampo(campoFicha.Id, campo.ObrigatorioNaFicha, campo.ObrigatorioNoComplemento);
            }
        }

        await _fichaRepository.InsertAsync(ficha);

        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(ficha.Key);
    }
}