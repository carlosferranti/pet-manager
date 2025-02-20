using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.IntegracaoSistemas.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.SistemasIntegracao;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovoSistemaIntegracaoDomainValidatorTests
{
    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;
    private readonly NovaIntegracaoSistemaDomainValidator _validator;

    public NovoSistemaIntegracaoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _sistemasIntegracaoRepository = databaseFixture.ServiceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
        _validator = new(_sistemasIntegracaoRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        string nome = IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Nome;

        // Act
        var resultado = _validator.Validate(nome);

        // Assert
        resultado.Should().BeFalse();
    }
}
