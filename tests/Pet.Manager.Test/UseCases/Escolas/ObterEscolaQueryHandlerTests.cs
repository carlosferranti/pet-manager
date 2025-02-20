using Anima.Inscricao.Application.UseCases.Escolas.ObterEscola;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Escolas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class ObterEscolaQueryHandlerTests
{
    private readonly IEscolaRepository _escolaRepository;
    private readonly ICidadeRepository _cidadeRepository;

    public ObterEscolaQueryHandlerTests(DatabaseFixture databaseFixture)
    {
        _escolaRepository = databaseFixture.ServiceProvider.GetRequiredService<IEscolaRepository>();
        _cidadeRepository = databaseFixture.ServiceProvider.GetRequiredService<ICidadeRepository>();
    }

    [Fact]
    public async Task DeveRetornarEscolaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterEscolaQuery
        {
            Key = EscolaConstants.IFSP.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Key.Should().Be(EscolaConstants.IFSP.Key);
        resultado.Nome.Should().Be(EscolaConstants.IFSP.Nome);
    }

    private ObterEscolaQueryHandler ObterUseCase()
    {
        return new(
            _escolaRepository,
            _cidadeRepository);
    }
}
