using Anima.Inscricao.Application.UseCases.Modalidades.RemoverModalidade;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.Modalidades.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Modalidades;

public class RemoverModalidadeCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IModalidadeRepository> _modalidadeRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverModalidadeCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverModalidadeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverModalidadeCommand()
        {
            Key = ModalidadeConstants.ModalidadePresencial.Key,
        }, default);

        // Assert
        _modalidadeRepository.Verify(x => x.Delete(It.IsAny<Modalidade>()), Times.Once);
    }

    private RemoverModalidadeCommandHandler ObterUseCase()
    {
        _modalidadeRepository
            .Setup(x => x.GetAsync(ModalidadeConstants.ModalidadePresencial.Key))
            .ReturnsAsync(ModalidadeConstants.ModalidadePresencial);

        return new(
                   _notificationContext.Object,
                   _modalidadeRepository.Object,
                   _unitOfWork.Object);
    }
}
