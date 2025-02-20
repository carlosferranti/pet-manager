using Anima.Inscricao.Domain.Marcas.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Marcas;

public class NovaIntegracaoMarcaDomainValidatorTests
{
    private readonly NovaIntegracaoMarcaDomainValidator _validator;

    public NovaIntegracaoMarcaDomainValidatorTests()
    {
        _validator = new();

        new ServiceExtensions()
           .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public void DeveValidarIntegracaoUnicaParaMarca()
    {
        // Arrange
        var marca = MarcaConstants.Unifg;

        // Act
        var resultado = _validator.Validate(marca, marca.IntegracoesMarcas.FirstOrDefault()!.IntegracaoSistemaId);

        // Assert
        resultado.Should().BeFalse();
    }
}
