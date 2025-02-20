using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Instituicoes.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Instituicoes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovaInstituicaoDomainValidatorTests
{
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly NovaInstituicaoDomainValidator _validator;

    public NovaInstituicaoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _instituicaoRepository = databaseFixture.ServiceProvider.GetRequiredService<IInstituicaoRepository>();
        _validator = new(_instituicaoRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        string nome = InstituicaoConstants.Unibh.Nome;
        string sigla = InstituicaoConstants.Unibh.Sigla;
        var marcaId = MarcaConstants.Unibh.Id;

        // Act
        var resultado = _validator.Validate(nome, sigla, marcaId);

        // Assert
        resultado.Should().BeFalse();
    }
}
