using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Enderecos.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Enderecos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovaCidadeDomainValidatorTests
{
    private readonly ICidadeRepository _cidadeRepository;
    private readonly NovaCidadeDomainValidator _validator;

    public NovaCidadeDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _cidadeRepository = databaseFixture.ServiceProvider.GetRequiredService<ICidadeRepository>();
        _validator = new(_cidadeRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        var nome = EnderecoConstants.CidadeCampinas.Nome;
        var estadoId = EnderecoConstants.CidadeCampinas.EstadoId;

        // Act
        var resultado = _validator.Validate(estadoId, nome);

        // Assert
        resultado.Should().BeFalse();
    }
}