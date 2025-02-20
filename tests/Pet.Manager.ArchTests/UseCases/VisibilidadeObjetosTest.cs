using ArchUnitNET.xUnit;
using Xunit;

using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace Anima.Inscricao.ArchTests.UseCases;

public class VisibilidadeObjetosTest
{
    [Fact]
    public void DeveValidarQueImplementacoesDeUseCasesSaoPublicos()
    {
        var classes = Classes().That().HaveNameContaining("Command");

        var regraClasses = classes
            .Should().BePublic();

        regraClasses.Check(Config.Arquitetura);
    }
}
