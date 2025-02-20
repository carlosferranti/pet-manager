using Anima.Inscricao.Application.UseCases.Escolas.PesquisarEscola;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Domain.Escolas.Enums;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Escolas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarEscolaQueryHandlerTests
{
    private readonly IEscolaRepository _escolaRepository;
    private readonly ICidadeRepository _cidadeRepository;

    public PesquisarEscolaQueryHandlerTests(DatabaseFixture databaseFixture)
    {
        _escolaRepository = databaseFixture.ServiceProvider.GetRequiredService<IEscolaRepository>();
        _cidadeRepository = databaseFixture.ServiceProvider.GetRequiredService<ICidadeRepository>();
    }

    [Fact]
    public async Task DeveRetornarEscolasComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarEscolaQuery()
        {
            Paginacao = new(),
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(3);
        resultado.Data.Should().HaveCount(3);
    }

    [Fact]
    public async Task DeveRetornarEscolasFiltrandoPorCidadeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarEscolaQuery()
        {
            Filtros = new(EnderecoConstants.CidadeSaoPaulo.Key, null),
            Paginacao = new(),
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(1);
        resultado.Data.Should().HaveCount(1);
    }

    [Theory]
    [InlineData(TipoCategoriaEscola.EducacaoSuperior, 1)]
    [InlineData(TipoCategoriaEscola.EducacaoBasica, 2)]
    public async Task DeveRetornarEscolasFiltrandoPorTipoCategoriaComSucessoAsync(TipoCategoriaEscola tipoCategoria, int quantidadeEsperada)
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarEscolaQuery()
        {
            Filtros = new(null, tipoCategoria),
            Paginacao = new(),
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(quantidadeEsperada);
        resultado.Data.Should().HaveCount(quantidadeEsperada);
    }

    private PesquisarEscolaQueryHandler ObterUseCase()
    {
        return new(
            _escolaRepository,
            _cidadeRepository);
    }
}
