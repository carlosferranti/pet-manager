using Anima.Inscricao.Application.UseCases.Cupons.ObterCupom;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Cupons;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Cupons;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class ObterCupomQueryHandlerTests
{
    private readonly ICupomRepository _escolaRepository;
    private readonly IConcursoRepository _concursoRepository;

    public ObterCupomQueryHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _escolaRepository = serviceProvider.GetRequiredService<ICupomRepository>();
        _concursoRepository = serviceProvider.GetRequiredService<IConcursoRepository>();
    }

    [Fact]
    public async Task DeveRetornarCupomComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterCupomQuery
        {
            Key = CupomConstants.CupomPablo100.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado!.Key.Should().Be(CupomConstants.CupomPablo100.Key);
        resultado.Codigo.Should().Be(CupomConstants.CupomPablo100.Codigo);
    }

    private ObterCupomQueryHandler ObterUseCase()
    {
        return new(_escolaRepository, _concursoRepository);
    }
}
