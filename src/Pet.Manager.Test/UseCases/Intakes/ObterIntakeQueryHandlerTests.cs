using Anima.Inscricao.Application.UseCases.Intakes.ObterIntake;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Intakes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class ObterIntakeQueryHandlerTests
{
    private readonly IIntakeRepository _intakeRepository;

    public ObterIntakeQueryHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _intakeRepository = serviceProvider.GetRequiredService<IIntakeRepository>();
    }

    [Fact]
    public async Task DeveRetornarIntakeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterIntakeQuery
        {
            Key = IntakeConstants.IntakeSegundoSemestre.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Key.Should().Be(IntakeConstants.IntakeSegundoSemestre.Key);
        resultado.Nome.Should().Be(IntakeConstants.IntakeSegundoSemestre.Nome);
        resultado.VigenciaInicio.Should().Be(IntakeConstants.IntakeSegundoSemestre.Vigencia.Inicio);
        resultado.VigenciaTermino.Should().Be(IntakeConstants.IntakeSegundoSemestre.Vigencia.Termino);
    }

    private ObterIntakeQueryHandler ObterUseCase()
    {
        return new(_intakeRepository);
    }
}
