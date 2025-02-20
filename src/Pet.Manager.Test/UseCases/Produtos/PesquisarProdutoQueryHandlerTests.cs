using Anima.Inscricao.Application.UseCases.Concursos.PesquisarConcurso;
using Anima.Inscricao.Application.UseCases.Produtos.ObterProduto;
using Anima.Inscricao.Application.UseCases.Produtos.PesquisarProduto;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Domain.Turnos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Produtos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarProdutoQueryHandlerTests
{
    private readonly IProdutoRepository _produtoRepository;
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly ICampusRepository _campusRepository;
    private readonly ICursoRepository _cursoRepository;
    private readonly ITurnoRepository _turnoRepository;

    public PesquisarProdutoQueryHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
        .BuildServiceProvider(new ServiceCollection());

        _produtoRepository = serviceProvider.GetRequiredService<IProdutoRepository>();
        _instituicaoRepository = serviceProvider.GetRequiredService<IInstituicaoRepository>();
        _campusRepository = serviceProvider.GetRequiredService<ICampusRepository>();
        _cursoRepository = serviceProvider.GetRequiredService<ICursoRepository>();
        _turnoRepository = serviceProvider.GetRequiredService<ITurnoRepository>();
    }

    [Fact]
    public async Task DeveRetornarListaDeProdutoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarProdutoQuery
        {
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(2);
    }

    [Fact]
    public async Task DeveRetornarListaDeConcursoFiltrandoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarProdutoQuery
        {
            Filtros = new(null, null, null, null, "Teste1"),
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(1);
    }


    private PesquisarProdutoQueryHandler ObterUseCase()
    {
        return new(
            _produtoRepository,
            _instituicaoRepository,
            _campusRepository,
            _cursoRepository,
            _turnoRepository);
    }
}
