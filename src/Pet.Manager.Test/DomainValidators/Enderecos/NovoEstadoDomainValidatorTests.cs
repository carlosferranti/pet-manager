using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Enderecos.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Enderecos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovoEstadoDomainValidatorTests
{
    private readonly IEstadoRepository _estadoRepository;
    private readonly NovoEstadoDomainValidator _validator;

    public NovoEstadoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _estadoRepository = databaseFixture.ServiceProvider.GetRequiredService<IEstadoRepository>();
        _validator = new(_estadoRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        var nome = EnderecoConstants.EstadoRS.Nome;
        var paisId = EnderecoConstants.PaisBrasil.Id;

        // Act
        var resultado = _validator.Validate(paisId, nome);

        // Assert
        resultado.Should().BeFalse();
    }
}