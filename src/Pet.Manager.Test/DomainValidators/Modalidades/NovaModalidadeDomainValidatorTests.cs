using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.Modalidades.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Modalidades;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovaModalidadeDomainValidatorTests
{
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly NovaModalidadeDomainValidator _validator;

    public NovaModalidadeDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _modalidadeRepository = databaseFixture.ServiceProvider.GetRequiredService<IModalidadeRepository>();
        _validator = new(_modalidadeRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        string nome = ModalidadeConstants.ModalidadePresencial.Nome;

        // Act
        var resultado = _validator.Validate(nome);

        // Assert
        resultado.Should().BeFalse();
    }
}
