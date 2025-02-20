using Anima.Inscricao.Application.UseCases.Deficiencias.ObterDeficienciaAcessibilidade;
using Anima.Inscricao.Application.UseCases.Deficiencias.PesquisarDeficiencia;
using Anima.Inscricao.Domain.Acessibilidades;
using Anima.Inscricao.Domain.Deficiencias;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Deficiencias;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class BuscarDeficienciaAcessibilidadeHandlerTests
{
    private readonly IDeficienciaRepository _deficienciaRepository;
    private readonly IAcessibilidadeRepository _acessibilidadeRepository;


    public BuscarDeficienciaAcessibilidadeHandlerTests(DatabaseFixture databaseFixture)
    {
        _deficienciaRepository = databaseFixture.ServiceProvider.GetRequiredService<IDeficienciaRepository>();
        _acessibilidadeRepository = databaseFixture.ServiceProvider.GetRequiredService<IAcessibilidadeRepository>();
    }

    [Fact]
    public async Task DeveRetornarDeficienciaComAcessibilidadesAsync()
    {
        var useCase = ObterUseCase();

        var resultado = await useCase.Handle(new BuscarDeficienciaAcessibilidadeQuery(), default);

        resultado.Should().NotBeNull();
        resultado.Should().HaveCountGreaterThan(0);

        var deficiencia = resultado.FirstOrDefault(d => d.Nome == "Cegueira");
        deficiencia.Should().NotBeNull();
        deficiencia.Acessibilidades.Should().Contain(a => a.Nome == "Ledor");
        deficiencia.Acessibilidades.Should().Contain(a => a.Nome == "Transcritor");
    }

    private BuscarDeficienciaAcessibilidadeHandler ObterUseCase()
    {
        return new BuscarDeficienciaAcessibilidadeHandler(_deficienciaRepository, _acessibilidadeRepository);
    }
}

