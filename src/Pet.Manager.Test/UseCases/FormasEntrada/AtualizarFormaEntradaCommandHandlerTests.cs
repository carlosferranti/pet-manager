using Anima.Inscricao.Application.UseCases.FormasEntrada.AtualizarFormaEntrada;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.FormasEntrada.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.FormasEntrada;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarFormaEntradaCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IFormaEntradaRepository> _formaEntradaRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public AtualizarFormaEntradaCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveAtualizarFormaDeEntradaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarFormaEntradaCommand
        {
            Key = FormaEntradaConstants.FormaEntradaVestibular.Key,
            Nome = "vestibular atualizado",
            ExibeCard = true,
        }, default);

        // Assert
        _formaEntradaRepository.Verify(x => x.Update(It.IsAny<FormaEntrada>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveAtualizarQuandoNomeJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarFormaEntradaCommand
        {
            Key = FormaEntradaConstants.FormaEntradaVestibular.Key,
            Nome = FormaEntradaConstants.FormaEntradaEnem.Nome,
            ExibeCard = true,
        }, default);

        // Assert
        _formaEntradaRepository.Verify(x => x.InsertAsync(It.IsAny<FormaEntrada>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    private AtualizarFormaEntradaCommandHandler ObterUseCase()
    {
        _formaEntradaRepository
            .Setup(x => x.GetAsync(FormaEntradaConstants.FormaEntradaVestibular.Key))
            .ReturnsAsync(FormaEntradaConstants.FormaEntradaVestibular);

        return new(
            _notificationContext.Object,
            _formaEntradaRepository.Object,
            _unitOfWork.Object);
    }
}
