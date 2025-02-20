using Anima.Inscricao.Application.UseCases.CursosExternos.ObterCursoExterno;
using Anima.Inscricao.Application.UseCases.CursosExternos.PesquisarCursoExterno;
using Anima.Inscricao.Domain.CursosExternos;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.CursosExternos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarCursoExternoQueryHandlerTests
{
    private readonly ICursoExternoRepository _cursoExternoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public PesquisarCursoExternoQueryHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _cursoExternoRepository = serviceProvider.GetRequiredService<ICursoExternoRepository>();
        _integracaoSistemaRepository = serviceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
    }

    [Fact]
    public async Task DeveRetornarTodosOsRegistrosAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarCursoExternoQuery { Filtros = null }, default);

        // Asert
        Assert.NotNull(resultado);
        Assert.NotEmpty(resultado);
        Assert.Equal(3, resultado.Count());
    }

    [Fact]
    public async Task DeveRetornarRegistrosComFiltroAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarCursoExternoQuery 
        { 
            Filtros = new ("Ch")
        }, default);

        // Asert
        Assert.NotNull(resultado);
        Assert.NotEmpty(resultado);
        Assert.Equal(CursoExternoConstants.LetrasChines.Nome, resultado.First().Nome);
    }

    private PesquisarCursoExternoQueryHandler ObterUseCase()
    {
        return new(
            _cursoExternoRepository,
            _integracaoSistemaRepository);
    }
}
