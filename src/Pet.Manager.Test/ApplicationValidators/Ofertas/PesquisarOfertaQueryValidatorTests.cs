using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application.UseCases.Ofertas.PesquisarOferta;
using Anima.Inscricao.Application.UseCases.Produtos.PesquisarProduto;
using Anima.Inscricao.Domain._Shared.Notifications;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Ofertas;

public class PesquisarOfertaQueryValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly PesquisarOfertaQueryValidator _validationRules;

    public PesquisarOfertaQueryValidatorTests()
    {
        _validationRules = new PesquisarOfertaQueryValidator(_notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarPaginacaoObrigatoriaAsync()
    {
        var query = new PesquisarOfertaQuery
        {
            Paginacao = null!,
        };

        var result = await _validationRules.TestValidateAsync(query);

        result.ShouldHaveValidationErrorFor(x => x.Paginacao)
           .WithErrorMessage("A paginação precisa ser informada.");
    }

    [Fact]
    public async Task DeveValidarErroQuantidadeRegistrosObrigatoriaAsync()
    {
        var query = new PesquisarOfertaQuery
        {
            Paginacao = new PaginacaoDto()
            {
                QuantidadeRegistros = 0,
            },
        };

        var result = await _validationRules.TestValidateAsync(query);

        result.ShouldHaveValidationErrorFor(x => x.Paginacao.QuantidadeRegistros)
           .WithErrorMessage("A quantidade de registros precisa ser maior que zero.");
    }

    [Fact]
    public async Task DeveValidarErroNumeroPaginaObrigatorioAsync()
    {
        var query = new PesquisarOfertaQuery
        {
            Paginacao = new PaginacaoDto()
            {
                NumeroPagina = 0,
            },
        };

        var result = await _validationRules.TestValidateAsync(query);

        result.ShouldHaveValidationErrorFor(x => x.Paginacao.NumeroPagina)
           .WithErrorMessage("A página de pesquisa precisa ser maior que zero.");
    }
}
