using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application.UseCases.Modalidades.PesquisarModalidade;
using Anima.Inscricao.Domain._Shared.Notifications;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.Validators.Modalidades;

public class PesquisarModalidadeQueryValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly PesquisarModalidadeQueryValidator _validationRules;

    public PesquisarModalidadeQueryValidatorTests()
    {
        _validationRules = new PesquisarModalidadeQueryValidator(_notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarPaginacaoObrigatoriaAsync()
    {
        var command = new PesquisarModalidadeQuery
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
        var command = new PesquisarModalidadeQuery
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
        var command = new PesquisarModalidadeQuery
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
