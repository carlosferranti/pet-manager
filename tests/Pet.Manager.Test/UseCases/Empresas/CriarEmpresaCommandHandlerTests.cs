using Anima.Inscricao.Application.UseCases.Empresas.CriarEmpresa;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Empresas;
using Anima.Inscricao.Domain.Empresas.Entities;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using Microsoft.Extensions.DependencyInjection;

using Moq;

using static Anima.Inscricao.Application.UseCases.Empresas.CriarEmpresa.CriarEmpresaCommand;

namespace Anima.Inscricao.Test.UseCases.Empresas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarEmpresaCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IEmpresaRepository> _empresaRepositoryMock = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    private readonly ICidadeRepository _cidadeRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public CriarEmpresaCommandHandlerTests(DatabaseFixture databaseFixture)
    {
        _cidadeRepository = databaseFixture.ServiceProvider.GetRequiredService<ICidadeRepository>();
        _integracaoSistemaRepository = databaseFixture.ServiceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
    }

    [Fact]
    public async Task DeveInserirEmpresaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarEmpresaCommand
        {
            RazaoSocial = "Empresa Teste",
            NomeFantasia = "Empresa Teste",
            Cnpj = "12345678901234",
            Enderecos = new List<CriarEnderecoEmpresaCommand>
            {
                new CriarEnderecoEmpresaCommand
                {
                    Cep = "12345678",
                    Logradouro = "Rua Teste",
                    Numero = "123",
                    Bairro = "Bairro Teste",
                    CidadeKey = EnderecoConstants.CidadeCampinas.Key
                },
            },
        }, default);

        // Assert
        _empresaRepositoryMock.Verify(x => x.InsertAsync(It.IsAny<Empresa>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveInserirQuandoCnpjJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarEmpresaCommand
        {
            RazaoSocial = "Empresa Teste",
            NomeFantasia = "Empresa Teste",
            Cnpj = EmpresaConstants.Anima.Cnpj,
            Enderecos = new List<CriarEnderecoEmpresaCommand>
            {
                new CriarEnderecoEmpresaCommand
                {
                    Cep = "12345678",
                    Logradouro = "Rua Teste",
                    Numero = "123",
                    Bairro = "Bairro Teste",
                    CidadeKey = EnderecoConstants.CidadeCampinas.Key
                },
            },
        }, default);

        // Assert
        _empresaRepositoryMock.Verify(x => x.InsertAsync(It.IsAny<Empresa>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    private CriarEmpresaCommandHandler ObterUseCase()
    {
        return new CriarEmpresaCommandHandler(
            _notificationContext.Object,
            _empresaRepositoryMock.Object,
            _cidadeRepository,
            _integracaoSistemaRepository,
            _unitOfWork.Object);
    }
}
