using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.UseCases.Enderecos.CriarCidade;
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
public class CriarCidadeCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<ICidadeRepository> _cidadeRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly IEstadoRepository _estadoRepository;

    public CriarCidadeCommandHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _integracaoSistemaRepository = serviceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
        _estadoRepository = serviceProvider.GetRequiredService<IEstadoRepository>();
    }

    [Fact]
    public async Task DeveInserirCidadeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarCidadeCommand
        {
            Nome = "Santos",
            EstadoKey = EnderecoConstants.EstadoSP.Key,
            CodigoMunicipio = 123,
            Ddd = 11,
        }, default);

        // Assert
        _cidadeRepository.Verify(x => x.InsertAsync(It.IsAny<Cidade>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveInserirQuandoInformacoesJaExistemAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarCidadeCommand
        {
            Nome = EnderecoConstants.CidadeSaoPaulo.Nome,
            EstadoKey = EnderecoConstants.EstadoSP.Key,
        }, default);

        // Assert
        _cidadeRepository.Verify(x => x.InsertAsync(It.IsAny<Cidade>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    [Fact]
    public async Task DeveInserirCidadeComIntegracaoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();
        var command = new CriarCidadeCommand
        {
            Nome = "Guaruja",
            EstadoKey = EnderecoConstants.EstadoSP.Key,
            Integracao = new SistemaIntegracaoDto()
            {
                CodigoOrigem = "123",
                NomeSistema = IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Nome,
            }
        };

        // Act
        await useCase.Handle(command, default);

        // Assert
        _cidadeRepository.Verify(x => x.InsertAsync(It.Is<Cidade>(x =>
            x.Nome == command.Nome &&
            x.IntegracaoCidade!.IntegracaoSistemaId == IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Id &&
            x.IntegracaoCidade!.CodigoOrigem == command.Integracao.CodigoOrigem)), Times.Once);

        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    private CriarCidadeCommandHandler ObterUseCase()
    {
        return new(
            _notificationContext.Object,
            _estadoRepository,
            _cidadeRepository.Object,
            _integracaoSistemaRepository,
            _unitOfWork.Object);
    }
}