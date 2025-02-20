using Anima.Inscricao.Application.UseCases.Deficiencias.RemoverDeficiencia;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Deficiencias;
using Anima.Inscricao.Domain.Deficiencias.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Deficiencias;

public class RemoverDeficienciaCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IDeficienciaRepository> _deficienciaRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverDeficienciaCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverDeficienciaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverDeficienciaCommand()
        {
            Key = DeficienciaConstants.Cegueira.Key,
        }, default);

        // Assert
        _deficienciaRepository.Verify(x => x.Delete(It.IsAny<Deficiencia>()), Times.Once);
    }

    private RemoverDeficienciaCommandHandler ObterUseCase()
    {
        _deficienciaRepository
            .Setup(x => x.GetAsync(DeficienciaConstants.Cegueira.Key))
            .ReturnsAsync(DeficienciaConstants.Cegueira);

        return new(
                   _notificationContext.Object,
                   _deficienciaRepository.Object,
                   _unitOfWork.Object);
    }
}
