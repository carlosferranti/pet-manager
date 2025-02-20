using Anima.Inscricao.Application.UseCases.Enderecos.ObterPais;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Enderecos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class ObterPaisQueryHandlerTests
{
    private readonly IPaisRepository _paisRepository;

    public ObterPaisQueryHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _paisRepository = serviceProvider.GetRequiredService<IPaisRepository>();
    }

    [Fact]
    public async Task DeveRetornarPaisComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterPaisQuery
        {
            Key = EnderecoConstants.PaisBrasil.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Key.Should().Be(EnderecoConstants.PaisBrasil.Key);
        resultado.Nome.Should().Be(EnderecoConstants.PaisBrasil.Nome);
        resultado.Sigla.Should().Be(EnderecoConstants.PaisBrasil.Sigla);
        resultado.SiglaAbreviada.Should().Be(EnderecoConstants.PaisBrasil.SiglaAbreviada);
    }

    private ObterPaisQueryHandler ObterUseCase()
    {
        return new(_paisRepository);
    }
}