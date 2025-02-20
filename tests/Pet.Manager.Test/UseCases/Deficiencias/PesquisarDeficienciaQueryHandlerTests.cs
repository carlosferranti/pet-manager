using Anima.Inscricao.Application.UseCases.Deficiencias.PesquisarDeficiencia;
using Anima.Inscricao.Domain.Deficiencias;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Deficiencias;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarDeficienciaQueryHandlerTests
{
    private readonly IDeficienciaRepository _deficienciaRepository;

    public PesquisarDeficienciaQueryHandlerTests(DatabaseFixture databaseFixture)
    {
        _deficienciaRepository = databaseFixture.ServiceProvider.GetRequiredService<IDeficienciaRepository>();
    }

    [Fact]
    public async Task DeveRetornarDeficienciaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarDeficienciaQuery()
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
    public async Task DeveRetornarFiltrandoPorNomeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarDeficienciaQuery()
        {
            Filtros = new(DeficienciaConstants.Cegueira.Nome),
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

    private PesquisarDeficienciaQueryHandler ObterUseCase()
    {
        return new PesquisarDeficienciaQueryHandler(_deficienciaRepository);
    }
}
