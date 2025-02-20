using Anima.Inscricao.Domain.Matriculas;
using Anima.Inscricao.Domain.Matriculas.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Matriculas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovaMatriculaDomainValidatorTests
{
    private readonly IMatriculaRepository _matriculaRepository;
    private readonly NovaMatriculaDomainValidator _validator;

    public NovaMatriculaDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _matriculaRepository = databaseFixture.ServiceProvider.GetRequiredService<IMatriculaRepository>();
        _validator = new(_matriculaRepository);
    }

    [Fact]
    public void DeveValidarMatriculasUnicas()
    {
        // Arrange
        var codigo = MatriculaConstants.MatriculaTrancada.CodigoAluno;
        var ra = MatriculaConstants.MatriculaTrancada.Ra;
        var status = MatriculaConstants.MatriculaTrancada.StatusMatricula;

        // Act
        var resultado = _validator.Validate(codigo, ra, status);

        // Assert
        resultado.Should().BeFalse();
    }
}