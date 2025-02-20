using Anima.Inscricao.Application.UseCases.Etapas.CriarEtapa;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Domain.Etapas.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Etapas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarEtapaTemplateCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IEtapaTemplateRepository> _etapaTemplateRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public CriarEtapaTemplateCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveInserirEtapaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarEtapaTemplateCommand
        {
            Nome = "Nova etapa",
            NomeArquivo = "arquivo",
            Descricao = "descricao",
        }, default);

        // Assert
        _etapaTemplateRepository.Verify(x => x.InsertAsync(It.IsAny<EtapaTemplate>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveInserirEtapaQunadoJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarEtapaTemplateCommand
        {
            Nome = EtapaConstants.EtapaDadosPessoais.Nome,
            NomeArquivo = EtapaConstants.EtapaDadosPessoais.NomeArquivo,
            Descricao = EtapaConstants.EtapaDadosPessoais.Descricao,
        }, default);

        // Assert
        _etapaTemplateRepository.Verify(x => x.InsertAsync(It.IsAny<EtapaTemplate>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    private CriarEtapaTemplateCommandHandler ObterUseCase()
    {
        return new(
            _notificationContext.Object,
            _etapaTemplateRepository.Object,
            _unitOfWork.Object);
    }
}