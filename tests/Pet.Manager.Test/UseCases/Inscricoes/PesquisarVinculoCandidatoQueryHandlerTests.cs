using Anima.Inscricao.Application.DTOs.Candidatos;
using Anima.Inscricao.Application.Interfaces.Repositories;
using Anima.Inscricao.Application.UseCases.Inscricoes.PesquisarVinculoCandidato;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Inscricoes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarVinculoCandidatoQueryHandlerTests
{
    private readonly IMarcaRepository _marcaRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly Mock<ICandidatoRepository> _candidatoRepositoryMock = new();
    private readonly Mock<ILogger<PesquisarVinculoCandidatoQueryHandler>> _loggerMock = new();

    public PesquisarVinculoCandidatoQueryHandlerTests(DatabaseFixture databaseFixture)
    {
        _marcaRepository = databaseFixture.ServiceProvider.GetRequiredService<IMarcaRepository>();
        _integracaoSistemaRepository = databaseFixture.ServiceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
    }


    [Fact]
    public async Task DeveRetornarVinculosDoCandidatoAsync()
    {
        // Arrange
        var query = new PesquisarVinculoCandidatoQuery()
        {
            Cpf = "12345678900",
        };

        _candidatoRepositoryMock
           .Setup(x => x.PesquisarVinculoCandidatoAsync(It.IsAny<string>(), It.IsAny<string?>(), It.IsAny<string?>()))
           .ReturnsAsync(new List<CandidatoVinculoDto>
           {
                new CandidatoVinculoDto
                {
                    NomeAluno = "Fulano",
                    CodigoMarca = 1,
                }
           });

        // Act
        var useCase = ObterUseCase();
        var result = await useCase.Handle(query, new CancellationToken());

        // Assert
        result.Should().NotBeNull();
        result.Should().HaveCount(1);
    }

    [Fact]
    public async Task DevePesquisarMarcaAntesDeConsultarVinculosDoCandidatoAsync()
    {
        // Arrange
        var query = new PesquisarVinculoCandidatoQuery()
        {
            Cpf = "12345678900",
            MarcaKey = MarcaConstants.Una.Key,
            FormaEntradaKey = FormaEntradaConstants.FormaEntradaReopcao.Key,
        };

        _candidatoRepositoryMock
           .Setup(x => x.PesquisarVinculoCandidatoAsync(It.IsAny<string>(), It.IsAny<string?>(), It.IsAny<string?>()))
           .ReturnsAsync(new List<CandidatoVinculoDto>());

        // Act
        var useCase = ObterUseCase();
        var result = await useCase.Handle(query, new CancellationToken());

        // Assert
        result.Should().BeEmpty();
        _candidatoRepositoryMock
            .Verify(x => x.PesquisarVinculoCandidatoAsync(It.IsAny<string>(), It.IsNotNull<string?>(), null), Times.Once);
    }

    private PesquisarVinculoCandidatoQueryHandler ObterUseCase()
    {
        return new PesquisarVinculoCandidatoQueryHandler(
            _candidatoRepositoryMock.Object,
            _marcaRepository,
            _integracaoSistemaRepository,
            _loggerMock.Object);
    }
}