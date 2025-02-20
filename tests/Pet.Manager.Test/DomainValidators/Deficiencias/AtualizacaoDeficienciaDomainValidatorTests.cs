using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Campi.Entities;
using Anima.Inscricao.Domain.Campi.Validators;
using Anima.Inscricao.Domain.Deficiencias;
using Anima.Inscricao.Domain.Deficiencias.Entities;
using Anima.Inscricao.Domain.Deficiencias.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Deficiencias;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizacaoDeficienciaDomainValidatorTests
{
    private readonly IDeficienciaRepository _deficienciaRepository;
    private readonly AtualizacaoDeficienciaDomainValidator _validator;

    public AtualizacaoDeficienciaDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _deficienciaRepository = databaseFixture.ServiceProvider.GetRequiredService<IDeficienciaRepository>();
        _validator = new(_deficienciaRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        DeficienciaId deficienciaId = DeficienciaConstants.DeficienciaFisica.Id;
        string nome = DeficienciaConstants.Cegueira.Nome;

        // Act
        var resultado = _validator.Validate(deficienciaId, nome);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeFor()
    {
        // Arrange
        DeficienciaId deficienciaId = DeficienciaConstants.Cegueira.Id;
        string nome = DeficienciaConstants.Cegueira.Nome;

        // Act
        var resultado = _validator.Validate(deficienciaId, nome);

        // Assert
        resultado.Should().BeTrue();
    }
}
