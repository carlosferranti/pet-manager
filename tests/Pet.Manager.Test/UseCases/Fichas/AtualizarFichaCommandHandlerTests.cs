using Anima.Inscricao.Application.UseCases.Fichas.AtualizarFicha;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campos;
using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Fichas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarFichaCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IFichaRepository> _fichaRepository = new();
    private readonly Mock<IEtapaTemplateRepository> _etapaTemplateRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();
    private readonly Mock<ICampoRepository> _campoRepository = new();

    public AtualizarFichaCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveAtualizarFichaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarFichaCommand
        {
            Key = FichaConstants.FichaB.Key,
            Nome = "Ficha atualizada",
        }, default);

        // Assert
        _fichaRepository.Verify(x => x.Update(It.IsAny<Ficha>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveAtualizarQuandoFichaJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarFichaCommand
        {
            Key = FichaConstants.FichaB.Key,
            Nome = FichaConstants.FichaPadrao.Nome,
            Descricao = FichaConstants.FichaPadrao.Descricao,
            Padrao = FichaConstants.FichaPadrao.Padrao,
        }, default);

        // Assert
        _fichaRepository.Verify(x => x.InsertAsync(It.IsAny<Ficha>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    private AtualizarFichaCommandHandler ObterUseCase()
    {
        _fichaRepository
            .Setup(x => x.GetAsync(FichaConstants.FichaB.Key))
            .ReturnsAsync(FichaConstants.FichaB);

        return new(
            _fichaRepository.Object,
            _etapaTemplateRepository.Object,
            _unitOfWork.Object,
            _notificationContext.Object,
            _campoRepository.Object);
    }
}