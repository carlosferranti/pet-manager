using Anima.Inscricao.Application.Config;
using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Domain.Inscricoes.Events;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Infra.Messaging._Shared.Kafka;
using Anima.Inscricao.Infra.Messaging.Publishes.Kafka.Inscricoes;
using Anima.Inscricao.Infra.Messaging.Publishes.Shared;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using Confluent.Kafka;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using Moq;

namespace Anima.Inscricao.Test.Publishes.Kafka.Inscricoes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class InscricaoCandidatoCriadoEventHandlerTests
{
    private const string TopicoConfiguracao = "topico-configuracao";

    private readonly IMarcaRepository _marcaRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly IFichaRepository _fichaRepository;
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;
    private readonly IEscolaRepository _escolaRepository;
    private readonly Mock<ILogger<InscricaoCandidatoCriadoEventHandler>> _loggerMock = new();
    private readonly Mock<IKafkaFactory> _kafkaFactoryMock = new();
    private readonly Mock<IProducer<string, string>> _producerMock = new();

    public InscricaoCandidatoCriadoEventHandlerTests(DatabaseFixture databaseFixture)
    {
        _marcaRepository = databaseFixture.ServiceProvider.GetRequiredService<IMarcaRepository>();
        _integracaoSistemaRepository = databaseFixture.ServiceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
        _fichaRepository = databaseFixture.ServiceProvider.GetRequiredService<IFichaRepository>();
        _etapaTemplateRepository = databaseFixture.ServiceProvider.GetRequiredService<IEtapaTemplateRepository>();
        _escolaRepository = databaseFixture.ServiceProvider.GetRequiredService<IEscolaRepository>();
    }

    [Fact]
    public async Task DevePublicarEventoCriacaoInscricao()
    {
        // Arrange
        var inscricao = InscricaoConstants.InscricaoCorretaComEtapa;
        InscricaoCandidatoCriadoEvent notification = new(inscricao);

        // Act
        var handler = ObterHandler();
        await handler.Handle(notification, CancellationToken.None);

        // Assert
        _producerMock.Verify(x => x.ProduceAsync(TopicoConfiguracao, It.IsAny<Message<string, string>>(), CancellationToken.None));
    }

    private InscricaoCandidatoCriadoEventHandler ObterHandler()
    {
        KafkaConfig kafkaConfig = new()
        {
            Topics = new()
            {
                CriacaoInscricao = TopicoConfiguracao,
            },
        };

        _kafkaFactoryMock
            .Setup(x => x.CreateProducer<string, string>())
            .Returns(_producerMock.Object);

        return new InscricaoCandidatoCriadoEventHandler(
            _marcaRepository,
            _integracaoSistemaRepository,
            _fichaRepository,
            _etapaTemplateRepository,
            _escolaRepository,
            _loggerMock.Object, 
            Options.Create(kafkaConfig), 
            _kafkaFactoryMock.Object);
    }
}
