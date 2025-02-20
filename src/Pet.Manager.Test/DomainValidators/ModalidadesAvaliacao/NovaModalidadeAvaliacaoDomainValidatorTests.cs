using Anima.Inscricao.Domain.ModalidadesAvaliacao;
using Anima.Inscricao.Domain.ModalidadesAvaliacao.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.ModalidadesAvaliacao;


[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovaModalidadeAvaliacaoDomainValidatorTests
{
    private readonly IModalidadeAvaliacaoRepository _modalidadeAvaliacaoRepository;
    private readonly NovaModalidadeAvaliacaoDomainValidator _validator;

    public NovaModalidadeAvaliacaoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _modalidadeAvaliacaoRepository = databaseFixture.ServiceProvider.GetRequiredService<IModalidadeAvaliacaoRepository>();
        _validator = new(_modalidadeAvaliacaoRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        string nome = ModalidadeAvaliacaoConstants.Presencial.Nome;

        // Act
        var resultado = _validator.Validate(nome);

        // Assert
        resultado.Should().BeFalse();
    }
}