using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.Enums;
using Anima.Inscricao.Application.UseCases.Inscricoes.CriarInscricaoCandidato;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Acessibilidades;
using Anima.Inscricao.Domain.Cupons;
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
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.Matriculas;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;
using Anima.Inscricoes.Domain.Inscricoes;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

using static Anima.Inscricao.Application.UseCases.Inscricoes.CriarInscricaoCandidato.CriarInscricaoCandidatoCommand;

namespace Anima.Inscricao.Test.UseCases.Inscricoes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarInscricaoCandidatoCommandHandlerTests
{
    private readonly INotificationContext _notificationContext;
    private readonly IInscricaoRepository _inscricaoRepository;
    private readonly IFichaRepository _fichaRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IMarcaRepository _marcaRepository;
    private readonly ICupomRepository _cupomRepository;
    private readonly IAcessibilidadeRepository _acessibilidadeRepository;
    private readonly IDeficienciaRepository _deficienciaRepository;
    private readonly IEstadoRepository _estadoRepository;
    private readonly ICidadeRepository _cidadeRepository;
    private readonly IEscolaRepository _escolaRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;
    private readonly IOfertaConcursoOpcaoAcessoRepository _ofertaConcursoOpcaoAcessoRepository;
    private readonly IEmpresaRepository _empresaRepository;
    private readonly ICursoExternoRepository _cursoExternoRepository;
    private readonly IMatriculaRepository _matriculaRepository;

    public CriarInscricaoCandidatoCommandHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _notificationContext = serviceProvider.GetRequiredService<INotificationContext>();
        _inscricaoRepository = serviceProvider.GetRequiredService<IInscricaoRepository>();
        _fichaRepository = serviceProvider.GetRequiredService<IFichaRepository>();
        _unitOfWork = serviceProvider.GetRequiredService<IUnitOfWork>();
        _ofertaConcursoRepository = serviceProvider.GetRequiredService<IOfertaConcursoRepository>();
        _ofertaRepository = serviceProvider.GetRequiredService<IOfertaRepository>();
        _marcaRepository = serviceProvider.GetRequiredService<IMarcaRepository>();
        _cupomRepository = serviceProvider.GetRequiredService<ICupomRepository>();
        _acessibilidadeRepository = serviceProvider.GetRequiredService<IAcessibilidadeRepository>();
        _deficienciaRepository = serviceProvider.GetRequiredService<IDeficienciaRepository>();
        _estadoRepository = serviceProvider.GetRequiredService<IEstadoRepository>();
        _cidadeRepository = serviceProvider.GetRequiredService<ICidadeRepository>();
        _escolaRepository = serviceProvider.GetRequiredService<IEscolaRepository>();
        _formaEntradaRepository = serviceProvider.GetRequiredService<IFormaEntradaRepository>();
        _etapaTemplateRepository = serviceProvider.GetRequiredService<IEtapaTemplateRepository>();
        _ofertaConcursoOpcaoAcessoRepository = serviceProvider.GetRequiredService<IOfertaConcursoOpcaoAcessoRepository>();
        _empresaRepository = serviceProvider.GetRequiredService<IEmpresaRepository>();
        _matriculaRepository = serviceProvider.GetRequiredService<IMatriculaRepository>();
    }

    [Fact]
    public async Task DeveObterFichaPadraoQuandoNaoInformadaNaRequisicaoAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand();
        command.MarcaKey = MarcaConstants.Una.Key;
        command.EtapaKey = EtapaConstants.EtapaDadosPessoais.Key;

        // Act
        var useCase = ObterUseCase();
        var entity = await useCase.Handle(command, CancellationToken.None);

        // Assert
        entity.Should().NotBeNull();
        entity!.Key.Should().NotBeEmpty();
        var inscricao = await ObterInscricaoCandidato(entity.Key);
        inscricao.FichaId.Should().Be(FichaConstants.FichaPadrao.Id);
        await RemoverInscricaoCandidato(entity.Key);
    }

    [Fact]
    public async Task DeveObterFichaQuandoInformadaNaRequisicaoAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            FichaKey = FichaConstants.FichaB.Key,
            MarcaKey = MarcaConstants.Una.Key,
            EtapaKey = EtapaConstants.EtapaDadosPessoais.Key,
        };

        // Act
        var useCase = ObterUseCase();
        var entity = await useCase.Handle(command, CancellationToken.None);

        // Assert
        entity.Should().NotBeNull();
        entity!.Key.Should().NotBeEmpty();
        var inscricao = await ObterInscricaoCandidato(entity.Key);
        inscricao.FichaId.Should().Be(FichaConstants.FichaB.Id);
        await RemoverInscricaoCandidato(entity.Key);
    }

    [Fact]
    public async Task DeveInserirInscricaoSomenteComDadosCandidatoAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            FichaKey = FichaConstants.FichaB.Key,
            MarcaKey = MarcaConstants.Una.Key,
            EtapaKey = EtapaConstants.EtapaDadosPessoais.Key,
            InfosPessoais = new CriarInfosPessoaisCommand
            {
                Nome = "Nome",
                DataNascimento = new DateTime(2000, 10, 08),
                Sexo = 1,
                NecessidadeEspecial = false,
                NomeSocial = null,
            }
        };

        // Act
        var useCase = ObterUseCase();
        var entity = await useCase.Handle(command, CancellationToken.None);

        // Assert
        entity.Should().NotBeNull();
        entity!.Key.Should().NotBeEmpty();

        var inscricao = await ObterInscricaoCandidato(entity.Key);
        inscricao.FichaId.Should().Be(FichaConstants.FichaB.Id);
        inscricao.Candidato.Nome.Should().Be("Nome");
        inscricao.Candidato.DataNascimento.Should().Be(new DateTime(2000, 10, 08));
        inscricao.Candidato.Sexo.Should().Be(1);
        inscricao.Candidato.NecessidadeEspecial.Should().BeFalse();
        inscricao.Candidato.NomeSocial.Should().BeNull();
        await RemoverInscricaoCandidato(entity.Key);
    }

    [Fact]
    public async Task DeveInserirInscricaoComVoucherAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            FichaKey = FichaConstants.FichaB.Key,
            MarcaKey = MarcaConstants.Una.Key,
            EtapaKey = EtapaConstants.EtapaDadosPessoais.Key,
            InfosPessoais = new CriarInfosPessoaisCommand
            {
                Nome = "Nome",
                DataNascimento = new DateTime(2000, 10, 08),
                Sexo = 1,
                NecessidadeEspecial = false,
                NomeSocial = null,
            },
            InfosCupons = new List<CriarInfosCupomCommand>()
            {
                new CriarInfosCupomCommand
                {
                    Codigo = CupomConstants.CupomPablo100.Codigo,
                }
            },
        };

        // Act
        var useCase = ObterUseCase();
        var entity = await useCase.Handle(command, CancellationToken.None);

        // Assert
        entity.Should().NotBeNull();
        entity!.Key.Should().NotBeEmpty();
        await RemoverInscricaoCandidato(entity.Key);
    }

    [Fact]
    public async Task DeveInserirInscricaoComOrigemAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            FichaKey = FichaConstants.FichaB.Key,
            MarcaKey = MarcaConstants.Una.Key,
            EtapaKey = EtapaConstants.EtapaDadosPessoais.Key,
            InfosPessoais = new CriarInfosPessoaisCommand
            {
                Nome = "Nome",
                DataNascimento = new DateTime(2000, 10, 08),
                Sexo = 1,
                NecessidadeEspecial = false,
                NomeSocial = null,
            },
            InfosCupons = new List<CriarInfosCupomCommand>()
            {
                new CriarInfosCupomCommand
                {
                    Codigo = CupomConstants.CupomPablo100.Codigo,
                }
            },
            InfoOrigem = new CriarInfosOrigemCommand
            {
                Tipo = TipoOrigemInscricao.Ficha,
                Url = "www.anima.com.br/teste"
            }
        };

        // Act
        var useCase = ObterUseCase();
        var entity = await useCase.Handle(command, CancellationToken.None);

        // Assert
        entity.Should().NotBeNull();
        entity!.Key.Should().NotBeEmpty();

        var inscricao = await ObterInscricaoCandidato(entity.Key);
        inscricao.Origem.Tipo.Should().Be(TipoOrigemInscricao.Ficha);
        await RemoverInscricaoCandidato(entity.Key);
    }

    [Fact]
    public async Task DeveInserirInscricaoComContatoAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            FichaKey = FichaConstants.FichaB.Key,
            MarcaKey = MarcaConstants.Una.Key,
            EtapaKey = EtapaConstants.EtapaDadosPessoais.Key,
            InfosPessoais = new CriarInfosPessoaisCommand
            {
                Nome = "Nome",
                DataNascimento = new DateTime(2000, 10, 08),
                Sexo = 1,
                NecessidadeEspecial = false,
                NomeSocial = null,
            },
            InfosCupons = new List<CriarInfosCupomCommand>()
            {
                new CriarInfosCupomCommand
                {
                    Codigo = CupomConstants.CupomPablo100.Codigo,
                }
            },
            InfoOrigem = new CriarInscricaoCandidatoCommand.CriarInfosOrigemCommand
            {
                Tipo = TipoOrigemInscricao.Ficha,
            },
            InfosContato = new List<CriarInscricaoCandidatoCommand.CriarInfosContatoCommand>()
            {
                new CriarInfosContatoCommand
                {
                    Tipo = TipoContatoInscricao.Email,
                    Valor = "email@teste.com",
                },
                new CriarInfosContatoCommand
                {
                    Tipo = TipoContatoInscricao.TelefoneCelular,
                    Valor = "11912345678",
                }
            }
        };

        // Act
        var useCase = ObterUseCase();
        var entity = await useCase.Handle(command, CancellationToken.None);

        // Assert
        entity.Should().NotBeNull();
        entity!.Key.Should().NotBeEmpty();

        var inscricao = await ObterInscricaoCandidato(entity.Key);
        inscricao.Contatos.Count.Should().Be(2);
        inscricao.Contatos.Should().Contain(c => c.Tipo == TipoContatoInscricao.Email && c.Valor == "email@teste.com");
        inscricao.Contatos.Should().Contain(c => c.Tipo == TipoContatoInscricao.TelefoneCelular && c.Valor == "11912345678" && c.ValorFormatado == "(11) 91234-5678");
        await RemoverInscricaoCandidato(entity.Key);
    }

    [Fact]
    public async Task DeveInserirInscricaoComEnderecoAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            FichaKey = FichaConstants.FichaB.Key,
            MarcaKey = MarcaConstants.Una.Key,
            EtapaKey = EtapaConstants.EtapaDadosPessoais.Key,
            InfosPessoais = new CriarInfosPessoaisCommand
            {
                Nome = "Nome",
                DataNascimento = new DateTime(2000, 10, 08),
                Sexo = 1,
                NecessidadeEspecial = false,
                NomeSocial = null,
            },
            InfosCupons = new List<CriarInfosCupomCommand>()
            {
                new CriarInfosCupomCommand
                {
                    Codigo = CupomConstants.CupomPablo100.Codigo,
                }
            },
            InfoOrigem = new CriarInfosOrigemCommand
            {
                Tipo = TipoOrigemInscricao.Ficha,
            },
            InfosContato = new List<CriarInfosContatoCommand>()
            {
                new CriarInfosContatoCommand
                {
                    Tipo = TipoContatoInscricao.Email,
                    Valor = "email@teste.com",
                },
                new CriarInfosContatoCommand
                {
                    Tipo = TipoContatoInscricao.TelefoneCelular,
                    Valor = "11912345678",
                }
            },
            InfosEndereco = new List<CriarInfosEnderecoCommand>()
            {
                new CriarInfosEnderecoCommand()
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
            },
        };

        // Act
        var useCase = ObterUseCase();
        var entity = await useCase.Handle(command, CancellationToken.None);

        // Assert
        entity.Should().NotBeNull();
        entity!.Key.Should().NotBeEmpty();

        var inscricao = await ObterInscricaoCandidato(entity.Key);
        inscricao.Enderecos.Count.Should().Be(1);
        inscricao.Enderecos.Should().Contain(e => e.Tipo == TipoEnderecoInscricao.Residencial &&
        e.Rua == "Rua Teste" && e.Cep == "12345678" && e.Cidade == "Cidade" && e.Estado == "Estado" &&
        e.Numero == "123" && e.Bairro == "Bairro" && e.Complemento == null);
        await RemoverInscricaoCandidato(entity.Key);
    }

    [Fact]
    public async Task DeveInserirInscricaoComDocumentosAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            FichaKey = FichaConstants.FichaB.Key,
            MarcaKey = MarcaConstants.Una.Key,
            EtapaKey = EtapaConstants.EtapaDadosPessoais.Key,
            InfosPessoais = new CriarInfosPessoaisCommand
            {
                Nome = "Nome",
                DataNascimento = new DateTime(2000, 10, 08),
                Sexo = 1,
                NecessidadeEspecial = false,
                NomeSocial = null,
            },
            InfosCupons = new List<CriarInfosCupomCommand>()
            {
                new CriarInfosCupomCommand
                {
                    Codigo = CupomConstants.CupomPablo100.Codigo,
                }
            },
            InfoOrigem = new CriarInfosOrigemCommand
            {
                Tipo = TipoOrigemInscricao.Ficha,
            },
            InfosContato = new List<CriarInfosContatoCommand>()
            {
                new CriarInfosContatoCommand
                {
                    Tipo = TipoContatoInscricao.Email,
                    Valor = "email@teste.com",
                },
                new CriarInfosContatoCommand
                {
                    Tipo = TipoContatoInscricao.TelefoneCelular,
                    Valor = "11912345678",
                }
            },
            InfosEndereco = new List<CriarInfosEnderecoCommand>()
            {
                new CriarInfosEnderecoCommand()
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
            },
            InfosDocumento = new List<CriarInfosDocumentoCommand>()
            {
                new CriarInfosDocumentoCommand()
                {
                    Tipo = TipoDocumentoInscricao.Cpf,
                    Valor = "12345678901",
                }
            }
        };

        // Act
        var useCase = ObterUseCase();
        var entity = await useCase.Handle(command, CancellationToken.None);

        // Assert
        entity.Should().NotBeNull();
        entity!.Key.Should().NotBeEmpty();

        var inscricao = await ObterInscricaoCandidato(entity.Key);
        inscricao.Documentos.Count.Should().Be(1);
        inscricao.Documentos.Should().Contain(d => d.Tipo == TipoDocumentoInscricao.Cpf && d.Valor == "12345678901" && d.ValorFormatado == "123.456.789-01");
        await RemoverInscricaoCandidato(entity.Key);
    }

    [Fact]
    public async Task DeveInserirInscricaoComSeguroFiancaAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            FichaKey = FichaConstants.FichaB.Key,
            MarcaKey = MarcaConstants.Una.Key,
            EtapaKey = EtapaConstants.EtapaDadosPessoais.Key,
            InfosPessoais = new CriarInfosPessoaisCommand
            {
                Nome = "Nome",
                DataNascimento = new DateTime(2000, 10, 08),
                Sexo = 1,
                NecessidadeEspecial = false,
                NomeSocial = null,
            },
            InfosCupons = new List<CriarInfosCupomCommand>()
            {
                new CriarInfosCupomCommand
                {
                    Codigo = CupomConstants.CupomPablo100.Codigo,
                }
            },
            InfoOrigem = new CriarInfosOrigemCommand
            {
                Tipo = TipoOrigemInscricao.Ficha,
            },
            InfosContato = new List<CriarInfosContatoCommand>()
            {
                new CriarInfosContatoCommand
                {
                    Tipo = TipoContatoInscricao.Email,
                    Valor = "email@teste.com",
                },
                new CriarInfosContatoCommand
                {
                    Tipo = TipoContatoInscricao.TelefoneCelular,
                    Valor = "11912345678",
                }
            },
            InfosEndereco = new List<CriarInfosEnderecoCommand>()
            {
                new CriarInfosEnderecoCommand()
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
            },
            InfosDocumento = new List<CriarInfosDocumentoCommand>()
            {
                new CriarInfosDocumentoCommand()
                {
                    Tipo = TipoDocumentoInscricao.Cpf,
                    Valor = "12345678901",
                }
            },
            InfosSeguroFianca = new List<CriarInfosSeguroFiancaCommand>()
            {
                new CriarInfosSeguroFiancaCommand()
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
            }
        };

        // Act
        var useCase = ObterUseCase();
        var entity = await useCase.Handle(command, CancellationToken.None);

        // Assert
        entity.Should().NotBeNull();
        entity!.Key.Should().NotBeEmpty();

        var inscricao = await ObterInscricaoCandidato(entity.Key);
        inscricao.SeguroFianca.Count.Should().Be(1);
        inscricao.SeguroFianca.Should().Contain(s => s.DadosFiador!.NomeFiador == "Nome Fiador" &&
        s.DadosFiador.PercentualFiador == 100 && s.DadosFiador!.InfoRendaFiador!.RendaMediaMensal == 1000 &&
        s.DadosFiador.TipoRelacionamentoSegurado == "Pai" && s.ContatosFiador!.TipoContato == TipoContatoInscricao.Email &&
        s.ContatosFiador.Valor == "email@email.com" && s.DocumentosFiador!.TipoDocumento == TipoDocumentoInscricao.Cpf &&
        s.DocumentosFiador.Valor == "12345678901");
        await RemoverInscricaoCandidato(entity.Key);
    }

    [Fact]
    public async Task DeveInserirInscricaoComInfosDeAcessibilidadeAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            FichaKey = FichaConstants.FichaB.Key,
            MarcaKey = MarcaConstants.Una.Key,
            EtapaKey = EtapaConstants.EtapaDadosPessoais.Key,
            InfosAcessibilidade = new List<CriarInfosAcessibilidadeCommand>()
            {
                new CriarInfosAcessibilidadeCommand()
                {
                    AcessibilidadeKey = AcessibilidadeConstants.InterpreterDeLibras.Key,
                }
            }
        };

        // Act
        var useCase = ObterUseCase();
        var entity = await useCase.Handle(command, CancellationToken.None);

        // Assert
        entity.Should().NotBeNull();
        entity!.Key.Should().NotBeEmpty();

        var inscricao = await ObterInscricaoCandidato(entity.Key);
        inscricao.Acessibilidades.Count.Should().Be(1);
        await RemoverInscricaoCandidato(entity.Key);
    }

    [Fact]
    public async Task DeveInserirInscricaoComInfosDeDeficienciaAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            FichaKey = FichaConstants.FichaB.Key,
            MarcaKey = MarcaConstants.Una.Key,
            EtapaKey = EtapaConstants.EtapaDadosPessoais.Key,
            InfosDeficiencia = new List<CriarInfosDeficienciaCommand>()
            {
                new CriarInfosDeficienciaCommand()
                {
                    DeficienciaKey = DeficienciaConstants.DeficienciaFisica.Key,
                }
            }
        };

        // Act
        var useCase = ObterUseCase();
        var entity = await useCase.Handle(command, CancellationToken.None);

        // Assert
        entity.Should().NotBeNull();
        entity!.Key.Should().NotBeEmpty();

        var inscricao = await ObterInscricaoCandidato(entity.Key);
        inscricao.Deficiencias.Count.Should().Be(1);
        await RemoverInscricaoCandidato(entity.Key);
    }

    [Fact]
    public async Task DeveInserirInscricaoComDadosDeOfertaAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            FichaKey = FichaConstants.FichaB.Key,
            MarcaKey = MarcaConstants.Una.Key,
            EtapaKey = EtapaConstants.EtapaDadosPessoais.Key,
            InfosOferta = new CriarInfosOfertaCommand
            {
                OfertaConcursoKey = OfertaConcursoConstants.Oferta2ConcursoVestibular.Key,
                OfertaKey = OfertaConstants.OfertaTeste1.Key,
                FormaEntradaKey = FormaEntradaConstants.FormaEntradaEnem.Key,
            }
        };

        // Act
        var useCase = ObterUseCase();
        var entity = await useCase.Handle(command, CancellationToken.None);

        // Assert
        entity.Should().NotBeNull();
        entity!.Key.Should().NotBeEmpty();

        var inscricao = await ObterInscricaoCandidato(entity.Key);
        inscricao.FormasEntrada.Should().NotBeNull();
        inscricao.FormasEntrada.Count().Should().Be(1);
        inscricao.FormasEntrada[0].FormaEntradaId.Should().Be(FormaEntradaConstants.FormaEntradaEnem.Id);
        inscricao.Oferta.OfertaId.Should().Be(OfertaConstants.OfertaTeste1.Id);
        inscricao.Oferta.OfertaConcursoId.Should().Be(OfertaConcursoConstants.Oferta2ConcursoVestibular.Id);
        await RemoverInscricaoCandidato(entity.Key);
    }

    [Fact]
    public async Task DeveInserirInscricaoComOpcaoAcessoAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            FichaKey = FichaConstants.FichaB.Key,
            MarcaKey = MarcaConstants.Una.Key,
            InfosPessoais = new CriarInfosPessoaisCommand
            {
                Nome = "Nome",
                Sexo = 1,
                NecessidadeEspecial = false,
                NomeSocial = null,
            },
            InfosOferta = new CriarInfosOfertaCommand
            {
                OfertaConcursoKey = OfertaConcursoConstants.Oferta2ConcursoVestibular.Key,
                OfertaKey = OfertaConstants.OfertaTeste1.Key,
                FormaEntradaKey = FormaEntradaConstants.FormaEntradaEnem.Key,
                OfertaConcursoOpcaoAcessos = new List<CriarInfoOfertaOpcaoAcessoCommand>()
                {
                    new CriarInfoOfertaOpcaoAcessoCommand()
                    {
                        Key = OfertaConcursoConstants.OfertaConcursoOpcaoAcessoProuni.Key,
                    },
                }
            }
        };

        // Act
        var useCase = ObterUseCase();
        var entity = await useCase.Handle(command, CancellationToken.None);

        // Assert
        entity.Should().NotBeNull();
        entity!.Key.Should().NotBeEmpty();

        var inscricao = await ObterInscricaoCandidato(entity.Key);
        inscricao.OpcoesAcesso.Count().Should().Be(1);
        await RemoverInscricaoCandidato(entity.Key);
    }

    [Fact]
    public async Task DeveInserirInscricaoComDadosDeEmpresaAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            FichaKey = FichaConstants.FichaB.Key,
            MarcaKey = MarcaConstants.Una.Key,
            InfosPessoais = new CriarInfosPessoaisCommand
            {
                Nome = "Nome",
                Sexo = 1,
                NecessidadeEspecial = false,
                NomeSocial = null,
            },
            InfosEmpresa = new CriarInfosEmpresaCommand
            {
                EmpresaKey = EmpresaConstants.Anima.Key,
                OutraEmpresa = "Outra empresa"
            }
        };

        // Act
        var useCase = ObterUseCase();
        var entity = await useCase.Handle(command, CancellationToken.None);

        // Assert
        entity.Should().NotBeNull();
        entity!.Key.Should().NotBeEmpty();

        var inscricao = await ObterInscricaoCandidato(entity.Key);
        inscricao.Empresas.ElementAt(0).Id.Id.Should().Be(EmpresaConstants.Anima.Id.Id);
        inscricao.Empresas.ElementAt(0).OutraEmpresa.Should().Be("Outra empresa");
    }

    [Fact]
    public async Task DeveInserirInscricaoComDadosDeMatriculaAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            FichaKey = FichaConstants.FichaB.Key,
            MarcaKey = MarcaConstants.Una.Key,
            InfosPessoais = new CriarInfosPessoaisCommand
            {
                Nome = "Nome",
                Sexo = 1,
                NecessidadeEspecial = false,
                NomeSocial = null,
            },
            InfosMatricula = new CriarInfosMatriculaCommand
            {
                Ra = "123456",
                CodigoAluno = "123456",
                CodigoStatusAluno = StatusMatricula.Abandono
            }
        };

        // Act
        var useCase = ObterUseCase();
        var entity = await useCase.Handle(command, CancellationToken.None);

        // Assert
        entity.Should().NotBeNull();
        entity!.Key.Should().NotBeEmpty();

        var inscricao = await ObterInscricaoCandidato(entity.Key);
        inscricao.Matriculas.Count().Should().Be(1);
    }

    [Fact]
    public async Task DeveInserirInscricaoComDadosDeFiliacaoAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            FichaKey = FichaConstants.FichaB.Key,
            MarcaKey = MarcaConstants.Una.Key,
            InfosPessoais = new CriarInfosPessoaisCommand
            {
                Nome = "Nome",
                Sexo = 1,
                NecessidadeEspecial = false,
                NomeSocial = null,
            },
            InfosFiliacao = new List<CriarInfosFiliacaoCommand>()
            {
                new CriarInfosFiliacaoCommand
                {
                    Nome = "Nome da mãe",
                    Tipo = TipoFiliacaoInscricao.Mae,
                }
            }
        };

        // Act
        var useCase = ObterUseCase();
        var entity = await useCase.Handle(command, CancellationToken.None);

        // Assert
        entity.Should().NotBeNull();
        entity!.Key.Should().NotBeEmpty();

        var inscricao = await ObterInscricaoCandidato(entity.Key);
        inscricao.Filiacoes.Count().Should().Be(1);
        inscricao.Filiacoes[0].Nome.Should().Be("Nome da mãe");
        inscricao.Filiacoes[0].Tipo.Should().Be(TipoFiliacaoInscricao.Mae);
    }

    private async Task<InscricaoCandidato> ObterInscricaoCandidato(Guid key)
    {
        return await _inscricaoRepository.GetAsync(key);
    }

    private async Task RemoverInscricaoCandidato(Guid key)
    {
        var inscricao = await _inscricaoRepository.GetAsync(key);
        _inscricaoRepository.Delete(inscricao);
        await _unitOfWork.CommitAsync();
    }

    private CriarInscricaoCandidatoCommandHandler ObterUseCase()
    {
        return new CriarInscricaoCandidatoCommandHandler(
            _notificationContext,
            _inscricaoRepository,
            _fichaRepository,
            _ofertaConcursoRepository,
            _ofertaRepository,
            _marcaRepository,
            _cupomRepository,
            _deficienciaRepository,
            _acessibilidadeRepository,
            _estadoRepository,
            _cidadeRepository,
            _escolaRepository,
            _etapaTemplateRepository,
            _formaEntradaRepository,
            _ofertaConcursoOpcaoAcessoRepository,
            _empresaRepository,
            _unitOfWork,
            _cursoExternoRepository,
            _matriculaRepository);
    }
}