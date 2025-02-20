using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain.FormasEntrada.Enums;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.CalcularMotorCoi;

public class CalcularMotorCoiCommand : ICommand<Guid?>
{
    public InstituicaoOrigemCommand? CursoOrigem { get; set; }

    public InstituicaoDestinoCommand CursoDestino { get; set; } = null!;

    public string CpfCandidato { get; set; } = string.Empty;

    public string? RaVinculo { get; set; }

    public string Modalidade { get; set; } = string.Empty;

    public int AnoCaptacao { get; set; }

    public int SemestreCaptacao { get; set; }

    public Guid FormaIngressoEscolhida { get; set; }

    public record InstituicaoOrigemCommand
    {
        public string? CodigoInstituicao { get; set; }

        public string? NomeCurso { get; set; }
    }

    public record InstituicaoDestinoCommand
    {
        public string CodigoInstituicao { get; set; } = string.Empty;

        public string NomeCurso { get; set; } = string.Empty;

        public string NomeTurno { get; set; } = string.Empty;

        public string NomeCampus { get; set; } = string.Empty;

        public string CodigoCampus { get; set; } = string.Empty;
    }
}
