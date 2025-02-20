using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Ofertas.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Ofertas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovaOfertaDomainValidatorTests
{
    private readonly IOfertaRepository _ofertaRepository;
    private readonly NovaOfertaDomainValidator _novaOfertaDomainValidator;

    public NovaOfertaDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _ofertaRepository = databaseFixture.ServiceProvider.GetRequiredService<IOfertaRepository>();
        _novaOfertaDomainValidator = new(_ofertaRepository);
    }

    [Fact]
    public void DeveValidarOfertasUnicasNoCadastro()
    {
        // Arrange
        var produtoId = OfertaConstants.OfertaTeste1.ProdutoId;
        var intakeId = OfertaConstants.OfertaTeste1.IntakeId;

        // Act
        var resultado = _novaOfertaDomainValidator.Validate(produtoId, intakeId);
        // Assert
        resultado.Should().BeFalse();
    }
}
