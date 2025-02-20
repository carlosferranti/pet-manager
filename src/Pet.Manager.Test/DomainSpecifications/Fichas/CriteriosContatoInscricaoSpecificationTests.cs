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
public class CriteriosContatoInscricaoSpecificationTests
{
    private readonly ICampoRepository _campoRepository;
    private readonly List<InfoValidation> _validations = new();

    public CriteriosContatoInscricaoSpecificationTests(DatabaseFixture databaseFixture)
    {
        _campoRepository = databaseFixture.ServiceProvider.GetRequiredService<ICampoRepository>();
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task DeveRetornarValidacaoDeCelularDependendoDaObrigatoriedadeAsync(bool obrigatorio)
    {
        // Arrange
        var specification = await ObterSpecification(obrigatorio);

        // Act
        var resultado = specification.IsSatisfiedBy(InscricaoConstants.InscricaoVazia.Contatos);

        // Assert
        resultado.Should().Be(!obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.TelefoneCelular.Nome).Should().Be(obrigatorio);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task DeveRetornarValidacaoDeEmailDependendoDaObrigatoriedadeAsync(bool obrigatorio)
    {
        // Arrange
        var specification = await ObterSpecification(obrigatorio);

        // Act
        var resultado = specification.IsSatisfiedBy(InscricaoConstants.InscricaoVazia.Contatos);

        // Assert
        resultado.Should().Be(!obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.Email.Nome).Should().Be(obrigatorio);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task DeveRetornarValidacaoDeTelefoneFixoDependendoDaObrigatoriedadeAsync(bool obrigatorio)
    {
        // Arrange
        var specification = await ObterSpecification(obrigatorio);

        // Act
        var resultado = specification.IsSatisfiedBy(InscricaoConstants.InscricaoVazia.Contatos);

        // Assert
        resultado.Should().Be(!obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.TelefoneFixo.Nome).Should().Be(obrigatorio);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task DeveRetornarValidacaoDeTelefoneComercialDependendoDaObrigatoriedadeAsync(bool obrigatorio)
    {
        // Arrange
        var specification = await ObterSpecification(obrigatorio);

        // Act
        var resultado = specification.IsSatisfiedBy(InscricaoConstants.InscricaoVazia.Contatos);

        // Assert
        resultado.Should().Be(!obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.TelefoneComercial.Nome).Should().Be(obrigatorio);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task DeveRetornarValidacaoDeTelefoneContatoDependendoDaObrigatoriedadeAsync(bool obrigatorio)
    {
        // Arrange
        var specification = await ObterSpecification(obrigatorio);

        // Act
        var resultado = specification.IsSatisfiedBy(InscricaoConstants.InscricaoVazia.Contatos);

        // Assert
        resultado.Should().Be(!obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.TelefoneContato.Nome).Should().Be(obrigatorio);
    }

    private async Task<CriteriosContatoInscricaoSpecification> ObterSpecification(bool obrigatorioFicha = true)
    {
        var campos = await _campoRepository.GetListAsync();

        return new(
            _validations,
            campos.Select(cf => new CampoFicha(cf.Id, obrigatorioFicha, false)).ToList(),
            campos.ToList());
    }
}