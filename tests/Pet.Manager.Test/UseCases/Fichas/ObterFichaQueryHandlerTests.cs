using Anima.Inscricao.Application.UseCases.Fichas.ObterFicha;
using Anima.Inscricao.Domain.Campos;
using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Fichas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class ObterFichaQueryHandlerTests
{
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;
    private readonly IFichaRepository _fichaRepository;
    private readonly ICampoRepository _campoRepository;

    public ObterFichaQueryHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _etapaTemplateRepository = serviceProvider.GetRequiredService<IEtapaTemplateRepository>();
        _fichaRepository = serviceProvider.GetRequiredService<IFichaRepository>();
        _campoRepository = serviceProvider.GetRequiredService<ICampoRepository>();
    }

    [Fact]
    public async Task DeveRetornarFichaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterFichaQuery
        {
            Key = FichaConstants.FichaPadrao.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Key.Should().Be(FichaConstants.FichaPadrao.Key);
        resultado.Nome.Should().Be(FichaConstants.FichaPadrao.Nome);
        resultado.Etapas.Count.Should().Be(FichaConstants.FichaPadrao.Etapas.Count);
        resultado.Campos.Count.Should().Be(FichaConstants.FichaPadrao.Campos.Count);
    }

    private ObterFichaQueryHandler ObterUseCase()
    {
        return new(_fichaRepository, _etapaTemplateRepository, _campoRepository);
    }
}