using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Domain.Escolas.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Escolas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovaEscolaDomainValidatorTests
{
    private readonly IEscolaRepository _escolaRepository;
    private readonly NovaEscolaDomainValidator _validator;

    public NovaEscolaDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _escolaRepository = databaseFixture.ServiceProvider.GetRequiredService<IEscolaRepository>();
        _validator = new(_escolaRepository);
    }

    [Fact]
    public void DeveValidarNomeUnico()
    {
        // Arrange
        string nome = EscolaConstants.ColegioRecife.Nome;
        CidadeId cidadeId = EscolaConstants.ColegioRecife.CidadeId;

        // Act
        var resultado = _validator.Validate(nome, cidadeId);

        // Assert
        resultado.Should().BeFalse();
    }
}
