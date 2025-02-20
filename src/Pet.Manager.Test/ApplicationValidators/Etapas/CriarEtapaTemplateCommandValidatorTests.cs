using Anima.Inscricao.Application.UseCases.Etapas.CriarEtapa;
using Anima.Inscricao.Domain._Shared.Notifications;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Etapas;

public class CriarEtapaTemplateCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly CriarEtapaTemplateCommandValidator _validator;

    public CriarEtapaTemplateCommandValidatorTests()
    {
        _validator = new CriarEtapaTemplateCommandValidator(_notificationContext.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeDaEtapaForVazio()
    {
        var command = new CriarEtapaTemplateCommand
        {
            Nome = string.Empty,
            Descricao = "Descrição da etapa",
            NomeArquivo = "template.txt"
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome da etapa é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeDaEtapaExcederLimiteDeCaracteres()
    {
        var command = new CriarEtapaTemplateCommand
        {
            Nome = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut diam nec nunc tincidunt ultrices. Nulla facilisi.",
            Descricao = "Descrição da etapa",
            NomeArquivo = "template.txt"
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome da etapa deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoDescricaoDaEtapaForVazia()
    {
        var command = new CriarEtapaTemplateCommand
        {
            Nome = "Nome da etapa",
            Descricao = string.Empty,
            NomeArquivo = "template.txt"
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Descricao)
            .WithErrorMessage("A descrição da etapa é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoDescricaoDaEtapaExcederLimiteDeCaracteres()
    {
        var command = new CriarEtapaTemplateCommand
        {
            Nome = "Nome da etapa",
            Descricao = new string('a', 300),
            NomeArquivo = "template"
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Descricao)
            .WithErrorMessage("A descrição da etapa deve ter no máximo 200 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeArquivoDoTemplateForVazio()
    {
        var command = new CriarEtapaTemplateCommand
        {
            Nome = "Nome da etapa",
            Descricao = "Descrição da etapa",
            NomeArquivo = string.Empty
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.NomeArquivo)
            .WithErrorMessage("O nome do arquivo do template é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeArquivoDoTemplateExcederLimiteDeCaracteres()
    {
        var command = new CriarEtapaTemplateCommand
        {
            Nome = "Nome da etapa",
            Descricao = "Descrição da etapa",
            NomeArquivo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut diam nec nunc tincidunt ultrices. Nulla facilisi."
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.NomeArquivo)
            .WithErrorMessage("O nome do arquivo do template deve ter no máximo 100 caracteres.");
    }
}