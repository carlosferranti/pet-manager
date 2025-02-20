using Anima.Inscricao.Application.UseCases.TiposFormacao.ObterTipoFormacao;
using Anima.Inscricao.Domain.TiposFormacao;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.TiposFormacao;

public class ObterTipoFormacaoQueryHandlerTests
{
    private readonly Mock<ITipoFormacaoRepository> _tipoFormacaoRepository = new();

    public ObterTipoFormacaoQueryHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRetornarTipoFormacaoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterTipoFormacaoQuery
        {
            Key = TipoFormacaoConstants.TipoFormacaoGraduacao.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Key.Should().Be(TipoFormacaoConstants.TipoFormacaoGraduacao.Key);
        resultado.Nome.Should().Be(TipoFormacaoConstants.TipoFormacaoGraduacao.Nome);
    }

    private ObterTipoFormacaoQueryHandler ObterUseCase()
    {
        _tipoFormacaoRepository
            .Setup(x => x.GetAsync(TipoFormacaoConstants.TipoFormacaoGraduacao.Key))
            .ReturnsAsync(TipoFormacaoConstants.TipoFormacaoGraduacao);

        return new(_tipoFormacaoRepository.Object);
    }
}
