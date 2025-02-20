using Anima.Inscricao.Application.Config;
using Anima.Inscricao.Domain.Acessibilidades;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Cupons;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.CursosExternos;
using Anima.Inscricao.Domain.Deficiencias;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Inscricoes.Events;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.Matriculas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Domain.Turnos;
using Anima.Inscricao.Infra.Messaging._Shared.Kafka;
using Anima.Inscricao.Infra.Messaging.Publishes.Kafka.Inscricoes;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;
using Anima.Inscricoes.Domain.Inscricoes;

using Confluent.Kafka;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using Moq;

namespace Anima.Inscricao.Test.Publishes.Kafka.Inscricoes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class InscricaoCandidatoConcluidaEventHandlerTests
{
    private const string TopicoConfiguracao = "topico-configuracao";

    private readonly Mock<ILogger<InscricaoCandidatoConcluidaEventHandler>> _loggerMock = new();
    private readonly Mock<IKafkaFactory> _kafkaFactoryMock = new();
    private readonly Mock<IProducer<string, string>> _producerMock = new();
    private readonly IAcessibilidadeRepository _acessibilidadeRepository;
    private readonly IDeficienciaRepository _deficienciaRepository;
    private readonly IEstadoRepository _estadoRepository;
    private readonly ICidadeRepository _cidadeRepository;
    private readonly IEscolaRepository _escolaRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IProdutoRepository _produtoRepository;
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly IFichaRepository _fichaRepository;
    private readonly IConcursoRepository _concursoRepository;
    private readonly ITurnoRepository _turnoRepository;
    private readonly ICampusRepository _campusRepository;
    private readonly ICursoRepository _cursoRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly IInscricaoRepository _inscricaoRepository;
    private readonly IOfertaConcursoOpcaoAcessoRepository _ofertaConcursoOpcaoAcessoRepository;
    private readonly IMarcaRepository _marcaRepository;
    private readonly ICupomRepository _cupomRepository;
    private readonly IMatriculaRepository _matriculaRepository;
    private readonly ICursoExternoRepository _cursoExternoRepository;
    private readonly INivelCursoRepository _nivelCursoRepository;
    private readonly IModalidadeRepository _modalidadeRepository;

    public InscricaoCandidatoConcluidaEventHandlerTests(DatabaseFixture databaseFixture)
    {
        _acessibilidadeRepository = databaseFixture.ServiceProvider.GetRequiredService<IAcessibilidadeRepository>();
        _deficienciaRepository = databaseFixture.ServiceProvider.GetRequiredService<IDeficienciaRepository>();
        _estadoRepository = databaseFixture.ServiceProvider.GetRequiredService<IEstadoRepository>();
        _cidadeRepository = databaseFixture.ServiceProvider.GetRequiredService<ICidadeRepository>();
        _escolaRepository = databaseFixture.ServiceProvider.GetRequiredService<IEscolaRepository>();
        _integracaoSistemaRepository = databaseFixture.ServiceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
        _ofertaConcursoRepository = databaseFixture.ServiceProvider.GetRequiredService<IOfertaConcursoRepository>();
        _ofertaRepository = databaseFixture.ServiceProvider.GetRequiredService<IOfertaRepository>();
        _produtoRepository = databaseFixture.ServiceProvider.GetRequiredService<IProdutoRepository>();
        _instituicaoRepository = databaseFixture.ServiceProvider.GetRequiredService<IInstituicaoRepository>();
        _fichaRepository = databaseFixture.ServiceProvider.GetRequiredService<IFichaRepository>();
        _concursoRepository = databaseFixture.ServiceProvider.GetRequiredService<IConcursoRepository>();
        _turnoRepository = databaseFixture.ServiceProvider.GetRequiredService<ITurnoRepository>();
        _campusRepository = databaseFixture.ServiceProvider.GetRequiredService<ICampusRepository>();
        _cursoRepository = databaseFixture.ServiceProvider.GetRequiredService<ICursoRepository>();
        _formaEntradaRepository = databaseFixture.ServiceProvider.GetRequiredService<IFormaEntradaRepository>();
        _ofertaConcursoOpcaoAcessoRepository = databaseFixture.ServiceProvider.GetRequiredService<IOfertaConcursoOpcaoAcessoRepository>();
        _cupomRepository = databaseFixture.ServiceProvider.GetRequiredService<ICupomRepository>();
        _marcaRepository = databaseFixture.ServiceProvider.GetRequiredService<IMarcaRepository>();
        _matriculaRepository = databaseFixture.ServiceProvider.GetRequiredService<IMatriculaRepository>();
        _cursoExternoRepository = databaseFixture.ServiceProvider.GetRequiredService<ICursoExternoRepository>();
        _nivelCursoRepository = databaseFixture.ServiceProvider.GetRequiredService<INivelCursoRepository>();
        _modalidadeRepository = databaseFixture.ServiceProvider.GetRequiredService<IModalidadeRepository>();
        _inscricaoRepository = databaseFixture.ServiceProvider.GetRequiredService<IInscricaoRepository>();
    }

    [Fact]
    public async Task DevePublicarEventoDeInscricaoConcluidaAsync()
    {
        // Arrange
        var inscricao = InscricaoConstants.InscricaoCorreta;
        var evento = new InscricaoCandidatoConcluidaEvent(inscricao);

        // Act
        var handler = ObterHandler();
        await handler.Handle(evento, CancellationToken.None);

        // Assert
        _producerMock.Verify(
           x => x.ProduceAsync(
               TopicoConfiguracao,
               It.IsAny<Message<string, string>>(),
               CancellationToken.None),
           Times.Once);

        _producerMock.Verify(x => x.Flush(CancellationToken.None), Times.Once);
    }

    private InscricaoCandidatoConcluidaEventHandler ObterHandler()
    {
        KafkaConfig kafkaConfig = new()
        {
            Topics = new()
            {
                ConfirmacaoInscricao = TopicoConfiguracao,
            },
        };

        List<(string NomeSistema, string CodigoOrigem)> inforOrigem = new ()
        {
            ("Salesforce", "00QHZ00000EYvNC2A1"),
            ("Vestib", "478124"),
        };

        _kafkaFactoryMock
            .Setup(x => x.CreateProducer<string, string>())
            .Returns(_producerMock.Object);

        return new(
            _loggerMock.Object,
            _kafkaFactoryMock.Object,
             Options.Create(kafkaConfig),
            _acessibilidadeRepository,
            _deficienciaRepository,
            _estadoRepository,
            _cidadeRepository,
            _escolaRepository,
            _integracaoSistemaRepository,
            _ofertaConcursoRepository,
            _ofertaRepository,
            _produtoRepository,
            _instituicaoRepository,
            _fichaRepository,
            _concursoRepository,
            _campusRepository,
            _turnoRepository,            
            _cursoRepository,
            _formaEntradaRepository,
            _inscricaoRepository,
            _ofertaConcursoOpcaoAcessoRepository,
            _marcaRepository,
            _cupomRepository,
            _matriculaRepository,
            _cursoExternoRepository,
            _nivelCursoRepository,
            _modalidadeRepository);
    }
}