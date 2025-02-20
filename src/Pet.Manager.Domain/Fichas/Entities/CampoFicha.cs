using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain.Campos.Entities;

namespace Anima.Inscricao.Domain.Fichas.Entities;

public class CampoFicha : Entity<CampoFichaId>
{
    public CampoFicha(CampoId campoId, bool obrigatorioNaFicha, bool obrigatorioNoComplemento)
    {
        CampoId = campoId;
        ObrigatorioNaFicha = obrigatorioNaFicha;
        ObrigatorioNoComplemento = obrigatorioNoComplemento;
    }

    protected CampoFicha() 
    {
        CampoId = null!;
        ObrigatorioNaFicha = false;
        ObrigatorioNoComplemento = false;
    }

    public CampoId CampoId { get; protected set; }

    public bool ObrigatorioNaFicha { get; protected set; }

    public bool ObrigatorioNoComplemento { get; protected set; }
}