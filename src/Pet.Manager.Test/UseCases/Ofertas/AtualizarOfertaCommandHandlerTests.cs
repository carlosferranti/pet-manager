using Anima.Inscricao.Application.UseCases.Ofertas.AtualizarOferta;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Ofertas.Entities;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Ofertas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarOfertaCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IOfertaRepository> _ofertaRepositoryMock = new();
    private readonly Mock<IProdutoRepository> _produtoRepositoryMock = new();
    private readonly Mock<IIntakeRepository> _intakeRepositoryMock = new();
    private readonly Mock<IUnitOfWork> _unitOfWorkMock = new();

    public AtualizarOfertaCommandHandlerTests()
    {
        var serviceProvider = new ServiceExtensions().BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveAtualizarOfertaComSucessoAsync()
    {
        // Arrange
        var oferta = OfertaConstants.OfertaTeste1;
        var command = new AtualizarOfertaCommand
        {
            Key = oferta.Key,
            ProdutoKey = ProdutoConstants.ProdutoTeste1.Key,
            IntakeKey = IntakeConstants.IntakeSegundoSemestre.Key
        };

        _produtoRepositoryMock.Setup(x => x.GetAsync(It.IsAny<Guid>())).ReturnsAsync(ProdutoConstants.ProdutoTeste1);
        _intakeRepositoryMock.Setup(x => x.GetAsync(It.IsAny<Guid>())).ReturnsAsync(IntakeConstants.IntakePrimeiroSemestre);
        _ofertaRepositoryMock.Setup(x => x.GetAsync(It.IsAny<Guid>())).ReturnsAsync(oferta);

        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(command, CancellationToken.None);

        // Assert
        _ofertaRepositoryMock.Verify(x => x.Update(It.IsAny<Oferta>()), Times.Once);
        _unitOfWorkMock.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    private AtualizarOfertaCommandHandler ObterUseCase()
    {
        return new(_notificationContextMock.Object,
             _ofertaRepositoryMock.Object,
            _produtoRepositoryMock.Object,
            _intakeRepositoryMock.Object,
            _unitOfWorkMock.Object);
    }
}
