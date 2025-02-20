using Anima.Inscricao.Application.UseCases.Escolas.ObterAnoConclusao;
using Anima.Inscricao.Application.UseCases.Escolas.ObterAnosConclusao;

namespace Anima.Inscricao.Test.UseCases.Escolas;

public class ObterAnosConclusaoCommandHandlerTests
{
    [Fact]
    public async Task DeveRetornarAnosConclusaoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();
        var command = new ObterAnosConclusaoQuery();
        
        // Act
        var result = await useCase.Handle(command, CancellationToken.None);
        
        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result);
        Assert.Equal(104, result.Count);
        Assert.Equal(DateTime.Now.Year + 3, result[0]);
        Assert.Equal(DateTime.Now.Year - 100, result[result.Count-1]);
    }


    private ObterAnosConclusaoQueryHandler ObterUseCase()
    {
        return new();
    }
}
