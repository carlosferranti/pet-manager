using Anima.Inscricao.Domain.Campos;
using Anima.Inscricao.Domain.Campos.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Campos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovoCampoDomainValidatorTests
{
    private readonly ICampoRepository _campoRepository;
    private readonly NovoCampoDomainValidator _validator;

    public NovoCampoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _campoRepository = databaseFixture.ServiceProvider.GetRequiredService<ICampoRepository>();
        _validator = new(_campoRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        string nome = CampoConstants.CPF.Nome;

        // Act
        var resultado = _validator.Validate(nome);

        // Assert
        resultado.Should().BeFalse();
    }
}
