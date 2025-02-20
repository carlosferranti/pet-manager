using Anima.Inscricao.Application.UseCases.Etapas.AtualizarEtapaTemplate;
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
public class AtualizarEtapaTemplateCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IEtapaTemplateRepository> _etapaTemplateRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public AtualizarEtapaTemplateCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveAtualizarEtapaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarEtapaTemplateCommand
        {
            Key = EtapaConstants.EtapaDadosContato.Key,
            Nome = "Etapa atualizada",
            Descricao = "Descrição atualizada",
            NomeArquivo = "NomeArquivo atualizado",
        }, default);

        // Assert
        _etapaTemplateRepository.Verify(x => x.Update(It.IsAny<EtapaTemplate>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveAtualizarQuandoNomeJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarEtapaTemplateCommand
        {
            Key = EtapaConstants.EtapaDadosContato.Key,
            Nome = EtapaConstants.EtapaDadosPessoais.Nome,
            Descricao = EtapaConstants.EtapaDadosPessoais.Descricao,
            NomeArquivo = EtapaConstants.EtapaDadosPessoais.NomeArquivo,
        }, default);

        // Assert
        _etapaTemplateRepository.Verify(x => x.InsertAsync(It.IsAny<EtapaTemplate>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    private AtualizarEtapaTemplateCommandHandler ObterUseCase()
    {
        _etapaTemplateRepository
            .Setup(x => x.GetAsync(EtapaConstants.EtapaDadosContato.Key))
            .ReturnsAsync(EtapaConstants.EtapaDadosContato);

        return new(
            _notificationContext.Object,
            _etapaTemplateRepository.Object,
            _unitOfWork.Object);
    }
}