using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Test.Extensions;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Domain.Ofertas.Entities;
using Anima.Inscricao.Application.UseCases.Ofertas.RemoverOferta;

using Moq;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Ofertas;

public class RemoverOfertaCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IOfertaRepository> _ofertaRepositoryMock = new();
    private readonly Mock<IUnitOfWork> _unitOfWorkMock = new();

    public RemoverOfertaCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverOfertaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverOfertaCommand()
        {
            Key = OfertaConstants.OfertaTeste1.Key,
        }, default);

        // Assert
        _ofertaRepositoryMock.Verify(x => x.Delete(It.IsAny<Oferta>()), Times.Once);
    }

    private RemoverOfertaCommandHandler ObterUseCase()
    {
        _ofertaRepositoryMock
         .Setup(x => x.GetAsync(OfertaConstants.OfertaTeste1.Key))
         .ReturnsAsync(OfertaConstants.OfertaTeste1);

        return new(_notificationContextMock.Object,
             _ofertaRepositoryMock.Object,
            _unitOfWorkMock.Object);
    }
}
