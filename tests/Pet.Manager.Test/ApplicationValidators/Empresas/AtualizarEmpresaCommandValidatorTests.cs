using Anima.Inscricao.Application.UseCases.Empresas.AtualizarEmpresa;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Empresas;
using Anima.Inscricao.Domain.Enderecos;

using FluentValidation.TestHelper;

using Moq;

using static Anima.Inscricao.Application.UseCases.Empresas.AtualizarEmpresa.AtualizarEmpresaCommand;

namespace Anima.Inscricao.Test.ApplicationValidators.Empresas;

public class AtualizarEmpresaCommandValidatorTests
{
    private readonly AtualizarEmpresaCommandValidator _validator;
    private readonly Mock<ICidadeRepository> _cidadeRepositoryMock = new();
    private readonly Mock<IEmpresaRepository> _empresaRepositoryMock = new();
    private readonly Mock<INotificationContext> _notificationContextMock = new();

    public AtualizarEmpresaCommandValidatorTests()
    {
        _validator = new AtualizarEmpresaCommandValidator(
            _notificationContextMock.Object,
            _cidadeRepositoryMock.Object,
            _empresaRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoKeyVaziaAsync()
    {
        // Arrange
        var command = new AtualizarEmpresaCommand
        {
            Key = Guid.Empty,
            NomeFantasia = "Empresa Teste",
            RazaoSocial = "Empresa Teste LTDA",
            Cnpj = "12345678901234"
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Key);
    }

    [Fact]
    public async Task DeveTerErroQuandoRazaoSocialVaziaAsync()
    {
        // Arrange
        var command = new AtualizarEmpresaCommand
        {
            Key = Guid.NewGuid(),
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
        var command = new AtualizarEmpresaCommand
        {
            Key = Guid.NewGuid(),
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
        var command = new AtualizarEmpresaCommand
        {
            Key = Guid.NewGuid(),
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
        var command = new AtualizarEmpresaCommand
        {
            Key = Guid.NewGuid(),
            NomeFantasia = "Empresa Teste",
            RazaoSocial = "Empresa Teste LTDA",
            Cnpj = "12345678901234",
            Enderecos = new List<AtualizarEnderecoEmpresaCommand>
            {
                new AtualizarEnderecoEmpresaCommand()
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
        var command = new AtualizarEmpresaCommand
        {
            Key = Guid.NewGuid(),
            NomeFantasia = "Empresa Teste",
            RazaoSocial = "Empresa Teste LTDA",
            Cnpj = "12345678901234",
            Enderecos = new List<AtualizarEnderecoEmpresaCommand>
            {
                new AtualizarEnderecoEmpresaCommand()
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
        var command = new AtualizarEmpresaCommand
        {
            Key = Guid.NewGuid(),
            NomeFantasia = "Empresa Teste",
            RazaoSocial = "Empresa Teste LTDA",
            Cnpj = "12345678901234",
            Enderecos = new List<AtualizarEnderecoEmpresaCommand>
            {
                new AtualizarEnderecoEmpresaCommand()
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
        var command = new AtualizarEmpresaCommand
        {
            Key = Guid.NewGuid(),
            NomeFantasia = "Empresa Teste",
            RazaoSocial = "Empresa Teste LTDA",
            Cnpj = "12345678901234",
            Enderecos = new List<AtualizarEnderecoEmpresaCommand>
            {
                new AtualizarEnderecoEmpresaCommand()
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
    public async Task DeveTerErroQuandoEmpresaNaoEncontradaAsync()
    {
        // Arrange
        var command = new AtualizarEmpresaCommand
        {
            Key = Guid.NewGuid(),
            NomeFantasia = "Empresa Teste",
            RazaoSocial = "Empresa Teste LTDA",
            Cnpj = "12345678901234"
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Key);
    }

    [Fact]
    public async Task NaoDeveExistirErrosQuandoPreenchidoCorretoAsync()
    {
        // Arrange
        _empresaRepositoryMock
            .Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(true);

        var command = new AtualizarEmpresaCommand
        {
            Key = Guid.NewGuid(),
            NomeFantasia = "Empresa Teste",
            RazaoSocial = "Empresa Teste LTDA",
            Cnpj = "54.615.102/0001-40"
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldNotHaveAnyValidationErrors();
    }
}