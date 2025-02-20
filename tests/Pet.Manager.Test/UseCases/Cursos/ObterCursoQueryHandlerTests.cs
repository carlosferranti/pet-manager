using Anima.Inscricao.Application.UseCases.Cursos.ObterCurso;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.TiposFormacao;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Cursos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class ObterCursoQueryHandlerTests
{
    private readonly ICursoRepository _cursoRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly INivelCursoRepository _nivelCursoRepository;
    private readonly IInstituicaoRepository _instituicaoRepository;

    public ObterCursoQueryHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _cursoRepository = serviceProvider.GetRequiredService<ICursoRepository>();
        _modalidadeRepository = serviceProvider.GetRequiredService<IModalidadeRepository>();
        _tipoFormacaoRepository = serviceProvider.GetRequiredService<ITipoFormacaoRepository>();
        _nivelCursoRepository = serviceProvider.GetRequiredService<INivelCursoRepository>();
        _instituicaoRepository = serviceProvider.GetRequiredService<IInstituicaoRepository>();
    }

    [Fact]
    public async Task DeveRetornarCursoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterCursoQuery
        {
            Key = CursoConstants.CursoAdministracao.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Key.Should().Be(CursoConstants.CursoAdministracao.Key);
        resultado.Nome.Should().Be(CursoConstants.CursoAdministracao.Nome);
        resultado.ModalidadeKey.Should().Be(ModalidadeConstants.ModalidadePresencial.Key);
        resultado.TipoFormacaoKey.Should().Be(TipoFormacaoConstants.TipoFormacaoGraduacao.Key);
        resultado.NivelFormacaoKey.Should().Be(NivelCursoConstants.Bacharelado.Key);
        resultado.InstituicaoKey.Should().Be(InstituicaoConstants.Una.Key);
    }

    private ObterCursoQueryHandler ObterUseCase()
    {
        return new(
            _cursoRepository, 
            _modalidadeRepository, 
            _tipoFormacaoRepository,
            _nivelCursoRepository,
            _instituicaoRepository);
    }
}
