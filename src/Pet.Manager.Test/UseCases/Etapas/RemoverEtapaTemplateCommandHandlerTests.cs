using Anima.Inscricao.Application.UseCases.Etapas.RemoverEtapaTemplate;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Domain.Etapas.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Etapas;

public class RemoverEtapaTemplateCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IEtapaTemplateRepository> _etapaTemplateRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverEtapaTemplateCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverEtapaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverEtapaTemplateCommand()
        {
            Key = EtapaConstants.EtapaDadosContato.Key,
        }, default);

        // Assert
        _etapaTemplateRepository.Verify(x => x.Delete(It.IsAny<EtapaTemplate>()), Times.Once);
    }

    private RemoverEtapaTemplateCommandHandler ObterUseCase()
    {
        _etapaTemplateRepository
            .Setup(x => x.GetAsync(EtapaConstants.EtapaDadosContato.Key))
            .ReturnsAsync(EtapaConstants.EtapaDadosContato);

        return new(
                   _notificationContext.Object,
                   _etapaTemplateRepository.Object,
                   _unitOfWork.Object);
    }
}
