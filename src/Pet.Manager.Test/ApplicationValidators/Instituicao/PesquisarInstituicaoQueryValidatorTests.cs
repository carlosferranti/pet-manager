﻿using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application.UseCases.Instituicoes.PesquisarInstituicao;
using Anima.Inscricao.Domain._Shared.Notifications;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Instituicao;

public class PesquisarInstituicaoQueryValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly PesquisarInstituicaoQueryValidator _validationRules;

    public PesquisarInstituicaoQueryValidatorTests()
    {
        _validationRules = new PesquisarInstituicaoQueryValidator(_notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarPaginacaoObrigatoriaAsync()
    {
        var command = new PesquisarInstituicaoQuery
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
        var command = new PesquisarInstituicaoQuery
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
        var command = new PesquisarInstituicaoQuery
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
