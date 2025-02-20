using Anima.Inscricao.Application.UseCases.Deficiencias.AtualizarDeficiencia;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Deficiencias;
using Anima.Inscricao.Domain.Deficiencias.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Deficiencias;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarDeficienciaCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IDeficienciaRepository> _deficienciaRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public AtualizarDeficienciaCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveAtualizarDeficienciaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarDeficienciaCommand
        {
            Key = DeficienciaConstants.DeficienciaFisica.Key,
            Nome = "Física",
        }, default);

        // Assert
        _deficienciaRepository.Verify(x => x.Update(It.IsAny<Deficiencia>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveAtualizarQuandoNomeJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarDeficienciaCommand
        {
            Key = DeficienciaConstants.DeficienciaFisica.Key,
            Nome = DeficienciaConstants.Cegueira.Nome,
        }, default);

        // Assert
        _deficienciaRepository.Verify(x => x.Update(It.IsAny<Deficiencia>()), Times.Never);
    }

    private AtualizarDeficienciaCommandHandler ObterUseCase()
    {
        _deficienciaRepository
            .Setup(x => x.GetAsync(DeficienciaConstants.DeficienciaFisica.Key))
            .ReturnsAsync(DeficienciaConstants.DeficienciaFisica);

        return new AtualizarDeficienciaCommandHandler(
            _notificationContext.Object,
            _deficienciaRepository.Object,
            _unitOfWork.Object);
    }
}