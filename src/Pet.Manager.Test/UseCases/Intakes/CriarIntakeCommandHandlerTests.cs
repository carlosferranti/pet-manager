using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.UseCases.Intakes.CriarIntake;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.Intakes.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Intakes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarIntakeCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IIntakeRepository> _intakeRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public CriarIntakeCommandHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _integracaoSistemaRepository = serviceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
    }

    [Fact]
    public async Task DeveInserirIntakeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarIntakeCommand
        {
            Nome = "Intake Graduação",
            VigenciaInicio = DateTime.Now,
            VigenciaTermino = DateTime.Now.AddMonths(6),
        }, default);

        // Assert
        _intakeRepository.Verify(x => x.InsertAsync(It.IsAny<Intake>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveInserirQuandoInformacoesJaExistemAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarIntakeCommand
        {
            Nome = IntakeConstants.IntakeSegundoSemestre.Nome,
            VigenciaTermino = IntakeConstants.IntakeSegundoSemestre.Vigencia.Termino,
            VigenciaInicio = IntakeConstants.IntakeSegundoSemestre.Vigencia.Inicio,
        }, default);

        // Assert
        _intakeRepository.Verify(x => x.InsertAsync(It.IsAny<Intake>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    [Fact]
    public async Task DeveInserirIntakentegracaoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();
        var command = new CriarIntakeCommand
        {
            Nome = "Intake Pós-Graduação",
            VigenciaInicio = DateTime.Now,
            VigenciaTermino = DateTime.Now.AddMonths(6),
            Integracao = new SistemaIntegracaoDto()
            {
                CodigoOrigem = "123",
                NomeSistema = IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Nome,
            }
        };

        // Act
        await useCase.Handle(command, default);

        // Assert
        _intakeRepository.Verify(x => x.InsertAsync(It.Is<Intake>(x =>
            x.Nome == command.Nome &&
            x.IntegracaoIntake!.IntegracaoSistemaId == IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Id &&
            x.IntegracaoIntake!.CodigoOrigem == command.Integracao.CodigoOrigem)), Times.Once);

        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    private CriarIntakeCommandHandler ObterUseCase()
    {
        return new(
            _notificationContext.Object,
            _intakeRepository.Object,
            _integracaoSistemaRepository,
            _unitOfWork.Object);
    }
}
