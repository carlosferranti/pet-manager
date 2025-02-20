using Anima.Inscricao.Application.UseCases.Concursos.PesquisarConcursoPorOferta;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Links;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Ofertas;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Concursos;

public class ObterConcursoPorOfertaQueryValidatorTests
{
    private readonly Mock<IOfertaRepository> _ofertaRepositoryMock = new();
    private readonly Mock<ILinkRepository> _linkRepositoryMock = new();
    private readonly Mock<IFormaEntradaRepository> _formaEntradaRepositoryMock = new();
    private readonly PesquisarConcursoPorOfertaQueryValidator _validator;

    public ObterConcursoPorOfertaQueryValidatorTests()
    {
        var notificationContextMock = new Mock<INotificationContext>();
        _validator = new PesquisarConcursoPorOfertaQueryValidator(
            _ofertaRepositoryMock.Object,
            _linkRepositoryMock.Object,
            _formaEntradaRepositoryMock.Object,
            notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveRetornarErro_QuandoCpfEstiverVazio()
    {
        // Arrange
        var request = new PesquisarConcursoPorOfertaQuery
        {
            Cpf = string.Empty,
            OfertaKey = Guid.NewGuid()
        };

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Cpf)
              .WithErrorMessage("O CPF é obrigatório.");
    }

    [Fact]
    public async Task DeveRetornarErro_QuandoCpfForInvalido()
    {
        // Arrange
        var request = new PesquisarConcursoPorOfertaQuery
        {
            Cpf = "12345678900",
            OfertaKey = Guid.NewGuid()
        };

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Cpf)
              .WithErrorMessage("CPF inválido.");
    }

    [Fact]
    public async Task DeveRetornarErro_QuandoOfertaKeyEstiverVazio()
    {
        // Arrange
        var request = new PesquisarConcursoPorOfertaQuery
        {
            Cpf = "11122233344",
            OfertaKey = Guid.Empty
        };

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.OfertaKey)
              .WithErrorMessage("A chave da oferta é obrigatória.");
    }

    [Fact]
    public async Task DeveRetornarErro_QuandoOfertaNaoExistir()
    {
        // Arrange
        var request = new PesquisarConcursoPorOfertaQuery
        {
            Cpf = "11122233344",
            OfertaKey = Guid.NewGuid()
        };

        _ofertaRepositoryMock.Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.OfertaKey)
              .WithErrorMessage("A chave da oferta não foi encontrada.");
    }

    [Fact]
    public async Task DevePassarValidacao_QuandoCpfEOfertaForemValidos()
    {
        // Arrange
        var request = new PesquisarConcursoPorOfertaQuery
        {
            Cpf = "968.354.112-79",
            OfertaKey = Guid.NewGuid(),
            LinkKey = Guid.NewGuid()
        };

        _ofertaRepositoryMock
            .Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(true);

        _linkRepositoryMock
            .Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(true);

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        Assert.True(result.IsValid);
    }

    [Fact]
    public async Task DeveRetornarErroQuandoLinkKeyEstiverVazio()
    {
        // Arrange
        var request = new PesquisarConcursoPorOfertaQuery
        {
            LinkKey = Guid.Empty
        };

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.LinkKey)
              .WithErrorMessage("A chave do link é obrigatória.");
    }

    [Fact]
    public async Task DeveRetornarErroQuandoLinkKeyNaoExistir()
    {
        // Arrange
        var request = new PesquisarConcursoPorOfertaQuery
        {
            LinkKey = Guid.NewGuid()
        };

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.LinkKey)
              .WithErrorMessage("A chave do link não foi encontrada.");
    }

    [Fact]
    public async Task DeveRetornarErroQuandoFormaEntradaKeyNaoExistirAsync()
    {
        // Arrange
        var request = new PesquisarConcursoPorOfertaQuery
        {
            FormaEntradaKey = Guid.NewGuid(),
        };

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.FormaEntradaKey.Value)
              .WithErrorMessage("A chave da forma de entrada não foi encontrada.");
    }
}
