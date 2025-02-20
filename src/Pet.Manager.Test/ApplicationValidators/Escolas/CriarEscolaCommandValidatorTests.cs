using Anima.Inscricao.Application.UseCases.Escolas.AtualizarEscola;
using Anima.Inscricao.Application.UseCases.Escolas.CriarEscola;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Escolas;

public class CriarEscolaCommandValidatorTests
{
    private readonly Mock<ICidadeRepository> _cidadeRepositoryMock = new();
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IIntegracaoSistemaRepository> _sistemasIntegracaoRepository = new();
    private readonly CriarEscolaCommandValidator _validationRules;

    public CriarEscolaCommandValidatorTests()
    {
        _validationRules = new CriarEscolaCommandValidator(
            _cidadeRepositoryMock.Object, 
            _sistemasIntegracaoRepository.Object,
            _notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroNomeObrigatorioAsync()
    {
        var command = new CriarEscolaCommand
        {
            Nome = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome da escola é obrigatório.");
    }

    [Theory]
    [InlineData(2)]
    [InlineData(201)]
    public async Task DeveValidarMensagemDeErroLimiteCaracteresNomeAsync(int numeroCaracteres)
    {
        var command = new CriarEscolaCommand
        {
            Nome = new string('a', numeroCaracteres),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome da escola deve ter entre 3 e 200 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoCidadeKeyNaoEncontradaAsync()
    {
        var command = new CriarEscolaCommand
        {
            CidadeKey = Guid.NewGuid(),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.CidadeKey.Value)
            .WithErrorMessage("A chave da cidade não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeSistemaIntegracaoNaoEncontradoAsync()
    {
        var command = new CriarEscolaCommand
        {
            Integracao = new()
            {
                NomeSistema = "SistemaInexistente",
            },
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Integracao!.NomeSistema)
            .WithErrorMessage("Nome do sistema de integração não encontrado.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeSistemaIntegracaoUltrapassarLimiteAsync()
    {
        var command = new CriarEscolaCommand
        {
            Integracao = new()
            {
                NomeSistema = new string('a', 150),
            },
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Integracao!.NomeSistema)
            .WithErrorMessage("O nome do sistema de integração deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoCodigoOrigemUltrapassarLimiteAsync()
    {
        var command = new CriarEscolaCommand
        {
            Integracao = new()
            {
                CodigoOrigem = new string('a', 150),
            },
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Integracao!.CodigoOrigem)
            .WithErrorMessage("O código de origem da integração deve ter no máximo 100 caracteres.");
    }
}
