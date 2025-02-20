using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.Intakes.Validators;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.Modalidades.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Intakes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovoIntakeDomainValidatorTests
{
    private readonly IIntakeRepository _intakeRepository;
    private readonly NovoIntakeDomainValidator _validator;

    public NovoIntakeDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _intakeRepository = databaseFixture.ServiceProvider.GetRequiredService<IIntakeRepository>();
        _validator = new(_intakeRepository);
    }

    [Fact]
    public void DeveValidarIntakesUnicos()
    {
        // Arrange
        string nome = IntakeConstants.IntakeSegundoSemestre.Nome;
        var vigencia = IntakeConstants.IntakeSegundoSemestre.Vigencia;

        // Act
        var resultado = _validator.Validate(nome, vigencia);

        // Assert
        resultado.Should().BeFalse();
    }
}
