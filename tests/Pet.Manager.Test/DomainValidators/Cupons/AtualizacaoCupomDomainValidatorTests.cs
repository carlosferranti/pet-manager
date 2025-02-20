using Anima.Inscricao.Domain.Concursos.Entities;
using Anima.Inscricao.Domain.Cupons;
using Anima.Inscricao.Domain.Cupons.Entities;
using Anima.Inscricao.Domain.Cupons.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Cupons;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizacaoCupomDomainValidatorTests
{
    private readonly ICupomRepository _cupomRepository;
    private readonly AtualizacaoCupomDomainValidator _validator;

    public AtualizacaoCupomDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _cupomRepository = databaseFixture.ServiceProvider.GetRequiredService<ICupomRepository>();
        _validator = new(_cupomRepository);
    }

    [Fact]
    public void DeveValidarCodigosUnicos()
    {
        // Arrange
        CupomId cupomId = CupomConstants.CupomPablo100.Id;
        ConcursoId concursoId = ConcursoConstants.ConcursoVestibular.Id;
        string codigo = CupomConstants.CupomPablo50.Codigo;

        // Act
        var resultado = _validator.Validate(cupomId, concursoId, codigo);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeOCodigoForIgual()
    {
        // Arrange
        CupomId cupomId = CupomConstants.CupomPablo100.Id;
        ConcursoId concursoId = ConcursoConstants.ConcursoEnem.Id;
        string codigo = CupomConstants.CupomPablo100.Codigo;

        // Act
        var resultado = _validator.Validate(cupomId, concursoId, codigo);

        // Assert
        resultado.Should().BeTrue();
    }
}
