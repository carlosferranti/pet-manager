using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Domain.Escolas.Entities;
using Anima.Inscricao.Domain.Escolas.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Escolas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizacaoEscolaDomainValidatorTests
{
    private readonly IEscolaRepository _escolaRepository;
    private readonly AtualizacaoEscolaDomainValidator _validator;

    public AtualizacaoEscolaDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _escolaRepository = databaseFixture.ServiceProvider.GetRequiredService<IEscolaRepository>();
        _validator = new(_escolaRepository);
    }

    [Fact]
    public void DeveValidarNomeUnico()
    {
        // Arrange
        EscolaId escolaId = EscolaConstants.ColegioRecife.Id;
        string nome = EscolaConstants.IFSP.Nome;
        CidadeId cidadeId = EscolaConstants.IFSP.CidadeId;

        // Act
        var resultado = _validator.Validate(escolaId, nome, cidadeId);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeOCodigoInepForIgual()
    {
        // Arrange
        EscolaId escolaId = EscolaConstants.IFSP.Id;
        string nome = EscolaConstants.IFSP.Nome;
        CidadeId cidadeId = EscolaConstants.IFSP.CidadeId;

        // Act
        var resultado = _validator.Validate(escolaId, nome, cidadeId);

        // Assert
        resultado.Should().BeTrue();
    }
}
