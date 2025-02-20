using ArchUnitNET.xUnit;

using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace Anima.Inscricao.ArchTests.DTO;

public class CamadasObjetosTest
{
    private const string NOME_OBJETO = "Dto";

    [Fact]
    public void DeveValidarQueDtosEstaoNaCamadaDeAplicacao()
    {
        var classes = Classes().That().HaveNameContaining(NOME_OBJETO);

        var regraClasses = classes
            .Should().Be(Config.CamadaAplicacao);

        regraClasses.Check(Config.Arquitetura);
    }
}
