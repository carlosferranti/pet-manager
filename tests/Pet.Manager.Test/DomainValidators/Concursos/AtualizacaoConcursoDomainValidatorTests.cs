using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Concursos.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Concursos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizacaoConcursoDomainValidatorTests
{
    private readonly IConcursoRepository _concursoRepository;
    private readonly AtualizacaoConcursoDomainValidator _validator;

    public AtualizacaoConcursoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _concursoRepository = databaseFixture.ServiceProvider.GetRequiredService<IConcursoRepository>();
        _validator = new(_concursoRepository);
    }

    [Fact]
    public void DevePermitirAtualizarSeForMesmoConcurso()
    {
        // Arrange
        var concursoId = ConcursoConstants.ConcursoVestibular.Id;
        var nome = ConcursoConstants.ConcursoVestibular.Nome;
        var periodoLetivo = ConcursoConstants.ConcursoVestibular.PeriodoLetivo;

        // Act
        var resultado = _validator.Validate(concursoId, nome, periodoLetivo);

        // Assert
        resultado.Should().BeTrue();
    }
}
