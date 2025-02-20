using Anima.Inscricao.Domain.Configuracoes;
using Anima.Inscricao.Domain.Configuracoes.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Configuracoes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovaConfiguracaoDomainValidatorTests
{
    private readonly IConfiguracaoRepository _configuracaoRepository;
    private readonly NovaConfiguracaoDomainValidator _validator;

    public NovaConfiguracaoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _configuracaoRepository = databaseFixture.ServiceProvider.GetRequiredService<IConfiguracaoRepository>();
        _validator = new(_configuracaoRepository);
    }

    [Fact]
    public void DeveValidarChavesUnicas()
    {
        // Arrange
        string chave = ConfiguracaoConstants.ConfiguracaoPadrao2.ChaveGenerica;

        // Act
        var resultado = _validator.Validate(chave);

        // Assert
        resultado.Should().BeFalse();
    }
}
