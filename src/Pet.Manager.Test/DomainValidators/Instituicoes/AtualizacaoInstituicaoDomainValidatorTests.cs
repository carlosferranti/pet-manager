using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Instituicoes.Entities;
using Anima.Inscricao.Domain.Instituicoes.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Instituicoes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizacaoInstituicaoDomainValidatorTests
{
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly AtualizacaoInstituicaoDomainValidator _validator;

    public AtualizacaoInstituicaoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _instituicaoRepository = databaseFixture.ServiceProvider.GetRequiredService<IInstituicaoRepository>();
        _validator = new(_instituicaoRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        InstituicaoId instituicaoId = InstituicaoConstants.UnaLive.Id;
        string nome = InstituicaoConstants.Una.Nome;
        string sigla = InstituicaoConstants.Una.Sigla;
        var marcaId = MarcaConstants.Una.Id;

        // Act
        var resultado = _validator.Validate(instituicaoId, nome, sigla, marcaId);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeONomeForIgual()
    {
        // Arrange
        InstituicaoId instituicaoId = InstituicaoConstants.Una.Id;
        string nome = InstituicaoConstants.Una.Nome;
        string sigla = InstituicaoConstants.Una.Sigla;
        var marcaId = MarcaConstants.Una.Id;

        // Act
        var resultado = _validator.Validate(instituicaoId, nome, sigla, marcaId);

        // Assert
        resultado.Should().BeTrue();
    }
}
