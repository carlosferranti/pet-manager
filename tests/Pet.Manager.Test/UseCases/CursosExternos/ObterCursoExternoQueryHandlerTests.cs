using Anima.Inscricao.Application.UseCases.CursosExternos.ObterCursoExterno;
using Anima.Inscricao.Domain.CursosExternos;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.CursosExternos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class ObterCursoExternoQueryHandlerTests
{
    private readonly ICursoExternoRepository _cursoExternoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public ObterCursoExternoQueryHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _cursoExternoRepository = serviceProvider.GetRequiredService<ICursoExternoRepository>();
        _integracaoSistemaRepository = serviceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
    }

    [Fact]
    public async Task DeveRetornarCursoExternoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterCursoExternoQuery
        {
            Key = CursoExternoConstants.LetrasChines.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Key.Should().Be(CursoExternoConstants.LetrasChines.Key);
        resultado.Nome.Should().Be(CursoExternoConstants.LetrasChines.Nome);
    }

    private ObterCursoExternoQueryHandler ObterUseCase()
    {
        return new(
            _cursoExternoRepository,
            _integracaoSistemaRepository);
    }
}
