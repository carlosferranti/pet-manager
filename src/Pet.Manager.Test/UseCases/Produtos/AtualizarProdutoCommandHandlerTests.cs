using Anima.Inscricao.Application.UseCases.Produtos.AtualizarProduto;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Domain.Turnos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;
using Anima.Inscricao.Domain.Produtos.Entities;

using Moq;

using Microsoft.Extensions.DependencyInjection;
using Anima.Inscricao.Application.UseCases.Cursos.AtualizarCurso;
using Anima.Inscricao.Infra.Data._Shared.Postgres.UoW;
using Anima.Inscricao.Infra.Data.Postgress.Repositories;
using Anima.Inscricao.Domain.Instituicoes.Entities;

namespace Anima.Inscricao.Test.UseCases.Produtos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarProdutoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IProdutoRepository> _produtoRepositoryMock = new();
    private readonly Mock<IInstituicaoRepository> _instituicaoRepositoryMock = new();
    private readonly Mock<ICampusRepository> _campusRepositoryMock = new();
    private readonly Mock<ICursoRepository> _cursoRepositoryMock = new();
    private readonly Mock<ITurnoRepository> _turnoRepositoryMock = new();
    private readonly Mock<IUnitOfWork> _unitOfWorkMock = new();

    public AtualizarProdutoCommandHandlerTests()
    {
        var serviceProvider = new ServiceExtensions().BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveAtualizarProdutoComSucessoAsync()
    {
        // Arrange
        var produto = ProdutoConstants.ProdutoTeste2;
        var command = new AtualizarProdutoCommand
        {
            Key = produto.Key,
            InstituicaoKey = InstituicaoConstants.Unibh.Key,
            CampusKey = CampusConstants.CampusRecife.Key,
            CursoKey = CursoConstants.CursoDireito.Key,
            TurnoKey = TurnoConstants.TurnoTarde.Key,
            Sku = "SkuTestes"
        };

        _instituicaoRepositoryMock.Setup(x => x.GetAsync(It.IsAny<Guid>())).ReturnsAsync(InstituicaoConstants.Una);
        _campusRepositoryMock.Setup(x => x.GetAsync(It.IsAny<Guid>())).ReturnsAsync(CampusConstants.CampusOlinda);
        _cursoRepositoryMock.Setup(x => x.GetAsync(It.IsAny<Guid>())).ReturnsAsync(CursoConstants.CursoDireito);
        _turnoRepositoryMock.Setup(x => x.GetAsync(It.IsAny<Guid>())).ReturnsAsync(TurnoConstants.TurnoManha);
        _produtoRepositoryMock.Setup(x => x.GetAsync(It.IsAny<Guid>())).ReturnsAsync(produto);

        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(command, CancellationToken.None);

        // Assert
        _produtoRepositoryMock.Verify(x => x.Update(It.IsAny<Produto>()), Times.Once);
        _unitOfWorkMock.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    private AtualizarProdutoCommandHandler ObterUseCase()
    {
        return new(
            _notificationContextMock.Object,
            _produtoRepositoryMock.Object,
            _instituicaoRepositoryMock.Object,
            _campusRepositoryMock.Object,
            _cursoRepositoryMock.Object,
            _turnoRepositoryMock.Object,
            _unitOfWorkMock.Object);
    }
}