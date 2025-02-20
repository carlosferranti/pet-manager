using Anima.Inscricao.Domain.Configuracoes;
using Anima.Inscricao.Domain.Configuracoes.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Configuracoes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizacaoConfiguracaoDomainValidatorTestes
{
    private readonly IConfiguracaoRepository _configuracaoRepository;
    private readonly AtualizacaoConfiguracaoDomainValidator _validator;

    public AtualizacaoConfiguracaoDomainValidatorTestes(DatabaseFixture databaseFixture)
    {
        _configuracaoRepository = databaseFixture.ServiceProvider.GetRequiredService<IConfiguracaoRepository>();
        _validator = new(_configuracaoRepository);
    }

    [Fact]
    public void DeveValidarChavesUnicas()
    {
        // Arrange
        var configuracaoid = ConfiguracaoConstants.ConfiguracaoPadrao.Id;
        var  chave = ConfiguracaoConstants.ConfiguracaoPadrao2.ChaveGenerica;

        // Act
        var resultado = _validator.Validate(configuracaoid, chave);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeAChaveForIgual()
    {
        // Arrange
        var configuracaoid = ConfiguracaoConstants.ConfiguracaoPadrao.Id;
        var chave = ConfiguracaoConstants.ConfiguracaoPadrao.ChaveGenerica;

        // Act
        var resultado = _validator.Validate(configuracaoid, chave);

        // Assert
        resultado.Should().BeTrue();
    }
}
