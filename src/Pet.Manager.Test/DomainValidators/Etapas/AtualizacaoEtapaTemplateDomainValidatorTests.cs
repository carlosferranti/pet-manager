using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Domain.Etapas.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Etapas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizacaoEtapaTemplateDomainValidatorTests
{
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;
    private readonly AtualizacaoEtapaTemplateDomainValidator _validator;

    public AtualizacaoEtapaTemplateDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _etapaTemplateRepository = databaseFixture.ServiceProvider.GetRequiredService<IEtapaTemplateRepository>();
        _validator = new(_etapaTemplateRepository);
    }

    [Fact]
    public void DeveValidarEtapasUnicasNaAtualizacao()
    {
        // Arrange
        var etapaId = EtapaConstants.EtapaDadosContato.Id;
        string nome = EtapaConstants.EtapaDadosPessoais.Nome;
        string nomeArquivo = EtapaConstants.EtapaDadosPessoais.NomeArquivo;

        // Act
        var resultado = _validator.Validate(etapaId, nome, nomeArquivo);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeForMesmoRegistro()
    {
        // Arrange
        var etapaId = EtapaConstants.EtapaDadosPessoais.Id;
        string nome = EtapaConstants.EtapaDadosPessoais.Nome;
        string nomeArquivo = EtapaConstants.EtapaDadosPessoais.NomeArquivo;

        // Act
        var resultado = _validator.Validate(etapaId, nome, nomeArquivo);

        // Assert
        resultado.Should().BeTrue();
    }
}