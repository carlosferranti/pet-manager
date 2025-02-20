using Anima.Inscricao.Application.UseCases.Inscricoes.ObterInscricaoCandidato;
using Anima.Inscricao.Domain.Acessibilidades;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Cupons;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.CursosExternos;
using Anima.Inscricao.Domain.Deficiencias;
using Anima.Inscricao.Domain.Empresas;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Inscricoes;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.Matriculas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Domain.Turnos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;
using Anima.Inscricoes.Domain.Inscricoes;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Inscricoes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class ObterInscricaoCandidatoQueryHandlerTests
{
    private readonly IInscricaoRepository _inscricaoRepository;
    private readonly IMarcaRepository _marcaRepository;
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IProdutoRepository _produtoRepository;
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly IFichaRepository _fichaRepository;
    private readonly IConcursoRepository _concursoRepository;
    private readonly ITurnoRepository _turnoRepository;
    private readonly ICampusRepository _campusRepository;
    private readonly ICursoRepository _cursoRepository;
    private readonly IAcessibilidadeRepository _acessibilidadeRepository;
    private readonly IDeficienciaRepository _deficienciaRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;
    private readonly IIntakeRepository _intakeRepository;
    private readonly ICupomRepository _cupomRepository;
    private readonly IInscricaoDocumentacaoRepository _inscricaoDocumentacaoRepository;
    private readonly IEscolaRepository _escolaRepository;
    private readonly ICidadeRepository _cidadeRepository;
    private readonly IEstadoRepository _estadoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly INivelCursoRepository _nivelCursoRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly IMatriculaRepository _matriculaRepository;
    private readonly IEmpresaRepository _empresaRepository;
    private readonly ICursoExternoRepository _cursoExternoRepository;

    public ObterInscricaoCandidatoQueryHandlerTests(DatabaseFixture databaseFixture)
    {
        _inscricaoRepository = databaseFixture.ServiceProvider.GetRequiredService<IInscricaoRepository>();
        _marcaRepository = databaseFixture.ServiceProvider.GetRequiredService<IMarcaRepository>();
        _ofertaConcursoRepository = databaseFixture.ServiceProvider.GetRequiredService<IOfertaConcursoRepository>();
        _ofertaRepository = databaseFixture.ServiceProvider.GetRequiredService<IOfertaRepository>();
        _produtoRepository = databaseFixture.ServiceProvider.GetRequiredService<IProdutoRepository>();
        _instituicaoRepository = databaseFixture.ServiceProvider.GetRequiredService<IInstituicaoRepository>();
        _fichaRepository = databaseFixture.ServiceProvider.GetRequiredService<IFichaRepository>();
        _concursoRepository = databaseFixture.ServiceProvider.GetRequiredService<IConcursoRepository>();
        _turnoRepository = databaseFixture.ServiceProvider.GetRequiredService<ITurnoRepository>();
        _campusRepository = databaseFixture.ServiceProvider.GetRequiredService<ICampusRepository>();
        _cursoRepository = databaseFixture.ServiceProvider.GetRequiredService<ICursoRepository>();
        _acessibilidadeRepository = databaseFixture.ServiceProvider.GetRequiredService<IAcessibilidadeRepository>();
        _deficienciaRepository = databaseFixture.ServiceProvider.GetRequiredService<IDeficienciaRepository>();
        _formaEntradaRepository = databaseFixture.ServiceProvider.GetRequiredService<IFormaEntradaRepository>();
        _etapaTemplateRepository = databaseFixture.ServiceProvider.GetRequiredService<IEtapaTemplateRepository>();
        _intakeRepository = databaseFixture.ServiceProvider.GetRequiredService<IIntakeRepository>();
        _cupomRepository = databaseFixture.ServiceProvider.GetRequiredService<ICupomRepository>();
        _inscricaoDocumentacaoRepository = databaseFixture.ServiceProvider.GetRequiredService<IInscricaoDocumentacaoRepository>();
        _escolaRepository = databaseFixture.ServiceProvider.GetRequiredService<IEscolaRepository>();
        _cidadeRepository = databaseFixture.ServiceProvider.GetRequiredService<ICidadeRepository>();
        _estadoRepository = databaseFixture.ServiceProvider.GetRequiredService<IEstadoRepository>();
        _integracaoSistemaRepository = databaseFixture.ServiceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
        _nivelCursoRepository = databaseFixture.ServiceProvider.GetRequiredService<INivelCursoRepository>();
        _modalidadeRepository = databaseFixture.ServiceProvider.GetRequiredService<IModalidadeRepository>();
        _matriculaRepository = databaseFixture.ServiceProvider.GetRequiredService<IMatriculaRepository>();
        _empresaRepository = databaseFixture.ServiceProvider.GetRequiredService<IEmpresaRepository>();
        _cursoExternoRepository = databaseFixture.ServiceProvider.GetRequiredService<ICursoExternoRepository>();
    }

    [Fact]
    public async Task DeveRetornarDetalhesAtualizadosDaInscricaoCandidatoAsync()
    {
        // Arrange
        var query = new ObterInscricaoCanditadoQuery
        {
            Key = InscricaoConstants.InscricaoCorreta.Key
        };

        // Act
        var handler = ObterUseCase();
        var result = await handler.Handle(query, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
    }

    private ObterInscricaoCandidatoQueryHandler ObterUseCase()
    {
        return new(
            _inscricaoRepository,
            _marcaRepository,
            _ofertaConcursoRepository,
            _ofertaRepository,
            _produtoRepository,
            _instituicaoRepository,
            _fichaRepository,
            _concursoRepository,
            _turnoRepository,
            _campusRepository,
            _cursoRepository,
            _acessibilidadeRepository,
            _deficienciaRepository,
            _formaEntradaRepository,
            _etapaTemplateRepository,
            _intakeRepository,
            _cupomRepository,
            _inscricaoDocumentacaoRepository,
            _escolaRepository,
            _estadoRepository,
            _cidadeRepository,
            _integracaoSistemaRepository,
            _nivelCursoRepository,
            _modalidadeRepository,
            _matriculaRepository,
            _empresaRepository,
            _cursoExternoRepository);

    }
}
