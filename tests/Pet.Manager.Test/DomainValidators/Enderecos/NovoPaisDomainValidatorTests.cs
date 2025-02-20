using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Enderecos.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Enderecos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovoPaisDomainValidatorTests
{
    private readonly IPaisRepository _paisRepository;
    private readonly NovoPaisDomainValidator _validator;

    public NovoPaisDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _paisRepository = databaseFixture.ServiceProvider.GetRequiredService<IPaisRepository>();
        _validator = new(_paisRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        string nome = EnderecoConstants.PaisBrasil.Nome;

        // Act
        var resultado = _validator.Validate(nome);

        // Assert
        resultado.Should().BeFalse();
    }
}
