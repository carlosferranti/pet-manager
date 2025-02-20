using Anima.Inscricao.Application.UseCases.Deficiencias.ObterDeficiencia;
using Anima.Inscricao.Domain.Deficiencias;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Deficiencias;

public class ObterDeficienciaQueryHandlerTests
{
    private readonly Mock<IDeficienciaRepository> _deficienciaRepository = new();

    public ObterDeficienciaQueryHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRetornarDeficienciaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterDeficienciaQuery
        {
            Key = DeficienciaConstants.Cegueira.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Key.Should().Be(DeficienciaConstants.Cegueira.Key);
        resultado.Nome.Should().Be(DeficienciaConstants.Cegueira.Nome);
    }

    private ObterDeficienciaQueryHandler ObterUseCase()
    {
        _deficienciaRepository
            .Setup(x => x.GetAsync(DeficienciaConstants.Cegueira.Key))
            .ReturnsAsync(DeficienciaConstants.Cegueira);

        return new(_deficienciaRepository.Object);
    }
}
