using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.UseCases.Enderecos.CriarPais;
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
public class CriarPaisCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IPaisRepository> _paisRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public CriarPaisCommandHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _integracaoSistemaRepository = serviceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
    }

    [Fact]
    public async Task DeveInserirPaisComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarPaisCommand
        {
            Nome = "Chile",
            Sigla = "CHL",
            SiglaAbreviada = "CL",
        }, default);

        // Assert
        _paisRepository.Verify(x => x.InsertAsync(It.IsAny<Pais>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveInserirQuandoInformacoesJaExistemAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarPaisCommand
        {
            Nome = EnderecoConstants.PaisBrasil.Nome,
            Sigla = EnderecoConstants.PaisBrasil.Sigla,
            SiglaAbreviada = EnderecoConstants.PaisBrasil.SiglaAbreviada,
        }, default);

        // Assert
        _paisRepository.Verify(x => x.InsertAsync(It.IsAny<Pais>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    [Fact]
    public async Task DeveInserirPaisIntegracaoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();
        var command = new CriarPaisCommand
        {
            Nome = "Uruguai",
            Sigla = "URY",
            SiglaAbreviada = "UY",
            Integracao = new SistemaIntegracaoDto()
            {
                CodigoOrigem = "123",
                NomeSistema = IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Nome,
            }
        };

        // Act
        await useCase.Handle(command, default);

        // Assert
        _paisRepository.Verify(x => x.InsertAsync(It.Is<Pais>(x =>
            x.Nome == command.Nome &&
            x.Sigla == command.Sigla &&
            x.SiglaAbreviada == command.SiglaAbreviada &&
            x.IntegracaoPais!.IntegracaoSistemaId == IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Id &&
            x.IntegracaoPais!.CodigoOrigem == command.Integracao.CodigoOrigem)), Times.Once);

        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    private CriarPaisCommandHandler ObterUseCase()
    {
        return new(
            _notificationContext.Object,
            _paisRepository.Object,
            _integracaoSistemaRepository,
            _unitOfWork.Object);
    }
}