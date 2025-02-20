using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Domain.Etapas.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Etapas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovaEtapaTemplateDomainValidatorTests
{
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;
    private readonly NovaEtapaTemplateDomainValidator _validator;

    public NovaEtapaTemplateDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _etapaTemplateRepository = databaseFixture.ServiceProvider.GetRequiredService<IEtapaTemplateRepository>();
        _validator = new(_etapaTemplateRepository);
    }

    [Fact]
    public void DeveValidarEtapasUnicasNoCadastro()
    {
        // Arrange
        string nome = EtapaConstants.EtapaEndereco.Nome;
        string nomeArquivo = EtapaConstants.EtapaEndereco.NomeArquivo;

        // Act
        var resultado = _validator.Validate(nome, nomeArquivo);

        // Assert
        resultado.Should().BeFalse();
    }
}
