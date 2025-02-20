using Anima.Inscricao.Domain.TiposFormacao;
using Anima.Inscricao.Domain.TiposFormacao.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.TiposFormacao;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovoTipoFormacaoDomainValidatorTests
{
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly NovoTipoFormacaoDomainValidator _validator;

    public NovoTipoFormacaoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _tipoFormacaoRepository = databaseFixture.ServiceProvider.GetRequiredService<ITipoFormacaoRepository>();
        _validator = new(_tipoFormacaoRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        string nome = TipoFormacaoConstants.TipoFormacaoGraduacaoMedicina.Nome;

        // Act
        var resultado = _validator.Validate(nome);

        // Assert
        resultado.Should().BeFalse();
    }
}
