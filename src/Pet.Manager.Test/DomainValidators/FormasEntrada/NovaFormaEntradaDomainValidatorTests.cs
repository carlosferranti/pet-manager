using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.FormasEntrada.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.FormasEntrada;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovaFormaEntradaDomainValidatorTests
{
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly NovaFormaEntradaDomainValidator _validator;

    public NovaFormaEntradaDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _formaEntradaRepository = databaseFixture.ServiceProvider.GetRequiredService<IFormaEntradaRepository>();
        _validator = new(_formaEntradaRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicosNoCadastro()
    {
        // Arrange
        string nome = FormaEntradaConstants.FormaEntradaEnem.Nome;

        // Act
        var resultado = _validator.Validate(nome);

        // Assert
        resultado.Should().BeFalse();
    }
}
