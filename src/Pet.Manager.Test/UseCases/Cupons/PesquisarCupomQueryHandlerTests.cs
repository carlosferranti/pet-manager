using Anima.Inscricao.Application.UseCases.Cupons.PesquisarCupom;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Cupons;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Cupons;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarCupomQueryHandlerTests
{
    private readonly ICupomRepository _cupomRepository;
    private readonly IConcursoRepository _concursoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public PesquisarCupomQueryHandlerTests(DatabaseFixture databaseFixture)
    {
        _cupomRepository = databaseFixture.ServiceProvider.GetRequiredService<ICupomRepository>();
        _concursoRepository = databaseFixture.ServiceProvider.GetRequiredService<IConcursoRepository>();
        _integracaoSistemaRepository = databaseFixture.ServiceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
    }

    [Fact]
    public async Task DeveRetornarCuponsComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarCupomQuery()
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
    public async Task DeveRetornarCuponsFiltrandoPorCodigoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarCupomQuery()
        {
            Filtros = new(CupomConstants.CupomPablo100.Codigo, null!, null!, null),
            Paginacao = new(),
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(1);
        resultado.Data.Should().HaveCount(1);
    }

    [Fact]
    public async Task DeveRetornarCuponsFiltrandoPorConcursoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarCupomQuery()
        {
            Filtros = new(null!, ConcursoConstants.ConcursoVestibular.Key, null!, null),
            Paginacao = new(),
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(2);
        resultado.Data.Should().HaveCount(2);
    }

    [Fact]
    public async Task DeveRetornarCuponsFiltrandoPorCodigoOrigemComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarCupomQuery()
        {
            Filtros = new(null!, null!, CupomConstants.CupomPablo100.IntegracaoCupom!.CodigoOrigem, null),
            Paginacao = new(),
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(1);
        resultado.Data.Should().HaveCount(1);
    }

    [Fact]
    public async Task DeveRetornarCuponsFiltrandoPorPeriodoLetivoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarCupomQuery()
        {
            Filtros = new(null!, null!, null, ConcursoConstants.ConcursoEnem.PeriodoLetivo),
            Paginacao = new(),
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(2);
        resultado.Data.Should().HaveCount(2);
    }

    private PesquisarCupomQueryHandler ObterUseCase()
    {
        return new(
            _cupomRepository, 
            _concursoRepository, 
            _integracaoSistemaRepository);
    }
}
