using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.UseCases.Inscricoes.AtualizarInscricaoCandidato;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Acessibilidades;
using Anima.Inscricao.Domain.CursosExternos;
using Anima.Inscricao.Domain.Deficiencias;
using Anima.Inscricao.Domain.Empresas;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Inscricoes.Enums;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricoes.Domain.Inscricoes;

using FluentValidation.TestHelper;

using Moq;

using static Anima.Inscricao.Application.UseCases.Inscricoes.AtualizarInscricaoCandidato.AtualizarInscricaoCandidatoCommand;

namespace Anima.Inscricao.Test.ApplicationValidators.Inscricoes;

public class AtualizarInscricaoCandidatoCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationMock = new();
    private readonly Mock<IFichaRepository> _fichaRepositoryMock = new();
    private readonly Mock<IEtapaTemplateRepository> _etapaTemplateRepositoryMock = new();
    private readonly Mock<IEstadoRepository> _estadoRepository = new();
    private readonly Mock<ICidadeRepository> _cidadeRepository = new();
    private readonly Mock<IEscolaRepository> _escolaRepository = new();
    private readonly Mock<IOfertaConcursoRepository> _ofertaConcursoRepository = new();
    private readonly Mock<IOfertaRepository> _ofertaRepository = new();
    private readonly Mock<IAcessibilidadeRepository> _acessibilidadeRepository = new();
    private readonly Mock<IDeficienciaRepository> _deficienciaRepository = new();
    private readonly Mock<IInscricaoRepository> _inscricaoRepository = new();
    private readonly Mock<IFormaEntradaRepository> _formaEntradaRepository = new();
    private readonly Mock<IOfertaConcursoOpcaoAcessoRepository> _ofertaConcursoOpcaoAcessoRepository = new();
    private readonly Mock<IEmpresaRepository> _empresaRepository = new();
    private readonly AtualizarInscricaoCandidatoCommandValidator _validator;
    private readonly Mock<ICursoExternoRepository> _cursoExternoRepository = new();

    public AtualizarInscricaoCandidatoCommandValidatorTests()
    {
        _validator = new AtualizarInscricaoCandidatoCommandValidator(
            _notificationMock.Object,
            _fichaRepositoryMock.Object,
            _ofertaRepository.Object,
            _ofertaConcursoRepository.Object,
            _estadoRepository.Object,
            _cidadeRepository.Object,
            _escolaRepository.Object,
            _deficienciaRepository.Object,
            _acessibilidadeRepository.Object,
            _etapaTemplateRepositoryMock.Object,
            _inscricaoRepository.Object,
            _formaEntradaRepository.Object,
            _ofertaConcursoOpcaoAcessoRepository.Object,
            _empresaRepository.Object,
            _cursoExternoRepository.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoOfertaNaoExistirAsync()
    {
        // Arrange
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosOferta = new AtualizarInfosOfertaCommand
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosOferta = new AtualizarInfosOfertaCommand
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosPessoais = new AtualizarInfosPessoaisCommand()
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosPessoais = new AtualizarInfosPessoaisCommand()
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosPessoais = new AtualizarInfosPessoaisCommand()
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosPessoais = new AtualizarInfosPessoaisCommand()
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosContato = new List<AtualizarInfosContatoCommand>()
            {
                new AtualizarInfosContatoCommand()
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosContato = new List<AtualizarInfosContatoCommand>()
            {
                new AtualizarInfosContatoCommand()
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosCupons = new List<AtualizarInfosCupomCommand>()
            {
                new AtualizarInfosCupomCommand()
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosEndereco = new List<AtualizarInfosEnderecoCommand>()
            {
                new AtualizarInfosEnderecoCommand()
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosEndereco = new List<AtualizarInfosEnderecoCommand>()
            {
                new AtualizarInfosEnderecoCommand()
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosEndereco = new List<AtualizarInfosEnderecoCommand>()
            {
                new AtualizarInfosEnderecoCommand()
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosEndereco = new List<AtualizarInfosEnderecoCommand>()
            {
                new AtualizarInfosEnderecoCommand()
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosEndereco = new List<AtualizarInfosEnderecoCommand>()
            {
                new AtualizarInfosEnderecoCommand()
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosEndereco = new List<AtualizarInfosEnderecoCommand>()
            {
                new AtualizarInfosEnderecoCommand()
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosEndereco = new List<AtualizarInfosEnderecoCommand>()
            {
                new AtualizarInfosEnderecoCommand()
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosDocumento = new List<AtualizarInfosDocumentoCommand>()
            {
                new AtualizarInfosDocumentoCommand()
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosDocumento = new List<AtualizarInfosDocumentoCommand>()
            {
                new AtualizarInfosDocumentoCommand()
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosSeguroFianca = new List<AtualizarInfosSeguroFiancaCommand>()
            {
                new AtualizarInfosSeguroFiancaCommand()
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosSeguroFianca = new List<AtualizarInfosSeguroFiancaCommand>()
            {
                new AtualizarInfosSeguroFiancaCommand()
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosSeguroFianca = new List<AtualizarInfosSeguroFiancaCommand>()
            {
                new AtualizarInfosSeguroFiancaCommand()
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosAcessibilidade = new List<AtualizarInfosAcessibilidadeCommand>()
            {
                new AtualizarInfosAcessibilidadeCommand()
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosDeficiencia = new List<AtualizarInfosDeficienciaCommand>()
            {
                new AtualizarInfosDeficienciaCommand()
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosEscolaridade = new List<AtualizarInfosEscolaridadeCommand>()
            {
                new AtualizarInfosEscolaridadeCommand()
                {
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosEscolaridade = new List<AtualizarInfosEscolaridadeCommand>()
            {
                new AtualizarInfosEscolaridadeCommand()
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
    public async Task DeveTerErroQuandoEtapaNaoExistirAsync()
    {
        // Arrange
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosFicha = new AtualizarInfosFichaCommand()
            {
                EtapaKey = Guid.Empty,
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.InfosFicha!.EtapaKey)
            .WithErrorMessage("Etapa da inscrição não encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveInscricaoNaoExistirAsync()
    {
        // Arrange
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InscricaoKey = Guid.NewGuid(),
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.InscricaoKey)
            .WithErrorMessage("Inscrição não encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveInscricaoForVaziaAsync()
    {
        // Arrange
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InscricaoKey = Guid.Empty,
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.InscricaoKey)
            .WithErrorMessage("A chave da inscrição é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoFormaEntradaNaoExistirAsync()
    {
        // Arrange
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosOferta = new AtualizarInfosOfertaCommand
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
    public async Task DeveTerErroQuandoOpcaoAcessoNaoExistirAsync()
    {
        // Arrange
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosOferta = new AtualizarInfosOfertaCommand
            {
                OfertaConcursoOpcaoAcessos = new List<AtualizarInfoOfertaOpcaoAcessoCommand>()
                {
                    new AtualizarInfoOfertaOpcaoAcessoCommand()
                    {
                        Key = Guid.NewGuid()
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosEmpresa = new AtualizarInfosEmpresaCommand
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
        var command = new AtualizarInscricaoCandidatoCommand
        {
            InfosEmpresa = new AtualizarInfosEmpresaCommand
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