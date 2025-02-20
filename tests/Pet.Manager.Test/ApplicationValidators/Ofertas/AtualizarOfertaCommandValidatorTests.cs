using Anima.Inscricao.Application.UseCases.Ofertas.AtualizarOferta;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Produtos;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Ofertas;

public class AtualizarOfertaCommandValidatorTests
{
    private readonly Mock<IOfertaRepository> _ofertaRepositoryMock = new();
    private readonly Mock<IProdutoRepository> _produtoRepositoryMock = new();  
    private readonly Mock<IIntakeRepository> _intakeRepositoryMock = new();
    private readonly Mock<INotificationContext> _notificationContext = new();

    private readonly AtualizarOfertaCommandValidator _validator;

    public AtualizarOfertaCommandValidatorTests()
    {
        _validator = new AtualizarOfertaCommandValidator(
            _ofertaRepositoryMock.Object,
            _produtoRepositoryMock.Object,
            _intakeRepositoryMock.Object,
            _notificationContext.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoOfertaForVazia()
    {
        var command = new AtualizarOfertaCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da oferta é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaOfertaNaoForEncontrada()
    {
        _ofertaRepositoryMock.Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var command = new AtualizarOfertaCommand
        {
            Key = Guid.NewGuid(),
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da oferta não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoProdutoForVazia()
    {
        var command = new AtualizarOfertaCommand
        {
            ProdutoKey = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.ProdutoKey)
            .WithErrorMessage("A chave do produto é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoProdutoNaoForEncontrada()
    {
        _produtoRepositoryMock.Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var command = new AtualizarOfertaCommand
        {
            ProdutoKey = Guid.NewGuid(),
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.ProdutoKey)
            .WithErrorMessage("A chave do produto não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoIntakeForVazia()
    {
        var command = new AtualizarOfertaCommand
        {
            IntakeKey = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.IntakeKey)
            .WithErrorMessage("A chave do intake é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoIntakeNaoForEncontrada()
    {
        _intakeRepositoryMock.Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var command = new AtualizarOfertaCommand
        {
            IntakeKey = Guid.NewGuid(),
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.IntakeKey)
            .WithErrorMessage("A chave do intake não foi encontrada.");
    }

}
