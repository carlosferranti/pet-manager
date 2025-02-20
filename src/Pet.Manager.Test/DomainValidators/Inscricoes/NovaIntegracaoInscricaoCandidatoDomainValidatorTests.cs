using Anima.Inscricao.Domain.Inscricoes.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Inscricoes;

public class NovaIntegracaoInscricaoCandidatoDomainValidatorTests
{
    private readonly NovaIntegracaoInscricaoCandidatoDomainValidator _validator;

    public NovaIntegracaoInscricaoCandidatoDomainValidatorTests()
    {
        _validator = new();

        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public void DeveValidarIntegracaoUnicaParaInscricao()
    {
        // Arrange
        var inscricao = InscricaoConstants.InscricaoComIntegracao;

        // Act
        var resultado = _validator.Validate(inscricao, inscricao.IntegracoesInscricao.FirstOrDefault()!.IntegracaoSistemaId);

        // Assert
        resultado.Should().BeFalse();
    }
}