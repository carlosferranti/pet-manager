using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Enderecos.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Enderecos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizacaoPaisDomainValidatorTests
{
    private readonly IPaisRepository _paisRepository;
    private readonly AtualizacaoPaisDomainValidator _validator;

    public AtualizacaoPaisDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _paisRepository = databaseFixture.ServiceProvider.GetRequiredService<IPaisRepository>();
        _validator = new(_paisRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        var paisId = EnderecoConstants.PaisArgentina.Id;
        string nome = EnderecoConstants.PaisBrasil.Nome;

        // Act
        var resultado = _validator.Validate(paisId, nome);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeONomeForIgual()
    {
        // Arrange
        var paisId = EnderecoConstants.PaisBrasil.Id;
        string nome = EnderecoConstants.PaisBrasil.Nome;

        // Act
        var resultado = _validator.Validate(paisId, nome);

        // Assert
        resultado.Should().BeTrue();
    }
}