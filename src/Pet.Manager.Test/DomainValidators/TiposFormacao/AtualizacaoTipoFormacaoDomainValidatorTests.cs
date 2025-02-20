using Anima.Inscricao.Domain.TiposFormacao;
using Anima.Inscricao.Domain.TiposFormacao.Entities;
using Anima.Inscricao.Domain.TiposFormacao.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.TiposFormacao;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizacaoTipoFormacaoDomainValidatorTests
{
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly AtualizacaoTipoFormacaoDomainValidator _validator;

    public AtualizacaoTipoFormacaoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _tipoFormacaoRepository = databaseFixture.ServiceProvider.GetRequiredService<ITipoFormacaoRepository>();
        _validator = new(_tipoFormacaoRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        TipoFormacaoId tipoFormacaoId = TipoFormacaoConstants.TipoFormacaoPos.Id;
        string nome = TipoFormacaoConstants.TipoFormacaoGraduacao.Nome;

        // Act
        var resultado = _validator.Validate(tipoFormacaoId, nome);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeONomeForIgual()
    {
        // Arrange
        TipoFormacaoId tipoFormacaoId = TipoFormacaoConstants.TipoFormacaoGraduacao.Id;
        string nome = TipoFormacaoConstants.TipoFormacaoGraduacao.Nome;

        // Act
        var resultado = _validator.Validate(tipoFormacaoId, nome);

        // Assert
        resultado.Should().BeTrue();
    }
}