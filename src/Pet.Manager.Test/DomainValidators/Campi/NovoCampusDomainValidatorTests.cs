using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Campi.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Campi;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovoCampusDomainValidatorTests
{
    private readonly ICampusRepository _campusRepository;
    private readonly NovoCampusDomainValidator _validator;

    public NovoCampusDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _campusRepository = databaseFixture.ServiceProvider.GetRequiredService<ICampusRepository>();
        _validator = new(_campusRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        string nome = CampusConstants.CampusMooca.Nome;
        string? nomeComercial = CampusConstants.CampusMooca.NomeComercial;

        // Act
        var resultado = _validator.Validate(nome, nomeComercial, null);

        // Assert
        resultado.Should().BeFalse();
    }
}
