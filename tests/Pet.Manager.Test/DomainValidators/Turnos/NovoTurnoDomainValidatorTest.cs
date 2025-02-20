using Anima.Inscricao.Domain.Turnos;
using Anima.Inscricao.Domain.Turnos.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Turnos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovoTurnoDomainValidatorTest
{

    private readonly ITurnoRepository _turnoRepository;
    private readonly NovoTurnoDomainValidator _validator;

    public NovoTurnoDomainValidatorTest(DatabaseFixture databaseFixture)
    {
        _turnoRepository = databaseFixture.ServiceProvider.GetRequiredService<ITurnoRepository>();
        _validator = new(_turnoRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        string nome = TurnoConstants.TurnoIntegral.Nome;

        // Act
        var resultado = _validator.Validate(nome);

        // Assert
        resultado.Should().BeFalse();
    }

}
