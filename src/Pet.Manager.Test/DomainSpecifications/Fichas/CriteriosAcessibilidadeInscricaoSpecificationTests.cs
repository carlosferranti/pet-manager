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
public class CriteriosAcessibilidadeInscricaoSpecificationTests
{
    private readonly ICampoRepository _campoRepository;
    private readonly List<InfoValidation> _validations = new();

    public CriteriosAcessibilidadeInscricaoSpecificationTests(DatabaseFixture databaseFixture)
    {
        _campoRepository = databaseFixture.ServiceProvider.GetRequiredService<ICampoRepository>();
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task DeveRetornarValidacaoDeAcessibilidadeDependendoDaObrigatoriedadeAsync(bool obrigatorio)
    {
        // Arrange
        var specification = await ObterSpecification(obrigatorio);

        // Act
        var resultado = specification.IsSatisfiedBy(InscricaoConstants.InscricaoVazia.Acessibilidades);

        // Assert
        resultado.Should().Be(!obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.Acessibilidade.Nome).Should().Be(obrigatorio);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task DeveRetornarValidacaoDeTipoAcessibilidadeDependendoDaObrigatoriedadeAsync(bool obrigatorio)
    {
        // Arrange
        var specification = await ObterSpecification(obrigatorio);
        var inscricao = InscricaoConstants.InscricaoVazia;
        inscricao.DefinirAcessibilidade(0);

        // Act
        var resultado = specification.IsSatisfiedBy(inscricao.Acessibilidades);

        // Assert
        resultado.Should().Be(!obrigatorio);
        _validations.Exists(x => x.Atributo == CampoConstants.Acessibilidade.Nome).Should().Be(obrigatorio);
    }

    private async Task<CriteriosAcessibilidadeInscricaoSpecification> ObterSpecification(bool obrigatorioFicha = true)
    {
        var campos = await _campoRepository.GetListAsync();

        return new(
            _validations,
            campos.Select(cf => new CampoFicha(cf.Id, obrigatorioFicha, false)).ToList(),
            campos.ToList());
    }
}