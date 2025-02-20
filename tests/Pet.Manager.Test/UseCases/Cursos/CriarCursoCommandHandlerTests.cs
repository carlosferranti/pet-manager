using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.UseCases.Cursos.CriarCurso;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Cursos.Entities;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.TiposFormacao;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Cursos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarCursoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();
    private readonly Mock<ICursoRepository> _cursoRepository = new();
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly INivelCursoRepository _nivelCursoRepository;
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public CriarCursoCommandHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _tipoFormacaoRepository = serviceProvider.GetRequiredService<ITipoFormacaoRepository>();
        _modalidadeRepository = serviceProvider.GetRequiredService<IModalidadeRepository>();
        _integracaoSistemaRepository = serviceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
        _nivelCursoRepository = serviceProvider.GetRequiredService<INivelCursoRepository>();
        _instituicaoRepository = serviceProvider.GetRequiredService<IInstituicaoRepository>();
    }

    [Fact]
    public async Task DeveInserirCursoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarCursoCommand
        {
            Nome = "Ciências Contábeis",
            ModalidadeKey = ModalidadeConstants.ModalidadePresencial.Key,
            TipoFormacaoKey = TipoFormacaoConstants.TipoFormacaoGraduacao.Key,
            NivelCursoKey = NivelCursoConstants.Bacharelado.Key,
            InstituicaoKey = InstituicaoConstants.Una.Key,
        }, default);

        // Assert
        _cursoRepository.Verify(x => x.InsertAsync(It.IsAny<Curso>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task DeveInserirCursoComNomeComcercialComSucesoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarCursoCommand
        {
            Nome = "Ciências Contábeis",
            NomeComercial = "Contabilidades Una",
            ModalidadeKey = ModalidadeConstants.ModalidadePresencial.Key,
            TipoFormacaoKey = TipoFormacaoConstants.TipoFormacaoGraduacao.Key,
            NivelCursoKey = NivelCursoConstants.Bacharelado.Key,
            InstituicaoKey = InstituicaoConstants.Una.Key,
        }, default);

        // Assert
        _cursoRepository.Verify(x => x.InsertAsync(It.IsAny<Curso>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);


    }

    [Fact]
    public async Task NaoDeveInserirCursoQuandoInformacoesJaExistemAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarCursoCommand
        {
            Nome = CursoConstants.CursoAdministracao.Nome,
            ModalidadeKey = ModalidadeConstants.ModalidadePresencial.Key,
            TipoFormacaoKey = TipoFormacaoConstants.TipoFormacaoGraduacao.Key,
            NivelCursoKey = NivelCursoConstants.Bacharelado.Key,
            InstituicaoKey = InstituicaoConstants.Una.Key,
        }, default);

        // Assert
        _cursoRepository.Verify(x => x.InsertAsync(It.IsAny<Curso>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    [Fact]
    public async Task DeveInserirCursoIntegracaoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();
        var command = new CriarCursoCommand
        {
            Nome = "Sistemas de Informação",
            ModalidadeKey = ModalidadeConstants.ModalidadePresencial.Key,
            TipoFormacaoKey = TipoFormacaoConstants.TipoFormacaoGraduacao.Key,
            NivelCursoKey = NivelCursoConstants.Bacharelado.Key,
            InstituicaoKey = InstituicaoConstants.Una.Key,
            Integracao = new SistemaIntegracaoDto()
            {
                CodigoOrigem = "123",
                NomeSistema = IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Nome,
            }
        };

        // Act
        await useCase.Handle(command, default);

        // Assert
        _cursoRepository.Verify(x => x.InsertAsync(It.Is<Curso>(x =>
            x.Nome == command.Nome &&
            x.IntegracaoCurso!.IntegracaoSistemaId == IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Id &&
            x.IntegracaoCurso!.CodigoOrigem == command.Integracao.CodigoOrigem)), Times.Once);

        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    private CriarCursoCommandHandler ObterUseCase()
    {
        return new(
             _notificationContext.Object,
             _cursoRepository.Object,
             _modalidadeRepository,
             _tipoFormacaoRepository,
             _nivelCursoRepository,
             _integracaoSistemaRepository,
             _instituicaoRepository,
             _unitOfWork.Object);
    }
}
