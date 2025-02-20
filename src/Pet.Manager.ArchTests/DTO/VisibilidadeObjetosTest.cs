using ArchUnitNET.xUnit;
using Xunit;

using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace Anima.Inscricao.ArchTests.DTO;

public class VisibilidadeObjetosTest
{
    private const string NOME_OBJETO = "Dto";

    [Fact]
    public void DeveValidarQueDtosSaoPublicos()
    {
        var classes = Classes().That().HaveNameContaining(NOME_OBJETO);

        var regraClasses = classes
            .Should().BePublic();

        regraClasses.Check(Config.Arquitetura);
    }
}
