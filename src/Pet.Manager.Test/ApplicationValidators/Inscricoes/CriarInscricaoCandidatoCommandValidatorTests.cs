using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.UseCases.Inscricoes.AtualizarInscricaoCandidato;
using Anima.Inscricao.Application.UseCases.Inscricoes.CriarInscricaoCandidato;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Acessibilidades;
using Anima.Inscricao.Domain.CursosExternos;
using Anima.Inscricao.Domain.Deficiencias;
using Anima.Inscricao.Domain.Empresas;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Inscricoes.Enums;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using FluentValidation.TestHelper;

using Moq;

using static Anima.Inscricao.Application.UseCases.Inscricoes.AtualizarInscricaoCandidato.AtualizarInscricaoCandidatoCommand;
using static Anima.Inscricao.Application.UseCases.Inscricoes.CriarInscricaoCandidato.CriarInscricaoCandidatoCommand;

namespace Anima.Inscricao.Test.ApplicationValidators.Inscricoes;

public class CriarInscricaoCandidatoCommandValidatorTests
{
    private readonly CriarInscricaoCandidatoCommandValidator _validator;
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IFichaRepository> _fichaRepositoryMock = new();
    private readonly Mock<IMarcaRepository> _marcaRepositoryMock = new();
    private readonly Mock<IEstadoRepository> _estadoRepositoryMock = new();
    private readonly Mock<ICidadeRepository> _cidadeRepositoryMock = new();
    private readonly Mock<IEscolaRepository> _escolaRepositoryMock = new();
    private readonly Mock<IOfertaConcursoRepository> _ofertaConcursoRepositoryMock = new();
    private readonly Mock<IOfertaRepository> _ofertaRepositoryMock = new();
    private readonly Mock<IAcessibilidadeRepository> _acessibilidadeRepositoryMock = new();
    private readonly Mock<IDeficienciaRepository> _deficienciaRepositoryMock = new();
    private readonly Mock<IFormaEntradaRepository> _formaEntradaRepositoryMock = new();
    private readonly Mock<IOfertaConcursoOpcaoAcessoRepository> _ofertaConcursoOpcaoAcessoRepository = new();
    private readonly Mock<IEmpresaRepository> _empresaRepository = new();
    private readonly Mock<ICursoExternoRepository> _cursoExternoRepositoryMock = new();

    public CriarInscricaoCandidatoCommandValidatorTests()
    {
        _validator = new CriarInscricaoCandidatoCommandValidator(
            _notificationContextMock.Object,
            _fichaRepositoryMock.Object,
            _ofertaRepositoryMock.Object,
            _ofertaConcursoRepositoryMock.Object,
            _marcaRepositoryMock.Object,
            _estadoRepositoryMock.Object,
            _cidadeRepositoryMock.Object,
            _escolaRepositoryMock.Object,
            _deficienciaRepositoryMock.Object,
            _acessibilidadeRepositoryMock.Object,
            _formaEntradaRepositoryMock.Object,
            _ofertaConcursoOpcaoAcessoRepository.Object,
            _empresaRepository.Object,
            _cursoExternoRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoFichaNaoExistirAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            FichaKey = Guid.NewGuid()
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.FichaKey!.Value)
            .WithErrorMessage("Ficha de inscrição não encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoMarcaNaoExistirAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            MarcaKey = Guid.NewGuid()
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.MarcaKey)
            .WithErrorMessage("Marca da inscrição não encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoOfertaNaoExistirAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosOferta = new CriarInfosOfertaCommand
            {
                OfertaKey = Guid.NewGuid()
            },
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.InfosOferta!.OfertaKey!.Value)
            .WithErrorMessage("Chave da oferta não encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoOfertaConcursoNaoExistirAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosOferta = new CriarInfosOfertaCommand
            {
                OfertaConcursoKey = Guid.NewGuid()
            },
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.InfosOferta!.OfertaConcursoKey!.Value)
            .WithErrorMessage("Chave da oferta concurso não encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeCandidatoExcederLimiteCaracteresAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosPessoais = new CriarInscricaoCandidatoCommand.CriarInfosPessoaisCommand()
            {
                Nome = new string('A', 101),
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.InfosPessoais!.Nome)
            .WithErrorMessage("O nome do candidato deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeSocialCandidatoExcederLimiteCaracteresAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosPessoais = new CriarInfosPessoaisCommand()
            {
                NomeSocial = new string('A', 101),
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.InfosPessoais!.NomeSocial)
            .WithErrorMessage("O nome social do candidato deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoSexoInvalidoAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosPessoais = new CriarInfosPessoaisCommand()
            {
                Sexo = 100,
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.InfosPessoais!.Sexo)
            .WithErrorMessage("Sexo do candidato inválido.");
    }

    [Fact]
    public async Task DeveTerErroQuandoDataNascimentoInvalidaAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosPessoais = new CriarInfosPessoaisCommand()
            {
                DataNascimento = DateTime.MinValue,
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.InfosPessoais!.DataNascimento)
            .WithErrorMessage("Data de nascimento do candidato inválida.");
    }

    [Fact]
    public async Task DeveTerErroQuandoValorContatoExcederLimiteCaracteresAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosContato = new List<CriarInfosContatoCommand>()
            {
                new CriarInfosContatoCommand()
                {
                    Tipo = TipoContatoInscricao.Email,
                    Valor = new string('A', 101),
                }
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("InfosContato[0].Valor")
            .WithErrorMessage("O valor do contato deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoEmailInvalidoAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosContato = new List<CriarInscricaoCandidatoCommand.CriarInfosContatoCommand>()
            {
                new CriarInscricaoCandidatoCommand.CriarInfosContatoCommand()
                {
                    Tipo = TipoContatoInscricao.Email,
                    Valor = "invalido" // E-mail inválido
                }
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("InfosContato[0].Valor")
            .WithErrorMessage("E-mail inválido.");
    }

    [Fact]
    public async Task DeveTerErroQuandoCodigoCupomExcederLimiteCaracteresAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosCupons = new List<CriarInfosCupomCommand>()
            {
                new CriarInfosCupomCommand()
                {
                    Codigo = new string('A', 101),
                }
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("InfosCupons[0].Codigo")
            .WithErrorMessage("O código do cupom deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoCepExcederLimiteCaracteresAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosEndereco = new List<CriarInfosEnderecoCommand>()
            {
                new CriarInfosEnderecoCommand()
                {
                    Cep = new string('A', 51)
                }
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("InfosEndereco[0].Cep")
            .WithErrorMessage("O valor do CEP deve ter no máximo 50 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoComplementoEnderecoExcederLimiteCaracteresAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosEndereco = new List<CriarInfosEnderecoCommand>()
            {
                new CriarInfosEnderecoCommand()
                {
                    Complemento = new string('A', 151)
                }
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("InfosEndereco[0].Complemento")
            .WithErrorMessage("O valor do complemento do endereço deve ter no máximo 150 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoEstadoEnderecoExcederLimiteCaracteresAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosEndereco = new List<CriarInfosEnderecoCommand>()
            {
                new CriarInfosEnderecoCommand()
                {
                    Estado = new string('A', 151),
                }
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("InfosEndereco[0].Estado")
            .WithErrorMessage("O estado do endereço deve ter no máximo 150 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoBairroEnderecoExcederLimiteCaracteresAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosEndereco = new List<CriarInfosEnderecoCommand>()
            {
                new CriarInfosEnderecoCommand()
                {
                    Bairro = new string('A', 151),
                }
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("InfosEndereco[0].Bairro")
            .WithErrorMessage("O valor do bairro do endereço deve ter no máximo 150 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoCidadeEnderecoExcederLimiteCaracteresAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosEndereco = new List<CriarInfosEnderecoCommand>()
            {
                new CriarInfosEnderecoCommand()
                {
                    Cidade = new string('A', 151),
                }
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("InfosEndereco[0].Cidade")
            .WithErrorMessage("O valor da cidade do endereço deve ter no máximo 150 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoRuaEnderecoExcederLimiteCaracteresAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosEndereco = new List<CriarInfosEnderecoCommand>()
            {
                new CriarInfosEnderecoCommand()
                {
                    Rua = new string('A', 151),
                }
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("InfosEndereco[0].Rua")
            .WithErrorMessage("O valor da rua do endereço deve ter no máximo 150 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNumeroEnderecoExcederLimiteCaracteresAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosEndereco = new List<CriarInfosEnderecoCommand>()
            {
                new CriarInfosEnderecoCommand()
                {
                    Numero = new string('A', 151),
                }
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("InfosEndereco[0].Numero")
            .WithErrorMessage("O valor do número do endereço deve ter no máximo 50 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoValorDocumentoExcederLimiteCaracteresAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosDocumento = new List<CriarInfosDocumentoCommand>()
            {
                new CriarInfosDocumentoCommand()
                {
                    Tipo = TipoDocumentoInscricao.Cpf,
                    Valor = new string('A', 101),
                }
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("InfosDocumento[0].Valor")
            .WithErrorMessage("O valor do documento deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoCpfInvalidoAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosDocumento = new List<CriarInfosDocumentoCommand>()
            {
                new CriarInfosDocumentoCommand()
                {
                     Tipo = TipoDocumentoInscricao.Cpf,
                    Valor = "12345678901" // CPF inválido
                }
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("InfosDocumento[0].Valor")
            .WithErrorMessage("CPF inválido.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeFiadorExcederLimiteCaracteresAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosSeguroFianca = new List<CriarInfosSeguroFiancaCommand>()
            {
                new CriarInfosSeguroFiancaCommand()
                {
                    NomeFiador = new string('A', 151),
                }
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("InfosSeguroFianca[0].NomeFiador")
            .WithErrorMessage("O nome do fiador deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoDocumentoFiadorExcederLimiteCaracteresAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosSeguroFianca = new List<CriarInfosSeguroFiancaCommand>()
            {
                new CriarInfosSeguroFiancaCommand()
                {
                    ValorDocumento = new string('A', 151),
                }
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("InfosSeguroFianca[0].ValorDocumento")
            .WithErrorMessage("O documento do fiador deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoContatoFiadorExcederLimiteCaracteresAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosSeguroFianca = new List<CriarInfosSeguroFiancaCommand>()
            {
                new CriarInfosSeguroFiancaCommand()
                {
                    ValorContato = new string('A', 151),
                }
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("InfosSeguroFianca[0].ValorContato")
            .WithErrorMessage("O contato do fiador deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoAcessibilidadeNaoExistirAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosAcessibilidade = new List<CriarInfosAcessibilidadeCommand>()
            {
                new CriarInfosAcessibilidadeCommand()
                {
                    AcessibilidadeKey = Guid.NewGuid()
                }
            },
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("InfosAcessibilidade[0].AcessibilidadeKey.Value")
            .WithErrorMessage("Chave da acessibilidade não encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoDeficienciaNaoExistirAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosDeficiencia = new List<CriarInfosDeficienciaCommand>()
            {
                new CriarInfosDeficienciaCommand()
                {
                    DeficienciaKey = Guid.NewGuid()
                }
            },
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("InfosDeficiencia[0].DeficienciaKey.Value")
            .WithErrorMessage("Chave da deficiência não encontrada.");
    }


    [Fact]
    public async Task DeveTerErroQuandoEstadoEscolaridadeNaoExistirAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosEscolaridade = new List<CriarInfosEscolaridadeCommand>()
            {
                new CriarInfosEscolaridadeCommand() 
                {
                    Nivel = TipoEscolaridadeInscricao.EnsinoSuperior,
                    EstadoKey = Guid.NewGuid(),
                }                
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("InfosEscolaridade[0].EstadoKey")
            .WithErrorMessage("Estado da escolaridade não encontrado.");
    }

    [Fact]
    public async Task DeveTerErroQuandoEscolaNaoExistirAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosEscolaridade = new List<CriarInfosEscolaridadeCommand>()
            {
                new CriarInfosEscolaridadeCommand()
                {
                    EscolaKey = Guid.NewGuid(),
                }
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("InfosEscolaridade[0].EscolaKey.Value")
            .WithErrorMessage("Escola não encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoFormaEntradaNaoExistirAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosOferta = new CriarInfosOfertaCommand
            {
                FormaEntradaKey = Guid.NewGuid()
            },
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.InfosOferta!.FormaEntradaKey!.Value)
            .WithErrorMessage("Chave da forma de entrada não encontrada.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroLimiteCaracteresUrlAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfoOrigem = new CriarInfosOrigemCommand
            {
                Url = new string('A', 251),
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.InfoOrigem!.Url)
            .WithErrorMessage("A URL da origem deve ter no máximo 250 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoOpcaoAcessoNaoExistirAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosOferta = new CriarInfosOfertaCommand
            {
                OfertaConcursoOpcaoAcessos = new List<CriarInfoOfertaOpcaoAcessoCommand>()
                {
                    new CriarInfoOfertaOpcaoAcessoCommand()
                    {
                        Key = Guid.NewGuid(),
                    }
                }
            },
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("InfosOferta.OfertaConcursoOpcaoAcessos[0].Key")
            .WithErrorMessage("Chave da opção de acesso não encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoEmpresaNaoExistirAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosEmpresa = new CriarInfosEmpresaCommand
            {
                EmpresaKey = Guid.NewGuid()
            },
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.InfosEmpresa!.EmpresaKey!.Value)
            .WithErrorMessage("Empresa não encontrada.");
    }

     [Fact]
    public async Task DeveTerErroQuandoOutraEmpresaUltrapassar200CaracteresAsync()
    {
        // Arrange
        var command = new CriarInscricaoCandidatoCommand
        {
            InfosEmpresa = new CriarInfosEmpresaCommand
            {
                OutraEmpresa = new string('1', 201)
            },
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.InfosEmpresa!.OutraEmpresa)
            .WithErrorMessage("Outra empresa deve ter no máximo 200 caracteres.");
    }
}
