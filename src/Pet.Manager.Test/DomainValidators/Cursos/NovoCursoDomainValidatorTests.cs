using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Cursos.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Cursos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovoCursoDomainValidatorTests
{
    private readonly ICursoRepository _cursoRepository;
    private readonly NovoCursoDomainValidator _validator;

    public NovoCursoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _cursoRepository = databaseFixture.ServiceProvider.GetRequiredService<ICursoRepository>();
        _validator = new(_cursoRepository);
    }

    [Fact]
    public void DeveValidarCursosUnicos()
    {
        // Arrange
        var nome = CursoConstants.CursoAdministracao.Nome;
        var nomeComercial = CursoConstants.CursoAdministracao.NomeComercial;
        var modalidadeId = CursoConstants.CursoAdministracao.ModalidadeId;
        var tipoFormacaoId = CursoConstants.CursoAdministracao.TipoFormacaoId;
        var nivelCursoId = CursoConstants.CursoAdministracao.NivelCursoId;
        var instituicaoId = CursoConstants.CursoAdministracao.InstituicaoId;

        // Act
        var resultado = _validator.Validate(nome, nomeComercial, modalidadeId, tipoFormacaoId, nivelCursoId, instituicaoId);

        // Assert
        resultado.Should().BeFalse();
    }
}
