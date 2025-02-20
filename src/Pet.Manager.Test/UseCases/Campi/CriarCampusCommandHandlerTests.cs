using System.Linq.Expressions;

using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.UseCases.Campi.CriarCampus;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Campi.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Campi;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarCampusCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<ICampusRepository> _campusRepository = new();
    private readonly Mock<IIntegracaoSistemaRepository> _integracaoSistemaRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public CriarCampusCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveInserirCampusComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarCampusCommand
        {
            Nome = "Jaboatão",
        }, default);

        // Assert
        _campusRepository.Verify(x => x.InsertAsync(It.IsAny<Campus>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task DeveInserirCampusComNomeComercial()
    {
        var useCase = ObterUseCase();

        await useCase.Handle(new CriarCampusCommand
        {
            Nome = "Jaboatão",
            NomeComercial = "Jaboatão dos Guararapes",
        }, default);

        _campusRepository.Verify(x => x.InsertAsync(It.Is<Campus>(x =>
            x.Nome == "Jaboatão" &&
            x.NomeComercial == "Jaboatão dos Guararapes")), Times.Once);

        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveInserirQuandoNomeJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarCampusCommand
        {
            Nome = CampusConstants.CampusRecife.Nome,
            NomeComercial = CampusConstants.CampusRecife.NomeComercial,
        }, default);

        // Assert
        _campusRepository.Verify(x => x.InsertAsync(It.IsAny<Campus>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    [Fact]
    public async Task DeveInserirCampusComSucessoComIntegracaoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();
        var command = new CriarCampusCommand
        {
            Nome = "Jaboatão",
            Integracao = new SistemaIntegracaoDto()
            {
                CodigoOrigem = "123",
                NomeSistema = IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Nome,
            },
        };

        // Act
        await useCase.Handle(command, default);

        // Assert
        _campusRepository.Verify(x => x.InsertAsync(It.Is<Campus>(x =>
            x.Nome == command.Nome &&
            x.IntegracaoCampus!.IntegracaoSistemaId == IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Id &&
            x.IntegracaoCampus!.CodigoOrigem == command.Integracao.CodigoOrigem)), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    private CriarCampusCommandHandler ObterUseCase()
    {
        _integracaoSistemaRepository
            .Setup(x => x.GetAsync(It.IsAny<Expression<Func<IntegracaoSistema, bool>>>(), It.IsAny<bool>()))
            .ReturnsAsync(IntegracaoSistemaConstants.IntegracaoSistemaPortfolio);

        return new CriarCampusCommandHandler(
            _notificationContext.Object,
            _campusRepository.Object,
            _integracaoSistemaRepository.Object,
            _unitOfWork.Object);
    }
}
