using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.UseCases.Produtos.CriarProduto;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Domain.Produtos.Entities;
using Anima.Inscricao.Domain.Turnos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Produtos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarProdutoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IProdutoRepository> _produtoRepositoryMock = new();
    private readonly IInstituicaoRepository _instituicaoRepositoryMock;
    private readonly ICampusRepository _campusRepositoryMock;
    private readonly ICursoRepository _cursoRepositoryMock;
    private readonly ITurnoRepository _turnoRepositoryMock;
    private readonly Mock<IUnitOfWork> _unitOfWorkMock = new();
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public CriarProdutoCommandHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _instituicaoRepositoryMock = serviceProvider.GetRequiredService<IInstituicaoRepository>();
        _campusRepositoryMock = serviceProvider.GetRequiredService<ICampusRepository>();
        _cursoRepositoryMock = serviceProvider.GetRequiredService<ICursoRepository>();
        _turnoRepositoryMock = serviceProvider.GetRequiredService<ITurnoRepository>();
        _integracaoSistemaRepository = serviceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
    }

    [Fact]
    public async Task DeveInserirProdutoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarProdutoCommand
        {
            InstituicaoKey = InstituicaoConstants.Unibh.Key,
            CampusKey = CampusConstants.CampusRecife.Key,
            CursoKey = CursoConstants.CursoDireito.Key,
            TurnoKey = TurnoConstants.TurnoTarde.Key,
            Sku = "SkuTeste",

        }, default);

        // Assert
        _produtoRepositoryMock.Verify(x => x.InsertAsync(It.IsAny<Produto>()), Times.Once);
        _unitOfWorkMock.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveInserirProdutoQuandoInformacoesJaExistemAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarProdutoCommand
        {
            InstituicaoKey = InstituicaoConstants.Una.Key,
            CampusKey = CampusConstants.CampusRecife.Key,
            CursoKey = CursoConstants.CursoAdministracao.Key,
            TurnoKey = TurnoConstants.TurnoManha.Key,
            Sku = "Teste1",
            Integracao = new SistemaIntegracaoDto
               {
                    CodigoOrigem = "123",
                    NomeSistema = IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Nome,
               }

        }, default);

        // Assert
        _produtoRepositoryMock.Verify(x => x.InsertAsync(It.IsAny<Produto>()), Times.Never);
        _unitOfWorkMock.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    private CriarProdutoCommandHandler ObterUseCase()
    {
        return new(
             _notificationContextMock.Object,
            _produtoRepositoryMock.Object,
            _instituicaoRepositoryMock,
            _campusRepositoryMock,
            _cursoRepositoryMock,
            _turnoRepositoryMock,
            _integracaoSistemaRepository,
            _unitOfWorkMock.Object);
    }
}
