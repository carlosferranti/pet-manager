using Anima.Inscricao.Application.UseCases.Marcas.AtualizarMarca;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.Marcas.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Marcas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarMarcaCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IMarcaRepository> _marcaRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public AtualizarMarcaCommandHandlerTests()
    {
        new ServiceExtensions()
           .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveAtualizarMarcaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarMarcaCommand
        {
            Key = MarcaConstants.UnaLive.Key,
            Nome = "Unibh",
        }, default);

        // Assert
        _marcaRepository.Verify(x => x.Update(It.IsAny<Marca>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveAtualizarQuandoNomeJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarMarcaCommand
        {
            Key = MarcaConstants.UnaLive.Key,
            Nome = MarcaConstants.UnaLive.Nome,
            Sigla = MarcaConstants.UnaLive.Sigla
        }, default);

        // Assert
        _marcaRepository.Verify(x => x.InsertAsync(It.IsAny<Marca>()), Times.Never);
    }

    private AtualizarMarcaCommandHandler ObterUseCase()
    {
        _marcaRepository.Setup(m => m.GetAsync(MarcaConstants.UnaLive.Key))
            .ReturnsAsync(MarcaConstants.Unibh);

        return new(
           _notificationContext.Object,
           _marcaRepository.Object,
           _unitOfWork.Object);
    }
}
