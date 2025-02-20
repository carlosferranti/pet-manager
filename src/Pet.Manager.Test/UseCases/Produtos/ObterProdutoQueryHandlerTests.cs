using Anima.Inscricao.Application.DTOs.Produtos;
using Anima.Inscricao.Application.UseCases.Produtos.ObterProduto;

using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Domain.Turnos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Produtos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class ObterProdutoQueryHandlerTests
{
    private readonly IProdutoRepository _produtoRepository;
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly ICampusRepository _campusRepository;
    private readonly ICursoRepository _cursoRepository;
    private readonly ITurnoRepository _turnoRepository;

    public ObterProdutoQueryHandlerTests()
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
    public async Task DeveRetornarConcursoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        Guid key = ProdutoConstants.ProdutoTeste1.Key;

        // Act
        var resultado = await useCase.Handle(new ObterProdutoQuery
        {
            Key = key,
        }, default);
        Console.WriteLine(resultado);
        // Assert
        resultado.Should().NotBeNull();
        resultado.Should().BeEquivalentTo(new ProdutoDto()
        {
            Key = key,
            InstituicaoKey = InstituicaoConstants.Una.Key,
            CampusKey = CampusConstants.CampusRecife.Key,
            CursoKey = CursoConstants.CursoAdministracao.Key,
            TurnoKey = TurnoConstants.TurnoManha.Key,
            Sku = "Teste1"
            

        });

    }

    private ObterProdutoQueryHandler ObterUseCase()
    {
        return new(
            _produtoRepository,
            _instituicaoRepository,
            _campusRepository,
            _cursoRepository,
            _turnoRepository);
    }
}
