using Anima.Inscricao.Application.UseCases.NiveisCurso.ObterNivelCurso;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.NiveisCurso;

public class ObterNivelCursoQueryHandlerTests
{
    private readonly Mock<INivelCursoRepository> _nivelCursoRepository = new();

    public ObterNivelCursoQueryHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRetornarNivelCursoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterNivelCursoQuery
        {
            Key = NivelCursoConstants.Bacharelado.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Key.Should().Be(NivelCursoConstants.Bacharelado.Key);
        resultado.Nome.Should().Be(NivelCursoConstants.Bacharelado.Nome);
    }

    private ObterNivelCursoQueryHandler ObterUseCase()
    {
        _nivelCursoRepository
            .Setup(x => x.GetAsync(NivelCursoConstants.Bacharelado.Key))
            .ReturnsAsync(NivelCursoConstants.Bacharelado);

        return new(_nivelCursoRepository.Object);
    }
}
