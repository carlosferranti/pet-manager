using Anima.Inscricao.Domain.Links;
using Anima.Inscricao.Domain.Links.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Links;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovoLinkDomainValidatorTests
{
    private readonly ILinkRepository _linkRepository;
    private readonly NovoLinkDomainValidator _validator;

    public NovoLinkDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _linkRepository = databaseFixture.ServiceProvider.GetRequiredService<ILinkRepository>();
        _validator = new(_linkRepository);
    }

    [Fact]
    public void DeveValidarLinksUnicos()
    {
        // Arrange
        string nome = LinkConstants.LinkEmpresa.Nome;

        // Act
        var resultado = _validator.Validate(nome);

        // Assert
        resultado.Should().BeFalse();
    }
}
