using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Domain.Escolas.Entities;
using Anima.Inscricao.Domain.Escolas.Enums;

namespace Anima.Inscricao.Test._Shared.Constants
{
    public static class EscolaConstants
    {
        public static readonly Escola IFSP =
            Escola.Criar("Instituto Federal de São Paulo", 123, new CidadeId(1), TipoCategoriaEscola.EducacaoSuperior)
            .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a escola IFSP");

        public static readonly Escola ColegioVitoria =
            Escola.Criar("Colégio Vitória", 321, new CidadeId(2), TipoCategoriaEscola.EducacaoBasica)
            .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a escola Colégio Vitória");

        public static readonly Escola ColegioRecife =
           Escola.Criar("Colégio Recife", 321, new CidadeId(2), TipoCategoriaEscola.EducacaoBasica)
           .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a escola Colégio Recife");
    }
}
