using Anima.Inscricao.Application.UseCases.NiveisCurso.PesquisarNivelCurso;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.NiveisCurso;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarNivelCursoQueryHandlerTests
{
    private readonly INivelCursoRepository _nivelCursoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public PesquisarNivelCursoQueryHandlerTests(DatabaseFixture databaseFixture)
    {
        _nivelCursoRepository = databaseFixture.ServiceProvider.GetRequiredService<INivelCursoRepository>();
        _integracaoSistemaRepository = databaseFixture.ServiceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
    }

    [Fact]
    public async Task DeveRetornarNiveisCursoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarNivelCursoQuery()
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
    public async Task DeveRetornarNiveisCursoFiltrandoPorNomeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarNivelCursoQuery()
        {
            Filtros = new(NivelCursoConstants.Bacharelado.Nome),
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

    private PesquisarNivelCursoQueryHandler ObterUseCase()
    {
        return new PesquisarNivelCursoQueryHandler(_nivelCursoRepository, _integracaoSistemaRepository);
    }
}
