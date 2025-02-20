using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.Intakes.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Intakes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizacaoIntakeDomainValidatorTests
{
    private readonly IIntakeRepository _intakeRepository;
    private readonly AtualizacaoIntakeDomainValidator _validator;

    public AtualizacaoIntakeDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _intakeRepository = databaseFixture.ServiceProvider.GetRequiredService<IIntakeRepository>();
        _validator = new(_intakeRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        var intakeId = IntakeConstants.IntakePrimeiroSemestre.Id;
        string nome = IntakeConstants.IntakeSegundoSemestre.Nome;
        var vigencia = IntakeConstants.IntakeSegundoSemestre.Vigencia;
        
        // Act
        var resultado = _validator.Validate(intakeId, nome, vigencia);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeForMesmoRegistro()
    {
        // Arrange
        var intakeId = IntakeConstants.IntakePrimeiroSemestre.Id;
        string nome = IntakeConstants.IntakePrimeiroSemestre.Nome;
        var vigencia = IntakeConstants.IntakePrimeiroSemestre.Vigencia;

        // Act
        var resultado = _validator.Validate(intakeId, nome, vigencia);

        // Assert
        resultado.Should().BeTrue();
    }
}
