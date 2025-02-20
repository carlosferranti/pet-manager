using Anima.Inscricao.Application.UseCases.Marcas.ObterMarca;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Marcas;

public class ObterMarcaQueryHandlerTests
{
    private readonly Mock<IMarcaRepository> _marcaRepository = new();

    public ObterMarcaQueryHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRetornarMarcaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterMarcaQuery
        {
            Key = MarcaConstants.Una.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Key.Should().Be(MarcaConstants.Una.Key);
        resultado.Nome.Should().Be(MarcaConstants.Una.Nome);
    }

    private ObterMarcaQueryHandler ObterUseCase()
    {
        _marcaRepository
            .Setup(x => x.GetAsync(MarcaConstants.Una.Key))
            .ReturnsAsync(MarcaConstants.Una);

        return new(_marcaRepository.Object);
    }
}
