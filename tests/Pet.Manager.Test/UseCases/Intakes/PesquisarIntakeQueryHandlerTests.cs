using Anima.Inscricao.Application.UseCases.Intakes.PesquisarIntake;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Intakes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarIntakeQueryHandlerTests
{
    private readonly IIntakeRepository _intakeRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public PesquisarIntakeQueryHandlerTests(DatabaseFixture databaseFixture)
    {
        _intakeRepository = databaseFixture.ServiceProvider.GetRequiredService<IIntakeRepository>();
        _integracaoSistemaRepository = databaseFixture.ServiceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
    }

    [Fact]
    public async Task DeveRetornarIntakesComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarIntakeQuery()
        {
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(2);
        resultado.Data.Should().HaveCount(2);
    }

    [Fact]
    public async Task DeveRetornarIntakesFiltrandoPorNomeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarIntakeQuery()
        {
            Filtros = new(IntakeConstants.IntakeSegundoSemestre.Nome),
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(1);
        resultado.Data.Should().HaveCount(1);
    }

    private PesquisarIntakeQueryHandler ObterUseCase()
    {
        return new(_intakeRepository, _integracaoSistemaRepository);
    }
}
