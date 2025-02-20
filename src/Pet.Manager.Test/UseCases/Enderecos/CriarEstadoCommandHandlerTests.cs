using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.UseCases.Enderecos.CriarEstado;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Enderecos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarEstadoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IEstadoRepository> _estadoRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly IPaisRepository _paisRepository;

    public CriarEstadoCommandHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _integracaoSistemaRepository = serviceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
        _paisRepository = serviceProvider.GetRequiredService<IPaisRepository>();
    }

    [Fact]
    public async Task DeveInserirEstadoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarEstadoCommand
        {
            Nome = "Minas Gerais",
            Sigla = "MG",
            PaisKey = EnderecoConstants.PaisBrasil.Key,
        }, default);

        // Assert
        _estadoRepository.Verify(x => x.InsertAsync(It.IsAny<Estado>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveInserirQuandoInformacoesJaExistemAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarEstadoCommand
        {
            Nome = EnderecoConstants.EstadoSP.Nome,
            Sigla = EnderecoConstants.EstadoSP.Sigla,
            PaisKey = EnderecoConstants.PaisBrasil.Key,
        }, default);

        // Assert
        _estadoRepository.Verify(x => x.InsertAsync(It.IsAny<Estado>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    [Fact]
    public async Task DeveInserirEstadoIntegracaoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();
        var command = new CriarEstadoCommand
        {
            Nome = "Rio grande do Norte",
            Sigla = "RN",
            PaisKey = EnderecoConstants.PaisBrasil.Key,
            Integracao = new SistemaIntegracaoDto()
            {
                CodigoOrigem = "123",
                NomeSistema = IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Nome,
            }
        };

        // Act
        await useCase.Handle(command, default);

        // Assert
        _estadoRepository.Verify(x => x.InsertAsync(It.Is<Estado>(x =>
            x.Nome == command.Nome &&
            x.Sigla == command.Sigla &&
            x.IntegracaoEstado!.IntegracaoSistemaId == IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Id &&
            x.IntegracaoEstado!.CodigoOrigem == command.Integracao.CodigoOrigem)), Times.Once);

        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    private CriarEstadoCommandHandler ObterUseCase()
    {
        return new(
            _notificationContext.Object,
            _paisRepository,
            _integracaoSistemaRepository,
            _estadoRepository.Object,
            _unitOfWork.Object);
    }
}