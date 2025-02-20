using Anima.Inscricao.Domain.Links;
using Anima.Inscricao.Domain.Links.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Links;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizacaoLinkDomainValidatorTests
{
    private readonly ILinkRepository _linkRepository;
    private readonly AtualizacaoLinkDomainValidator _validator;

    public AtualizacaoLinkDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _linkRepository = databaseFixture.ServiceProvider.GetRequiredService<ILinkRepository>();
        _validator = new(_linkRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        var linkId = LinkConstants.LinkPadrao.Id;
        string nome = LinkConstants.LinkEscola.Nome;

        // Act
        var resultado = _validator.Validate(linkId, nome);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeForMesmoRegistro()
    {
        // Arrange
        var linkId = LinkConstants.LinkPadrao.Id;
        string nome = LinkConstants.LinkPadrao.Nome;

        // Act
        var resultado = _validator.Validate(linkId, nome);

        // Assert
        resultado.Should().BeTrue();
    }
}