using Anima.Inscricao.Application.UseCases.Configuracoes.ObterConfiguracao;
using Anima.Inscricao.Domain.Configuracoes;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Configuracoes;

public class ObterConfiguracaoQueryHandlerTests
{
    private readonly Mock<IConfiguracaoRepository> _configuracaoRepository = new();

    public ObterConfiguracaoQueryHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRetornarConfiguracaoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterConfiguracaoQuery
        {
            Key = ConfiguracaoConstants.ConfiguracaoPadrao.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Key.Should().Be(ConfiguracaoConstants.ConfiguracaoPadrao.Key);
        resultado.Valor.Should().Be(ConfiguracaoConstants.ConfiguracaoPadrao.Valor);
    }

    private ObterConfiguracaoQueryHandler ObterUseCase()
    {
        _configuracaoRepository.Setup(x => x.GetAsync(ConfiguracaoConstants.ConfiguracaoPadrao.Key))
            .ReturnsAsync(ConfiguracaoConstants.ConfiguracaoPadrao);

        return new(_configuracaoRepository.Object);
    }
}
