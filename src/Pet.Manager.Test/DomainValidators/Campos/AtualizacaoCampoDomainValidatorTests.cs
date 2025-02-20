using Anima.Inscricao.Domain.Campos;
using Anima.Inscricao.Domain.Campos.Entities;
using Anima.Inscricao.Domain.Campos.Validators;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Campos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizacaoCampoDomainValidatorTests
{
    private readonly ICampoRepository _campoRepository;
    private readonly AtualizacaoCampoDomainValidator _validator;

    public AtualizacaoCampoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _campoRepository = databaseFixture.ServiceProvider.GetRequiredService<ICampoRepository>();
        _validator = new(_campoRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        CampoId campoId = CampoConstants.Email.Id;
        string nome = CampoConstants.CPF.Nome;

        // Act
        var resultado = _validator.Validate(campoId, nome);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeONomeForIgual()
    {
        // Arrange
        var campoId = CampoConstants.Email.Id;
        string nome = CampoConstants.Email.Nome;

        // Act
        var resultado = _validator.Validate(campoId, nome);

        // Assert
        resultado.Should().BeTrue();
    }
}
