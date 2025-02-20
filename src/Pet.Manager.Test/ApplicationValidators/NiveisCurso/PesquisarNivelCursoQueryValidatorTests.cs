﻿using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application.UseCases.Campi.PesquisarCampus;
using Anima.Inscricao.Application.UseCases.NiveisCurso.PesquisarNivelCurso;
using Anima.Inscricao.Domain._Shared.Notifications;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.NiveisCurso;

public class PesquisarNivelCursoQueryValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly PesquisarNivelCursoQueryValidator _validationRules;

    public PesquisarNivelCursoQueryValidatorTests()
    {
        _validationRules = new PesquisarNivelCursoQueryValidator(_notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarPaginacaoObrigatoriaAsync()
    {
        var command = new PesquisarNivelCursoQuery
        {
            Paginacao = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Paginacao)
           .WithErrorMessage("A paginação precisa ser informada.");
    }

    [Fact]
    public async Task DeveValidarErroQuantidadeRegistrosObrigatoriaAsync()
    {
        var command = new PesquisarNivelCursoQuery
        {
            Paginacao = new PaginacaoDto()
            {
                QuantidadeRegistros = 0,
            },
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Paginacao.QuantidadeRegistros)
           .WithErrorMessage("A quantidade de registros precisa ser maior que zero.");
    }

    [Fact]
    public async Task DeveValidarErroNumeroPaginaObrigatorioAsync()
    {
        var command = new PesquisarNivelCursoQuery
        {
            Paginacao = new PaginacaoDto()
            {
                NumeroPagina = 0,
            },
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Paginacao.NumeroPagina)
           .WithErrorMessage("A página de pesquisa precisa ser maior que zero.");
    }
}
