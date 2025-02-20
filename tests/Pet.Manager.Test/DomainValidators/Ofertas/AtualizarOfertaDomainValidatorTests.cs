using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Ofertas.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Ofertas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarOfertaDomainValidatorTests
{
    private readonly IOfertaRepository _ofertaRepository;
    private readonly AtualizacaoOfertaDomainValidator _validator;

    public AtualizarOfertaDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _ofertaRepository = databaseFixture.ServiceProvider.GetRequiredService<IOfertaRepository>();
        _validator = new(_ofertaRepository);
    }

    [Fact]
    public void DeveValidarOfertaUnica()
    {
        // Arrange
        var ofertaId = OfertaConstants.OfertaTeste2.Id;
        var produtoId = OfertaConstants.OfertaTeste1.ProdutoId;
        var intakeId = OfertaConstants.OfertaTeste1.IntakeId;


        // Act
        var resultado = _validator.Validate(ofertaId, produtoId, intakeId);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeForProdutoDiferente()
    {
        // Arrange
        var ofertaId = OfertaConstants.OfertaTeste1.Id;
        var produtoId = OfertaConstants.OfertaTeste1.ProdutoId;
        var intakeId = OfertaConstants.OfertaTeste1.IntakeId;

        // Act
        var resultado = _validator.Validate(ofertaId, produtoId, intakeId);

        // Assert
        resultado.Should().BeTrue();
    }
}
