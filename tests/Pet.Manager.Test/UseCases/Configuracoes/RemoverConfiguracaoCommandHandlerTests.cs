using Anima.Inscricao.Application.UseCases.Configuracoes.RemoverConfiguracao;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Configuracoes;
using Anima.Inscricao.Domain.Configuracoes.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Configuracoes;

public class RemoverConfiguracaoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IConfiguracaoRepository> _configuracaoRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverConfiguracaoCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverConfiguracaoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverConfiguracaoCommand()
        {
            Key = ConfiguracaoConstants.ConfiguracaoPadrao.Key,
        }, default);

        // Assert
        _configuracaoRepository.Verify(x => x.Delete(It.IsAny<Configuracao>()), Times.Once);
    }

    private RemoverConfiguracaoCommandHandler ObterUseCase()
    {
        _configuracaoRepository.Setup(x => x.GetAsync(ConfiguracaoConstants.ConfiguracaoPadrao.Key))
            .ReturnsAsync(ConfiguracaoConstants.ConfiguracaoPadrao);

        return new RemoverConfiguracaoCommandHandler(
            _notificationContext.Object, 
            _configuracaoRepository.Object, 
            _unitOfWork.Object);
    }
}
    