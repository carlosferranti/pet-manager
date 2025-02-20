using Anima.Inscricao.Application.UseCases.Campi.PesquisarCampus;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Campi;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarCampusQueryHandlerTests
{
    private readonly ICampusRepository _campusRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public PesquisarCampusQueryHandlerTests(DatabaseFixture databaseFixture)
    {
        _campusRepository = databaseFixture.ServiceProvider.GetRequiredService<ICampusRepository>();
        _integracaoSistemaRepository = databaseFixture.ServiceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
    }

    [Fact]
    public async Task DeveRetornarCampiComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarCampusQuery()
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
    public async Task DeveRetornarCampiFiltrandoPorNomeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarCampusQuery()
        {
            Filtros = new(CampusConstants.CampusRecife.Nome),
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

    private PesquisarCampusQueryHandler ObterUseCase()
    {
        return new PesquisarCampusQueryHandler(_campusRepository, _integracaoSistemaRepository);
    }
}
