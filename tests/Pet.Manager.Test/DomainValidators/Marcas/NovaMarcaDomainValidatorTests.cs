using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.Marcas.Validators;
using Anima.Inscricao.Test._Shared.Tests;
using Microsoft.Extensions.DependencyInjection;
using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.Marcas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovaMarcaDomainValidatorTests
{
    private readonly IMarcaRepository _marcaRepository;
    private readonly NovaMarcaDomainValidator _validator;

    public NovaMarcaDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _marcaRepository = databaseFixture.ServiceProvider.GetRequiredService<IMarcaRepository>();
        _validator = new(_marcaRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        string nome = MarcaConstants.Unibh.Nome;
        string sigla = MarcaConstants.Unibh.Sigla;

        // Act
        var resultado = _validator.Validate(nome, sigla);

        // Assert
        resultado.Should().BeFalse();
    }
}
