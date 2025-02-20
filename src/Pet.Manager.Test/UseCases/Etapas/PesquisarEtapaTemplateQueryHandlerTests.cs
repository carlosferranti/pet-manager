using Anima.Inscricao.Application.UseCases.Etapas.PesquisarEtapa;
using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Etapas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarEtapaTemplateQueryHandlerTests
{
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;

    public PesquisarEtapaTemplateQueryHandlerTests(DatabaseFixture databaseFixture)
    {
        _etapaTemplateRepository = databaseFixture.ServiceProvider.GetRequiredService<IEtapaTemplateRepository>();
    }

    [Fact]
    public async Task DeveRetornarEtapasComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarEtapaTemplateQuery()
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
    public async Task DeveRetornarEtapasFiltrandoPorNomeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarEtapaTemplateQuery()
        {
            Filtros = new(EtapaConstants.EtapaDadosPessoais.Nome),
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

    private PesquisarEtapaTemplateQueryHandler ObterUseCase()
    {
        return new(_etapaTemplateRepository);
    }
}