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
public class CriteriosEnderecoInscricaoSpecificationTests
{
    private readonly ICampoRepository _campoRepository;
    private readonly List<InfoValidation> _validations = new();

    public CriteriosEnderecoInscricaoSpecificationTests(DatabaseFixture databaseFixture)
    {
        _campoRepository = databaseFixture.ServiceProvider.GetRequiredService<ICampoRepository>();
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task DeveRetornarValidacaoDeRuaDependendoDaObrigatoriedadeAsync(bool obrigatorio)
    {
        // Arrange
        var specification = await ObterSpecification(obrigatorio);

        // Act
        var resultado = specification.IsSatisfiedBy(InscricaoConstants.InscricaoVazia.Enderecos);

        // Assert
        resultado.Should().Be(!obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.EnderecoCobrancaRua.Nome).Should().Be(obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.EnderecoComercialRua.Nome).Should().Be(obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.EnderecoResidencialRua.Nome).Should().Be(obrigatorio);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task DeveRetornarValidacaoDeNumeroDependendoDaObrigatoriedadeAsync(bool obrigatorio)
    {
        // Arrange
        var specification = await ObterSpecification(obrigatorio);

        // Act
        var resultado = specification.IsSatisfiedBy(InscricaoConstants.InscricaoVazia.Enderecos);

        // Assert
        resultado.Should().Be(!obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.EnderecoCobrancaNumero.Nome).Should().Be(obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.EnderecoComercialNumero.Nome).Should().Be(obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.EnderecoResidencialNumero.Nome).Should().Be(obrigatorio);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task DeveRetornarValidacaoDeComplementoDependendoDaObrigatoriedadeAsync(bool obrigatorio)
    {
        // Arrange
        var specification = await ObterSpecification(obrigatorio);

        // Act
        var resultado = specification.IsSatisfiedBy(InscricaoConstants.InscricaoVazia.Enderecos);

        // Assert
        resultado.Should().Be(!obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.EnderecoCobrancaComplemento.Nome).Should().Be(obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.EnderecoComercialComplemento.Nome).Should().Be(obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.EnderecoResidencialComplemento.Nome).Should().Be(obrigatorio);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task DeveRetornarValidacaoDeBairroDependendoDaObrigatoriedadeAsync(bool obrigatorio)
    {
        // Arrange
        var specification = await ObterSpecification(obrigatorio);

        // Act
        var resultado = specification.IsSatisfiedBy(InscricaoConstants.InscricaoVazia.Enderecos);

        // Assert
        resultado.Should().Be(!obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.EnderecoCobrancaBairro.Nome).Should().Be(obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.EnderecoComercialBairro.Nome).Should().Be(obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.EnderecoResidencialBairro.Nome).Should().Be(obrigatorio);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task DeveRetornarValidacaoDeCepDependendoDaObrigatoriedadeAsync(bool obrigatorio)
    {
        // Arrange
        var specification = await ObterSpecification(obrigatorio);

        // Act
        var resultado = specification.IsSatisfiedBy(InscricaoConstants.InscricaoVazia.Enderecos);

        // Assert
        resultado.Should().Be(!obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.EnderecoCobrancaCep.Nome).Should().Be(obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.EnderecoComercialCep.Nome).Should().Be(obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.EnderecoResidencialCep.Nome).Should().Be(obrigatorio);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task DeveRetornarValidacaoDeEstadoDependendoDaObrigatoriedadeAsync(bool obrigatorio)
    {
        // Arrange
        var specification = await ObterSpecification(obrigatorio);

        // Act
        var resultado = specification.IsSatisfiedBy(InscricaoConstants.InscricaoVazia.Enderecos);

        // Assert
        resultado.Should().Be(!obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.EnderecoCobrancaEstado.Nome).Should().Be(obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.EnderecoComercialEstado.Nome).Should().Be(obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.EnderecoResidencialEstado.Nome).Should().Be(obrigatorio);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task DeveRetornarValidacaoDeCidadeDependendoDaObrigatoriedadeAsync(bool obrigatorio)
    {
        // Arrange
        var specification = await ObterSpecification(obrigatorio);

        // Act
        var resultado = specification.IsSatisfiedBy(InscricaoConstants.InscricaoVazia.Enderecos);

        // Assert
        resultado.Should().Be(!obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.EnderecoCobrancaCidade.Nome).Should().Be(obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.EnderecoComercialCidade.Nome).Should().Be(obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.EnderecoResidencialCidade.Nome).Should().Be(obrigatorio);
    }

    private async Task<CriteriosEnderecoInscricaoSpecification> ObterSpecification(bool obrigatorioFicha = true)
    {
        var campos = await _campoRepository.GetListAsync();

        return new(
            _validations,
            campos.Select(cf => new CampoFicha(cf.Id, obrigatorioFicha, false)).ToList(),
            campos.ToList());
    }
}