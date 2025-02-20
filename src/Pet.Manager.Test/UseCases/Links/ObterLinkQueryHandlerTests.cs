using Anima.Inscricao.Application.UseCases.Links.ObterLink;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Links;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Links;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class ObterLinkQueryHandlerTests
{
    private readonly ILinkRepository _linkRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;

    public ObterLinkQueryHandlerTests(DatabaseFixture databaseFixture)
    {
        _linkRepository = databaseFixture.ServiceProvider.GetRequiredService<ILinkRepository>();
        _formaEntradaRepository = databaseFixture.ServiceProvider.GetRequiredService<IFormaEntradaRepository>();
    }

    [Fact]
    public async Task DeveRetornarLinkComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterLinkQuery()
        {
            Key = LinkConstants.LinkPadrao.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Key.Should().Be(LinkConstants.LinkPadrao.Key);
        resultado.Nome.Should().Be(LinkConstants.LinkPadrao.Nome);
    }

    private ObterLinkQueryHandler ObterUseCase()
    {
        return new(_linkRepository, _formaEntradaRepository);
    }
}