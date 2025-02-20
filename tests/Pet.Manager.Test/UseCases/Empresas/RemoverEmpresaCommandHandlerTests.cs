using Anima.Inscricao.Application.UseCases.Empresas.RemoverEmpresa;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Empresas;
using Anima.Inscricao.Domain.Empresas.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Empresas;

public class RemoverEmpresaCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IEmpresaRepository> _empresaRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverEmpresaCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverEmpresaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverEmpresaCommand()
        {
            Key = EmpresaConstants.Compass.Key,
        }, default);

        // Assert
        _empresaRepository.Verify(x => x.Delete(It.IsAny<Empresa>()), Times.Once);
    }

    private RemoverEmpresaCommandHandler ObterUseCase()
    {
        _empresaRepository
            .Setup(x => x.GetAsync(EmpresaConstants.Compass.Key))
            .ReturnsAsync(EmpresaConstants.Compass);

        return new(
                   _notificationContext.Object,
                   _empresaRepository.Object,
                   _unitOfWork.Object);
    }
}