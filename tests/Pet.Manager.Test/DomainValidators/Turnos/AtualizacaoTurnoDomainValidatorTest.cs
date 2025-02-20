using Anima.Inscricao.Domain.Turnos;
using Anima.Inscricao.Domain.Turnos.Entities;
using Anima.Inscricao.Domain.Turnos.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Turnos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizacaoTurnoDomainValidatorTest
{
    private readonly ITurnoRepository _turnoRepository;
    private readonly AtualizacaoTurnoDomainValidator _validator;

    public AtualizacaoTurnoDomainValidatorTest(DatabaseFixture databaseFixture)
    {
        _turnoRepository = databaseFixture.ServiceProvider.GetRequiredService<ITurnoRepository>();
        _validator = new(_turnoRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        TurnoId turnoId = TurnoConstants.TurnoManha.Id;
        string nome = TurnoConstants.TurnoTarde.Nome;

        // Act
        var resultado = _validator.Validate(turnoId, nome);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeONomeForIgual()
    {
        // Arrange
        TurnoId turnoId = TurnoConstants.TurnoManha.Id;
        string nome = TurnoConstants.TurnoManha.Nome;

        // Act
        var resultado = _validator.Validate(turnoId, nome);

        // Assert
        resultado.Should().BeTrue();
    }
}
