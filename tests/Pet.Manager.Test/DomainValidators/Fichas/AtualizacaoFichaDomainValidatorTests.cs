using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Domain.Fichas.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Fichas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizacaoFichaDomainValidatorTests
{
    private readonly IFichaRepository _fichaRepository;
    private readonly AtualizacaoFichaDomainValidator _validator;

    public AtualizacaoFichaDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _fichaRepository = databaseFixture.ServiceProvider.GetRequiredService<IFichaRepository>();
        _validator = new(_fichaRepository);
    }

    [Fact]
    public void DeveValidarFichasUnicasNaAtualizacao()
    {
        // Arrange
        var fichaId = FichaConstants.FichaB.Id;
        string nome = FichaConstants.FichaPadrao.Nome;
        bool padrao = FichaConstants.FichaPadrao.Padrao;

        // Act
        var resultado = _validator.Validate(fichaId, nome, padrao);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeForMesmoRegistro()
    {
        // Arrange
        var fichaId = FichaConstants.FichaB.Id;
        string nome = FichaConstants.FichaB.Nome;
        bool padrao = FichaConstants.FichaB.Padrao;

        // Act
        var resultado = _validator.Validate(fichaId, nome, padrao);

        // Assert
        resultado.Should().BeTrue();
    }
}