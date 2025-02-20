using Anima.Inscricao.Application.UseCases.Inscricoes.PesquisarInscricaoAnteriorCandidato;
using Anima.Inscricao.Application.UseCases.Inscricoes.PesquisarInscricaoCandidatoMarca;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Marcas;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Inscricoes;

public class PesquisarInscricaoCandidatoMarcaQueryValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IMarcaRepository> _marcaRepositoryMock = new();
    private readonly PesquisarInscricaoCandidatoMarcaQueryValidator _validator;

    public PesquisarInscricaoCandidatoMarcaQueryValidatorTests()
    {
        _validator = new (_notificationContextMock.Object, _marcaRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoMarcaNaoExistirAsync()
    {
        // Arrange
        var command = new PesquisarInscricaoCandidatoMarcaQuery
        {
            MarcaKey = Guid.NewGuid()
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.MarcaKey)
            .WithErrorMessage("Marca da inscrição não encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoCpfVazioAsync()
    {
        // Arrange
        var query = new PesquisarInscricaoCandidatoMarcaQuery
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
        var query = new PesquisarInscricaoCandidatoMarcaQuery
        {
            Cpf = "000000000",
        };

        // Act
        var result = await _validator.TestValidateAsync(query);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Cpf)
            .WithErrorMessage("CPF inválido.");
    }
}