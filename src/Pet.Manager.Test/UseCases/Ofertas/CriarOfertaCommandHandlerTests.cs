using Anima.Inscricao.Application.UseCases.Ofertas.CriarOferta;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Ofertas.Entities;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Ofertas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarOfertaCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IOfertaRepository> _ofertaRepositoryMock = new();
    private readonly IProdutoRepository _produtoRepository;
    private readonly IIntakeRepository _intakeRepository;
    private readonly Mock<IUnitOfWork> _unitOfWorkMock = new();
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public CriarOfertaCommandHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _produtoRepository = serviceProvider.GetRequiredService<IProdutoRepository>();
        _intakeRepository = serviceProvider.GetRequiredService<IIntakeRepository>();
        _integracaoSistemaRepository = serviceProvider.GetRequiredService<IIntegracaoSistemaRepository>();

    }

    [Fact]
    public async Task DeveInserirOfertaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarOfertaCommand
        {
            ProdutoKey = ProdutoConstants.ProdutoTeste1.Key,
            IntakeKey = IntakeConstants.IntakeSegundoSemestre.Key,

        }, default);

        // Assert
        _ofertaRepositoryMock.Verify(x => x.InsertAsync(It.IsAny<Oferta>()), Times.Once);
        _unitOfWorkMock.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveInserirOfertaQuandoInformacoesJaExistemAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarOfertaCommand
        {
            ProdutoKey = ProdutoConstants.ProdutoTeste1.Key,
            IntakeKey = IntakeConstants.IntakePrimeiroSemestre.Key,

        }, default);

        // Assert
        _ofertaRepositoryMock.Verify(x => x.InsertAsync(It.IsAny<Oferta>()), Times.Never);
        _unitOfWorkMock.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    private CriarOfertaCommandHandler ObterUseCase()
    {
        return new(
            _notificationContextMock.Object,
            _ofertaRepositoryMock.Object,
            _produtoRepository,
            _intakeRepository,
            _integracaoSistemaRepository,
            _unitOfWorkMock.Object);
    }
}
