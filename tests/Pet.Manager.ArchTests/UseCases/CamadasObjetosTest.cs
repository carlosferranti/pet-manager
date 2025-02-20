using ArchUnitNET.xUnit;

using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace Anima.Inscricao.ArchTests.UseCases;

public class CamadasObjetosTest
{
    [Fact]
    public void DeveValidarQueImplementacoesDeUseCasesEstaoNaCamadaDeAplicacao()
    {
        var classes = Classes().That().HaveNameContaining("Command");

        var regraClasses = classes
            .Should().Be(Config.CamadaAplicacao);

        regraClasses.Check(Config.Arquitetura);
    }
}
