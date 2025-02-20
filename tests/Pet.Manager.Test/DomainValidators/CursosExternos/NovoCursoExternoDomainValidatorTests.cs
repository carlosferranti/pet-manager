using Anima.Inscricao.Domain.CursosExternos;
using Anima.Inscricao.Domain.CursosExternos.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.CursosExternos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovoCursoExternoDomainValidatorTests
{
    private readonly ICursoExternoRepository _cursoExternoRepository;
    private readonly NovoCursoExternoDomainValidator _validator;

    public NovoCursoExternoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _cursoExternoRepository = databaseFixture.ServiceProvider.GetRequiredService <ICursoExternoRepository>();
        _validator = new(_cursoExternoRepository);
    }

    [Fact]
    public void DeveValidarCodigosUnicos()
    {
        // Arrange
        string codigo = CursoExternoConstants.Radialismo.Nome;

        // Act
        var resultado = _validator.Validate(codigo);

        // Assert
        resultado.Should().BeFalse();
    }
}
