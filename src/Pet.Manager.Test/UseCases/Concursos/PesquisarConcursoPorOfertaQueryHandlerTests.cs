using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Application.DTOs.OfertaConcursos;
using Anima.Inscricao.Application.Interfaces.Repositories;
using Anima.Inscricao.Application.UseCases.Concursos.PesquisarConcursoPorOferta;
using Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoDestrancamentoReopcao;
using Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoEnem;
using Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoInscricaoAtiva;
using Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoReopcao;
using Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoSegundaGraduacao;
using Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraTransferencia;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Links;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.ModalidadesAvaliacao;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using MediatR;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Moq;

using static Anima.Inscricao.Application.DTOs.Concursos.ConcursosPorOfertaDto;

namespace Anima.Inscricao.Test.UseCases.Concursos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarConcursoPorOfertaQueryHandlerTests
{
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IConcursoRepository _concursoRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly IIntakeRepository _intakeRepository;
    private readonly IProdutoRepository _produtoRepository;
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly IMarcaRepository _marcaRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly ILinkRepository _linkRepository;
    private readonly ICursoRepository _cursoRepository;
    private readonly IModalidadeAvaliacaoRepository _modalidadeAvaliacaoRepository;
    private readonly Mock<ICandidatoRepository> _candidatoRepository = new();
    private readonly Mock<IMediator> _mediatorMock;
    private readonly Mock<ILogger<PesquisarConcursoPorOfertaQueryHandler>> _logger = new();

    public PesquisarConcursoPorOfertaQueryHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _mediatorMock = new Mock<IMediator>();
        _ofertaConcursoRepository = serviceProvider.GetRequiredService<IOfertaConcursoRepository>();
        _concursoRepository = serviceProvider.GetRequiredService<IConcursoRepository>();
        _formaEntradaRepository = serviceProvider.GetRequiredService<IFormaEntradaRepository>();
        _ofertaRepository = serviceProvider.GetRequiredService<IOfertaRepository>();
        _modalidadeRepository = serviceProvider.GetRequiredService<IModalidadeRepository>();
        _intakeRepository = serviceProvider.GetRequiredService<IIntakeRepository>();
        _produtoRepository = serviceProvider.GetRequiredService<IProdutoRepository>();
        _instituicaoRepository = serviceProvider.GetRequiredService<IInstituicaoRepository>();
        _marcaRepository = serviceProvider.GetRequiredService<IMarcaRepository>();
        _integracaoSistemaRepository = serviceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
        _modalidadeAvaliacaoRepository = serviceProvider.GetRequiredService<IModalidadeAvaliacaoRepository>();
        _linkRepository = serviceProvider.GetRequiredService<ILinkRepository>();
        _cursoRepository = serviceProvider.GetRequiredService<ICursoRepository>();
    }

    [Fact]
    public async Task DeveRetornarConcursosPorOfertaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();
        var query = new PesquisarConcursoPorOfertaQuery
        {
            OfertaKey = OfertaConstants.OfertaTeste2.Key,
        };

        var concursosFormasEntrada = ObterFormasEntradaConcurso(query.OfertaKey);

        _mediatorMock
            .Setup(m => m.Send(It.IsAny<ProcessarRegraConcursoTransferenciaCommand>(), default))
            .ReturnsAsync(concursosFormasEntrada);
        _mediatorMock
            .Setup(m => m.Send(It.IsAny<ProcessarRegraConcursoDestrancamentoRetornoCommand>(), default))
            .ReturnsAsync(concursosFormasEntrada);
        _mediatorMock
            .Setup(m => m.Send(It.IsAny<ProcessarRegraConcursoReopcaoCommand>(), default))
            .ReturnsAsync(concursosFormasEntrada);
        _mediatorMock
            .Setup(m => m.Send(It.IsAny<ProcessarRegraConcursoSegundaGraduacaoCommand>(), default))
            .ReturnsAsync(concursosFormasEntrada);
        _mediatorMock
           .Setup(m => m.Send(It.IsAny<ProcessarRegraConcursoEnemCommand>(), default))
           .ReturnsAsync(concursosFormasEntrada);
        _mediatorMock
          .Setup(m => m.Send(It.IsAny<ProcessarRegraConcursoInscricaoAtivaCommand>(), default))
          .ReturnsAsync(concursosFormasEntrada);

        // Act
        var resultado = await useCase.Handle(query, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Should().ContainEquivalentOf(new ConcursosPorOfertaDto
        {
            FormaEntradaKey = FormaEntradaConstants.FormaEntradaEnem.Key,
            NomeFormaEntrada = FormaEntradaConstants.FormaEntradaEnem.Nome,
            DescricaoFormaEntrada = FormaEntradaConstants.FormaEntradaEnem.Descricao,
            Concursos = new List<ConcursosFormaEntradaDto>
            {
                new ConcursosFormaEntradaDto
                {
                    DataInicioProva = null,
                    DataTerminoProva = null,
                    HoraInicioProva = null,
                    HoraTerminoProva = null,
                    NomeConcurso = ConcursoConstants.ConcursoEnem.Nome,
                    OfertaConcursoKey = OfertaConcursoConstants.Oferta2ConcursoEnem.Key,
                    Modalidade = ModalidadeConstants.ModalidadePresencial.Nome,
                },
            },
        });
    }

    private List<ConcursosPorOfertaDto> ObterFormasEntradaConcurso(Guid ofertaKey)
    {
        var dataAtual = DateTime.Now;

        var query = from ofertaConcurso in _ofertaConcursoRepository.GetQueryable().Include(x => x.OpcaoAcessos)
                    join concurso in _concursoRepository.GetQueryable()
                        on ofertaConcurso.ConcursoId equals concurso.Id
                    from concursoFormaEntrada in concurso.FormasEntrada
                    join formaEntrada in _formaEntradaRepository.GetQueryable()
                        on concursoFormaEntrada.FormaEntradaId equals formaEntrada.Id
                    join oferta in _ofertaRepository.GetQueryable()
                        on ofertaConcurso.OfertaId equals oferta.Id
                    from modalidade in _modalidadeRepository.GetQueryable()
                    where ofertaConcurso.OfertaId == oferta.Id &&
                    oferta.Key == ofertaKey &&
                    concurso.Modalidades.Any(x => x.ModalidadeId == modalidade.Id) &&
                    concurso.VigenciaInscricao.Inicio < dataAtual &&
                    concurso.VigenciaInscricao.Termino > dataAtual
                    select new
                    {
                        FormaEntradaKey = formaEntrada.Key,
                        NomeFormaEntrada = formaEntrada.Nome,
                        OfertaConcursoKey = ofertaConcurso.Key,
                        NomeConcurso = concurso.Nome,
                        InicioProva = concurso.InicioProva,
                        TerminoProva = concurso.TerminoProva,
                        Modalidade = modalidade.Nome,
                        DescricaoFormaEntrada = formaEntrada.Descricao,
                        OpcoesAcesso = ofertaConcurso.OpcaoAcessos,
                    };

        var queryGroup = query
            .GroupBy(x => new { x.FormaEntradaKey, x.NomeFormaEntrada, x.DescricaoFormaEntrada })
            .Select(x => new ConcursosPorOfertaDto()
            {
                FormaEntradaKey = x.Key.FormaEntradaKey,
                NomeFormaEntrada = x.Key.NomeFormaEntrada,
                DescricaoFormaEntrada = x.Key.DescricaoFormaEntrada,
                Concursos = x.Select(c => new ConcursosPorOfertaDto.ConcursosFormaEntradaDto()
                {
                    OfertaConcursoKey = c.OfertaConcursoKey,
                    NomeConcurso = c.NomeConcurso,
                    DataInicioProva = c.InicioProva,
                    HoraInicioProva = c.InicioProva.HasValue ? c.InicioProva.Value.ToString("HH\"h\"mm").Replace("h00", "h") : null,
                    DataTerminoProva = c.TerminoProva,
                    HoraTerminoProva = c.TerminoProva.HasValue ? c.TerminoProva.Value.ToString("HH\"h\"mm").Replace("h00", "h") : null,
                    Modalidade = c.Modalidade,
                    OpcaoAcessos = c.OpcoesAcesso.Any() ? c.OpcoesAcesso.Select(o => new OpcaoAcessoDto()
                    {
                        Key = o.Key,
                        Tipo = (int)o.TipoOpcaoAcesso,
                    }).ToList() : null,
                }).ToList(),
            });

        return queryGroup.ToList();
    }

    private PesquisarConcursoPorOfertaQueryHandler ObterUseCase()
    {
        _mediatorMock
            .Setup(m => m.Send(It.IsAny<ProcessarRegraConcursoTransferenciaCommand>(), default));

        return new PesquisarConcursoPorOfertaQueryHandler(
            _mediatorMock.Object,
            _ofertaConcursoRepository,
            _concursoRepository,
            _formaEntradaRepository,
            _ofertaRepository,
            _modalidadeRepository,
            _candidatoRepository.Object,
            _intakeRepository,
            _produtoRepository,
            _instituicaoRepository,
            _marcaRepository,
            _integracaoSistemaRepository,
            _modalidadeAvaliacaoRepository,
            _linkRepository,
            _cursoRepository,
            _logger.Object);
    }
}