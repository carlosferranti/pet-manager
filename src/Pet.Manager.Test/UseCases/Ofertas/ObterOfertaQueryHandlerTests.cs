using Anima.Inscricao.Application.DTOs.Ofertas;

using Anima.Inscricao.Application.UseCases.Ofertas.ObterOferta;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Ofertas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class ObterOfertaQueryHandlerTests
{
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IProdutoRepository _produtoRepository;
    private readonly IIntakeRepository _intakeRepository;

    public ObterOfertaQueryHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
        .BuildServiceProvider(new ServiceCollection());

        _ofertaRepository = serviceProvider.GetRequiredService<IOfertaRepository>();
        _produtoRepository = serviceProvider.GetRequiredService<IProdutoRepository>();
        _intakeRepository = serviceProvider.GetRequiredService<IIntakeRepository>();
    }

    [Fact]
    public async Task DeveRetornarOfertaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        Guid key = OfertaConstants.OfertaTeste1.Key;

        // Act
        var resultado = await useCase.Handle(new ObterOfertaQuery
        {
            Key = key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Should().BeEquivalentTo(new OfertaDto()
        {
            Key = key,
            ProdutoKey = ProdutoConstants.ProdutoTeste1.Key,
            IntakeKey = IntakeConstants.IntakePrimeiroSemestre.Key,

        });

    }

    private ObterOfertaQueryHandler ObterUseCase()
    {
        return new(
            _ofertaRepository,
            _produtoRepository,
            _intakeRepository);
    }
}
