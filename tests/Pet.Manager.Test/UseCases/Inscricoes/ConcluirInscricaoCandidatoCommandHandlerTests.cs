using Anima.Inscricao.Application.UseCases.Inscricoes.ConcluirInscricaoCandidato;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Campos;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.CursosExternos;
using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Inscricoes.Entities;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Matriculas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Domain.Turnos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;
using Anima.Inscricoes.Domain.Inscricoes;

using FluentAssertions;

using MediatR;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Inscricoes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class ConcluirInscricaoCandidatoCommandHandlerTests
{
    private readonly INotificationContext _notificationContext;
    private readonly IInscricaoRepository _inscricaoRepository;
    private readonly IFichaRepository _fichaRepository;
    private readonly ICampoRepository _campoRepository;
    private readonly IMatriculaRepository _matriculaRepository;
    private readonly IConcursoRepository _concursoRepository;
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly IIntakeRepository _intakeRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly IEscolaRepository _escolaRepository;
    private readonly ICursoExternoRepository _cursoExternoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly ICursoRepository _cursoRepository;
    private readonly ITurnoRepository _turnoRepository;
    private readonly ICampusRepository _campusRepository;
    private readonly IProdutoRepository _produtoRepository;
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly Mock<IUnitOfWork> _unitOfWorkMock = new();
    private readonly Mock<IMediator> _mediatorMock = new();

    public ConcluirInscricaoCandidatoCommandHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
           .BuildServiceProvider(new ServiceCollection());

        _notificationContext = serviceProvider.GetRequiredService<INotificationContext>();
        _fichaRepository = serviceProvider.GetRequiredService<IFichaRepository>();
        _campoRepository = serviceProvider.GetRequiredService<ICampoRepository>();
        _inscricaoRepository = serviceProvider.GetRequiredService<IInscricaoRepository>();
        _turnoRepository = serviceProvider.GetRequiredService<ITurnoRepository>();
        _cursoRepository = serviceProvider.GetRequiredService<ICursoRepository>();
        _campusRepository = serviceProvider.GetRequiredService<ICampusRepository>();
        _instituicaoRepository = serviceProvider.GetRequiredService<IInstituicaoRepository>();
        _produtoRepository = serviceProvider.GetRequiredService<IProdutoRepository>();
        _integracaoSistemaRepository = serviceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
        _cursoExternoRepository = serviceProvider.GetRequiredService<ICursoExternoRepository>();
        _escolaRepository = serviceProvider.GetRequiredService<IEscolaRepository>();
        _formaEntradaRepository = serviceProvider.GetRequiredService<IFormaEntradaRepository>();
        _intakeRepository = serviceProvider.GetRequiredService<IIntakeRepository>();
        _modalidadeRepository = serviceProvider.GetRequiredService<IModalidadeRepository>();
        _ofertaRepository = serviceProvider.GetRequiredService<IOfertaRepository>();
        _ofertaConcursoRepository = serviceProvider.GetRequiredService<IOfertaConcursoRepository>();
        _concursoRepository = serviceProvider.GetRequiredService<IConcursoRepository>();
        _matriculaRepository = serviceProvider.GetRequiredService<IMatriculaRepository>();
    }

    [Fact]
    public async Task DeveConcluirInscricaoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new ConcluirInscricaoCandidatoCommand
        {
            Key = InscricaoConstants.InscricaoCorreta.Key,
        }, default);

        // Assert
        _unitOfWorkMock.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task DeveNaoConcluirInscricaoIndicandoErrosAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new ConcluirInscricaoCandidatoCommand
        {
            Key = InscricaoConstants.InscricaoIncompleta.Key,
        }, default);

        // Assert
        _unitOfWorkMock.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
        _notificationContext.HasNotifications.Should().BeTrue();
    }


    private ConcluirInscricaoCandidatoCommandHandler ObterUseCase()
    {
        return new(
            _notificationContext,
            _inscricaoRepository,
            _fichaRepository,
            _campoRepository,
            _unitOfWorkMock.Object,
            _mediatorMock.Object,
            _matriculaRepository,
            _concursoRepository,
            _ofertaConcursoRepository,
            _ofertaRepository,
            _modalidadeRepository,
            _intakeRepository,
            _formaEntradaRepository,
            _escolaRepository,
            _cursoExternoRepository,
            _integracaoSistemaRepository,
            _cursoRepository,
            _turnoRepository,
            _campusRepository,
            _produtoRepository,
            _instituicaoRepository);
    }
}