using Anima.Inscricao.Application.UseCases.TiposFormacao.PesquisarTipoFormacao;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.TiposFormacao;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.TiposFormacao;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarTipoFormacaoQueryHandlerTests
{
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public PesquisarTipoFormacaoQueryHandlerTests(DatabaseFixture databaseFixture)
    {
        _tipoFormacaoRepository = databaseFixture.ServiceProvider.GetRequiredService<ITipoFormacaoRepository>();
        _integracaoSistemaRepository = databaseFixture.ServiceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
    }

    [Fact]
    public async Task DeveRetornarTiposFormacaoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarTipoFormacaoQuery()
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
    public async Task DeveRetornarTiposFormacaoFiltrandoPorNomeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarTipoFormacaoQuery()
        {
            Filtros = new(TipoFormacaoConstants.TipoFormacaoGraduacaoMedicina.Nome),
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

    private PesquisarTipoFormacaoQueryHandler ObterUseCase()
    {
        return new(_tipoFormacaoRepository, _integracaoSistemaRepository);
    }
}
