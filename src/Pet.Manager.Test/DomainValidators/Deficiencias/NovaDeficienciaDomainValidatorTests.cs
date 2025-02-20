using Anima.Inscricao.Domain.Deficiencias;
using Anima.Inscricao.Domain.Deficiencias.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Deficiencias;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovaDeficienciaDomainValidatorTests
{
    private readonly IDeficienciaRepository _deficienciaRepository;
    private readonly NovaDeficienciaDomainValidator _validator;

    public NovaDeficienciaDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _deficienciaRepository = databaseFixture.ServiceProvider.GetRequiredService<IDeficienciaRepository>();
        _validator = new(_deficienciaRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        string nome = DeficienciaConstants.Cegueira.Nome;

        // Act
        var resultado = _validator.Validate(nome);

        // Assert
        resultado.Should().BeFalse();
    }
}
