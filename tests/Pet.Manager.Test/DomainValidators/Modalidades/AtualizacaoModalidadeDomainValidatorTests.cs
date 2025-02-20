using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.Modalidades.Entities;
using Anima.Inscricao.Domain.Modalidades.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Modalidades;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizacaoModalidadeDomainValidatorTests
{
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly AtualizacaoModalidadeDomainValidator _validator;

    public AtualizacaoModalidadeDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _modalidadeRepository = databaseFixture.ServiceProvider.GetRequiredService<IModalidadeRepository>();
        _validator = new(_modalidadeRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        ModalidadeId modalidadeId = ModalidadeConstants.ModalidadeSemiPresencial.Id;
        string nome = ModalidadeConstants.ModalidadePresencial.Nome;

        // Act
        var resultado = _validator.Validate(modalidadeId, nome);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeONomeForIgual()
    {
        // Arrange
        ModalidadeId modalidadeId = ModalidadeConstants.ModalidadePresencial.Id;
        string nome = ModalidadeConstants.ModalidadePresencial.Nome;

        // Act
        var resultado = _validator.Validate(modalidadeId, nome);

        // Assert
        resultado.Should().BeTrue();
    }
}
