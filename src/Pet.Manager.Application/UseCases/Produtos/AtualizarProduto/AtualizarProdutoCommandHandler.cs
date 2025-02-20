using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Domain.Turnos;

namespace Anima.Inscricao.Application.UseCases.Produtos.AtualizarProduto;

public class AtualizarProdutoCommandHandler : ICommandHandler<AtualizarProdutoCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly IProdutoRepository _produtoRepository;
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly ICampusRepository _campusRepository;
    private readonly ICursoRepository   _cursoRepository;
    private readonly ITurnoRepository _turnoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarProdutoCommandHandler(
        INotificationContext notificationContext, 
        IProdutoRepository produtoRepository,
        IInstituicaoRepository instituicaoRepository,
        ICampusRepository campusRepository, 
        ICursoRepository cursoRepository, 
        ITurnoRepository turnoRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _produtoRepository = produtoRepository;
        _instituicaoRepository = instituicaoRepository;
        _campusRepository = campusRepository;
        _cursoRepository = cursoRepository;
        _turnoRepository = turnoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarProdutoCommand request, CancellationToken cancellationToken)
    {
        var instituicao = await _instituicaoRepository.GetAsync(request.InstituicaoKey);

        var campus = await _campusRepository.GetAsync(request.CampusKey);

        var curso = await _cursoRepository.GetAsync(request.CursoKey);

        var turno = await _turnoRepository.GetAsync(request.TurnoKey);

        var produto = await _produtoRepository.GetAsync(request.Key);

        var produtoAtualizado = produto.AtualizarInfos(instituicao.Id, campus.Id, curso.Id, turno.Id, request.Sku)
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (produtoAtualizado)
        {
            _produtoRepository.Update(produto);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
