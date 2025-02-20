using Anima.Inscricao.Application.DTOs.OfertaConcursos;
using Anima.Inscricao.Application.UseCases.OfertaConcursos.ObterOfertaConcurso;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.OfertaConcursos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class ObterOfertaConcursoQueryHandlerTests
{
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IConcursoRepository _concursoRepository;

    public ObterOfertaConcursoQueryHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
        .BuildServiceProvider(new ServiceCollection());

        _ofertaConcursoRepository = serviceProvider.GetRequiredService<IOfertaConcursoRepository>();
        _ofertaRepository = serviceProvider.GetRequiredService<IOfertaRepository>();
        _concursoRepository = serviceProvider.GetRequiredService<IConcursoRepository>();
    }

    [Fact]
    public async Task DeveRetornarOfertaConcursoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        Guid key = OfertaConcursoConstants.Oferta2ConcursoEnem.Key;

        // Act
        var resultado = await useCase.Handle(new ObterOfertaConcursoQuery
        {
            Key = key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Should().BeEquivalentTo(new OfertaConcursoDto()
        {
            Key = key,
            OfertaKey = OfertaConstants.OfertaTeste2.Key,
            ConcursoKey = ConcursoConstants.ConcursoEnem.Key,

        });

    }

    private ObterOfertaConcursoQueryHandler ObterUseCase()
    {
        return new(
        _ofertaConcursoRepository,
            _ofertaRepository,
            _concursoRepository);
    }
}
