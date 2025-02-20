using Anima.Inscricao.Application.UseCases.NiveisCurso.AtualizarNivelCurso;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.NiveisCurso.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.NiveisCurso;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarNivelCursoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<INivelCursoRepository> _nivelCursoRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public AtualizarNivelCursoCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveAtualizarNivelCursoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarNivelCursoCommand
        {
            Key = NivelCursoConstants.Licenciatura.Key,
            Nome = "Tecnólogo",
        }, default);

        // Assert
        _nivelCursoRepository.Verify(x => x.Update(It.IsAny<NivelCurso>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveAtualizarQuandoNomeJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarNivelCursoCommand
        {
            Key = NivelCursoConstants.Licenciatura.Key,
            Nome = NivelCursoConstants.Bacharelado.Nome,
        }, default);

        // Assert
        _nivelCursoRepository.Verify(x => x.Update(It.IsAny<NivelCurso>()), Times.Never);
    }

    private AtualizarNivelCursoCommandHandler ObterUseCase()
    {
        _nivelCursoRepository
            .Setup(x => x.GetAsync(NivelCursoConstants.Licenciatura.Key))
            .ReturnsAsync(NivelCursoConstants.Licenciatura);

        return new(
            _notificationContext.Object,
            _nivelCursoRepository.Object,
            _unitOfWork.Object);
    }
}
