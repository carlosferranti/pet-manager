using ArchUnitNET.xUnit;

using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace Anima.Inscricao.ArchTests.DTO;

public class NomesObjetosTest
{
    private const string NOME_PASTA = "DTOs";
    private const string NOME_OBJETO = "Dto";

    [Fact]
    public void DeveValidarQueDtosPossuemONomeCorreto()
    {
        var padraoNomeRegex = ObterRegexDtos();
        var classes = Classes().That().HaveNameContaining(NOME_OBJETO);

        var regraClasses = classes
            .Should().HaveFullName(padraoNomeRegex, true);

        regraClasses.Check(Config.Arquitetura);
    }

    private static string ObterRegexDtos() => Config.ObterRegexClasses(NOME_PASTA, NOME_OBJETO);
}
