using Anima.Inscricao.Application.Config;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.FormasEntrada.Entities;
using Anima.Inscricao.Domain.Inscricoes.Entities;
using Anima.Inscricao.Domain.Inscricoes.Events;
using Anima.Inscricao.Infra.Messaging._Shared.Kafka;
using Anima.Inscricao.Infra.Messaging.Publishes.Kafka.Inscricoes;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;
using Anima.Inscricoes.Domain.Inscricoes;
using Confluent.Kafka;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using MockQueryable.Moq;

using Moq;

namespace Anima.Inscricao.Test.Publishes.Kafka.Inscricoes;

public class DocumentacaoInscricaoCriadaEventHandlerTests
{
    private const string Topico = "topico";

    private readonly Mock<ILogger<DocumentacaoInscricaoCriadaEventHandler>> _loggerMock = new();
    private readonly Mock<IKafkaFactory> _kafkaFactoryMock = new();
    private readonly Mock<IProducer<string, string>> _producerMock = new();
    private readonly Mock<IInscricaoRepository> _inscricaoRepositoryMock = new();
    private readonly Mock<IFormaEntradaRepository> _formaEntradaRepositoryMock = new();

    public DocumentacaoInscricaoCriadaEventHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DevePublicarEventoDeAtualizacaoDaInscricaoComDocumentacaoAsync()
    {
        // Arrange
        var evento = new DocumentacaoInscricaoCriadaEvent(
            new InscricaoCandidatoId(1),
            InscricaoConstants.InscricaoCorreta.Key,
            InscricaoDocumentacaoConstants.DocumentacaoHistoricoEscolarS3.Key,
            null,
            InscricaoDocumentacaoConstants.DocumentacaoHistoricoEscolarS3.Tipo,
            InscricaoDocumentacaoConstants.DocumentacaoHistoricoEscolarS3.Arquivo);

        // Act
        var handler = ObterHandler();
        await handler.Handle(evento, CancellationToken.None);

        // Assert
        _producerMock.Verify(
           x => x.ProduceAsync(
               Topico,
               It.IsAny<Message<string, string>>(),
               CancellationToken.None),
           Times.Once);

        _producerMock.Verify(x => x.Flush(CancellationToken.None), Times.Once);
    }

    private DocumentacaoInscricaoCriadaEventHandler ObterHandler()
    {
        KafkaConfig kafkaConfig = new()
        {
            Topics = new()
            {
                AtualizacaoInscricao = Topico,
            },
        };

        _kafkaFactoryMock
            .Setup(x => x.CreateProducer<string, string>())
            .Returns(_producerMock.Object);

        _inscricaoRepositoryMock
            .Setup(x => x.ObterMarcaInscricaoAsync(It.IsAny<InscricaoCandidatoId>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(MarcaConstants.Una);

        _inscricaoRepositoryMock
           .Setup(c => c.GetQueryable())
           .Returns(new List<InscricaoCandidato>() { InscricaoConstants.InscricaoCorreta }.AsQueryable().BuildMock());

        _formaEntradaRepositoryMock
          .Setup(c => c.GetQueryable())
          .Returns(new List<FormaEntrada>() { FormaEntradaConstants.FormaEntradaVestibular }.AsQueryable().BuildMock());

        return new(
            _loggerMock.Object,
            _kafkaFactoryMock.Object,
             Options.Create(kafkaConfig),
            _inscricaoRepositoryMock.Object,
            _formaEntradaRepositoryMock.Object);
    }
}