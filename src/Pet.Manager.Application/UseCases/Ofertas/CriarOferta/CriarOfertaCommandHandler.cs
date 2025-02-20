using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Ofertas.Entities;
using Anima.Inscricao.Domain.Produtos;

namespace Anima.Inscricao.Application.UseCases.Ofertas.CriarOferta;

public class CriarOfertaCommandHandler : ICommandHandler<CriarOfertaCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IProdutoRepository _produtoRepository;
    private readonly IIntakeRepository _intakeRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemasRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarOfertaCommandHandler(
        INotificationContext notificationContext, 
        IOfertaRepository ofertaRepository, 
        IProdutoRepository produtoRepository, 
        IIntakeRepository intakeRepository, 
        IIntegracaoSistemaRepository integracaoSistemasRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _ofertaRepository = ofertaRepository;
        _produtoRepository = produtoRepository;
        _intakeRepository = intakeRepository;
        _integracaoSistemasRepository = integracaoSistemasRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarOfertaCommand request, CancellationToken cancellationToken)
    {
        var produto = await _produtoRepository.GetAsync(request.ProdutoKey);

        var intake = await _intakeRepository.GetAsync(request.IntakeKey);

        var ofertaCriada = Oferta.Criar(produto.Id, intake.Id)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if(ofertaCriada ==  null)
        {
            return null;
        }

        if(request.Integracao != null)
        {
            var sistema = await _integracaoSistemasRepository.GetAsync(s => s.Nome.ToUpper() == request.Integracao.NomeSistema.ToUpper());
            ofertaCriada.AdicionarIntegracao(sistema.Id, request.Integracao.CodigoOrigem);
        }

        await _ofertaRepository.InsertAsync(ofertaCriada);

        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(ofertaCriada.Key);
    }
}
