using Anima.Inscricao.Application.UseCases.Turnos.ObterTurno;
using Anima.Inscricao.Domain.Turnos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Turnos;

public class ObterTurnoQueryHandlerTests
{
    private readonly Mock<ITurnoRepository> _turnoRepository = new();

    public ObterTurnoQueryHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRetornarTurnoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterTurnoQuery
        {
            Key = TurnoConstants.TurnoManha.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Key.Should().Be(TurnoConstants.TurnoManha.Key);
        resultado.Nome.Should().Be(TurnoConstants.TurnoManha.Nome);
    }

    private ObterTurnoQueryHandler ObterUseCase()
    {
        _turnoRepository
            .Setup(x => x.GetAsync(TurnoConstants.TurnoManha.Key))
            .ReturnsAsync(TurnoConstants.TurnoManha);

        return new(_turnoRepository.Object);
    }
}
