using Anima.Inscricao.Application.UseCases.Inscricoes.CriarDocumentacaoInscricaoCandidato;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricoes.Domain.Inscricoes;

using FluentValidation.TestHelper;

using Microsoft.AspNetCore.Http;

using Moq;

using static Anima.Inscricao.Application.UseCases.Inscricoes.CriarDocumentacaoInscricaoCandidato.CriarDocumentacaoInscricaoCandidatoCommand;

namespace Anima.Inscricao.Test.ApplicationValidators.Inscricoes;

public class CriarDocumentacaoInscricaoCandidatoCommandValidatorTests
{
    private readonly CriarDocumentacaoInscricaoCandidatoCommandValidator _validator;
    private readonly Mock<IInscricaoRepository> _inscricaoRepositoryMock = new();
    private readonly Mock<INotificationContext> _notificationContextMock = new();

    public CriarDocumentacaoInscricaoCandidatoCommandValidatorTests()
    {
        _validator = new CriarDocumentacaoInscricaoCandidatoCommandValidator(
            _notificationContextMock.Object,
            _inscricaoRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaInscricaoForVaziaAsync()
    {
        // Arrange
        var command = new CriarDocumentacaoInscricaoCandidatoCommand
        {
            InscricaoKey = Guid.Empty,
            Documentos = new List<InfoDocumentoCommand>()
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.InscricaoKey)
            .WithErrorMessage("A chave da inscrição é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaInscricaoNaoEncontradaAsync()
    {
        // Arrange
        var command = new CriarDocumentacaoInscricaoCandidatoCommand
        {
            InscricaoKey = Guid.NewGuid(),
            Documentos = new List<InfoDocumentoCommand>()
        };
        _inscricaoRepositoryMock.Setup(x => x.ExistsAsync(command.InscricaoKey, CancellationToken.None))
            .ReturnsAsync(false);

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.InscricaoKey)
            .WithErrorMessage("A chave da inscrição não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoListaDeDocumentaoForVaziaAsync()
    {
        // Arrange
        var command = new CriarDocumentacaoInscricaoCandidatoCommand
        {
            InscricaoKey = Guid.NewGuid(),
            Documentos = new List<InfoDocumentoCommand>()
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Documentos)
            .WithErrorMessage("A lista de documentos é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoArquivoNaoInformadoAsync()
    {
        // Arrange
        var command = new CriarDocumentacaoInscricaoCandidatoCommand
        {
            InscricaoKey = Guid.NewGuid(),
            Documentos = new List<InfoDocumentoCommand>
            {
                new InfoDocumentoCommand
                {
                    Arquivo = null,
                    Observacoes = "Observações"
                }
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("Documentos[0].Arquivo")
            .WithErrorMessage("O arquivo é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoTamanhoDoArquivoForMaiorQueLimiteAsync()
    {
        // Arrange
        var command = new CriarDocumentacaoInscricaoCandidatoCommand
        {
            InscricaoKey = Guid.NewGuid(),
            Documentos = new List<InfoDocumentoCommand>
            {
                new InfoDocumentoCommand
                {
                    Arquivo = new FormFile(
                        baseStream: new MemoryStream(1),
                        baseStreamOffset: 0,
                        length: 11 * 1024 * 1024,
                        name: "Data",
                        fileName: "arquivo.pdf"),
                    Observacoes = "Observações"
                }
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("Documentos[0].Arquivo")
            .WithErrorMessage("O tamanho máximo do arquivo é 10MB.");
    }

    [Fact]
    public async Task DeveTerErroQuandoExtensaoArquivoNaoForPermitidaAsync()
    {
        // Arrange
        var command = new CriarDocumentacaoInscricaoCandidatoCommand
        {
            InscricaoKey = Guid.NewGuid(),
            Documentos = new List<InfoDocumentoCommand>
            {
                new InfoDocumentoCommand
                {
                    Arquivo = new FormFile(
                        baseStream: new MemoryStream(1),
                        baseStreamOffset: 0,
                        length: 1 * 1024,
                        name: "Data",
                        fileName: "arquivo.xlsx"),
                    Observacoes = "Observações"
                }
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("Documentos[0].Arquivo")
            .WithErrorMessage("O formato do arquivo é inválido.");
    }

    [Fact]
    public async Task DeveTerErroQuandoObservacaoUltrapassarLimitePermitidoAsync()
    {
        // Arrange
        var command = new CriarDocumentacaoInscricaoCandidatoCommand
        {
            InscricaoKey = Guid.NewGuid(),
            Documentos = new List<InfoDocumentoCommand>
            {
                new InfoDocumentoCommand
                {
                    Arquivo = new FormFile(
                        baseStream: new MemoryStream(1),
                        baseStreamOffset: 0,
                        length: 1 * 1024,
                        name: "Data",
                        fileName: "arquivo.xlsx"),
                    Observacoes = new string('a', 501) // 501 characters
                }
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("Documentos[0].Observacoes")
            .WithErrorMessage("A observação do arquivo deve ter no máximo 500 caracteres.");
    }
}