using Anima.Inscricao.Application.Extensions;
using Anima.Inscricao.Application.UseCases.TiposStatusInscricao.PesquisarTiposStatusInscricao;
using Anima.Inscricao.Domain.Inscricoes.Enums;

using FluentAssertions;

namespace Anima.Inscricao.Test.UseCases.TiposStatusInscricao;

public class PesquisarTiposStatusInscricaoQueryHandlerTest
{

    [Fact]
    public async Task DeveRetornarTodosValoresDoEnum()
    {
        var useCase = ObterUseCase();

        var resultado = await useCase.Handle(new PesquisarTiposStatusInscricaoQuery(), default);
        resultado.Should().NotBeNull();
        resultado.Should().HaveCount(7);
        resultado[0].Nome.Should().Be(EnumExtensions.Description(TipoStatusInscricao.EmAndamento));
        resultado[0].Id.Should().Be(1);
        resultado[1].Nome.Should().Be(EnumExtensions.Description(TipoStatusInscricao.ParcialmenteConcluida));
        resultado[1].Id.Should().Be(2);
        resultado[2].Nome.Should().Be(EnumExtensions.Description(TipoStatusInscricao.TotalmenteConcluida));
        resultado[2].Id.Should().Be(3);
        resultado[3].Nome.Should().Be(EnumExtensions.Description(TipoStatusInscricao.InscricaoProcessadaSucesso));
        resultado[3].Id.Should().Be(4);
    }

    private PesquisarTiposStatusInscricaoQueryHandler ObterUseCase()
    {
        return new();
    }
}
