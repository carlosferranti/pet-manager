using Anima.Inscricao.Application.UseCases.Inscricoes.PesquisarVinculoCandidato;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Marcas;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Inscricoes;

public class PesquisarVinculoCandidatoQueryValidatorTests
{
    private readonly Mock<IFormaEntradaRepository> _formaEntradaRepository = new();
    private readonly Mock<IMarcaRepository> _marcaRepository = new();
    private readonly Mock<INotificationContext> _notificationMock = new();
    private readonly PesquisarVinculoCandidatoQueryValidator _validator;

    public PesquisarVinculoCandidatoQueryValidatorTests()
    {
        _validator = new(
            _formaEntradaRepository.Object,
            _marcaRepository.Object,
            _notificationMock.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoCpfVazioAsync()
    {
        // Arrange
        var query = new PesquisarVinculoCandidatoQuery
        {
            Cpf = string.Empty,
        };

        // Act
        var result = await _validator.TestValidateAsync(query);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Cpf)
            .WithErrorMessage("O CPF precisa ser informado.");
    }

    [Fact]
    public async Task DeveTerErroQuandoCpfInvalidoAsync()
    {
        // Arrange
        var query = new PesquisarVinculoCandidatoQuery
        {
            Cpf = "000000000",
        };

        // Act
        var result = await _validator.TestValidateAsync(query);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Cpf)
            .WithErrorMessage("CPF inválido.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaMarcaNaoExistir()
    {
        // Arrange
        var query = new PesquisarVinculoCandidatoQuery
        {
           MarcaKey = Guid.NewGuid(),
        };

        // Act
        var result = await _validator.TestValidateAsync(query);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.MarcaKey!.Value)
            .WithErrorMessage("Marca não encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaFormaEntradaNaoExistir()
    {
        // Arrange
        var query = new PesquisarVinculoCandidatoQuery
        {
            FormaEntradaKey = Guid.NewGuid(),
        };

        // Act
        var result = await _validator.TestValidateAsync(query);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.FormaEntradaKey!.Value)
            .WithErrorMessage("Forma de entrada não encontrada.");
    }
}