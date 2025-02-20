using Anima.Inscricao.Application.DTOs.Enem;
using Anima.Inscricao.Application.Interfaces.Services;
using Anima.Inscricao.Domain.Inscricoes.Events;

using MediatR;

namespace Anima.Inscricao.Infra.Messaging.Publishes.Http.Inscricoes;

public class SolicitaClassificacaoEnemEventHandler : INotificationHandler<DocumentoInscricaoCriadoEvent>
{
    private readonly IEnemService _enemService;

    public SolicitaClassificacaoEnemEventHandler(IEnemService enemService)
    {
        _enemService = enemService;
    }

    public async Task Handle(DocumentoInscricaoCriadoEvent notification, CancellationToken cancellationToken)
    {
        if(notification.Tipo != Domain.Inscricoes.Enums.TipoDocumentoInscricao.Cpf ||
            string.IsNullOrWhiteSpace(notification.Valor))
        {
            return;
        }

       await _enemService.SolicitarClassificacaoEnemAsync(new SolicitarClassificacaoRequestDto()
       {
           Cpf = notification.Valor
       });
    }
}