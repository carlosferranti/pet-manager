using Amazon.S3;

using Anima.Inscricao.Application.Interfaces.Services;
using Anima.Inscricao.Application.UseCases.Inscricoes.CriarDocumentacaoInscricaoCandidato;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Inscricoes;
using Anima.Inscricao.Domain.Inscricoes.Entities;
using Anima.Inscricao.Domain.Inscricoes.Enums;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;
using Anima.Inscricoes.Domain.Inscricoes;

using FluentAssertions;

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Moq;

using static Anima.Inscricao.Application.UseCases.Inscricoes.CriarDocumentacaoInscricaoCandidato.CriarDocumentacaoInscricaoCandidatoCommand;

namespace Anima.Inscricao.Test.UseCases.Inscricoes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarDocumentacaoInscricaoCandidatoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IInscricaoRepository> _inscricaoRepositoryMock = new();
    private readonly Mock<IInscricaoDocumentacaoRepository> _inscricaoDocumentacaoRepositoryMock = new();
    private readonly Mock<IUnitOfWork> _unitOfWorkMock = new();
    private readonly Mock<IAmazonS3Service> _amazonS3ServiceMock = new();
    private readonly Mock<ILogger<CriarDocumentacaoInscricaoCandidatoCommandHandler>> _loggerMock = new();

    public CriarDocumentacaoInscricaoCandidatoCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveInserirDocumentacaoComSucessoAsync()
    {
        // Arrange
        var command = new CriarDocumentacaoInscricaoCandidatoCommand()
        {
            InscricaoKey = InscricaoConstants.InscricaoCorreta.Key,
            Documentos = new List<InfoDocumentoCommand>()
            {
                new InfoDocumentoCommand()
                {
                    Arquivo = new FormFile(
                        baseStream: new MemoryStream(1),
                        baseStreamOffset: 0,
                        length: 11 * 1024,
                        name: "arquivo",
                        fileName: "arquivo.pdf"),
                    Observacoes = "Observacoes",
                    Tipo = TipoDocumentacaoInscricao.LaudoNecessidadesEspeciais
                },
            },
        };

        _amazonS3ServiceMock
            .Setup(x => x.UploadArquivoAsync(It.IsAny<byte[]>(), It.IsAny<string>(), It.IsAny<Guid>(), CancellationToken.None))
            .ReturnsAsync("https://s3.amazonaws.com/arquivo.pdf");

        // Act
        var useCase = ObterUseCase();
        var result = await useCase.Handle(command, default);

        // Assert
        result.Should().NotBeNull();
        result.Should().HaveCount(1);
        result![0].TipoLocalArquivo.Should().Be(1);
        result![0].NomeArquivo.Should().Be("arquivo.pdf");
        result![0].ExtensaoArquivo.Should().Be(".pdf");
        result![0].TamanhoArquivo.Should().Be(11 * 1024);
        result![0].Key.Should().NotBeEmpty();
        result![0].ChaveArquivo.Should().NotBeEmpty();

        _inscricaoDocumentacaoRepositoryMock.Verify(x => x.InsertAsync(It.IsAny<DocumentacaoInscricao>()), Times.Once);
        _unitOfWorkMock.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
        _amazonS3ServiceMock.Verify(x => x.UploadArquivoAsync(It.IsAny<byte[]>(), It.IsAny<string>(), It.IsAny<Guid>(), CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task DeveExcluirArquivoNoS3QuandoAcontecerErroAsync()
    {
        // Arrange
        var command = new CriarDocumentacaoInscricaoCandidatoCommand()
        {
            InscricaoKey = InscricaoConstants.InscricaoCorreta.Key,
            Documentos = new List<InfoDocumentoCommand>()
            {
                new InfoDocumentoCommand()
                {
                    Arquivo = new FormFile(
                        baseStream: new MemoryStream(1),
                        baseStreamOffset: 0,
                        length: 11 * 1024,
                        name: "arquivo1",
                        fileName: "arquivo1.pdf"),
                    Tipo = TipoDocumentacaoInscricao.LaudoNecessidadesEspeciais,
                },
                new InfoDocumentoCommand()
                {
                    Arquivo = new FormFile(
                        baseStream: new MemoryStream(1),
                        baseStreamOffset: 0,
                        length: 11 * 1024,
                        name: "arquivo2",
                        fileName: "arquivo2.pdf"),
                    Tipo = TipoDocumentacaoInscricao.LaudoNecessidadesEspeciais,
                },
            },
        };

        _amazonS3ServiceMock
            .SetupSequence(x => x.UploadArquivoAsync(It.IsAny<byte[]>(), It.IsAny<string>(), It.IsAny<Guid>(), CancellationToken.None))
            .ReturnsAsync("https://s3.amazonaws.com/arquivo.pdf")
            .ThrowsAsync(new AmazonS3Exception("erro"));

        // Act
        var useCase = ObterUseCase();
        await Assert.ThrowsAsync<AmazonS3Exception>(() => useCase.Handle(command, default));

        // Assert
        _unitOfWorkMock.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
        _inscricaoDocumentacaoRepositoryMock.Verify(x => x.InsertAsync(It.IsAny<DocumentacaoInscricao>()), Times.Once);
        _amazonS3ServiceMock.Verify(x => x.UploadArquivoAsync(It.IsAny<byte[]>(), It.IsAny<string>(), It.IsAny<Guid>(), CancellationToken.None), Times.Exactly(2));
        _amazonS3ServiceMock.Verify(x => x.RemoverArquivoAsync(It.IsAny<string>(), CancellationToken.None), Times.Once);
    }

    private CriarDocumentacaoInscricaoCandidatoCommandHandler ObterUseCase()
    {
        _inscricaoRepositoryMock
            .Setup(x => x.ObterInscriaoCandidatoIdAsync(It.IsAny<Guid>()))
            .ReturnsAsync(InscricaoConstants.InscricaoCorreta.Id);

        return new(
            _inscricaoRepositoryMock.Object,
            _inscricaoDocumentacaoRepositoryMock.Object,
            _notificationContextMock.Object,
            _unitOfWorkMock.Object,
            _amazonS3ServiceMock.Object,
            _loggerMock.Object);
    }
}