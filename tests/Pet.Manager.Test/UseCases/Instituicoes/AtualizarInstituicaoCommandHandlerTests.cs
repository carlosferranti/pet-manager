using Anima.Inscricao.Application.UseCases.Instituicoes.AtualizarInstituicao;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Instituicoes.Entities;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Instituicoes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarInstituicaoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IInstituicaoRepository> _instituicaoRepository = new();
    private readonly IMarcaRepository _marcaRepository;
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public AtualizarInstituicaoCommandHandlerTests()
    {
        var serviceProvider =  new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _marcaRepository = serviceProvider.GetRequiredService<IMarcaRepository>();
    }

    [Fact]
    public async Task DeveAtualizarInstituicaoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarInstituicaoCommand
        {
            Key = InstituicaoConstants.UnaLive.Key,
            Nome = "Faculdade de Educação Superior de Catalão",
            MarcaKey = MarcaConstants.UnaLive.Key
        }, default);

        // Assert
        _instituicaoRepository.Verify(x => x.Update(It.IsAny<Instituicao>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveAtualizarQuandoNomeJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarInstituicaoCommand
        {
            Key = InstituicaoConstants.UnaLive.Key,
            Nome = InstituicaoConstants.UnaLive.Nome,
            Sigla = InstituicaoConstants.UnaLive.Sigla,
            MarcaKey = MarcaConstants.Una.Key
        }, default);

        // Assert
        _instituicaoRepository.Verify(x => x.InsertAsync(It.IsAny<Instituicao>()), Times.Never);
    }

    private AtualizarInstituicaoCommandHandler ObterUseCase()
    {

        _instituicaoRepository.Setup(x => x.GetAsync(InstituicaoConstants.UnaLive.Key))
            .ReturnsAsync(InstituicaoConstants.UnaLive);

        return new(
            _notificationContext.Object, 
            _instituicaoRepository.Object,
            _marcaRepository,
            _unitOfWork.Object);
    }
}
