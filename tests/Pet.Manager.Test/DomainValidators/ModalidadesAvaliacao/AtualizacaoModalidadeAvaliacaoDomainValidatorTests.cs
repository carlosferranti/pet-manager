using Anima.Inscricao.Domain.ModalidadesAvaliacao;
using Anima.Inscricao.Domain.ModalidadesAvaliacao.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.ModalidadesAvaliacao;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizacaoModalidadeAvaliacaoDomainValidatorTests
{
    private readonly IModalidadeAvaliacaoRepository _modalidadeAvaliacaoRepository;
    private readonly AtualizacaoModalidadeAvaliacaoDomainValidator _validator;

    public AtualizacaoModalidadeAvaliacaoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _modalidadeAvaliacaoRepository = databaseFixture.ServiceProvider.GetRequiredService<IModalidadeAvaliacaoRepository>();
        _validator = new(_modalidadeAvaliacaoRepository);
    }

    [Fact]
    public void DeveValidarNomesUnicos()
    {
        // Arrange
        var id = ModalidadeAvaliacaoConstants.Online.Id;
        string nome = ModalidadeAvaliacaoConstants.Presencial.Nome;

        // Act
        var resultado = _validator.Validate(id, nome);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeForMesmoRegistro()
    {
        // Arrange
        var id = ModalidadeAvaliacaoConstants.Presencial.Id;
        string nome = ModalidadeAvaliacaoConstants.Presencial.Nome;

        // Act
        var resultado = _validator.Validate(id, nome);

        // Assert
        resultado.Should().BeTrue();
    }
}