using Anima.Inscricao.Domain.Configuracoes.Entities;
using Anima.Inscricao.Domain.Configuracoes.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.Configuracoes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverConfiguracaoDomainValidatorTests
{
    private readonly RemoverConfiguracaoDomainValidator _validator;

    public RemoverConfiguracaoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validator = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirRegistro()
    {
        // Arrange
        ConfiguracaoId configuracaoId = ConfiguracaoConstants.ConfiguracaoPadrao.Id;

        // Act
        var resultado = _validator.Validate(configuracaoId);

        // Assert
        resultado.Should().BeTrue();
    }
}
