using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.Marcas.Entities;
using Anima.Inscricao.Domain.Marcas.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Marcas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizacaoMarcaDomainValidatorTests
{
    private readonly IMarcaRepository _marcaRepository;
    private readonly AtualizacaoMarcaDomainValidator _validator;

    public AtualizacaoMarcaDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _marcaRepository = databaseFixture.ServiceProvider.GetRequiredService<IMarcaRepository>();
        _validator = new(_marcaRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        MarcaId marcaId = MarcaConstants.Una.Id;
        string nome = MarcaConstants.UnaLive.Nome;
        string sigla = MarcaConstants.UnaLive.Sigla;

        // Act
        var resultado = _validator.Validate(marcaId, nome, sigla);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeONomeForIgual()
    {
        // Arrange
        MarcaId marcaId = MarcaConstants.Una.Id;
        string nome = MarcaConstants.Una.Nome;
        string sigla = MarcaConstants.Una.Sigla;

        // Act
        var resultado = _validator.Validate(marcaId, nome, sigla);

        // Assert
        resultado.Should().BeTrue();
    }
}
