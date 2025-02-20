namespace Anima.Inscricao.Application.DTOs.Enem;

public class SolicitarClassificacaoRequestDto
{
    public string Cpf { get; set; } = string.Empty;

    public int Prioridade { get; set; } = 2;
}