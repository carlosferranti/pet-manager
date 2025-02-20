using Anima.Inscricao.Application.UseCases.Modalidades.AtualizarModalidade;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.Modalidades.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Modalidades;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarModalidadeCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IModalidadeRepository> _modalidadeRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public AtualizarModalidadeCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveAtualizarModalidadeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarModalidadeCommand
        {
            Key = ModalidadeConstants.ModalidadeSemiPresencial.Key,
            Nome = "Presencial atualizado",
        }, default);

        // Assert
        _modalidadeRepository.Verify(x => x.Update(It.IsAny<Modalidade>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveAtualizarQuandoNomeJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarModalidadeCommand
        {
            Key = ModalidadeConstants.ModalidadeSemiPresencial.Key,
            Nome = ModalidadeConstants.ModalidadePresencial.Nome,
        }, default);

        // Assert
        _modalidadeRepository.Verify(x => x.InsertAsync(It.IsAny<Modalidade>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    private AtualizarModalidadeCommandHandler ObterUseCase()
    {
        _modalidadeRepository
            .Setup(x => x.GetAsync(ModalidadeConstants.ModalidadeSemiPresencial.Key))
            .ReturnsAsync(ModalidadeConstants.ModalidadeSemiPresencial);

        return new(
            _notificationContext.Object,
            _modalidadeRepository.Object,
            _unitOfWork.Object);
    }
}
