using System.Linq.Expressions;

using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.UseCases.Marcas.CriarMarca;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.Marcas.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Marcas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarMarcaCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IMarcaRepository> _marcaRepository = new();
    private readonly Mock<IIntegracaoSistemaRepository> _integracaoSistemaRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public CriarMarcaCommandHandlerTests()
    {
        new ServiceExtensions()
           .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveInserirMarcaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarMarcaCommand
        {
            Nome = "Anima",
        }, default);

        // Assert
        _marcaRepository.Verify(x => x.InsertAsync(It.IsAny<Marca>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveInserirQuandoNomeJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarMarcaCommand
        {
            Nome = MarcaConstants.Una.Nome,
            Sigla = MarcaConstants.Una.Sigla,
        }, default);

        // Assert
        _marcaRepository.Verify(x => x.InsertAsync(It.IsAny<Marca>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    [Fact]
    public async Task DeveInserirMarcaComSucessoComIntegracaoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();
        var command = new CriarMarcaCommand
        {
            Nome = "FADERGS Live",
            Sigla = "FADERGS Live",
            Integracao = new SistemaIntegracaoDto()
            {
                CodigoOrigem = "123",
                NomeSistema = IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Nome,
            },
        };

        // Act
        await useCase.Handle(command, default);

        // Assert
        _marcaRepository.Verify(x => x.InsertAsync(It.Is<Marca>(x =>
            x.Nome == command.Nome &&
            x.IntegracoesMarcas.FirstOrDefault()!.IntegracaoSistemaId == IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Id &&
            x.IntegracoesMarcas.FirstOrDefault()!.CodigoOrigem == command.Integracao.CodigoOrigem)), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    private CriarMarcaCommandHandler ObterUseCase()
    {
        _integracaoSistemaRepository
        .Setup(m => m.GetAsync(It.IsAny<Expression<Func<IntegracaoSistema, bool>>>(), It.IsAny<bool>()))
            .ReturnsAsync(IntegracaoSistemaConstants.IntegracaoSistemaPortfolio);

        return new CriarMarcaCommandHandler(
            _notificationContext.Object,
            _marcaRepository.Object,
            _integracaoSistemaRepository.Object,
            _unitOfWork.Object);
    }
}
