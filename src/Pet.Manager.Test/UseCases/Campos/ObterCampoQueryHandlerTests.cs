using Anima.Inscricao.Application.UseCases.Campos.ObterCampo;
using Anima.Inscricao.Domain.Campos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Campos;

public class ObterCampoQueryHandlerTests
{
    private readonly Mock<ICampoRepository> _campoRepository = new();

    public ObterCampoQueryHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRetornarCampoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterCampoQuery
        {
            Key = CampoConstants.CPF.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Key.Should().Be(CampoConstants.CPF.Key);
        resultado.Nome.Should().Be(CampoConstants.CPF.Nome);
    }

    private ObterCampoQueryHandler ObterUseCase()
    {
        _campoRepository
            .Setup(x => x.GetAsync(CampoConstants.CPF.Key))
            .ReturnsAsync(CampoConstants.CPF);

        return new(_campoRepository.Object);
    }
}
