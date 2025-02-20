using Anima.Inscricao.Application.UseCases.Ofertas.ObterOferta;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Ofertas;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Ofertas;

public class ObterOfertaCommandValidatorTests
{
    private readonly Mock<IOfertaRepository> _ofertaRepositoryMock = new();
    private readonly ObterOfertaQueryValidator _validator;

    public ObterOfertaCommandValidatorTests()
    {
        _validator =  new ObterOfertaQueryValidator(
            _ofertaRepositoryMock.Object,
            new Mock<INotificationContext>().Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaOFertaForVazia()
    {
        var query = new ObterOfertaQuery
        {
            Key = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(query);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da oferta é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaOfertaNaoForEncontrada()
    {
        _ofertaRepositoryMock.Setup(repo => repo.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var query = new ObterOfertaQuery
        {
            Key = Guid.NewGuid(),
        };

        var result = await _validator.TestValidateAsync(query);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da oferta não foi encontrada.");
    }

    [Fact]
    public async Task NaoDeveTerErroQuandoChaveDoProdutoForValida()
    {
        _ofertaRepositoryMock.Setup(repo => repo.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(true);

        var query = new ObterOfertaQuery
        {
            Key = Guid.NewGuid(),
        };

        var result = await _validator.TestValidateAsync(query);

        result.ShouldNotHaveValidationErrorFor(x => x.Key);
    }
}
