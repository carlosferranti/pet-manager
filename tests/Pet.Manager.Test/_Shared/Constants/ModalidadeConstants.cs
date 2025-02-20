using Anima.Inscricao.Domain.Modalidades.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class ModalidadeConstants
{
    public static readonly Modalidade ModalidadePresencial =
        Modalidade.Criar("Presencial", "Descricao")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a modalidade Presencial");

    public static readonly Modalidade ModalidadeSemiPresencial =
          Modalidade.Criar("Semi-Presencial", "Descricao")
          .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a modalidade Semi-Presencial");

    public static readonly Modalidade ModalidadeLive =
      Modalidade.Criar("Live", "Descricao")
      .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a modalidade Live");
}
