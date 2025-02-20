using Anima.Inscricao.Application.UseCases.Acessibilidades.PesquisarAcessibilidade;
using Anima.Inscricao.Domain.Acessibilidades;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Acessibilidades;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarAcessibilidadeQueryHandlerTests
{
    private readonly IAcessibilidadeRepository _acessibilidadeRepository;

    public PesquisarAcessibilidadeQueryHandlerTests(DatabaseFixture databaseFixture)
    {
        _acessibilidadeRepository = databaseFixture.ServiceProvider.GetRequiredService<IAcessibilidadeRepository>();
    }

    [Fact]
    public async Task DeveRetornarAcessibilidadesComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarAcessibilidadeQuery()
        {
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(4);
        resultado.Data.Should().HaveCount(4);
    }

    [Fact]
    public async Task DeveRetornarAcessibilidadesFiltrandoPorNomeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarAcessibilidadeQuery()
        {
            Filtros = new(AcessibilidadeConstants.InterpreterDeLibras.Nome),
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

    private PesquisarAcessibilidadeQueryHandler ObterUseCase()
    {
        return new(_acessibilidadeRepository);
    }
}
