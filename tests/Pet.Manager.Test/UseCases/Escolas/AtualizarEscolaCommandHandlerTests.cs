using Anima.Inscricao.Application.UseCases.Escolas.AtualizarEscola;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Domain.Escolas.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Escolas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarEscolaCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<ICidadeRepository> _cidadeRepository = new();
    private readonly Mock<IEscolaRepository> _escolaRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public AtualizarEscolaCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveAtualizarEscolaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarEscolaCommand
        {
            Key = EscolaConstants.ColegioVitoria.Key,
            Nome = "Escola Municipal de São Paulo",
            CodigoInep = 12345678,
            CidadeKey = EnderecoConstants.CidadeSaoPaulo.Key,
        }, default);

        // Assert
        _escolaRepository.Verify(x => x.Update(It.IsAny<Escola>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveAtualizarQuandoNomeJaExistir()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarEscolaCommand
        {
            Key = EscolaConstants.ColegioVitoria.Key,
            Nome = EscolaConstants.IFSP.Nome,
            CodigoInep = EscolaConstants.IFSP.CodigoInep,
            CidadeKey = EnderecoConstants.CidadeSaoPaulo.Key,
        }, default);

        // Assert
        _escolaRepository.Verify(x => x.Update(It.IsAny<Escola>()), Times.Never);
    }

    private AtualizarEscolaCommandHandler ObterUseCase()
    {
        _cidadeRepository.Setup(x => x.GetAsync(It.IsAny<Guid>()))
            .ReturnsAsync(EnderecoConstants.CidadeSaoPaulo);

        _escolaRepository.Setup(x => x.GetAsync(EscolaConstants.ColegioVitoria.Key))
            .ReturnsAsync(EscolaConstants.ColegioVitoria);

        return new(
            _notificationContext.Object,
            _cidadeRepository.Object,
            _escolaRepository.Object,
            _unitOfWork.Object);
    }
}
