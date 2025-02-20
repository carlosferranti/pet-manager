using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.UseCases.Links.CriarLink;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Links;
using Anima.Inscricao.Domain.Links.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Links;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarLinkCommandHandlerTests
{
    private readonly INotificationContext _notificationContext;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly Mock<IUnitOfWork> _unitOfWorkMock = new();
    private readonly Mock<ILinkRepository> _linkRepositoryMock = new();

    public CriarLinkCommandHandlerTests(DatabaseFixture databaseFixture)
    {
        _notificationContext = databaseFixture.ServiceProvider.GetRequiredService<INotificationContext>();
        _formaEntradaRepository = databaseFixture.ServiceProvider.GetRequiredService<IFormaEntradaRepository>();
    }

    [Fact]
    public async Task DeveCriarLinkComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarLinkCommand
        {
            Nome = "novo link",
            FormasEntrada = new List<EntityKeyDto>
            {
                new EntityKeyDto
                {
                    Key = FormaEntradaConstants.FormaEntradaVestibularEscola.Key,
                },
            },
        }, default);

        // Assert
        _linkRepositoryMock.Verify(x => x.InsertAsync(It.IsAny<Link>()), Times.Once);
        _unitOfWorkMock.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    private CriarLinkCommandHandler ObterUseCase()
    {
        return new(
            _notificationContext,
            _linkRepositoryMock.Object,
            _formaEntradaRepository,
            _unitOfWorkMock.Object);
    }
}