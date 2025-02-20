using Anima.Inscricao.Application.UseCases.Instituicoes.ObterInstituicao;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Instituicoes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class ObterInstituicaoQueryHandlerTests
{
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly IMarcaRepository _marcaRepository;

    public ObterInstituicaoQueryHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _instituicaoRepository = serviceProvider.GetRequiredService<IInstituicaoRepository>();
        _marcaRepository = serviceProvider.GetRequiredService<IMarcaRepository>();
    }

    [Fact]
    public async Task DeveRetornarInstituicaoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterInstituicaoQuery
        {
            Key = InstituicaoConstants.Una.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Key.Should().Be(InstituicaoConstants.Una.Key);
        resultado.Nome.Should().Be(InstituicaoConstants.Una.Nome);
    }

    private ObterInstituicaoQueryHandler ObterUseCase()
    {
        return new(_instituicaoRepository, _marcaRepository);
    }
}
