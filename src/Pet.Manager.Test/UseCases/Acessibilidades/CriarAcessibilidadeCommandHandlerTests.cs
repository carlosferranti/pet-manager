using Anima.Inscricao.Application.UseCases.Acessibilidades.CriarAcessibilidade;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Acessibilidades;
using Anima.Inscricao.Domain.Acessibilidades.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Acessibilidades;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarAcessibilidadeCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IAcessibilidadeRepository> _acessibilidadeRepository = new();
    private readonly Mock<IIntegracaoSistemaRepository> _integracaoSistemaRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public CriarAcessibilidadeCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveInserirAcessibilidadeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarAcessibilidadeCommand
        {
            Nome = "Sala para lactantes",
        }, default);

        // Assert
        _acessibilidadeRepository.Verify(x => x.InsertAsync(It.IsAny<Acessibilidade>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    private CriarAcessibilidadeCommandHandler ObterUseCase()
    {
        return new CriarAcessibilidadeCommandHandler(
            _notificationContext.Object,
            _acessibilidadeRepository.Object,
            _integracaoSistemaRepository.Object,
            _unitOfWork.Object);
    }
}
