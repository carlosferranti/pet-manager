using System.Linq.Expressions;

using Anima.Inscricao.Application.Enums;
using Anima.Inscricao.Application.UseCases.Inscricoes.AtualizarInscricaoCandidato;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain.Acessibilidades;
using Anima.Inscricao.Domain.Cupons;
using Anima.Inscricao.Domain.Cupons.Entities;
using Anima.Inscricao.Domain.CursosExternos;
using Anima.Inscricao.Domain.Deficiencias;
using Anima.Inscricao.Domain.Empresas;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Inscricoes.Entities;
using Anima.Inscricao.Domain.Inscricoes.Enums;
using Anima.Inscricao.Domain.Matriculas;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;
using Anima.Inscricoes.Domain.Inscricoes;

using MediatR;

using Microsoft.Extensions.DependencyInjection;

using Moq;

using static Anima.Inscricao.Application.UseCases.Inscricoes.AtualizarInscricaoCandidato.AtualizarInscricaoCandidatoCommand;

namespace Anima.Inscricao.Test.UseCases.Inscricoes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarInscricaoCandidatoCommandHandlerTests
{
    private readonly Mock<IInscricaoRepository> _inscricaoRepositoryMock = new();
    private readonly Mock<IOfertaConcursoRepository> _ofertaConcursoRepositoryMock = new();
    private readonly Mock<IOfertaRepository> _ofertaRepositoryMock = new();
    private readonly Mock<IFichaRepository> _fichaRepositoryMock = new();
    private readonly Mock<IEtapaTemplateRepository> _etapaTemplateRepositoryMock = new();
    private readonly Mock<ICupomRepository> _cupomRepositoryMock = new();
    private readonly Mock<IDeficienciaRepository> _deficienciaRepositoryMock = new();
    private readonly Mock<IAcessibilidadeRepository> _acessibilidadeRepositoryMock = new();
    private readonly Mock<IFormaEntradaRepository> _formaEntradaRepositoryMock = new();
    private readonly Mock<IEstadoRepository> _estadoRepository = new();
    private readonly Mock<ICidadeRepository> _cidadeRepository = new();
    private readonly Mock<IEscolaRepository> _escolaRepository = new();
    private readonly Mock<IOfertaConcursoOpcaoAcessoRepository> _ofertaConcursoOpcaoAcessoRepositoryMock = new();
    private readonly Mock<IEmpresaRepository> _empresaRepositoryMock = new();
    private readonly Mock<ICursoExternoRepository> _cursoExternoRepositoryMock = new();
    private readonly Mock<IMatriculaRepository> _matriculaRepositoryMock = new();
    private readonly Mock<IUnitOfWork> _iUnitOfWorkMock = new();

    public AtualizarInscricaoCandidatoCommand Command = new()
    {
        InscricaoKey = InscricaoConstants.InscricaoCorreta.Key,
    };


    public AtualizarInscricaoCandidatoCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveAtualizarInscricaoSomenteComDadosCandidatoAsync()
    {
        // Arrange
        Command.InfosPessoais = new AtualizarInfosPessoaisCommand
        {
            Nome = "Nome atualizado",
            DataNascimento = new DateTime(2001, 10, 08, 0, 0, 0, DateTimeKind.Utc),
            Sexo = 1,
            NecessidadeEspecial = false,
            NomeSocial = null,
        };

        // Act
        var useCase = ObterUseCase();
        await useCase.Handle(Command, CancellationToken.None);

        // Assert
        _inscricaoRepositoryMock
            .Verify(x => x.AtualizarInformacaoCandidato(It.IsAny<Guid>(), It.IsAny<InfoCandidato>(), It.IsAny<CancellationToken>()),
            Times.Once);
    }

    [Fact]
    public async Task DeveAtualizarInscricaoComCupomAsync()
    {
        // Arrange
        Command.InfosCupons = new List<AtualizarInfosCupomCommand>()
        {
            new AtualizarInfosCupomCommand
            {
                Codigo = CupomConstants.CupomPablo100.Codigo,
            }
        };

        // Act
        var useCase = ObterUseCase();
        await useCase.Handle(Command, CancellationToken.None);

        // Assert
        _inscricaoRepositoryMock
            .Verify(x => x.ExcluirCupons(It.IsAny<Guid>(), It.IsAny<CancellationToken>()),
            Times.Once);

        _inscricaoRepositoryMock
            .Verify(x => x.InserirCupons(It.IsAny<Guid>(), It.IsAny<CupomInscricao>(), It.IsAny<CancellationToken>()),
            Times.Exactly(1));
    }

    [Fact]
    public async Task DeveAtualizarInscricaoComContatosAsync()
    {
        // Arrange
        Command.InfosContato = new List<AtualizarInfosContatoCommand>()
        {
            new AtualizarInfosContatoCommand
            {
                Tipo = TipoContatoInscricao.Email,
                Valor = "email@teste.com",
            },
            new AtualizarInfosContatoCommand
            {
                Tipo = TipoContatoInscricao.TelefoneCelular,
                Valor = "11912345678",
            }
        };

        // Act
        var useCase = ObterUseCase();
        await useCase.Handle(Command, CancellationToken.None);

        // Assert
        _inscricaoRepositoryMock
            .Verify(x => x.ExcluirContatos(It.IsAny<Guid>(), It.IsAny<CancellationToken>()),
            Times.Once);

        _inscricaoRepositoryMock
            .Verify(x => x.InserirContatos(It.IsAny<Guid>(), It.IsAny<ContatoInscricao>(), It.IsAny<CancellationToken>()),
            Times.Exactly(2));
    }

    [Fact]
    public async Task DeveAtualizarInscricaoComEnderecoAsync()
    {
        // Arrange
        Command.InfosEndereco = new List<AtualizarInfosEnderecoCommand>()
        {
            new AtualizarInfosEnderecoCommand()
            {
                Tipo = TipoEnderecoInscricao.Residencial,
                Cep = "12345678",
                Rua = "Rua Teste",
                Numero = "123",
                Complemento = null,
                Bairro = "Bairro",
                Cidade = "Cidade",
                Estado = "Estado",
            },
        };

        // Act
        var useCase = ObterUseCase();
        await useCase.Handle(Command, CancellationToken.None);

        // Assert
        _inscricaoRepositoryMock
            .Verify(x => x.ExcluirEndereco(It.IsAny<Guid>(), It.IsAny<CancellationToken>()),
            Times.Once);

        _inscricaoRepositoryMock
            .Verify(x => x.InserirEndereco(It.IsAny<Guid>(), It.IsAny<EnderecoInscricao>(), It.IsAny<CancellationToken>()),
            Times.Once);
    }

    [Fact]
    public async Task DeveAtualizarInscricaoComDocumentosAsync()
    {
        // Arrange
        Command.InfosDocumento = new List<AtualizarInfosDocumentoCommand>()
        {
            new AtualizarInfosDocumentoCommand()
            {
                Tipo = TipoDocumentoInscricao.Cpf,
                Valor = "12345678901",
            }
        };

        // Act
        var useCase = ObterUseCase();
        await useCase.Handle(Command, CancellationToken.None);

        // Assert
        _inscricaoRepositoryMock
            .Verify(x => x.ExcluirDocumentos(It.IsAny<Guid>(), It.IsAny<CancellationToken>()),
            Times.Once);

        _inscricaoRepositoryMock
            .Verify(x => x.InserirDocumento(It.IsAny<Guid>(), It.IsAny<DocumentoInscricao>(), It.IsAny<CancellationToken>()),
            Times.Once);
    }

    [Fact]
    public async Task DeveAtualizarInscricaoComSeguroFiancaAsync()
    {
        // Arrange
        Command.InfosSeguroFianca = new List<AtualizarInfosSeguroFiancaCommand>()
        {
            new AtualizarInfosSeguroFiancaCommand()
            {
                NomeFiador = "Nome Fiador",
                PercentualFiador = 100,
                RendaMediaMensal = 1000,
                TipoRelacionamentoSegurado = "Pai",
                TipoContato = TipoContatoInscricao.Email,
                ValorContato = "email@email.com",
                TipoDocumento = TipoDocumentoInscricao.Cpf,
                ValorDocumento = "12345678901",
            }
        };

        // Act
        var useCase = ObterUseCase();
        await useCase.Handle(Command, CancellationToken.None);

        // Assert
        _inscricaoRepositoryMock
            .Verify(x => x.ExcluirSeguroFianca(It.IsAny<Guid>(), It.IsAny<CancellationToken>()),
            Times.Once);

        _inscricaoRepositoryMock
            .Verify(x => x.InserirSeguroFianca(It.IsAny<Guid>(), It.IsAny<SeguroFiancaInscricao>(), It.IsAny<CancellationToken>()),
            Times.Once);
    }

    [Fact]
    public async Task DeveInserirEtapaAsync()
    {
        // Arrange
        Command.InfosFicha = new AtualizarInfosFichaCommand()
        {
            FichaKey = FichaConstants.FichaPadrao.Key,
            EtapaKey = EtapaConstants.EtapaDadosPessoais.Key,
        };

        _fichaRepositoryMock
            .Setup(x => x.GetAsync(It.IsAny<Guid>()))
            .ReturnsAsync(FichaConstants.FichaPadrao);

        _etapaTemplateRepositoryMock
            .Setup(x => x.GetAsync(It.IsAny<Guid>()))
            .ReturnsAsync(EtapaConstants.EtapaDadosPessoais);

        // Act
        var useCase = ObterUseCase();
        await useCase.Handle(Command, CancellationToken.None);

        // Assert
        _inscricaoRepositoryMock
            .Verify(x => x.InserirEtapas(It.IsAny<Guid>(), It.IsAny<EtapaInscricao>(), It.IsAny<CancellationToken>()),
            Times.Once);
    }

    [Fact]
    public async Task DeveInserirAcessibilidadeInscricaoAsync()
    {
        // Arrange
        Command.InfosAcessibilidade = new List<AtualizarInfosAcessibilidadeCommand>()
        {
            new AtualizarInfosAcessibilidadeCommand()
            {
                AcessibilidadeKey = AcessibilidadeConstants.InterpreterDeLibras.Key,
            }
        };

        // Act
        var useCase = ObterUseCase();
        await useCase.Handle(Command, CancellationToken.None);

        // Assert
        _inscricaoRepositoryMock
            .Verify(x => x.ExcluirAcessibilidade(It.IsAny<Guid>(), It.IsAny<CancellationToken>()),
            Times.Once);

        _inscricaoRepositoryMock
            .Verify(x => x.InserirAcessibilidade(It.IsAny<Guid>(), It.IsAny<AcessibilidadeInscricao>(), It.IsAny<CancellationToken>()),
            Times.Once);
    }

    [Fact]
    public async Task DeveInserirDeficienciaInscricaoAsync()
    {
        // Arrange
        Command.InfosDeficiencia = new List<AtualizarInfosDeficienciaCommand>()
        {
            new AtualizarInfosDeficienciaCommand()
            {
                DeficienciaKey = DeficienciaConstants.DeficienciaFisica.Key,
            }
        };

        // Act
        var useCase = ObterUseCase();
        await useCase.Handle(Command, CancellationToken.None);

        // Assert
        _inscricaoRepositoryMock
            .Verify(x => x.ExcluirDeficiencia(It.IsAny<Guid>(), It.IsAny<CancellationToken>()),
            Times.Once);

        _inscricaoRepositoryMock
            .Verify(x => x.InserirDeficiencia(It.IsAny<Guid>(), It.IsAny<DeficienciaInscricao>(), It.IsAny<CancellationToken>()),
            Times.Once);
    }

    [Fact]
    public async Task DeveAtualizarInscricaoComDadosDeOfertaAsync()
    {
        // Arrange
        Command.InfosOferta = new AtualizarInfosOfertaCommand()
        {
            OfertaConcursoKey = OfertaConcursoConstants.Oferta2ConcursoVestibular.Key,
            OfertaKey = OfertaConstants.OfertaTeste1.Key,
            FormaEntradaKey = FormaEntradaConstants.FormaEntradaEnem.Key,
        };

        // Act
        var useCase = ObterUseCase();
        await useCase.Handle(Command, CancellationToken.None);

        // Assert

        _formaEntradaRepositoryMock.Verify(x => x.GetAsync(It.IsAny<Guid>()), Times.Once);
        _ofertaConcursoRepositoryMock.Verify(x => x.GetAsync(It.IsAny<Guid>()), Times.Once);
        _ofertaRepositoryMock.Verify(x => x.GetAsync(It.IsAny<Guid>()), Times.Once);
        _inscricaoRepositoryMock
            .Verify(x => x.AtualizarOferta(It.IsAny<Guid>(), It.IsAny<InfoOfertaInscricao>(), It.IsAny<CancellationToken>()),
            Times.Once);
    }

    [Fact]
    public async Task DeveAtualizarInscricaoComDadosDeOpcaoAcessoAsync()
    {
        // Arrange
        Command.InfosOferta = new AtualizarInfosOfertaCommand()
        {
            OfertaConcursoKey = OfertaConcursoConstants.Oferta2ConcursoVestibular.Key,
            OfertaKey = OfertaConstants.OfertaTeste1.Key,
            FormaEntradaKey = FormaEntradaConstants.FormaEntradaEnem.Key,
            OfertaConcursoOpcaoAcessos = new List<AtualizarInfoOfertaOpcaoAcessoCommand>()
            {
                new AtualizarInfoOfertaOpcaoAcessoCommand()
                { 
                    Key = OfertaConcursoConstants.OfertaConcursoOpcaoAcessoProuni.Key,
                }
            }
        };

        // Act
        var useCase = ObterUseCase();
        await useCase.Handle(Command, CancellationToken.None);

        // Assert
        _ofertaConcursoOpcaoAcessoRepositoryMock.Verify(x => x.GetAsync(It.IsAny<Guid>()), Times.Once);
        _inscricaoRepositoryMock
            .Verify(x => x.ExcluirOfertaConcursoOpcaoEntrada(It.IsAny<Guid>(), It.IsAny<CancellationToken>()),
            Times.Once);
        _inscricaoRepositoryMock
            .Verify(x => x.InserirOfertaConcursoOpcaoEntrada(It.IsAny<Guid>(), It.IsAny<InscricaoOpcaoAcesso>(), It.IsAny<CancellationToken>()),
            Times.Once);
    }

    [Fact]
    public async Task DeveAtualizarInscricaoComDadosDeEmpresaAsync()
    {
        // Arrange
        Command.InfosEmpresa = new AtualizarInfosEmpresaCommand()
        {
            EmpresaKey = EmpresaConstants.Anima.Key,
            OutraEmpresa = "Outra empresa"
        };

        // Act
        var useCase = ObterUseCase();
        await useCase.Handle(Command, CancellationToken.None);

        // Assert

        _inscricaoRepositoryMock
            .Verify(x => x.ExcluirEmpresa(It.IsAny<Guid>(), It.IsAny<CancellationToken>()),
            Times.Once);
        _inscricaoRepositoryMock
            .Verify(x => x.InserirEmpresa(It.IsAny<Guid>(), It.IsAny<EmpresaInscricao>(), It.IsAny<CancellationToken>()),
            Times.Once);
    }

    [Fact]
    public async Task DeveAtualizarInscricaoComDadosDeMatriculaAsync()
    {
        // Arrange
        Command.InfosMatricula = new AtualizarInfosMatriculaCommand()
        {
           CodigoAluno = "123",
           Ra = "123",
           CodigoStatusAluno = StatusMatricula.Ativo,
        };

        // Act
        var useCase = ObterUseCase();
        await useCase.Handle(Command, CancellationToken.None);

        // Assert

        _inscricaoRepositoryMock
            .Verify(x => x.ExcluirMatricula(It.IsAny<Guid>(), It.IsAny<CancellationToken>()),
            Times.Once);
        _inscricaoRepositoryMock
            .Verify(x => x.InserirMatricula(It.IsAny<Guid>(), It.IsAny<InscricaoMatricula>(), It.IsAny<CancellationToken>()),
            Times.Once);
    }

    [Fact]
    public async Task DeveAtualizarInscricaoComDadosDeFiliacaoAsync()
    {
        // Arrange
        Command.InfosFiliacao = new List<AtualizarInfosFiliacaoCommand>()
        {
            new AtualizarInfosFiliacaoCommand()
            {
                Nome = "Nome do pai",
                Tipo = TipoFiliacaoInscricao.Pai,
            }
        };

        // Act
        var useCase = ObterUseCase();
        await useCase.Handle(Command, CancellationToken.None);

        // Assert
        _inscricaoRepositoryMock
            .Verify(x => x.ExcluirFiliacao(It.IsAny<Guid>(), It.IsAny<CancellationToken>()),
            Times.Once);
        _inscricaoRepositoryMock
            .Verify(x => x.InserirFiliacao(
                It.IsAny<Guid>(), 
                It.Is<InscricaoFiliacao>(f => f.Nome == "Nome do pai" && f.Tipo == TipoFiliacaoInscricao.Pai), 
                It.IsAny<CancellationToken>()),
            Times.Once);
    }


    private AtualizarInscricaoCandidatoCommandHandler ObterUseCase()
    {
        _cupomRepositoryMock
            .Setup(x => x.GetListAsync(It.IsAny<Expression<Func<Cupom, bool>>>()))
            .ReturnsAsync(new List<Cupom>() { CupomConstants.CupomPablo100 });

        _deficienciaRepositoryMock
            .Setup(x => x.GetAsync(It.IsAny<Guid>()))
            .ReturnsAsync(DeficienciaConstants.DeficienciaFisica);

        _acessibilidadeRepositoryMock
            .Setup(x => x.GetAsync(It.IsAny<Guid>()))
            .ReturnsAsync(AcessibilidadeConstants.InterpreterDeLibras);

        _formaEntradaRepositoryMock
            .Setup(x => x.GetAsync(It.IsAny<Guid>()))
            .ReturnsAsync(FormaEntradaConstants.FormaEntradaEnem);

        _ofertaRepositoryMock
            .Setup(x => x.GetAsync(It.IsAny<Guid>()))
            .ReturnsAsync(OfertaConstants.OfertaTeste1);

        _ofertaConcursoRepositoryMock
            .Setup(x => x.GetAsync(It.IsAny<Guid>()))
            .ReturnsAsync(OfertaConcursoConstants.Oferta2ConcursoVestibular);

        _ofertaConcursoOpcaoAcessoRepositoryMock
            .Setup(x => x.GetAsync(It.IsAny<Guid>()))
            .ReturnsAsync(OfertaConcursoConstants.OfertaConcursoOpcaoAcessoProuni);

        return new AtualizarInscricaoCandidatoCommandHandler(
            _inscricaoRepositoryMock.Object,
            _ofertaConcursoRepositoryMock.Object,
            _ofertaRepositoryMock.Object,
            _fichaRepositoryMock.Object,
            _etapaTemplateRepositoryMock.Object,
            _cupomRepositoryMock.Object,
            _acessibilidadeRepositoryMock.Object,
            _deficienciaRepositoryMock.Object,
            _estadoRepository.Object,
            _cidadeRepository.Object,
            _escolaRepository.Object,
            _formaEntradaRepositoryMock.Object,
            _ofertaConcursoOpcaoAcessoRepositoryMock.Object,
            _empresaRepositoryMock.Object,
            _cursoExternoRepositoryMock.Object,
            _matriculaRepositoryMock.Object,
            _iUnitOfWorkMock.Object);
    }
}