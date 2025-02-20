using Anima.Inscricao.Domain.TiposFormacao.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class TipoFormacaoConstants
{
    public static readonly TipoFormacao TipoFormacaoGraduacao =
        TipoFormacao.Criar("Graduação")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o tipo de formação graduação.");

    public static readonly TipoFormacao TipoFormacaoPos =
        TipoFormacao.Criar("Pós-Graduação")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o tipo de formação pós-graduação.");
    
    public static readonly TipoFormacao TipoFormacaoGraduacaoMedicina =
          TipoFormacao.Criar("Graduação Medicina")
          .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o tipo de formação Graduação Medicina.");
}