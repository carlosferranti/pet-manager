using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Enderecos.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Enderecos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizacaoEstadoDomainValidatorTests
{
    private readonly IEstadoRepository _estadoRepository;
    private readonly AtualizacaoEstadoDomainValidator _validator;

    public AtualizacaoEstadoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _estadoRepository = databaseFixture.ServiceProvider.GetRequiredService<IEstadoRepository>();
        _validator = new(_estadoRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        var estadoId = EnderecoConstants.EstadoRJ.Id;
        var nome = EnderecoConstants.EstadoSP.Nome;
        var paisId = EnderecoConstants.EstadoSP.PaisId;

        // Act
        var resultado = _validator.Validate(estadoId, paisId, nome);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeORegistroForOMesmo()
    {
        // Arrange
        var estadoId = EnderecoConstants.EstadoRJ.Id;
        var nome = EnderecoConstants.EstadoRJ.Nome;
        var paisId = EnderecoConstants.EstadoRJ.PaisId;

        // Act
        var resultado = _validator.Validate(estadoId, paisId, nome);

        // Assert
        resultado.Should().BeTrue();
    }
}
