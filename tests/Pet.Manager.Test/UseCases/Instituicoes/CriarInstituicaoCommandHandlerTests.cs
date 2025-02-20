using System.Linq.Expressions;

using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.UseCases.Instituicoes.CriarInstituicao;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Instituicoes.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Instituicoes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarInstituicaoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IInstituicaoRepository> _instituicaoRepository = new();
    private readonly IMarcaRepository _marcaRepository;
    private readonly Mock<IIntegracaoSistemaRepository> _integracaoSistemaRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public CriarInstituicaoCommandHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _marcaRepository = serviceProvider.GetRequiredService<IMarcaRepository>();
    }

    [Fact]
    public async Task DeveInserirInstituicaoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarInstituicaoCommand
        {
            Nome = "Anima",
            MarcaKey = MarcaConstants.Una.Key,
        }, default);

        // Assert
        _instituicaoRepository.Verify(x => x.InsertAsync(It.IsAny<Instituicao>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveInserirQuandoNomeJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarInstituicaoCommand
        {
            Nome = InstituicaoConstants.Una.Nome,
            Sigla = InstituicaoConstants.Una.Sigla,
            MarcaKey = MarcaConstants.Una.Key,
        }, default);

        // Assert
        _instituicaoRepository.Verify(x => x.InsertAsync(It.IsAny<Instituicao>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    [Fact]
    public async Task DeveInserirInstituicaoComSucessoComIntegracaoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();
        var command = new CriarInstituicaoCommand
        {
            Nome = "Jaboatão",
            Sigla = "JAB",
            MarcaKey = MarcaConstants.UnaLive.Key,
            Integracao = new SistemaIntegracaoDto()
            {
                CodigoOrigem = "123",
                NomeSistema = IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Nome,
            },
        };

        // Act
        await useCase.Handle(command, default);

        // Assert
        _instituicaoRepository.Verify(x => x.InsertAsync(It.Is<Instituicao>(x =>
            x.Nome == command.Nome &&
            x.IntegracaoInstituicao != null &&
            x.IntegracaoInstituicao.Any(integ =>
                integ.IntegracaoSistemaId == IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Id &&
                integ.CodigoOrigem == command.Integracao.CodigoOrigem
    ))), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    private CriarInstituicaoCommandHandler ObterUseCase()
    {
        _integracaoSistemaRepository
            .Setup(x => x.GetAsync(It.IsAny<Expression<Func<IntegracaoSistema, bool>>>(), It.IsAny<bool>()))
            .ReturnsAsync(IntegracaoSistemaConstants.IntegracaoSistemaPortfolio);

        return new CriarInstituicaoCommandHandler(
            _notificationContext.Object,
            _instituicaoRepository.Object,
            _marcaRepository,
            _integracaoSistemaRepository.Object,
            _unitOfWork.Object);
    } 
}
