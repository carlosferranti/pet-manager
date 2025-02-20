using Anima.Inscricao.Application.UseCases.Configuracoes.AtualizarConfiguracao;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Configuracoes;
using Anima.Inscricao.Domain.Configuracoes.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Configuracoes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarConfiguracaoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IConfiguracaoRepository> _configuracaoRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public AtualizarConfiguracaoCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveAtualizarConfiguracaoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarConfiguracaoCommand
        {
            Key = ConfiguracaoConstants.ConfiguracaoPadrao.Key,
            Valor = "Novo valor",
        }, default);

        // Assert
        _configuracaoRepository.Verify(x => x.Update(It.IsAny<Configuracao>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveAtualizarQuandoChaveGenericaJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarConfiguracaoCommand
        {
            Key = ConfiguracaoConstants.ConfiguracaoPadrao.Key,
            ChaveGenerica = ConfiguracaoConstants.ConfiguracaoPadrao3.ChaveGenerica,
        }, default);

        // Assert
        _configuracaoRepository.Verify(x => x.Update(It.IsAny<Configuracao>()), Times.Never);
    }

    private AtualizarConfiguracaoCommandHandler ObterUseCase()
    {
        _configuracaoRepository.Setup(x => x.GetAsync(ConfiguracaoConstants.ConfiguracaoPadrao.Key))
            .ReturnsAsync(ConfiguracaoConstants.ConfiguracaoPadrao);

        return new AtualizarConfiguracaoCommandHandler(
            _notificationContext.Object,
            _configuracaoRepository.Object,
            _unitOfWork.Object);
    }
}
