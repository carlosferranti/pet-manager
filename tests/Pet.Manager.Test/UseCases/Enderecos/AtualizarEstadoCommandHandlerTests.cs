using Anima.Inscricao.Application.UseCases.Enderecos.AtualizarEstado;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Enderecos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarEstadoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly IPaisRepository _paisRepository;
    private readonly Mock<IEstadoRepository> _estadoRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public AtualizarEstadoCommandHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _paisRepository = serviceProvider.GetRequiredService<IPaisRepository>();
    }

    [Fact]
    public async Task DeveAtualizarEstadoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarEstadoCommand
        {
            Key = EnderecoConstants.EstadoRJ.Key,
            Nome = "R. de Janeiro",
            Sigla = "RJ",
            PaisKey = EnderecoConstants.PaisBrasil.Key,
        }, default);

        // Assert
        _estadoRepository.Verify(x => x.Update(It.IsAny<Estado>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveAtualizarQuandoInformacoesJaExistemAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarEstadoCommand
        {
            Key = EnderecoConstants.EstadoRJ.Key,
            Nome = EnderecoConstants.EstadoSP.Nome,
            Sigla = EnderecoConstants.EstadoSP.Sigla,
            PaisKey = EnderecoConstants.PaisBrasil.Key,
        }, default);

        // Assert
        _estadoRepository.Verify(x => x.InsertAsync(It.IsAny<Estado>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    private AtualizarEstadoCommandHandler ObterUseCase()
    {
        _estadoRepository
            .Setup(x => x.GetAsync(EnderecoConstants.EstadoRJ.Key))
            .ReturnsAsync(EnderecoConstants.EstadoRJ);

        return new(
            _notificationContext.Object,
            _paisRepository,
            _estadoRepository.Object,
            _unitOfWork.Object);
    }
}
