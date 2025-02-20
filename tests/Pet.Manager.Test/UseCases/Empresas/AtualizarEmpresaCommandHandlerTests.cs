using Anima.Inscricao.Application.UseCases.Empresas.AtualizarEmpresa;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Empresas;
using Anima.Inscricao.Domain.Empresas.Entities;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Empresas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarEmpresaCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IEmpresaRepository> _empresaRepositoryMock = new();
    private readonly Mock<ICidadeRepository> _cidadeRepositoryMock = new();
    private readonly Mock<IUnitOfWork> _unitOfWorkMock = new();

    public AtualizarEmpresaCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveAtualizarEmpresaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarEmpresaCommand
        {
            Key = EmpresaConstants.Compass.Key,
            Cnpj = EmpresaConstants.Compass.Cnpj,
            NomeFantasia = EmpresaConstants.Compass.NomeFantasia,
            RazaoSocial = "Compass atualizado"
        }, default);

        // Assert
        _empresaRepositoryMock.Verify(x => x.Update(It.IsAny<Empresa>()), Times.Once);
        _unitOfWorkMock.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveAtualizarQuandoCnpjJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarEmpresaCommand
        {
            Key = EmpresaConstants.Compass.Key,
            Cnpj = EmpresaConstants.Anima.Cnpj,
            NomeFantasia = EmpresaConstants.Compass.NomeFantasia,
            RazaoSocial = "Compass atualizado"
        }, default);

        // Assert
        _empresaRepositoryMock.Verify(x => x.Update(It.IsAny<Empresa>()), Times.Never);
    }

    private AtualizarEmpresaCommandHandler ObterUseCase()
    {
        _empresaRepositoryMock
            .Setup(x => x.GetAsync(EmpresaConstants.Compass.Key))
            .ReturnsAsync(EmpresaConstants.Compass);

        return new AtualizarEmpresaCommandHandler(
            _notificationContextMock.Object,
            _empresaRepositoryMock.Object,
            _cidadeRepositoryMock.Object,
            _unitOfWorkMock.Object);
    }
}