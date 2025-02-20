using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.FormasEntrada.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.FormasEntrada;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizacaoFormaEntradaDomainValidatorTests
{
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly AtualizacaoFormaEntradaDomainValidator _validator;

    public AtualizacaoFormaEntradaDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _formaEntradaRepository = databaseFixture.ServiceProvider.GetRequiredService<IFormaEntradaRepository>();
        _validator = new(_formaEntradaRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicosNaAtualizacao()
    {
        // Arrange
        var formaEntradaId = FormaEntradaConstants.FormaEntradaVestibular.Id;
        string nome = FormaEntradaConstants.FormaEntradaEnem.Nome;

        // Act
        var resultado = _validator.Validate(formaEntradaId, nome);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeForMesmoRegistro()
    {
        // Arrange
        var formaEntradaId = FormaEntradaConstants.FormaEntradaVestibular.Id;
        string nome = FormaEntradaConstants.FormaEntradaVestibular.Nome;

        // Act
        var resultado = _validator.Validate(formaEntradaId, nome);

        // Assert
        resultado.Should().BeTrue();
    }
}
