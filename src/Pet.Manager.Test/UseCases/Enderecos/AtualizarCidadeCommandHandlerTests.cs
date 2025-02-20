using Anima.Inscricao.Application.UseCases.Enderecos.AtualizarCidade;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Enderecos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarCidadeCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<ICidadeRepository> _cidadeRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();
    private readonly IEstadoRepository _estadoRepository;

    public AtualizarCidadeCommandHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _estadoRepository = serviceProvider.GetRequiredService<IEstadoRepository>();
    }

    [Fact]
    public async Task DeveAtualizarCidadeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarCidadeCommand
        {
            Key = EnderecoConstants.CidadeCampinas.Key,
            Nome = "Campinas",  
            EstadoKey = EnderecoConstants.EstadoSP.Key,
            CodigoMunicipio = 1234567,
        }, default);

        // Assert
        _cidadeRepository.Verify(x => x.Update(It.IsAny<Cidade>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveAtualizarQuandoInformacoesJaExistemAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarCidadeCommand
        {
            Key = EnderecoConstants.CidadeCampinas.Key,
            EstadoKey = EnderecoConstants.EstadoSP.Key,
            Nome = EnderecoConstants.CidadeSaoPaulo.Nome,
        }, default);

        // Assert
        _cidadeRepository.Verify(x => x.InsertAsync(It.IsAny<Cidade>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    private AtualizarCidadeCommandHandler ObterUseCase()
    {
        _cidadeRepository
            .Setup(x => x.GetAsync(EnderecoConstants.CidadeCampinas.Key))
            .ReturnsAsync(EnderecoConstants.CidadeCampinas);

        return new(
            _notificationContext.Object,
            _cidadeRepository.Object,
            _estadoRepository,
            _unitOfWork.Object);
    }
}