using Anima.Inscricao.Application.UseCases.Inscricoes.PesquisarInscricoesCandidatos;
using Anima.Inscricao.Application.UseCases.Instituicoes.PesquisarLinkRedirecionamentoCandidato;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;
using Anima.Inscricoes.Domain.Inscricoes;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Inscricoes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarInscricoesCandidatosQueryHandlerTests
{
    private readonly IInscricaoRepository _inscricaoRepository;
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IConcursoRepository _concursoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public PesquisarInscricoesCandidatosQueryHandlerTests(DatabaseFixture databaseFixture)
    {
        _inscricaoRepository = databaseFixture.ServiceProvider.GetRequiredService<IInscricaoRepository>();
        _ofertaConcursoRepository = databaseFixture.ServiceProvider.GetRequiredService<IOfertaConcursoRepository>();
        _concursoRepository = databaseFixture.ServiceProvider.GetRequiredService<IConcursoRepository>();
        _integracaoSistemaRepository = databaseFixture.ServiceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
    }

    [Fact(Skip ="refatorar")]
    public async Task DeveRetornarInscricoesPaginadasComSucessoAsync()
    {
        var useCase = ObterUseCase();

        var resultado = await useCase.Handle(new PesquisarInscricoesCandidatosQuery()
        {
            Filtros = new PesquisarInscricoesCandidatosQuery.PesquisarInscricoesCandidatosFiltros(null, null, null, null, null),
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().BeGreaterThanOrEqualTo(1);
    }

    [Fact(Skip = "refatorar")]
    public async Task DeveRetornarInscricoesFiltradasPorIdAsync()
    {
        var useCase = ObterUseCase();

        var resultado = await useCase.Handle(new PesquisarInscricoesCandidatosQuery()
        {
            Filtros = new PesquisarInscricoesCandidatosQuery.PesquisarInscricoesCandidatosFiltros(null, 1, null, null, null),
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(1);
        resultado.Data.Should().HaveCount(1);
        resultado.Data.ElementAt(0).Id.Should().Be(1);
    }

    [Fact(Skip = "refatorar")]
    public async Task DeveRetornarInscricoesFiltradasPorConcursoIdAsync()
    {
        var useCase = ObterUseCase();

        var resultado = await useCase.Handle(new PesquisarInscricoesCandidatosQuery()
        {
            Filtros = new PesquisarInscricoesCandidatosQuery.PesquisarInscricoesCandidatosFiltros("1234", null, null, null, null),
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().BeGreaterThanOrEqualTo(1);
    }

    [Fact(Skip = "refatorar")]
    public async Task DeveRetornarInscricoesFiltradasPorNomeAsync()
    {
        var useCase = ObterUseCase();

        var resultado = await useCase.Handle(new PesquisarInscricoesCandidatosQuery()
        {
            Filtros = new PesquisarInscricoesCandidatosQuery.PesquisarInscricoesCandidatosFiltros(null, null, "Nome Segunda", null, null),
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(1);
        resultado.Data.Should().HaveCount(1);
        resultado.Data.ElementAt(0).InfoPessoais.Nome.Should().Be("Nome Segunda");
    }

    [Fact(Skip = "refatorar")]
    public async Task DeveRetornarInscricoesFiltradasPorCpfAsync()
    {
        var useCase = ObterUseCase();

        var resultado = await useCase.Handle(new PesquisarInscricoesCandidatosQuery()
        {
            Filtros = new PesquisarInscricoesCandidatosQuery.PesquisarInscricoesCandidatosFiltros(null, null, null, "66204518021", null),
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(1);
        resultado.Data.Should().HaveCount(1);
        resultado.Data.ElementAt(0).InfoDocumentos.Cpf.Should().Be("662.045.180-21");
    }

    [Fact(Skip = "refatorar")]
    public async Task DeveRetornarInscricoesFiltradasIdsStatusAsync()
    {
        var useCase = ObterUseCase();

        var resultado = await useCase.Handle(new PesquisarInscricoesCandidatosQuery()
        {
            Filtros = new PesquisarInscricoesCandidatosQuery.PesquisarInscricoesCandidatosFiltros(null, null, null, null, [1, 2, 3]),
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().BeGreaterThanOrEqualTo(2);
    }

    [Fact(Skip = "refatorar")]
    public async Task DeveRetornarInscricoesFiltradasIdsPorUmUnicoIdStatusAsync()
    {
        var useCase = ObterUseCase();

        var resultado = await useCase.Handle(new PesquisarInscricoesCandidatosQuery()
        {
            Filtros = new PesquisarInscricoesCandidatosQuery.PesquisarInscricoesCandidatosFiltros(null, null, null, null, [3]),
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(1);
        resultado.Data.Should().HaveCount(1);
    }

    private PesquisarInscricoesCandidatosQueryHandler ObterUseCase()
    {
        return new PesquisarInscricoesCandidatosQueryHandler(
            _inscricaoRepository,
            _ofertaConcursoRepository,
            _concursoRepository,
            _integracaoSistemaRepository
        );
    }
}