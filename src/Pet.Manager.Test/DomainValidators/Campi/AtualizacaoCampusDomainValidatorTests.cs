using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Campi.Entities;
using Anima.Inscricao.Domain.Campi.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Campi;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizacaoCampusDomainValidatorTests
{
    private readonly ICampusRepository _campusRepository;
    private readonly AtualizacaoCampusDomainValidator _validator;

    public AtualizacaoCampusDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _campusRepository = databaseFixture.ServiceProvider.GetRequiredService<ICampusRepository>();
        _validator = new(_campusRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        CampusId campusId = CampusConstants.CampusRecife.Id;
        string nome = CampusConstants.CampusMooca.Nome;
        string? nomeComercial = CampusConstants.CampusMooca.NomeComercial;

        // Act
        var resultado = _validator.Validate(campusId, nome, nomeComercial);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeONomeForIgual()
    {
        // Arrange
        CampusId campusId = CampusConstants.CampusRecife.Id;
        string nome = CampusConstants.CampusRecife.Nome;

        // Act
        var resultado = _validator.Validate(campusId, nome, null);

        // Assert
        resultado.Should().BeTrue();
    }
}
