using Anima.Inscricao.Domain.Campos.Entities;
using Anima.Inscricao.Domain.Etapas.Entities;
using Anima.Inscricao.Domain.Fichas.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class FichaConstants
{
    public static readonly Ficha FichaPadrao = CriaFichaPadrao();
   
    public static readonly Ficha FichaB = CriaFichaB();

    public static readonly Ficha FichaVazia = Ficha.Criar("Ficha Vazia", "Ficha vazia", false)
            .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a ficha vazia");

    private static Ficha CriaFichaPadrao()
    {
        var ficaPadrao = Ficha.Criar("Ficha Padrao", "Ficha modelo padrão", true)
            .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a ficha padrão");

        ficaPadrao.AdicionarEtapa(new EtapaTemplateId(1), 1);
        ficaPadrao.AdicionarEtapa(new EtapaTemplateId(2), 2);

        ficaPadrao.AdicionarCampo(new CampoId(1), true, false);
        ficaPadrao.AdicionarCampo(new CampoId(2), true, false);
        ficaPadrao.AdicionarCampo(new CampoId(3), true, false);

        return ficaPadrao;
    }

    private static Ficha CriaFichaB()
    {
        var fichaB = Ficha.Criar("Ficha B", "Ficha modelo B", false)
            .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a ficha B");

        fichaB.AdicionarEtapa(new EtapaTemplateId(1), 1);

        fichaB.AdicionarCampo(new CampoId(1), true, false);
        fichaB.AdicionarCampo(new CampoId(2), true, false);
        fichaB.AdicionarCampo(new CampoId(3), true, false);

        return fichaB;
    }
}
