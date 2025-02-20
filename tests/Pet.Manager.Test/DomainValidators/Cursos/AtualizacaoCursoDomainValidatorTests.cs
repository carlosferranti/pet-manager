using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Cursos.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Cursos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizacaoCursoDomainValidatorTests
{
    private readonly ICursoRepository _cursoRepository;
    private readonly AtualizacaoCursoDomainValidator _validator;

    public AtualizacaoCursoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _cursoRepository = databaseFixture.ServiceProvider.GetRequiredService<ICursoRepository>();
        _validator = new(_cursoRepository);
    }

    [Fact]
    public void DeveValidarCursosUnicos()
    {
        // Arrange
        var cursoId = CursoConstants.CursoDireito.Id;
        var nome = CursoConstants.CursoAdministracao.Nome;
        var nomeComercial = CursoConstants.CursoAdministracao.NomeComercial;
        var modalidadeId = CursoConstants.CursoAdministracao.ModalidadeId;
        var tipoFormacaoId = CursoConstants.CursoAdministracao.TipoFormacaoId;
        var nivelCursoId = CursoConstants.CursoAdministracao.NivelCursoId;
        var instituicaoId = CursoConstants.CursoAdministracao.InstituicaoId;

        // Act
        var resultado = _validator.Validate(cursoId, nome, nomeComercial, modalidadeId, tipoFormacaoId, nivelCursoId, instituicaoId);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeForMesmoCurso()
    {
        // Arrange
        var cursoId = CursoConstants.CursoAdministracao.Id;
        var nome = CursoConstants.CursoAdministracao.Nome;
        var nomeComercial = CursoConstants.CursoAdministracao.NomeComercial;
        var modalidadeId = CursoConstants.CursoAdministracao.ModalidadeId;
        var tipoFormacaoId = CursoConstants.CursoAdministracao.TipoFormacaoId;
        var nivelCursoId = CursoConstants.CursoAdministracao.NivelCursoId;
        var instituicaoId = CursoConstants.CursoAdministracao.InstituicaoId;

        // Act
        var resultado = _validator.Validate(cursoId, nome, nomeComercial, modalidadeId, tipoFormacaoId, nivelCursoId, instituicaoId);

        // Assert
        resultado.Should().BeTrue();
    }
}