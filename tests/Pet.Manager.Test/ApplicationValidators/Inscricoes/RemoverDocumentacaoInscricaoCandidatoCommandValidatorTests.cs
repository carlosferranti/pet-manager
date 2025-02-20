using Anima.Inscricao.Application.UseCases.Inscricoes.RemoverDocumentacaoInscricaoCandidato;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Inscricoes;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Inscricoes;

public class RemoverDocumentacaoInscricaoCandidatoCommandValidatorTests
{
    private readonly RemoverDocumentacaoInscricaoCandidatoCommandValidator _validator;
    private readonly Mock<IInscricaoDocumentacaoRepository> _inscricaoDocumentacaoRepositoryMock = new();
    private readonly Mock<INotificationContext> _notificationContextMock = new();

    public RemoverDocumentacaoInscricaoCandidatoCommandValidatorTests()
    {
        _validator = new(
            _notificationContextMock.Object,
            _inscricaoDocumentacaoRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaInscricaoForVaziaAsync()
    {
        // Arrange
        var command = new RemoverDocumentacaoInscricaoCandidatoCommand
        {
            InscricaoDocumentacaoKey = Guid.Empty,
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.InscricaoDocumentacaoKey)
            .WithErrorMessage("A chave da inscrição documentacao é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaInscricaoNaoEncontradaAsync()
    {
        // Arrange
        var command = new RemoverDocumentacaoInscricaoCandidatoCommand
        {
            InscricaoDocumentacaoKey = Guid.NewGuid(),
        };

        _inscricaoDocumentacaoRepositoryMock
            .Setup(x => x.ExistsAsync(command.InscricaoDocumentacaoKey, CancellationToken.None))
            .ReturnsAsync(false);

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.InscricaoDocumentacaoKey)
            .WithErrorMessage("A chave da inscrição documentacao não foi encontrada.");
    }
}