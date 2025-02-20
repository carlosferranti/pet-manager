using Anima.Inscricao.Application.UseCases.Acessibilidades.ObterAcessibilidade;
using Anima.Inscricao.Domain.Acessibilidades;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Acessibilidades;

public class ObterAcessibilidadeQueryHandlerTests
{
    private readonly Mock<IAcessibilidadeRepository> _acessibilidadeRepository = new();

    public ObterAcessibilidadeQueryHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRetornarAcessibilidadeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterAcessibilidadeQuery
        {
            Key = AcessibilidadeConstants.ProvaBraile.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Key.Should().Be(AcessibilidadeConstants.ProvaBraile.Key);
        resultado.Nome.Should().Be(AcessibilidadeConstants.ProvaBraile.Nome);
    }

    private ObterAcessibilidadeQueryHandler ObterUseCase() {         
        
        _acessibilidadeRepository
            .Setup(x => x.GetAsync(AcessibilidadeConstants.ProvaBraile.Key))
            .ReturnsAsync(AcessibilidadeConstants.ProvaBraile);

        return new(_acessibilidadeRepository.Object);
    }
}
