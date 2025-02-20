using Anima.Inscricao.Application.UseCases.TiposFormacao.RemoverTipoFormacao;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.TiposFormacao;
using Anima.Inscricao.Domain.TiposFormacao.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.TiposFormacao;

public class RemoverTipoFormacaoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<ITipoFormacaoRepository> _tipoFormacaoRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverTipoFormacaoCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverTipoFormacaoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverTipoFormacaoCommand()
        {
            Key = TipoFormacaoConstants.TipoFormacaoGraduacao.Key,
        }, default);

        // Assert
        _tipoFormacaoRepository.Verify(x => x.Delete(It.IsAny<TipoFormacao>()), Times.Once);
    }

    private RemoverTipoFormacaoCommandHandler ObterUseCase()
    {
        _tipoFormacaoRepository
            .Setup(x => x.GetAsync(TipoFormacaoConstants.TipoFormacaoGraduacao.Key))
            .ReturnsAsync(TipoFormacaoConstants.TipoFormacaoGraduacao);

        return new(
                   _notificationContext.Object,
                   _tipoFormacaoRepository.Object,
                   _unitOfWork.Object);
    }
}
