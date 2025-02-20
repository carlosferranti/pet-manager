using Anima.Inscricao.Application.UseCases.Acessibilidades.RemoverAcessibilidade;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Acessibilidades;
using Anima.Inscricao.Domain.Acessibilidades.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Acessibilidades;

public class RemoverAcessibilidadeCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IAcessibilidadeRepository> _acessibilidadeRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverAcessibilidadeCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverAcessibilidadeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverAcessibilidadeCommand()
        {
            Key = AcessibilidadeConstants.InterpreterDeLibras.Key,
        }, default);

        // Assert
        _acessibilidadeRepository.Verify(x => x.Delete(It.IsAny<Acessibilidade>()), Times.Once);
    }

    private RemoverAcessibilidadeCommandHandler ObterUseCase()
    {
        _acessibilidadeRepository
            .Setup(x => x.GetAsync(AcessibilidadeConstants.InterpreterDeLibras.Key))
            .ReturnsAsync(AcessibilidadeConstants.InterpreterDeLibras);

        return new(_unitOfWork.Object,
                   _notificationContext.Object,
                   _acessibilidadeRepository.Object);
    }
}
