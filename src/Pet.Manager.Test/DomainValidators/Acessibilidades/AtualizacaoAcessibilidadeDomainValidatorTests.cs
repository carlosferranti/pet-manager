using Anima.Inscricao.Domain.Acessibilidades;
using Anima.Inscricao.Domain.Acessibilidades.Entities;
using Anima.Inscricao.Domain.Acessibilidades.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Acessibilidades;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizacaoAcessibilidadeDomainValidatorTests
{
    private readonly IAcessibilidadeRepository _acessibilidadeRepository;
    private readonly AtualizacaoAcessibilidadeDomainValidator _validator;

    public AtualizacaoAcessibilidadeDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _acessibilidadeRepository = databaseFixture.ServiceProvider.GetRequiredService<IAcessibilidadeRepository>();
        _validator = new(_acessibilidadeRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        AcessibilidadeId AcessibilidadeId = AcessibilidadeConstants.ProvaBraile.Id;
        string nome = AcessibilidadeConstants.InterpreterDeLibras.Nome;

        // Act
        var resultado = _validator.Validate(AcessibilidadeId, nome);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeONomeForIgual()
    {
        // Arrange
        AcessibilidadeId AcessibilidadeId = AcessibilidadeConstants.ProvaBraile.Id;
        string nome = AcessibilidadeConstants.ProvaBraile.Nome;

        // Act
        var resultado = _validator.Validate(AcessibilidadeId, nome);

        // Assert
        resultado.Should().BeTrue();
    }
}
