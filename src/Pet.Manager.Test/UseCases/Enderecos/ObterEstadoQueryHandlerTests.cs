using Anima.Inscricao.Application.UseCases.Enderecos.ObterEstado;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Enderecos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class ObterEstadoQueryHandlerTests
{
    private readonly IEstadoRepository _estadoRepository;
    private readonly IPaisRepository _paisRepository;

    public ObterEstadoQueryHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _estadoRepository = serviceProvider.GetRequiredService<IEstadoRepository>();
        _paisRepository = serviceProvider.GetRequiredService<IPaisRepository>();
    }

    [Fact]
    public async Task DeveRetornarEstadoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterEstadoQuery
        {
            Key = EnderecoConstants.EstadoSP.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Key.Should().Be(EnderecoConstants.EstadoSP.Key);
        resultado.Nome.Should().Be(EnderecoConstants.EstadoSP.Nome);
        resultado.Sigla.Should().Be(EnderecoConstants.EstadoSP.Sigla);
        resultado.PaisKey.Should().Be(EnderecoConstants.PaisBrasil.Key);
    }

    private ObterEstadoQueryHandler ObterUseCase()
    {
        return new(_paisRepository, _estadoRepository);
    }
}