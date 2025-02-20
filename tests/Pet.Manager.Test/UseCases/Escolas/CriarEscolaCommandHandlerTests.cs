using System.Linq.Expressions;

using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.UseCases.Escolas.CriarEscola;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Domain.Escolas.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Infra.Data.Postgress.Repositories;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Escolas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarEscolaCommandHandlerTests 
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<ICidadeRepository> _cidadeRepository = new();
    private readonly Mock<IEscolaRepository> _escolaRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();
    private readonly Mock<IIntegracaoSistemaRepository> _integracaoSistemaRepository = new();

    public CriarEscolaCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveInserirEscolaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var result = await useCase.Handle(new CriarEscolaCommand
        {
            Nome = "Escola Teste",
            CodigoInep = 987,
            CidadeKey = Guid.NewGuid(),
        }, default);

        // Assert
        _escolaRepository.Verify(x => x.InsertAsync(It.IsAny<Escola>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(default), Times.Once);
        result.Should().NotBeNull();
    }

    [Fact]
    public async Task NaoDeveInserirQuandoCodigoInepJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var result = await useCase.Handle(new CriarEscolaCommand
        {
            Nome = EscolaConstants.ColegioRecife.Nome,
            CidadeKey = EnderecoConstants.CidadeSaoPaulo.Key,
        }, default);

        // Assert
        _escolaRepository.Verify(x => x.InsertAsync(It.IsAny<Escola>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(default), Times.Never);
        result.Should().BeNull();
    }

    [Fact]
    public async Task DeveInserirEscolaComSucessoComIntegracaoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();
        var command = new CriarEscolaCommand
        {
            Nome = "Escola Teste",
            CodigoInep = 987,
            CidadeKey = Guid.NewGuid(),
            Integracao = new SistemaIntegracaoDto()
            {
                CodigoOrigem = "123",
                NomeSistema = "Sistema Teste"
            }
        };

        // Act
        var result = await useCase.Handle(command, default);

        // Assert
        _escolaRepository.Verify(x => x.InsertAsync(It.Is<Escola>(x =>
            x.Nome == command.Nome &&
            x.IntegracaoEscola!.IntegracaoSistemaId == IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Id &&
            x.IntegracaoEscola!.CodigoOrigem == command.Integracao.CodigoOrigem)), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
        result.Should().NotBeNull();
    }

    private CriarEscolaCommandHandler ObterUseCase()
    {
        _integracaoSistemaRepository
            .Setup(x => x.GetAsync(It.IsAny<Expression<Func<IntegracaoSistema, bool>>>(), It.IsAny<bool>()))
            .ReturnsAsync(IntegracaoSistemaConstants.IntegracaoSistemaPortfolio);

        _cidadeRepository
            .Setup(x => x.GetAsync(It.IsAny<Guid>()))
            .ReturnsAsync(EnderecoConstants.CidadeCampinas);

        return new CriarEscolaCommandHandler(
            _notificationContext.Object,
            _cidadeRepository.Object,
            _escolaRepository.Object,
            _unitOfWork.Object,
            _integracaoSistemaRepository.Object);
    }
}
