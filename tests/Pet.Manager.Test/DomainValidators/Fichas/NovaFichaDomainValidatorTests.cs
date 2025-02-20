using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Domain.Fichas.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Fichas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovaFichaDomainValidatorTests
{
    private readonly IFichaRepository _fichaRepository;
    private readonly NovaFichaDomainValidator _validator;

    public NovaFichaDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _fichaRepository = databaseFixture.ServiceProvider.GetRequiredService<IFichaRepository>();
        _validator = new(_fichaRepository);
    }

    [Fact]
    public void DeveValidarFichasUnicasNoCadastro()
    {
        // Arrange
        string nome = FichaConstants.FichaPadrao.Nome;
        bool fichaEhPadrao = FichaConstants.FichaPadrao.Padrao;

        // Act
        var resultado = _validator.Validate(nome, fichaEhPadrao);

        // Assert
        resultado.Should().BeFalse();
    }
}