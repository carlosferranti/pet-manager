using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Campos;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Domain.Fichas.Rules;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainSpecifications.Fichas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriteriosSeguroFiancaInscricaoSpecificationTests
{
    private readonly ICampoRepository _campoRepository;
    private readonly List<InfoValidation> _validations = new();

    public CriteriosSeguroFiancaInscricaoSpecificationTests(DatabaseFixture databaseFixture)
    {
        _campoRepository = databaseFixture.ServiceProvider.GetRequiredService<ICampoRepository>();
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task DeveRetornarValidacaoDeFiadorDependendoDaObrigatoriedadeAsync(bool obrigatorio)
    {
        // Arrange
        var specification = await ObterSpecification(obrigatorio);

        // Act
        var resultado = specification.IsSatisfiedBy(InscricaoConstants.InscricaoVazia.SeguroFianca);

        // Assert
        resultado.Should().Be(!obrigatorio);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task DeveRetornarValidacaoDeNomeFiadorDependendoDaObrigatoriedadeAsync(bool obrigatorio)
    {
        // Arrange
        var specification = await ObterSpecification(obrigatorio);
        var inscricao = InscricaoConstants.InscricaoVazia;
        inscricao.DefinirSeguroFianca(null, null, 0, 0, 0, null, 0, null);
        // Act
        var resultado = specification.IsSatisfiedBy(inscricao.SeguroFianca);

        // Assert
        resultado.Should().Be(!obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.NomeFiador.Nome).Should().Be(obrigatorio);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task DeveRetornarValidacaoDeRelacionamentoFiadorDependendoDaObrigatoriedadeAsync(bool obrigatorio)
    {
        // Arrange
        var specification = await ObterSpecification(obrigatorio);
        var inscricao = InscricaoConstants.InscricaoVazia;
        inscricao.DefinirSeguroFianca(null, null, 0, 0, 0, null, 0, null);
        // Act
        var resultado = specification.IsSatisfiedBy(inscricao.SeguroFianca);

        // Assert
        resultado.Should().Be(!obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.RelacionamentoFiador.Nome).Should().Be(obrigatorio);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task DeveRetornarValidacaoDePercentualFiadorDependendoDaObrigatoriedadeAsync(bool obrigatorio)
    {
        // Arrange
        var specification = await ObterSpecification(obrigatorio);
        var inscricao = InscricaoConstants.InscricaoVazia;
        inscricao.DefinirSeguroFianca(null, null, 0, 0, 0, null, 0, null);
        // Act
        var resultado = specification.IsSatisfiedBy(inscricao.SeguroFianca);

        // Assert
        resultado.Should().Be(!obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.PercentualFiador.Nome).Should().Be(obrigatorio);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task DeveRetornarValidacaoDeRendaMediaFiadorDependendoDaObrigatoriedadeAsync(bool obrigatorio)
    {
        // Arrange
        var specification = await ObterSpecification(obrigatorio);
        var inscricao = InscricaoConstants.InscricaoVazia;
        inscricao.DefinirSeguroFianca(null, null, 0, 0, 0, null, 0, null);
        // Act
        var resultado = specification.IsSatisfiedBy(inscricao.SeguroFianca);

        // Assert
        resultado.Should().Be(!obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.RendaMediaMensalFiador.Nome).Should().Be(obrigatorio);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task DeveRetornarValidacaoDeDocumentoFiadorDependendoDaObrigatoriedadeAsync(bool obrigatorio)
    {
        // Arrange
        var specification = await ObterSpecification(obrigatorio);
        var inscricao = InscricaoConstants.InscricaoVazia;
        inscricao.DefinirSeguroFianca(null, null, 0, 0, 0, null, 0, null);
        // Act
        var resultado = specification.IsSatisfiedBy(inscricao.SeguroFianca);

        // Assert
        resultado.Should().Be(!obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.DocumentoFiador.Nome).Should().Be(obrigatorio);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task DeveRetornarValidacaoDeContatoFiadorDependendoDaObrigatoriedadeAsync(bool obrigatorio)
    {
        // Arrange
        var specification = await ObterSpecification(obrigatorio);
        var inscricao = InscricaoConstants.InscricaoVazia;
        inscricao.DefinirSeguroFianca(null, null, 0, 0, 0, null, 0, null);
        // Act
        var resultado = specification.IsSatisfiedBy(inscricao.SeguroFianca);

        // Assert
        resultado.Should().Be(!obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.ContatoFiador.Nome).Should().Be(obrigatorio);
    }

    private async Task<CriteriosSeguroFiancaInscricaoSpecification> ObterSpecification(bool obrigatorioFicha = true)
    {
        var campos = await _campoRepository.GetListAsync();

        return new(
            _validations,
            campos.Select(cf => new CampoFicha(cf.Id, obrigatorioFicha, false)).ToList(),
            campos.ToList());
    }
}