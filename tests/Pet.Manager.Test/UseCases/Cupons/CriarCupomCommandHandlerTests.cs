using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.Enums;
using Anima.Inscricao.Application.UseCases.Cupons.CriarCupom;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Cupons;
using Anima.Inscricao.Domain.Cupons.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Cupons;


[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarCupomCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<ICupomRepository> _cupomRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly IConcursoRepository _concursoRepository;

    public CriarCupomCommandHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _integracaoSistemaRepository = serviceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
        _concursoRepository = serviceProvider.GetRequiredService<IConcursoRepository>();
    }

    [Fact]
    public async Task DeveInserirCupomComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarCupomCommand
        {
            ConcursoKey = ConcursoConstants.ConcursoEnem.Key,
            Codigo = "ERLON100",
            Descricao = "Cupom de desconto de 100%",
            ValorDesconto = 100,
            TipoDesconto = (int)TipoDesconto.Porcentagem,
            DataValidade = DateTime.Now.AddYears(5),
        }, default);

        // Assert
        _cupomRepository.Verify(x => x.InsertAsync(It.IsAny<Cupom>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveInserirQuandoInformacoesJaExistemAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarCupomCommand
        {
            ConcursoKey = ConcursoConstants.ConcursoVestibular.Key,
            Codigo = CupomConstants.CupomPablo50.Codigo,
            Descricao = "Cupom de desconto de 50%",
            ValorDesconto = 50,
            TipoDesconto = (int)TipoDesconto.Porcentagem,
            DataValidade = DateTime.Now.AddYears(5),
        }, default);

        // Assert
        _cupomRepository.Verify(x => x.InsertAsync(It.IsAny<Cupom>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    [Fact]
    public async Task DeveInserirCupomComIntegracaoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();
        var command = new CriarCupomCommand
        {
            ConcursoKey = ConcursoConstants.ConcursoEnem.Key,
            Codigo = "ERLON100",
            Descricao = "Cupom de desconto de 100%",
            ValorDesconto = 100,
            TipoDesconto = (int)TipoDesconto.Porcentagem,
            DataValidade = DateTime.Now.AddYears(5),
            Integracao = new SistemaIntegracaoDto
            {
                CodigoOrigem = "123",
                NomeSistema = IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Nome,
            },
        };

        // Act
        await useCase.Handle(command, default);

        // Assert
        _cupomRepository.Verify(x => x.InsertAsync(It.Is<Cupom>(x =>
            x.Codigo == command.Codigo &&
            x.IntegracaoCupom!.IntegracaoSistemaId == IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Id &&
            x.IntegracaoCupom!.CodigoOrigem == command.Integracao.CodigoOrigem)), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    private CriarCupomCommandHandler ObterUseCase()
    {
        return new CriarCupomCommandHandler(
            _cupomRepository.Object,
            _concursoRepository,
            _notificationContext.Object,
            _integracaoSistemaRepository,
            _unitOfWork.Object);
    }
}
