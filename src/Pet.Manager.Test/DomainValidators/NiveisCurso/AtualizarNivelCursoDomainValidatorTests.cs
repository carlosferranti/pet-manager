using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.NiveisCurso.Entities;
using Anima.Inscricao.Domain.NiveisCurso.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.NiveisCurso;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarNivelCursoDomainValidatorTests
{
    private readonly INivelCursoRepository _nivelCursoRepository;
    private readonly AtualizarNivelCursoDomainValidator _validator;

    public AtualizarNivelCursoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _nivelCursoRepository = databaseFixture.ServiceProvider.GetRequiredService<INivelCursoRepository>();
        _validator = new(_nivelCursoRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        NivelCursoId nivelCursoId = NivelCursoConstants.Bacharelado.Id;
        string nome = NivelCursoConstants.Tecnico.Nome;

        // Act
        var resultado = _validator.Validate(nivelCursoId, nome);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeONomeForIgual()
    {
        // Arrange
        NivelCursoId nivelCursoId = NivelCursoConstants.Bacharelado.Id;
        string nome = NivelCursoConstants.Bacharelado.Nome;

        // Act
        var resultado = _validator.Validate(nivelCursoId, nome);

        // Assert
        resultado.Should().BeTrue();
    }
}
