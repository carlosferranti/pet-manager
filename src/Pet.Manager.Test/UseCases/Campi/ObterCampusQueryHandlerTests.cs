using Anima.Inscricao.Application.UseCases.Campi.ObterCampus;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Campi;

public class ObterCampusQueryHandlerTests
{
    private readonly Mock<ICampusRepository> _campusRepository = new();

    public ObterCampusQueryHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRetornarCampusComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterCampusQuery
        {
            Key = CampusConstants.CampusOlinda.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Key.Should().Be(CampusConstants.CampusOlinda.Key);
        resultado.Nome.Should().Be(CampusConstants.CampusOlinda.Nome);
    }

    private ObterCampusQueryHandler ObterUseCase()
    {
        _campusRepository
            .Setup(x => x.GetAsync(CampusConstants.CampusOlinda.Key))
            .ReturnsAsync(CampusConstants.CampusOlinda);

        return new(_campusRepository.Object);
    }
}
