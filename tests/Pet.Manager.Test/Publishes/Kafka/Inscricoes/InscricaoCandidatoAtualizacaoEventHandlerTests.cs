using Anima.Inscricao.Application.Config;
using Anima.Inscricao.Domain.Inscricoes.Events;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Infra.Messaging._Shared.Kafka;
using Anima.Inscricao.Infra.Messaging.Publishes.Kafka.Inscricoes;
using Anima.Inscricao.Infra.Messaging.Publishes.Shared;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricoes.Domain.Inscricoes;
using Confluent.Kafka;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
using Anima.Inscricao.Test._Shared.Tests;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;

using Anima.Inscricao.Application.UseCases.Inscricoes.AtualizarInscricaoCandidato;

using static Anima.Inscricao.Application.UseCases.Inscricoes.AtualizarInscricaoCandidato.AtualizarInscricaoCandidatoCommand;

using Anima.Inscricao.Application.Mappers;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Turnos;
using Anima.Inscricao.Infra.Data.Postgress.Repositories;
using Anima.Inscricao.Domain.Cupons;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Domain.FormasEntrada;

namespace Anima.Inscricao.Test.Publishes.Kafka.Inscricoes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class InscricaoCandidatoAtualizacaoEventHandlerTests
{
    private const string TopicoAtualizacaoInscricao = "topico-atualizacao-inscricao";

    private readonly Mock<IInscricaoRepository> _inscricaoRepository = new();
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly IMarcaRepository _marcaRepository;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IProdutoRepository _produtoRepository;
    private readonly ICampusRepository _campusRepository;
    private readonly ICursoRepository _cursoRepository;
    private readonly ITurnoRepository _turnoRepository;
    private readonly ICidadeRepository _cidadeRepository;
    private readonly ICupomRepository _cupomRepository;
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IConcursoRepository _concursoRepository;
    private readonly IEstadoRepository _estadoRepository;
    private readonly IPaisRepository _paisRepository;
    private readonly IEscolaRepository _escolaRepository;
    private readonly Mock<ILogger<InscricaoCandidatoAtualizacaoEventHandler>> _loggerMock = new();
    private readonly IFichaRepository _fichaRepository;
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;
    private readonly Mock<IKafkaFactory> _kafkaFactoryMock = new();
    private readonly Mock<IProducer<string, string>> _producerMock = new();
    private readonly IFormaEntradaRepository _formaEntradaRepository;

    public InscricaoCandidatoAtualizacaoEventHandlerTests(DatabaseFixture databaseFixture)
    {
        _integracaoSistemaRepository = databaseFixture.ServiceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
        _marcaRepository = databaseFixture.ServiceProvider.GetRequiredService<IMarcaRepository>();
        _ofertaRepository = databaseFixture.ServiceProvider.GetRequiredService<IOfertaRepository>();
        _produtoRepository = databaseFixture.ServiceProvider.GetRequiredService<IProdutoRepository>();
        _campusRepository = databaseFixture.ServiceProvider.GetRequiredService<ICampusRepository>();
        _cursoRepository = databaseFixture.ServiceProvider.GetRequiredService<ICursoRepository>();
        _turnoRepository = databaseFixture.ServiceProvider.GetRequiredService<ITurnoRepository>();
        _cidadeRepository = databaseFixture.ServiceProvider.GetRequiredService<ICidadeRepository>();
        _cupomRepository = databaseFixture.ServiceProvider.GetRequiredService<ICupomRepository>();
        _ofertaConcursoRepository = databaseFixture.ServiceProvider.GetRequiredService<IOfertaConcursoRepository>();
        _concursoRepository = databaseFixture.ServiceProvider.GetRequiredService<IConcursoRepository>();
        _estadoRepository = databaseFixture.ServiceProvider.GetRequiredService<IEstadoRepository>();
        _paisRepository = databaseFixture.ServiceProvider.GetRequiredService<IPaisRepository>();
        _escolaRepository = databaseFixture.ServiceProvider.GetRequiredService<IEscolaRepository>();
        _fichaRepository = databaseFixture.ServiceProvider.GetRequiredService<IFichaRepository>();
        _etapaTemplateRepository = databaseFixture.ServiceProvider.GetRequiredService<IEtapaTemplateRepository>();
        _formaEntradaRepository = databaseFixture.ServiceProvider.GetRequiredService<IFormaEntradaRepository>();
    }

    [Fact]
    public async Task DevePublicarEventoAtualizacaoInscricao()
    {
        // Arrange
        var inscricao = InscricaoConstants.InscricaoCorreta;
        var atualizarInscricao = new AtualizarInscricaoCandidatoCommand()
        {
            InscricaoKey = inscricao.Key,
            InfosOferta = new AtualizarInfosOfertaCommand()
            {
                OfertaConcursoKey = Guid.Parse("64626609-a2f7-4b10-93cf-49ff8e7d7c33"),
                OfertaKey = Guid.Parse("cc990df5-711c-413e-843f-cd8060ab574c")
            },
            InfosPessoais = new AtualizarInfosPessoaisCommand()
            {
                Nome = "Romário de Souza Faria",
                DataNascimento = new DateTime(1966, 1, 29),
                Sexo = 1, 
                NecessidadeEspecial = false,
                NomeSocial = null 
            },
            InfosContato = new List<AtualizarInfosContatoCommand>()
            {
                new AtualizarInfosContatoCommand()
                {
                    Valor = "3198989898"    
                }
            }
        };
        var evento = new InfoInscricaoCandidatoAtualizadaEvent<AtualizarInscricaoCandidatoCommand>(inscricao, atualizarInscricao);

        // Act
        var handler = ObterHandler();
        await handler.Handle(evento, CancellationToken.None);

        // Assert
        _producerMock.Verify(
           x => x.ProduceAsync(
               TopicoAtualizacaoInscricao,
               It.IsAny<Message<string, string>>(),
               CancellationToken.None),
           Times.Once);

        _producerMock.Verify(x => x.Flush(CancellationToken.None), Times.Once);
    }

    private InscricaoCandidatoAtualizacaoEventHandler ObterHandler()
    {
        KafkaConfig kafkaConfig = new()
        {
            Topics = new()
            {
                AtualizacaoInscricao = TopicoAtualizacaoInscricao,
            },
        };

        _kafkaFactoryMock
            .Setup(x => x.CreateProducer<string, string>())
            .Returns(_producerMock.Object);

        var mapperConfiguration = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new InfoInscricaoCandidatoAtualizacaoEventoMapper());
        });

        var mapper = new Mapper(mapperConfiguration);

        return new InscricaoCandidatoAtualizacaoEventHandler(
            _loggerMock.Object,
            _kafkaFactoryMock.Object,
            Options.Create(kafkaConfig),
            _inscricaoRepository.Object,
            _integracaoSistemaRepository,
            _marcaRepository,
            _ofertaRepository,
            _produtoRepository,
            _campusRepository,
            _cursoRepository,
            _turnoRepository,
            _cidadeRepository,
            _cupomRepository,
            _ofertaConcursoRepository,
            _concursoRepository,
            _estadoRepository,
            _paisRepository,
            _escolaRepository,
            _fichaRepository,
            _etapaTemplateRepository,
            mapper,
            _formaEntradaRepository);
    }
}

