using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain.Inscricoes;
using Anima.Inscricao.Domain.Inscricoes.Enums;
using Anima.Inscricao.Domain.Inscricoes.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Inscricoes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovaDocumentacaoInscricaoDomainValidatorTests
{
    private readonly IInscricaoDocumentacaoRepository _inscricaoDocumentacaoRepository;
    private readonly NovaDocumentacaoInscricaoDomainValidator _validator;

    public NovaDocumentacaoInscricaoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _inscricaoDocumentacaoRepository = databaseFixture.ServiceProvider.GetRequiredService<IInscricaoDocumentacaoRepository>();
        _validator = new(_inscricaoDocumentacaoRepository);
    }

    [Fact]
    public void DeveValidarDocumentacaoUnicaNaInscricao()
    {
        // Arrange
        var inscricaoId = InscricaoConstants.InscricaoCorreta.Id;
        var tipo = TipoDocumentacaoInscricao.LaudoNecessidadesEspeciais;
        var tipoLocalArquivo = InscricaoDocumentacaoConstants.DocumentacaoLaudoNecessidadesEspeciais.Arquivo!.TipoLocalArquivo;
        var infoArquivo = InscricaoDocumentacaoConstants.DocumentacaoLaudoNecessidadesEspeciais.Arquivo!.Informacoes;
        var chaveArquivo = InscricaoDocumentacaoConstants.DocumentacaoLaudoNecessidadesEspeciais.Arquivo!.Chave;

        // Act
        var resultado = _validator.Validate(inscricaoId, tipo, new Arquivo(infoArquivo, tipoLocalArquivo, chaveArquivo));

        // Assert
        resultado.Should().BeFalse();
    }
}