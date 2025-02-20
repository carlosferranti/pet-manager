using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Concursos.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Concursos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovoConcursoDomainValidatorTests
{
    private readonly IConcursoRepository _concursoRepository;
    private readonly NovoConcursoDomainValidator _validator;

    public NovoConcursoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _concursoRepository = databaseFixture.ServiceProvider.GetRequiredService<IConcursoRepository>();
        _validator = new(_concursoRepository);
    }

    [Fact]
    public void DeveSemprePermitirCadastrarConcursos()
    {
        // Arrange
        var nome = ConcursoConstants.ConcursoEnem.Nome;
        var periodoLetivo = ConcursoConstants.ConcursoEnem.PeriodoLetivo;

        // Act
        var resultado = _validator.Validate(nome, periodoLetivo);

        // Assert
        resultado.Should().BeTrue();
    }
}