using Anima.Inscricao.Application.UseCases.FormasEntrada.ObterFormaEntrada;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.FormasEntrada;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class ObterFormaEntradaQueryHandlerTests
{
    private readonly IFormaEntradaRepository _formaEntradaRepository;

    public ObterFormaEntradaQueryHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _formaEntradaRepository = serviceProvider.GetRequiredService<IFormaEntradaRepository>();
    }

    [Fact]
    public async Task DeveRetornarFormaDeEntradaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterFormaEntradaQuery
        {
            Key = FormaEntradaConstants.FormaEntradaEnem.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Key.Should().Be(FormaEntradaConstants.FormaEntradaEnem.Key);
        resultado.Nome.Should().Be(FormaEntradaConstants.FormaEntradaEnem.Nome);
    }

    private ObterFormaEntradaQueryHandler ObterUseCase()
    {
        return new(_formaEntradaRepository);
    }
}
