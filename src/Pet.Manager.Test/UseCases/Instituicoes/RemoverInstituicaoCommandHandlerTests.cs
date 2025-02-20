using Anima.Inscricao.Application.UseCases.Instituicoes.RemoverInstituicao;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Instituicoes.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Instituicoes;

public class RemoverInstituicaoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IInstituicaoRepository> _instituicaoRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverInstituicaoCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverInstituicaoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverInstituicaoCommand()
        {
            Key = InstituicaoConstants.Una.Key,
        }, default);

        // Assert
        _instituicaoRepository.Verify(x => x.Delete(It.IsAny<Instituicao>()), Times.Once);
    }


    private RemoverInstituicaoCommandHandler ObterUseCase()
    {
        _instituicaoRepository
            .Setup(x => x.GetAsync(InstituicaoConstants.Una.Key))
            .ReturnsAsync(InstituicaoConstants.Una);

        return new(
                   _notificationContext.Object,
                   _instituicaoRepository.Object,
                   _unitOfWork.Object);
    }
}
