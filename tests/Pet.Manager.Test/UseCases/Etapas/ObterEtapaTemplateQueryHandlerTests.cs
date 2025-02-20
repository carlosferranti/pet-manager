using Anima.Inscricao.Application.UseCases.Etapas.ObterEtapaTemplate;
using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Etapas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class ObterEtapaTemplateQueryHandlerTests
{
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;

    public ObterEtapaTemplateQueryHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _etapaTemplateRepository = serviceProvider.GetRequiredService<IEtapaTemplateRepository>();
    }

    [Fact]
    public async Task DeveRetornarEtapaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterEtapaTemplateQuery
        {
            Key = EtapaConstants.EtapaDadosPessoais.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Key.Should().Be(EtapaConstants.EtapaDadosPessoais.Key);
        resultado.Nome.Should().Be(EtapaConstants.EtapaDadosPessoais.Nome);
    }

    private ObterEtapaTemplateQueryHandler ObterUseCase()
    {
        return new(_etapaTemplateRepository);
    }
}