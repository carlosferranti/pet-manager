using Anima.Inscricao.Application.Interfaces.Services;
using Anima.Inscricao.Application.UseCases.Inscricoes.RemoverDocumentacaoInscricaoCandidato;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain.Inscricoes;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Inscricoes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverDocumentacaoInscricaoCandidatoCommandHandlerTests
{
    private readonly IInscricaoDocumentacaoRepository _inscricaoDocumentacaoRepository;
    private readonly Mock<IUnitOfWork> _unitOfWorkMock = new();
    private readonly Mock<IAmazonS3Service> _amazonS3ServiceMock = new();

    public RemoverDocumentacaoInscricaoCandidatoCommandHandlerTests(DatabaseFixture databaseFixture)
    {
        _inscricaoDocumentacaoRepository = databaseFixture.ServiceProvider
            .GetRequiredService<IInscricaoDocumentacaoRepository>();

    }

    [Fact]
    public async Task DeveRemoverDocumentacaoComSucessoAsync()
    {
        // Arrange
        var command = new RemoverDocumentacaoInscricaoCandidatoCommand()
        {
            InscricaoDocumentacaoKey = InscricaoDocumentacaoConstants.DocumentacaoLaudoNecessidadesEspeciais.Key,
        };

        // Act
        var useCase = ObterUseCase();
        await useCase.Handle(command, default);

        // Assert
        _unitOfWorkMock.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
        _amazonS3ServiceMock.Verify(x => x.RemoverArquivoAsync(It.IsAny<string>(), CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task DeveRemoverDocumentacaoEquivalentoNoSmartShareComSucessoAsync()
    {
        // Arrange
        var command = new RemoverDocumentacaoInscricaoCandidatoCommand()
        {
            InscricaoDocumentacaoKey = InscricaoDocumentacaoConstants.DocumentacaoHistoricoEscolarS3.Key,
        };

        // Act
        var useCase = ObterUseCase();
        await useCase.Handle(command, default);

        // Assert
        _unitOfWorkMock.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
        _amazonS3ServiceMock.Verify(x => x.RemoverArquivoAsync(It.IsAny<string>(), CancellationToken.None), Times.Never);
    }

    private RemoverDocumentacaoInscricaoCandidatoCommandHandler ObterUseCase()
    {
        return new(
            _inscricaoDocumentacaoRepository,
            _unitOfWorkMock.Object,
            _amazonS3ServiceMock.Object);
    }
}