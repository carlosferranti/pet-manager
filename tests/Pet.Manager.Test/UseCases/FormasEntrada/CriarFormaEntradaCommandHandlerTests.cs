using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.UseCases.FormasEntrada.CriarFormaEntrada;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.FormasEntrada.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.FormasEntrada;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarFormaEntradaCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IFormaEntradaRepository> _formaEntradaRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public CriarFormaEntradaCommandHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _integracaoSistemaRepository = serviceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
    }

    [Fact]
    public async Task DeveInserirFormaDeEntradaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarFormaEntradaCommand
        {
            Nome = "Entrada Simplificada",
            ExibeCard = true,
        }, default);

        // Assert
        _formaEntradaRepository.Verify(x => x.InsertAsync(It.IsAny<FormaEntrada>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveInserirFormaDeEntradaQuandoNomeJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarFormaEntradaCommand
        {
            Nome = FormaEntradaConstants.FormaEntradaEnem.Nome,
            ExibeCard = true,
        }, default);

        // Assert
        _formaEntradaRepository.Verify(x => x.InsertAsync(It.IsAny<FormaEntrada>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    [Fact]
    public async Task DeveInserirFormaDeEntradaIntegracaoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();
        var command = new CriarFormaEntradaCommand
        {
            Nome = "COI",
            ExibeCard = true,
            Integracao = new List<SistemaIntegracaoDto>()
            {
                new SistemaIntegracaoDto()
                {
                    CodigoOrigem = "123",
                    NomeSistema = IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Nome,
                }
            }
        };

        // Act
        await useCase.Handle(command, default);

        // Assert
        _formaEntradaRepository.Verify(x => x.InsertAsync(It.Is<FormaEntrada>(x =>
            x.Nome == command.Nome &&
            x.IntegracoesFormaEntrada.Count() == 1)), Times.Once);

        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    private CriarFormaEntradaCommandHandler ObterUseCase()
    {
        return new(
            _notificationContext.Object,
            _formaEntradaRepository.Object,
            _integracaoSistemaRepository,
            _unitOfWork.Object);
    }
}
