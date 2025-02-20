using Anima.Inscricao.Application.UseCases.Concursos.PesquisarConcurso;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.ModalidadesAvaliacao;
using Anima.Inscricao.Domain.TiposFormacao;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Concursos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarConcursoQueryHandlerTests
{
    private readonly IConcursoRepository _concursoRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly IModalidadeAvaliacaoRepository _modalidadeAvaliacaoRepository;

    public PesquisarConcursoQueryHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _concursoRepository = serviceProvider.GetRequiredService<IConcursoRepository>();
        _formaEntradaRepository = serviceProvider.GetRequiredService<IFormaEntradaRepository>();
        _tipoFormacaoRepository = serviceProvider.GetRequiredService<ITipoFormacaoRepository>();
        _modalidadeRepository = serviceProvider.GetRequiredService<IModalidadeRepository>();
        _integracaoSistemaRepository = serviceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
        _modalidadeAvaliacaoRepository = serviceProvider.GetRequiredService<IModalidadeAvaliacaoRepository>();
    }

    [Fact]
    public async Task DeveRetornarListaDeConcursoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarConcursoQuery
        {
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(6);
    }

    [Fact]
    public async Task DeveRetornarListaDeConcursoFiltrandoPorNomeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarConcursoQuery
        {
            Filtros = new(ConcursoConstants.ConcursoEnem.Nome, null, null),
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

    [Fact]
    public async Task DeveRetornarListaDeConcursoFiltrandoPorCodigoSistemaComSucessoAsync2()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarConcursoQuery
        {
            Filtros = new(null!, "1234", null),
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Data!.FirstOrDefault()!.Integracao!.CodigoOrigem.Should().Be("1234");
        resultado.TotalRegistros.Should().Be(1);
    }

    private PesquisarConcursoQueryHandler ObterUseCase()
    {
        return new(
            _concursoRepository,
            _tipoFormacaoRepository,
            _formaEntradaRepository,
            _modalidadeRepository,
            _integracaoSistemaRepository,
            _modalidadeAvaliacaoRepository);
    }
}