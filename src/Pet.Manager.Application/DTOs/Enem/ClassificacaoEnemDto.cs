namespace Anima.Inscricao.Application.DTOs.Enem;

public class ClassificacaoEnemDto
{
    public int ClassificacaoId { get; set; }

    public int Ano { get; set; }

    public string Cpf { get; set; } = string.Empty;

    public List<ObterClassificacaoCriterioEnemDto>? Criterios { get; set; }
}

public class ObterClassificacaoCriterioEnemDto
{
    public int CriterioClassificacaoId { get; set; }

    public string TipoCriterio { get; set; } = string.Empty;

    public string Observacoes { get; set; } = string.Empty;

    public DateTime DataVerificacao { get; set; }

    public bool Atual { get; set; }

    public ObterClassificacaoCriterioSituacaoEnemDto? Situacao { get; set; }
}

public class ObterClassificacaoCriterioSituacaoEnemDto
{
    public int Codigo { get; set; }

    public string Descricao { get; set; } = string.Empty;
}