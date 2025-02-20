using Anima.Inscricao.Application.DTOs.Enem;
using Anima.Inscricao.Application.Interfaces.Services;
using Anima.Inscricao.Domain.Inscricoes.Enums;
using Anima.Inscricao.Domain.Inscricoes.Events;
using Anima.Inscricao.Infra.Messaging.Publishes.Http.Inscricoes;

using Moq;

namespace Anima.Inscricao.Test.Publishes.Http;

public class SolicitaClassificacaoEnemEventHandlerTests
{
    private readonly Mock<IEnemService> _enemServiceMock = new();

    [Fact]
    public async Task DeveSolicitarClassificacaoEnemQuandoDocumentoInscricaoCriadoForCpf()
    {
        // Arrange
        var handler = ObterHandler();
        var notification = new DocumentoInscricaoCriadoEvent(Guid.NewGuid(), Guid.NewGuid(), "93971433014", "939.714.330-14", TipoDocumentoInscricao.Cpf);

        // Act
        await handler.Handle(notification, CancellationToken.None);

        // Assert
        _enemServiceMock.Verify(x => x.SolicitarClassificacaoEnemAsync(It.IsAny<SolicitarClassificacaoRequestDto>()), Times.Once);
    }

    [Fact]
    public async Task NaoDeveSolicitarClassificacaoEnemQuandoDocumentoInscricaoCriadoForDiferenteDeCpf()
    {
        // Arrange
        var handler = ObterHandler();
        var notification = new DocumentoInscricaoCriadoEvent(Guid.NewGuid(), Guid.NewGuid(), "1232132", "12.321-32", TipoDocumentoInscricao.Rg);

        // Act
        await handler.Handle(notification, CancellationToken.None);

        // Assert
        _enemServiceMock.Verify(x => x.SolicitarClassificacaoEnemAsync(It.IsAny<SolicitarClassificacaoRequestDto>()), Times.Never);
    }

    [Fact]
    public async Task NaoDeveSolicitarClassificacaoEnemQuandoDocumentoInscricaoCriadoForVazio()
    {
        // Arrange
        var handler = ObterHandler();
        var notification = new DocumentoInscricaoCriadoEvent(Guid.NewGuid(), Guid.NewGuid(), "", "", TipoDocumentoInscricao.Cpf);

        // Act
        await handler.Handle(notification, CancellationToken.None);

        // Assert
        _enemServiceMock.Verify(x => x.SolicitarClassificacaoEnemAsync(It.IsAny<SolicitarClassificacaoRequestDto>()), Times.Never);
    }

    private SolicitaClassificacaoEnemEventHandler ObterHandler()
    {
        return new(_enemServiceMock.Object);
    }
}