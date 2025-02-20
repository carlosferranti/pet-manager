using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.UseCases.Links.AtualizarLink;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Links;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Links;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarLinkCommandHandlerTests
{
    private readonly INotificationContext _notificationContext;
    private readonly ILinkRepository _linkRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public AtualizarLinkCommandHandlerTests(DatabaseFixture databaseFixture)
    {
        _notificationContext = databaseFixture.ServiceProvider.GetRequiredService<INotificationContext>();
        _linkRepository = databaseFixture.ServiceProvider.GetRequiredService<ILinkRepository>();
        _formaEntradaRepository = databaseFixture.ServiceProvider.GetRequiredService<IFormaEntradaRepository>();
    }

    [Fact]
    public async Task DeveAtualizarLinkComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarLinkCommand
        {
            Key = LinkConstants.LinkEscola.Key,
            Nome = "link escolar",
            FormasEntrada = new List<EntityKeyDto>
            {
                new EntityKeyDto
                {
                    Key = FormaEntradaConstants.FormaEntradaVestibularEscola.Key,
                },
            },
        }, default);

        // Assert
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    private AtualizarLinkCommandHandler ObterUseCase()
    {
        return new(
            _notificationContext,
            _linkRepository,
            _formaEntradaRepository,
            _unitOfWork.Object);
    }
}