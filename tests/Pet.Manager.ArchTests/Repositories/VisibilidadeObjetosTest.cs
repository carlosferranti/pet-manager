using ArchUnitNET.xUnit;

using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace Anima.Inscricao.ArchTests.Repositories;

public class VisibilidadeObjetosTest
{
    [Fact]
    public void DeveValidarQueContratosDeRepositoriosSaoPublicos()
    {
        var interfaces = Interfaces().That().HaveNameContaining("Repository");

        var regraInterfaces = interfaces
            .Should().BePublic();

        regraInterfaces.Check(Config.Arquitetura);
    }

    [Fact]
    public void DeveValidarQueImplementacoesDeRepositoriosSaoPublicos()
    {
        var interfaces = Interfaces().That().HaveNameContaining("Repository");
        var classes = Classes().That().AreAssignableTo(interfaces);

        var regraClasses = classes
            .Should().BePublic();

        regraClasses.Check(Config.Arquitetura);
    }
}
