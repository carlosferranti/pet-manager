using Anima.Inscricao.Application.UseCases.Escolas.RemoverEscola;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Domain.Escolas.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Escolas;

public class RemoverEscolaCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IEscolaRepository> _escolaRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverEscolaCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverEscolaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverEscolaCommand()
        {
            Key = EscolaConstants.IFSP.Key,
        }, default);

        // Assert
        _escolaRepository.Verify(x => x.Delete(It.IsAny<Escola>()), Times.Once);
    }

    private RemoverEscolaCommandHandler ObterUseCase()
    {
        _escolaRepository
            .Setup(x => x.GetAsync(EscolaConstants.IFSP.Key))
            .ReturnsAsync(EscolaConstants.IFSP);

        return new(
            _escolaRepository.Object, 
            _notificationContext.Object,
            _unitOfWork.Object);
    }
}
