using Anima.Inscricao.Application.UseCases.Configuracoes.CriarConfiguracao;
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
public class CriarConfiguracaoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IConfiguracaoRepository> _configuracaoRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public CriarConfiguracaoCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveInserirConfiguracaoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarConfiguracaoCommand
        {
            ChaveGenerica = "ChaveGenerica 1",
            Valor = "Valor 1",
        }, default);

        // Assert
        _configuracaoRepository.Verify(x => x.InsertAsync(It.IsAny<Configuracao>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveInserirQuandoChaveGenericaJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarConfiguracaoCommand
        {
            ChaveGenerica = ConfiguracaoConstants.ConfiguracaoPadrao3.ChaveGenerica,
            Valor = "Valor 1",
        }, default);

        // Assert
        _configuracaoRepository.Verify(x => x.InsertAsync(It.IsAny<Configuracao>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    private CriarConfiguracaoCommandHandler ObterUseCase()
    {
        return new CriarConfiguracaoCommandHandler(
            _notificationContext.Object,
            _configuracaoRepository.Object,
            _unitOfWork.Object);
    }
}
