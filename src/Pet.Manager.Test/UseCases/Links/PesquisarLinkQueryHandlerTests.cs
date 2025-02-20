using Anima.Inscricao.Application.UseCases.Links.PesquisarLink;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Links;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Links;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarLinkQueryHandlerTests
{
    private readonly ILinkRepository _linkRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;

    public PesquisarLinkQueryHandlerTests(DatabaseFixture databaseFixture)
    {
        _linkRepository = databaseFixture.ServiceProvider.GetRequiredService<ILinkRepository>();
        _formaEntradaRepository = databaseFixture.ServiceProvider.GetRequiredService<IFormaEntradaRepository>();
    }

    [Fact]
    public async Task DevePesquisarLinkComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarLinkQuery(), default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(3);
        resultado.Data.Should().HaveCount(3);
    }

    [Fact]
    public async Task DevePesquisarLinkPorFormaEntradaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarLinkQuery()
        {
            Filtros = new(FormaEntradaConstants.FormaEntradaVestibular.Key),
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(1);
        resultado.Data.Should().HaveCount(1);
    }

    private PesquisarLinkQueryHandler ObterUseCase()
    {
        return new(_linkRepository, _formaEntradaRepository);
    }
}