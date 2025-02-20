using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application.UseCases.Inscricoes.PesquisarInscricoesCandidatos;
using Anima.Inscricao.Application.UseCases.Instituicoes.PesquisarLinkRedirecionamentoCandidato;
using Anima.Inscricao.Domain._Shared.Notifications;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Inscricoes;

public class PesquisarInscricoesCandidatosQueryValidatorTests
{

    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly PesquisarInscricoesCandidatosQueryValidator _validationRules;

    public PesquisarInscricoesCandidatosQueryValidatorTests()
    {
        _validationRules = new PesquisarInscricoesCandidatosQueryValidator(_notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarSeConcursoIdTemMaisQue100CaracteresAsync()
    {
        var command = new PesquisarInscricoesCandidatosQuery
        {
            Filtros = new PesquisarInscricoesCandidatosQuery.PesquisarInscricoesCandidatosFiltros(new string('1', 101), null, null, null, null),
            Paginacao = new PaginacaoDto()
            {
                QuantidadeRegistros = 10,
                NumeroPagina = 1
            }
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Filtros.ConcursoId)
           .WithErrorMessage("Id do concurso deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveValidarIdCandidatoEInteiroAsync()
    {
        var command = new PesquisarInscricoesCandidatosQuery
        {
            Filtros = new PesquisarInscricoesCandidatosQuery.PesquisarInscricoesCandidatosFiltros(null, 0, null, null, null),
            Paginacao = new PaginacaoDto()
            {
                QuantidadeRegistros = 10,
                NumeroPagina = 1
            }
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Filtros.CandidatoId)
           .WithErrorMessage("O id do candidato deve ser um número positivo.");
    }

    [Fact]
    public async Task DeveValidarSeNomeTemMaisQue100CaracteresAsync()
    {
        var command = new PesquisarInscricoesCandidatosQuery
        {
            Filtros = new PesquisarInscricoesCandidatosQuery.PesquisarInscricoesCandidatosFiltros(null, null, new string('1', 101), null, null),
            Paginacao = new PaginacaoDto()
            {
                QuantidadeRegistros = 10,
                NumeroPagina = 1
            }
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Filtros.Nome)
           .WithErrorMessage("Nome deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveValidarSeCpfTemMaisQue14CaracteresAsync()
    {
        var command = new PesquisarInscricoesCandidatosQuery
        {
            Filtros = new PesquisarInscricoesCandidatosQuery.PesquisarInscricoesCandidatosFiltros(null, null, null, new string('1', 15), null),
            Paginacao = new PaginacaoDto()
            {
                QuantidadeRegistros = 10,
                NumeroPagina = 1
            }
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Filtros.Cpf)
           .WithErrorMessage("Cpf deve ter no máximo 14 caracteres.");
    }


    [Fact]
    public async Task DeveValidarSeOsIdsStatusSaoNumerosInteirosMaiorQue0Async()
    {
        var command = new PesquisarInscricoesCandidatosQuery
        {
            Filtros = new PesquisarInscricoesCandidatosQuery.PesquisarInscricoesCandidatosFiltros(null, null, null, null, [0]),
            Paginacao = new PaginacaoDto()
            {
                QuantidadeRegistros = 10,
                NumeroPagina = 1
            }
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Filtros.StatusInscricaoIds)
           .WithErrorMessage("Os ids de status de inscrição devem ser números inteiros maior que 0");
    }

    [Fact]
    public async Task DeveValidarPaginacaoObrigatoriaAsync()
    {
        var command = new PesquisarInscricoesCandidatosQuery
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
        var command = new PesquisarInscricoesCandidatosQuery
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
        var command = new PesquisarInscricoesCandidatosQuery
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
