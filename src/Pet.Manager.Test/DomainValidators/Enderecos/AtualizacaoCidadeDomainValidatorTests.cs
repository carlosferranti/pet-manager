using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Enderecos.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Enderecos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizacaoCidadeDomainValidatorTests
{
    private readonly ICidadeRepository _cidadeRepository;
    private readonly AtualizacaoCidadeDomainValidator _validator;

    public AtualizacaoCidadeDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _cidadeRepository = databaseFixture.ServiceProvider.GetRequiredService<ICidadeRepository>();
        _validator = new(_cidadeRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        var cidadeId = EnderecoConstants.CidadeCampinas.Id;
        var nome = EnderecoConstants.CidadeSaoPaulo.Nome;
        var estadoId = EnderecoConstants.EstadoSP.Id;

        // Act
        var resultado = _validator.Validate(cidadeId, estadoId, nome);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeORegistroForOMesmo()
    {
        // Arrange
        var cidadeId = EnderecoConstants.CidadeCampinas.Id;
        var nome = EnderecoConstants.CidadeCampinas.Nome;
        var estadoId = EnderecoConstants.EstadoSP.Id;

        // Act
        var resultado = _validator.Validate(cidadeId, estadoId, nome);

        // Assert
        resultado.Should().BeTrue();
    }
}
