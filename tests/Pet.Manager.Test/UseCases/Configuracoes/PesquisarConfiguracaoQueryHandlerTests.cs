using Anima.Inscricao.Application.UseCases.Configuracoes.PesquisarConfiguracao;
using Anima.Inscricao.Domain.Configuracoes;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Configuracoes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarConfiguracaoQueryHandlerTests
{
    private readonly IConfiguracaoRepository _configuracaoRepository;

    public PesquisarConfiguracaoQueryHandlerTests(DatabaseFixture databaseFixture)
    {
        _configuracaoRepository = databaseFixture.ServiceProvider
            .GetRequiredService<IConfiguracaoRepository>();
    }

    [Fact]
    public async Task DeveRetornarConfiguracoesComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarConfiguracaoQuery()
        {
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(3);
        resultado.Data.Should().HaveCount(3);
    }

    [Fact]
    public async Task DeveRetornarConfiguracoesFiltrandoPorNomeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarConfiguracaoQuery()
        {
            Filtros = new(ConfiguracaoConstants.ConfiguracaoPadrao3.ChaveGenerica, null),
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(1);
        resultado.Data.Should().HaveCount(1);
    }

    private PesquisarConfiguracaoQueryHandler ObterUseCase ()
    {
        return new PesquisarConfiguracaoQueryHandler(_configuracaoRepository);
    }
}
