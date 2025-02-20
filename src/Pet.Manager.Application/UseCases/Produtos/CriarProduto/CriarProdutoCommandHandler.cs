using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Domain.Produtos.Entities;
using Anima.Inscricao.Domain.Turnos;

namespace Anima.Inscricao.Application.UseCases.Produtos.CriarProduto;

public class CriarProdutoCommandHandler : ICommandHandler<CriarProdutoCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly IProdutoRepository _produtoRepository;
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly ICampusRepository _campusRepository;
    private readonly ICursoRepository _cursoRepository;
    private readonly ITurnoRepository _turnoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemasRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarProdutoCommandHandler(INotificationContext notificationContext, 
        IProdutoRepository produtoRepository, 
        IInstituicaoRepository instituicaoRepository, 
        ICampusRepository campusRepository, 
        ICursoRepository cursoRepository, 
        ITurnoRepository turnoRepository, 
        IIntegracaoSistemaRepository integracaoSistemasRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _produtoRepository = produtoRepository;
        _instituicaoRepository = instituicaoRepository;
        _campusRepository = campusRepository;
        _cursoRepository = cursoRepository;
        _turnoRepository = turnoRepository;
        _integracaoSistemasRepository = integracaoSistemasRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarProdutoCommand request, CancellationToken cancellationToken)
    {
        var instituicao = await _instituicaoRepository.GetAsync(request.InstituicaoKey);

        var campus = await _campusRepository.GetAsync(request.CampusKey);

        var curso = await _cursoRepository.GetAsync(request.CursoKey);

        var turno = await _turnoRepository.GetAsync(request.TurnoKey);

        var produtoCriado = Produto.Criar(instituicao.Id, campus.Id, curso.Id, turno.Id, request.Sku)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (produtoCriado == null)
        {
            return null;
        }

        if(request.Integracao != null)
        {
            var sistema = await _integracaoSistemasRepository.GetAsync(s => s.Nome.ToUpper() == request.Integracao.NomeSistema.ToUpper());
            produtoCriado.AdicionarIntegracao(sistema.Id, request.Integracao.CodigoOrigem);
        }

        await _produtoRepository.InsertAsync(produtoCriado);

        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(produtoCriado.Key);
    }
}
