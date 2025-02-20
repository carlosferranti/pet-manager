using Anima.Inscricao.Application.UseCases.Fichas.AtualizarFicha;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Etapas;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Fichas;

public class AtualizarFichaCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IEtapaTemplateRepository> _etapaTemplateRepository = new();
    private readonly AtualizarFichaCommandValidator _validator;

    public AtualizarFichaCommandValidatorTests()
    {
        _validator = new AtualizarFichaCommandValidator(_notificationContext.Object, _etapaTemplateRepository.Object);
    }

    [Fact]
    public async Task DeveTerNomeObrigatorio()
    {
        var command = new AtualizarFichaCommand
        {
            Nome = string.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome da ficha é obrigatório.");
    }

    [Fact]
    public async Task DeveTerNomeComTamanhoMaximo()
    {
        var command = new AtualizarFichaCommand
        {
            Nome = new string('a', 101)
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome da ficha deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerDescricaoObrigatorio()
    {
        var command = new AtualizarFichaCommand
        {
            Descricao = string.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Descricao)
            .WithErrorMessage("A descrição da ficha é obrigatória.");
    }

    [Fact]
    public async Task DeveTerDescricaoComTamanhoMaximo()
    {
        var command = new AtualizarFichaCommand
        {
            Descricao = new string('a', 201)
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Descricao)
            .WithErrorMessage("A descrição da ficha deve ter no máximo 200 caracteres.");
    }

    [Fact]
    public async Task DeveTerEtapasObrigatorio()
    {
        var command = new AtualizarFichaCommand
        {
            Etapas = null!,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Etapas)
            .WithErrorMessage("As etapas da ficha são obrigatórias.");
    }

    [Fact]
    public async Task DeveTerSequenciaDaEtapaObrigatorio()
    {
        var command = new AtualizarFichaCommand
        {
            Etapas = new List<AtualizarFichaCommand.AtualizarEtapaFichaCommand>()
            {
                new AtualizarFichaCommand.AtualizarEtapaFichaCommand(Guid.NewGuid(), 0),
            }
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor("Etapas[0].Sequencia")
            .WithErrorMessage("A sequencia da etapa é obrigatória.");
    }

    [Fact]
    public async Task DeveTerChaveDaEtapaObrigatorio()
    {
        var command = new AtualizarFichaCommand
        {
            Etapas = new List<AtualizarFichaCommand.AtualizarEtapaFichaCommand>()
            {
                new AtualizarFichaCommand.AtualizarEtapaFichaCommand(Guid.Empty, 0),
            }
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor("Etapas[0].EtapaKey")
            .WithErrorMessage("A chave da etapa é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarExistenciaDaEtapa()
    {
        var command = new AtualizarFichaCommand
        {
            Etapas = new List<AtualizarFichaCommand.AtualizarEtapaFichaCommand>(),
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Etapas)
            .WithErrorMessage("As etapas da ficha são obrigatórias.");
    }
}