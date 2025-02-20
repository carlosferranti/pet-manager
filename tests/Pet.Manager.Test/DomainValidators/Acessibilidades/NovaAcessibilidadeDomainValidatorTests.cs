using Anima.Inscricao.Domain.Acessibilidades;
using Anima.Inscricao.Domain.Acessibilidades.Validators;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Campi.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Acessibilidades;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovaAcessibilidadeDomainValidatorTests
{
    private readonly IAcessibilidadeRepository _acessibilidadeRepository;
    private readonly NovaAcessibilidadeDomainValidator _validator;

    public NovaAcessibilidadeDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _acessibilidadeRepository = databaseFixture.ServiceProvider.GetRequiredService<IAcessibilidadeRepository>();
        _validator = new(_acessibilidadeRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        string nome = AcessibilidadeConstants.InterpreterDeLibras.Nome;

        // Act
        var resultado = _validator.Validate(nome);

        // Assert
        resultado.Should().BeFalse();
    }
}
