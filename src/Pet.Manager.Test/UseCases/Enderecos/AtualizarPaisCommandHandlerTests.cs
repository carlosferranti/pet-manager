using Anima.Inscricao.Application.UseCases.Enderecos.AtualizarPais;
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
public class AtualizarPaisCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IPaisRepository> _paisRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public AtualizarPaisCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveAtualizarPaisComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarPaisCommand
        {
            Key = EnderecoConstants.PaisArgentina.Key,
            Nome = "Argentina alterado",
            Sigla = "ARG",
            SiglaAbreviada = "AR",
            Tipo = "A"
        }, default);

        // Assert
        _paisRepository.Verify(x => x.Update(It.IsAny<Pais>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveAtualizarQuandoInformacoesJaExistemAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarPaisCommand
        {
            Key = EnderecoConstants.PaisArgentina.Key,
            Nome = EnderecoConstants.PaisBrasil.Nome,
            Sigla = EnderecoConstants.PaisBrasil.Sigla,
            SiglaAbreviada = EnderecoConstants.PaisBrasil.SiglaAbreviada,
            Tipo = EnderecoConstants.PaisBrasil.Tipo
        }, default);

        // Assert
        _paisRepository.Verify(x => x.InsertAsync(It.IsAny<Pais>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    private AtualizarPaisCommandHandler ObterUseCase()
    {
        _paisRepository
            .Setup(x => x.GetAsync(EnderecoConstants.PaisArgentina.Key))
            .ReturnsAsync(EnderecoConstants.PaisArgentina);

        return new(
            _notificationContext.Object,
            _paisRepository.Object,
            _unitOfWork.Object);
    }
}
