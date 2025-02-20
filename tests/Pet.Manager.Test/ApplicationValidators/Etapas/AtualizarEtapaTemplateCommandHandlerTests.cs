using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Anima.Inscricao.Application.DTOs.Etapas;
using Anima.Inscricao.Application.UseCases.Etapas.AtualizarEtapaTemplate;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Etapas;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Etapas;

public class AtualizarEtapaTemplateCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IEtapaTemplateRepository> _etapaTemplateRepository = new();
    private readonly AtualizarEtapaTemplateCommandValidator _validator;

    public AtualizarEtapaTemplateCommandHandlerTests()
    {
        _validator = new AtualizarEtapaTemplateCommandValidator(
            _notificationContext.Object,
            _etapaTemplateRepository.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaEtapaForVazia()
    {
        var command = new AtualizarEtapaTemplateCommand
        {
            Key = Guid.Empty
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da etapa é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaEtapaNaoExistir()
    {
        var command = new AtualizarEtapaTemplateCommand
        {
            Key = Guid.NewGuid()
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da etapa não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeDaEtapaForVazio()
    {
        var command = new AtualizarEtapaTemplateCommand
        {
            Nome = string.Empty
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome da etapa é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeDaEtapaExcederLimiteDeCaracteres()
    {
        var command = new AtualizarEtapaTemplateCommand
        {
            Nome = new string('a', 101)
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome da etapa deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoDescricaoDaEtapaForVazia()
    {
        var command = new AtualizarEtapaTemplateCommand
        {
            Descricao = string.Empty
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Descricao)
            .WithErrorMessage("A descrição da etapa é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoDescricaoDaEtapaExcederLimiteDeCaracteres()
    {
        var command = new AtualizarEtapaTemplateCommand
        {
            Descricao = new string('a', 201)
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Descricao)
            .WithErrorMessage("A descrição da etapa deve ter no máximo 200 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeDoArquivoDoTemplateForVazio()
    {
        var command = new AtualizarEtapaTemplateCommand
        {
            NomeArquivo = string.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.NomeArquivo)
            .WithErrorMessage("O nome do arquivo do template é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeDoArquivoDoTemplateExcederLimiteDeCaracteres()
    {
        var command = new AtualizarEtapaTemplateCommand
        {
            NomeArquivo = new string('a', 101),
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.NomeArquivo)
            .WithErrorMessage("O nome do arquivo do template deve ter no máximo 100 caracteres.");
    }
}