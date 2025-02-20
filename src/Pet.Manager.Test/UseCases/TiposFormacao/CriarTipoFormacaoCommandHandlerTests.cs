using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.UseCases.TiposFormacao.CriarTipoFormacao;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.TiposFormacao;
using Anima.Inscricao.Domain.TiposFormacao.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.TiposFormacao;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarTipoFormacaoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<ITipoFormacaoRepository> _tipoFormacaoRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public CriarTipoFormacaoCommandHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _integracaoSistemaRepository = serviceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
    }

    [Fact]
    public async Task DeveInserirTipoFormacaoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarTipoFormacaoCommand
        {
            Nome = "Técnico",
        }, default);

        // Assert
        _tipoFormacaoRepository.Verify(x => x.InsertAsync(It.IsAny<TipoFormacao>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveInserirQuandoNomeJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarTipoFormacaoCommand
        {
            Nome = TipoFormacaoConstants.TipoFormacaoGraduacao.Nome,
        }, default);

        // Assert
        _tipoFormacaoRepository.Verify(x => x.InsertAsync(It.IsAny<TipoFormacao>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    [Fact]
    public async Task DeveInserirTipoFormacaoComIntegracaoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();
        var command = new CriarTipoFormacaoCommand
        {
            Nome = "MBA",
            Integracao = new SistemaIntegracaoDto()
            {
                CodigoOrigem = "123",
                NomeSistema = IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Nome,
            }
        };

        // Act
        await useCase.Handle(command, default);

        // Assert
        _tipoFormacaoRepository.Verify(x => x.InsertAsync(It.Is<TipoFormacao>(x =>
            x.Nome == command.Nome &&
            x.IntegracaoTipoFormacao!.IntegracaoSistemaId == IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Id &&
            x.IntegracaoTipoFormacao!.CodigoOrigem == command.Integracao.CodigoOrigem)), Times.Once);

        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    private CriarTipoFormacaoCommandHandler ObterUseCase()
    {
        return new(
            _notificationContext.Object,
            _tipoFormacaoRepository.Object,
            _integracaoSistemaRepository,
            _unitOfWork.Object);
    }
}
