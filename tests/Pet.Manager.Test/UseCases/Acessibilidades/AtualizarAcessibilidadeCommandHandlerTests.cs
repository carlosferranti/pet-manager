using Anima.Inscricao.Application.UseCases.Acessibilidades.AtualizarAcessibilidade;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Acessibilidades;
using Anima.Inscricao.Domain.Acessibilidades.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Acessibilidades;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarAcessibilidadeCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();
    private readonly Mock<IAcessibilidadeRepository> _acessibilidadeRepository = new();

    public AtualizarAcessibilidadeCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveAtualizarAcessibilidadeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarAcessibilidadeCommand
        {
            Key = AcessibilidadeConstants.ProvaBraile.Key,
            Nome = "Sala para lactantes",
        }, default);

        // Assert
        _acessibilidadeRepository.Verify(x => x.Update(It.IsAny<Acessibilidade>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveAtualizarQuandoNomeJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarAcessibilidadeCommand
        {
            Key = AcessibilidadeConstants.ProvaBraile.Key,
            Nome = AcessibilidadeConstants.InterpreterDeLibras.Nome,
        }, default);

        // Assert
        _acessibilidadeRepository.Verify(x => x.Update(It.IsAny<Acessibilidade>()), Times.Never);
    }

    private AtualizarAcessibilidadeCommandHandler ObterUseCase()
    {
        _acessibilidadeRepository.Setup(x => x.GetAsync(AcessibilidadeConstants.ProvaBraile.Key))
            .ReturnsAsync(AcessibilidadeConstants.ProvaBraile);

        return new AtualizarAcessibilidadeCommandHandler(
            _notificationContext.Object,
            _acessibilidadeRepository.Object,
            _unitOfWork.Object);
    }
}
