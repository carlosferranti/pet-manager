using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.NiveisCurso.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.NiveisCurso;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovoNivelCursoDomainValidatorTests
{
    private readonly INivelCursoRepository _nivelCursoRepository;
    private readonly NovoNivelCursoDomainValidator _validator;

    public NovoNivelCursoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _nivelCursoRepository = databaseFixture.ServiceProvider.GetRequiredService<INivelCursoRepository>();
        _validator = new(_nivelCursoRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        string nome = NivelCursoConstants.Tecnico.Nome;

        // Act
        var resultado = _validator.Validate(nome);

        // Assert
        resultado.Should().BeFalse();
    }
}
