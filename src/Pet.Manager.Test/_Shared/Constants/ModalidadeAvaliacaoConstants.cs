using Anima.Inscricao.Domain.ModalidadesAvaliacao.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class ModalidadeAvaliacaoConstants
{
    public static readonly ModalidadeAvaliacao Online =
       ModalidadeAvaliacao.Criar("Online")
       .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a modalidade de avaliação Online");

    public static readonly ModalidadeAvaliacao Presencial =
       ModalidadeAvaliacao.Criar("Presencial")
       .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a modalidade de avaliação Presencial");
}