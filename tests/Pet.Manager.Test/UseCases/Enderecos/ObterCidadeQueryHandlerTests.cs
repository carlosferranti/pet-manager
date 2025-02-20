using Anima.Inscricao.Application.UseCases.Enderecos.ObterCidade;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Enderecos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class ObterCidadeQueryHandlerTests
{
    private readonly IEstadoRepository _estadoRepository;
    private readonly ICidadeRepository _cidadeRepository;

    public ObterCidadeQueryHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _estadoRepository = serviceProvider.GetRequiredService<IEstadoRepository>();
        _cidadeRepository = serviceProvider.GetRequiredService<ICidadeRepository>();
    }

    [Fact]
    public async Task DeveRetornarCidadeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterCidadeQuery
        {
            Key = EnderecoConstants.CidadeSaoPaulo.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Key.Should().Be(EnderecoConstants.CidadeSaoPaulo.Key);
        resultado.Nome.Should().Be(EnderecoConstants.CidadeSaoPaulo.Nome);
    }

    private ObterCidadeQueryHandler ObterUseCase()
    {
        return new(_cidadeRepository, _estadoRepository);
    }
}