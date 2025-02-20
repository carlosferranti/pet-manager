using Anima.Inscricao.Application.UseCases.Cursos.AtualizarCurso;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Cursos.Entities;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.TiposFormacao;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Cursos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarCursoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();
    private readonly Mock<ICursoRepository> _cursoRepository = new();
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly INivelCursoRepository _nivelCursoRepository;
    private readonly IInstituicaoRepository _instituicaoRepository;

    public AtualizarCursoCommandHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _tipoFormacaoRepository = serviceProvider.GetRequiredService<ITipoFormacaoRepository>();
        _modalidadeRepository = serviceProvider.GetRequiredService<IModalidadeRepository>();
        _nivelCursoRepository = serviceProvider.GetRequiredService<INivelCursoRepository>();
        _instituicaoRepository = serviceProvider.GetRequiredService<IInstituicaoRepository>();
    }

    [Fact]
    public async Task DeveAtualizarCursoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarCursoCommand
        {
            Key = CursoConstants.CursoDireito.Key,
            ModalidadeKey = ModalidadeConstants.ModalidadePresencial.Key,
            TipoFormacaoKey = TipoFormacaoConstants.TipoFormacaoGraduacao.Key,
            NivelCursoKey = NivelCursoConstants.Bacharelado.Key,
            InstituicaoKey = InstituicaoConstants.Una.Key,
            Nome = "Direito atualizado",
        }, default);

        // Assert
        _cursoRepository.Verify(x => x.Update(It.IsAny<Curso>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveAtualizarQuandoNomeJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarCursoCommand
        {
            Key = CursoConstants.CursoDireito.Key,
            ModalidadeKey = ModalidadeConstants.ModalidadePresencial.Key,
            TipoFormacaoKey = TipoFormacaoConstants.TipoFormacaoGraduacao.Key,
            NivelCursoKey = NivelCursoConstants.Bacharelado.Key,
            InstituicaoKey = InstituicaoConstants.Una.Key,
            Nome = CursoConstants.CursoAdministracao.Nome,
        }, default);

        // Assert
        _cursoRepository.Verify(x => x.InsertAsync(It.IsAny<Curso>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    private AtualizarCursoCommandHandler ObterUseCase()
    {
        _cursoRepository
            .Setup(x => x.GetAsync(CursoConstants.CursoDireito.Key))
            .ReturnsAsync(CursoConstants.CursoDireito);

        return new(
            _notificationContext.Object,
            _cursoRepository.Object,
            _modalidadeRepository,
            _tipoFormacaoRepository,
            _nivelCursoRepository,
            _instituicaoRepository,
            _unitOfWork.Object);
    }
}
