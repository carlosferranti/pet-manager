using Anima.Inscricao.Application.Enums;
using Anima.Inscricao.Application.UseCases.Cupons.AtualizarCupom;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Cupons;
using Anima.Inscricao.Domain.Cupons.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Cupons;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarCupomCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<ICupomRepository> _cupomRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();
    private readonly IConcursoRepository _concursoRepository;

    public AtualizarCupomCommandHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _concursoRepository = serviceProvider.GetRequiredService<IConcursoRepository>();
    }

    [Fact]
    public async Task DeveAtualizarCupomComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarCupomCommand
        {
            Key = CupomConstants.CupomPablo50.Key,
            Codigo = "PABLO50",
            Descricao = "Cupom de desconto de R$50,00",
            ValorDesconto = 50,
            TipoDesconto = (int)TipoDesconto.Valor,
            DataValidade = DateTime.Now.AddDays(30),
            ConcursoKey = ConcursoConstants.ConcursoVestibular.Key,
        }, default);

        // Assert
        _cupomRepository.Verify(x => x.Update(It.IsAny<Cupom>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(default), Times.Once);
    }

    [Fact]
    public async Task NaoDeveAtualizarQuandoInformacoesJaExistemAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarCupomCommand
        {
            Key = CupomConstants.CupomPablo50.Key,
            Codigo = CupomConstants.CupomPablo25.Codigo,
            Descricao = "Cupom de desconto de R$100,00",
            ValorDesconto = 100,
            TipoDesconto = (int)TipoDesconto.Valor,
            DataValidade = DateTime.Now.AddDays(30),
            ConcursoKey = ConcursoConstants.ConcursoEnem.Key,
        }, default);

        // Assert
        _cupomRepository.Verify(x => x.Update(It.IsAny<Cupom>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(default), Times.Never);
    }

    private AtualizarCupomCommandHandler ObterUseCase()
    {
        _cupomRepository.Setup(x => x.GetAsync(CupomConstants.CupomPablo50.Key))
            .ReturnsAsync(CupomConstants.CupomPablo50);

        return new AtualizarCupomCommandHandler(
            _notificationContext.Object,
            _concursoRepository,
            _cupomRepository.Object,
            _unitOfWork.Object);
    }
}
