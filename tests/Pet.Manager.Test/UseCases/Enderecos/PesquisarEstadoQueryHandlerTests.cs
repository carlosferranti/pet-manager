using Anima.Inscricao.Application.UseCases.Enderecos.PesquisarEstado;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Enderecos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarEstadoQueryHandlerTests
{
    private readonly IPaisRepository _paisRepository;
    private readonly IEstadoRepository _estadoRepository;

    public PesquisarEstadoQueryHandlerTests(DatabaseFixture databaseFixture)
    {
        _paisRepository = databaseFixture.ServiceProvider.GetRequiredService<IPaisRepository>();
        _estadoRepository = databaseFixture.ServiceProvider.GetRequiredService<IEstadoRepository>();
    }

    [Fact]
    public async Task DeveRetornarEstadosComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarEstadoQuery()
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
    public async Task DeveRetornarEstadosFiltrandoPorPaisComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarEstadoQuery()
        {
            Filtros = new(EnderecoConstants.PaisBrasil.Key),
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

    private PesquisarEstadoQueryHandler ObterUseCase()
    {
        return new(_paisRepository, _estadoRepository);
    }
}