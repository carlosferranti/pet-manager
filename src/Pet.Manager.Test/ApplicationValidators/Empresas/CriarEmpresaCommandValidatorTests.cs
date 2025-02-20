using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Anima.Inscricao.Application.UseCases.Deficiencias.CriarDeficiencia;
using Anima.Inscricao.Application.UseCases.Empresas.AtualizarEmpresa;
using Anima.Inscricao.Application.UseCases.Empresas.CriarEmpresa;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Empresas;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using FluentValidation;
using FluentValidation.TestHelper;

using Moq;
using static Anima.Inscricao.Application.UseCases.Empresas.AtualizarEmpresa.AtualizarEmpresaCommand;
using static Anima.Inscricao.Application.UseCases.Empresas.CriarEmpresa.CriarEmpresaCommand;

namespace Anima.Inscricao.Test.ApplicationValidators.Empresas;

public class CriarEmpresaCommandValidatorTests
{
    private readonly CriarEmpresaCommandValidator _validator;
    private readonly Mock<ICidadeRepository> _cidadeRepositoryMock = new();
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IIntegracaoSistemaRepository> _sistemasIntegracaoRepository = new();

    public CriarEmpresaCommandValidatorTests()
    {
        _validator = new CriarEmpresaCommandValidator(
            _notificationContextMock.Object,
            _cidadeRepositoryMock.Object,
            _sistemasIntegracaoRepository.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoRazaoSocialVaziaAsync()
    {
        // Arrange
        var command = new CriarEmpresaCommand
        {
            NomeFantasia = "Empresa Teste",
            RazaoSocial = string.Empty,
            Cnpj = "12345678901234"
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.RazaoSocial);
    }

    [Fact]
    public async Task DeveTerErroQuandoCnpjVazioAsync()
    {
        // Arrange
        var command = new CriarEmpresaCommand
        {
            NomeFantasia = "Empresa Teste",
            RazaoSocial = "Empresa Teste LTDA",
            Cnpj = string.Empty
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Cnpj);
    }

    [Fact]
    public async Task DeveTerErroQuandoCnpjInvalidoAsync()
    {
        // Arrange
        var command = new CriarEmpresaCommand
        {
            NomeFantasia = "Empresa Teste",
            RazaoSocial = "Empresa Teste LTDA",
            Cnpj = "1234567890"
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Cnpj);
    }

    [Fact]
    public async Task DeveTerErroQuandoCepUltrapassaLimiteCaracteresAsync()
    {
        // Arrange
        var command = new CriarEmpresaCommand
        {
            NomeFantasia = "Empresa Teste",
            RazaoSocial = "Empresa Teste LTDA",
            Cnpj = "12345678901234",
            Enderecos = new List<CriarEnderecoEmpresaCommand>
            {
                new CriarEnderecoEmpresaCommand()
                {
                    Cep = new string('a', 100),
                },
            },
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("Enderecos[0].Cep");
    }

    [Fact]
    public async Task DeveTerErroQuandoNumeroUltrapassaLimiteCaracteresAsync()
    {
        // Arrange
        var command = new CriarEmpresaCommand
        {
            NomeFantasia = "Empresa Teste",
            RazaoSocial = "Empresa Teste LTDA",
            Cnpj = "12345678901234",
            Enderecos = new List<CriarEnderecoEmpresaCommand>
            {
                new CriarEnderecoEmpresaCommand()
                {
                    Numero = new string('a', 100),
                },
            },
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("Enderecos[0].Numero");
    }

    [Fact]
    public async Task DeveTerErroQuandoLogradouroUltrapassaLimiteCaracteresAsync()
    {
        // Arrange
        var command = new CriarEmpresaCommand
        {
            NomeFantasia = "Empresa Teste",
            RazaoSocial = "Empresa Teste LTDA",
            Cnpj = "12345678901234",
            Enderecos = new List<CriarEnderecoEmpresaCommand>
            {
                new CriarEnderecoEmpresaCommand()
                {
                    Logradouro = new string('a', 300),
                },
            },
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("Enderecos[0].Logradouro");
    }

    [Fact]
    public async Task DeveTerErroQuandoCidadeNaoEncontradaAsync()
    {
        // Arrange
        var command = new CriarEmpresaCommand
        {
            NomeFantasia = "Empresa Teste",
            RazaoSocial = "Empresa Teste LTDA",
            Cnpj = "12345678901234",
            Enderecos = new List<CriarEnderecoEmpresaCommand>
            {
                new CriarEnderecoEmpresaCommand()
                {
                    CidadeKey = Guid.NewGuid(),
                },
            },
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("Enderecos[0].CidadeKey");
    }

    [Fact]
    public async Task NaoDeveExistirErrosQuandoPreenchidoCorretoAsync()
    {
        // Arrange
        var command = new CriarEmpresaCommand
        {
            NomeFantasia = "Empresa Teste",
            RazaoSocial = "Empresa Teste LTDA",
            Cnpj = "54.615.102/0001-40"
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeSistemaIntegracaoNaoEncontradoAsync()
    {
        var command = new CriarEmpresaCommand
        {
            Integracao = new()
            {
                NomeSistema = "SistemaInexistente",
            },
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Integracao!.NomeSistema)
            .WithErrorMessage("Nome do sistema de integração não encontrado.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeSistemaIntegracaoUltrapassarLimiteAsync()
    {
        var command = new CriarEmpresaCommand
        {
            Integracao = new()
            {
                NomeSistema = new string('a', 251),
            },
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Integracao!.NomeSistema)
            .WithErrorMessage("O nome do sistema de integração deve ter no máximo 250 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoCodigoOrigemUltrapassarLimiteAsync()
    {
        var command = new CriarEmpresaCommand
        {
            Integracao = new()
            {
                CodigoOrigem = new string('a', 150),
            },
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Integracao!.CodigoOrigem)
            .WithErrorMessage("O código de origem da integração deve ter no máximo 100 caracteres.");
    }
}