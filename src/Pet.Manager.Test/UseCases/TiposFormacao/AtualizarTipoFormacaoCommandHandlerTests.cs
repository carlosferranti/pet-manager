using Anima.Inscricao.Application.UseCases.TiposFormacao.AtualizarTipoFormacao;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.TiposFormacao;
using Anima.Inscricao.Domain.TiposFormacao.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.TiposFormacao;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarTipoFormacaoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<ITipoFormacaoRepository> _tipoFormacaoRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public AtualizarTipoFormacaoCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveAtualizarTipoFormacaoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarTipoFormacaoCommand
        {
            Key = TipoFormacaoConstants.TipoFormacaoPos.Key,
            Nome = "Pós atualizado",
        }, default);

        // Assert
        _tipoFormacaoRepository.Verify(x => x.Update(It.IsAny<TipoFormacao>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveAtualizarQuandoNomeJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarTipoFormacaoCommand
        {
            Key = TipoFormacaoConstants.TipoFormacaoPos.Key,
            Nome = TipoFormacaoConstants.TipoFormacaoGraduacao.Nome,
        }, default);

        // Assert
        _tipoFormacaoRepository.Verify(x => x.InsertAsync(It.IsAny<TipoFormacao>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    private AtualizarTipoFormacaoCommandHandler ObterUseCase()
    {
        _tipoFormacaoRepository
            .Setup(x => x.GetAsync(TipoFormacaoConstants.TipoFormacaoPos.Key))
            .ReturnsAsync(TipoFormacaoConstants.TipoFormacaoPos);

        return new(
            _notificationContext.Object,
            _tipoFormacaoRepository.Object,
            _unitOfWork.Object);
    }
}
