using System.Linq.Expressions;

using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.UseCases.Deficiencias.CriarDeficiencia;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Deficiencias;
using Anima.Inscricao.Domain.Deficiencias.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Deficiencias;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarDeficienciaCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IDeficienciaRepository> _deficienciaRepository = new();
    private readonly Mock<IIntegracaoSistemaRepository> _integracaoSistemaRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public CriarDeficienciaCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveInserirDeficienciaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarDeficienciaCommand
        {
            Nome = "Deficiência Múltipla",
        }, default);

        // Assert
        _deficienciaRepository.Verify(x => x.InsertAsync(It.IsAny<Deficiencia>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveInserirQuandoNomeJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarDeficienciaCommand
        {
            Nome = DeficienciaConstants.Cegueira.Nome,
        }, default);

        // Assert
        _deficienciaRepository.Verify(x => x.InsertAsync(It.IsAny<Deficiencia>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    [Fact]
    public async Task DeveInserirDeficienciaComSucessoComIntegracaoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();
        var command = new CriarDeficienciaCommand
        {
            Nome = "Síndrome de Rett",
            Integracao = new SistemaIntegracaoDto()
            {
                CodigoOrigem = "123",
                NomeSistema = IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Nome,
            },
        };

        // Act
        await useCase.Handle(command, default);

        // Assert
        _deficienciaRepository.Verify(x => x.InsertAsync(It.Is<Deficiencia>(x =>
            x.Nome == command.Nome &&
            x.IntegracaoDeficiencia!.IntegracaoSistemaId == IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Id &&
            x.IntegracaoDeficiencia!.CodigoOrigem == command.Integracao.CodigoOrigem)), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    private CriarDeficienciaCommandHandler ObterUseCase()
    {
        _integracaoSistemaRepository
            .Setup(x => x.GetAsync(It.IsAny<Expression<Func<IntegracaoSistema, bool>>>(), It.IsAny<bool>()))
            .ReturnsAsync(IntegracaoSistemaConstants.IntegracaoSistemaPortfolio);

        return new CriarDeficienciaCommandHandler(
            _notificationContext.Object,
            _deficienciaRepository.Object,
            _integracaoSistemaRepository.Object,
            _unitOfWork.Object);
    }
}
