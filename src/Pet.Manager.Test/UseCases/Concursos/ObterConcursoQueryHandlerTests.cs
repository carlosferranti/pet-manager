using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Application.DTOs.FormasEntrada;
using Anima.Inscricao.Application.DTOs.Modalidades;
using Anima.Inscricao.Application.DTOs.TiposFormacao;
using Anima.Inscricao.Application.UseCases.Concursos.ObterConcurso;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.ModalidadesAvaliacao;
using Anima.Inscricao.Domain.TiposFormacao;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Concursos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class ObterConcursoQueryHandlerTests
{
    private readonly IConcursoRepository _concursoRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly IModalidadeAvaliacaoRepository _modalidadeAvaliacaoRepository;

    public ObterConcursoQueryHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _concursoRepository = serviceProvider.GetRequiredService<IConcursoRepository>();
        _formaEntradaRepository = serviceProvider.GetRequiredService<IFormaEntradaRepository>();
        _tipoFormacaoRepository = serviceProvider.GetRequiredService<ITipoFormacaoRepository>();
        _modalidadeRepository = serviceProvider.GetRequiredService<IModalidadeRepository>();
        _modalidadeAvaliacaoRepository = serviceProvider.GetRequiredService<IModalidadeAvaliacaoRepository>();
    }

    [Fact]
    public async Task DeveRetornarConcursoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterConcursoQuery
        {
            Key = ConcursoConstants.ConcursoEnem.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Should().BeEquivalentTo(new ConcursoDto()
        {
            Key = ConcursoConstants.ConcursoEnem.Key,
            Nome = ConcursoConstants.ConcursoEnem.Nome,
            InicioInscricao = ConcursoConstants.ConcursoEnem.VigenciaInscricao.Inicio,
            TerminoInscricao = ConcursoConstants.ConcursoEnem.VigenciaInscricao.Termino,
            InicioProva = ConcursoConstants.ConcursoEnem.InicioProva,
            TerminoProva = ConcursoConstants.ConcursoEnem.TerminoProva,
            PeriodoLetivo = ConcursoConstants.ConcursoEnem.PeriodoLetivo,
            FormasEntrada = new List<FormaEntradaDto>()
            {
                new FormaEntradaDto()
                {
                    Key = FormaEntradaConstants.FormaEntradaEnem.Key,
                    Nome = FormaEntradaConstants.FormaEntradaEnem.Nome,
                }
            },
            TipoFormacao = new TipoFormacaoDto()
            {
                Key = TipoFormacaoConstants.TipoFormacaoGraduacao.Key,
                Nome = TipoFormacaoConstants.TipoFormacaoGraduacao.Nome,
            },
            Modalidade = new ModalidadeDto()
            {
                Key = ModalidadeConstants.ModalidadePresencial.Key,
                Nome = ModalidadeConstants.ModalidadePresencial.Nome,
            },
            Parametros = null,
            DivulgacaoResultado = ConcursoConstants.ConcursoEnem.DivulgacaoResultado,
        });
       
    }

    private ObterConcursoQueryHandler ObterUseCase()
    {
        return new(
            _concursoRepository,
            _tipoFormacaoRepository,
            _formaEntradaRepository,
            _modalidadeRepository,
            _modalidadeAvaliacaoRepository);
    }
}