using System.Linq.Expressions;

using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.UseCases.NiveisCurso.CriarNivelCurso;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.NiveisCurso.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.NiveisCurso;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarNivelCursoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<INivelCursoRepository> _nivelCursoRepository = new();
    private readonly Mock<IIntegracaoSistemaRepository> _integracaoSistemaRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public CriarNivelCursoCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveInserirNivelCursoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarNivelCursoCommand
        {
            Nome = "Teste",
        }, default);

        // Assert
        _nivelCursoRepository.Verify(x => x.InsertAsync(It.IsAny<NivelCurso>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveInserirQuandoNomeJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarNivelCursoCommand
        {
            Nome = NivelCursoConstants.Bacharelado.Nome,
        }, default);

        // Assert
        _nivelCursoRepository.Verify(x => x.InsertAsync(It.IsAny<NivelCurso>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    [Fact]
    public async Task DeveInserirNivelCursoComSucessoComIntegracaoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();
        var command = new CriarNivelCursoCommand
        {
            Nome = "Tecnólogo",
            Integracao = new SistemaIntegracaoDto()
            {
                CodigoOrigem = "123",
                NomeSistema = IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Nome,
            },
        };

        // Act
        await useCase.Handle(command, default);

        // Assert
        _nivelCursoRepository.Verify(x => x.InsertAsync(It.Is<NivelCurso>(x =>
            x.Nome == command.Nome &&
            x.IntegracaoNivelCurso!.IntegracaoSistemaId == IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Id &&
            x.IntegracaoNivelCurso!.CodigoOrigem == command.Integracao.CodigoOrigem)), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    private CriarNivelCursoCommandHandler ObterUseCase()
    {
        _integracaoSistemaRepository
            .Setup(x => x.GetAsync(It.IsAny<Expression<Func<IntegracaoSistema, bool>>>(), It.IsAny<bool>()))
            .ReturnsAsync(IntegracaoSistemaConstants.IntegracaoSistemaPortfolio);

        return new CriarNivelCursoCommandHandler(
            _notificationContext.Object,
            _nivelCursoRepository.Object,
            _integracaoSistemaRepository.Object,
            _unitOfWork.Object);
    }
}
