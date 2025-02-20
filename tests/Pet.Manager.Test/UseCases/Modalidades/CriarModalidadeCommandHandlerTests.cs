using System.Linq.Expressions;

using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.UseCases.Modalidades.CriarModalidade;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.Modalidades.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Modalidades;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarModalidadeCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IModalidadeRepository> _modalidadeRepository = new();
    private readonly Mock<IIntegracaoSistemaRepository> _sistemasIntegracaoRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public CriarModalidadeCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveInserirModalidadeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarModalidadeCommand
        {
            Nome = "Ead",
        }, default);

        // Assert
        _modalidadeRepository.Verify(x => x.InsertAsync(It.IsAny<Modalidade>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveInserirQuandoNomeJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarModalidadeCommand
        {
            Nome = ModalidadeConstants.ModalidadePresencial.Nome,
        }, default);

        // Assert
        _modalidadeRepository.Verify(x => x.InsertAsync(It.IsAny<Modalidade>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    [Fact]
    public async Task DeveInserirModalidadeComIntegracaoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();
        var command = new CriarModalidadeCommand
        {
            Nome = "Hibrido",
            Integracao = new SistemaIntegracaoDto()
            {
                CodigoOrigem = "123",
                NomeSistema = IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Nome,
            }
        };

        // Act
        await useCase.Handle(command, default);

        // Assert
        _modalidadeRepository.Verify(x => x.InsertAsync(It.Is<Modalidade>(x => 
            x.Nome == command.Nome &&
            x.IntegracaoModalidade!.IntegracaoSistemaId == IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Id &&
            x.IntegracaoModalidade!.CodigoOrigem == command.Integracao.CodigoOrigem)), Times.Once);
        
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    private CriarModalidadeCommandHandler ObterUseCase()
    {
        _sistemasIntegracaoRepository
            .Setup(x => x.GetAsync(It.IsAny<Expression<Func<IntegracaoSistema, bool>>>(), It.IsAny<bool>()))
            .ReturnsAsync(IntegracaoSistemaConstants.IntegracaoSistemaPortfolio);

        return new(
            _notificationContext.Object,
            _modalidadeRepository.Object,
            _sistemasIntegracaoRepository.Object,
            _unitOfWork.Object);
    }
}
