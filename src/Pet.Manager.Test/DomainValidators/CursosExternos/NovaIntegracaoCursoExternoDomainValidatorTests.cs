using Anima.Inscricao.Domain.CursosExternos.Validators;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.CursosExternos;

public class NovaIntegracaoCursoExternoDomainValidatorTests
{
    private readonly NovaIntegracaoCursoExternoDomainValidator _validator;

    public NovaIntegracaoCursoExternoDomainValidatorTests()
    {
        _validator = new();

        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public void DeveValidarSistemaIntegradorUnicoParaCursoExterno()
    {
        // Arrange
        var cursoExterno = CursoExternoConstants.AbiArtesVisuais;
        var integracaoSistemaId = new IntegracaoSistemaId(1);

        // Act
        var resultado = _validator.Validate(cursoExterno, integracaoSistemaId);

        // Assert
        resultado.Should().BeFalse();
    }
}
