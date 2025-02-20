using Anima.Inscricao.Domain.Concursos.Entities;
using Anima.Inscricao.Domain.Cupons;
using Anima.Inscricao.Domain.Cupons.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Cupons;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovoCupomDomainValidatorTests
{
    private readonly ICupomRepository _cupomRepository;
    private readonly NovoCupomDomainValidator _validator;

    public NovoCupomDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _cupomRepository = databaseFixture.ServiceProvider.GetRequiredService<ICupomRepository>();
        _validator = new(_cupomRepository);
    }

    [Fact]
    public void DeveValidarCodigosUnicos()
    {
        // Arrange
        string codigo = CupomConstants.CupomPablo25.Codigo;
        ConcursoId concursoId = ConcursoConstants.ConcursoEnem.Id;

        // Act
        var resultado = _validator.Validate(codigo, concursoId);

        // Assert
        resultado.Should().BeFalse();
    }
}
