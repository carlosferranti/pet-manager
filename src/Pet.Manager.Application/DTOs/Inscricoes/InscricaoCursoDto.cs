using Anima.Inscricao.Application.DTOs.Modalidades;
using Anima.Inscricao.Application.DTOs.NiveisCurso;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class InscricaoCursoDto
{
    public Guid? Key { get; set; }

    public string? Nome { get; set; }

    public List<SistemaIntegracaoDto>? Integracoes { get; set; }

    public NivelCursoDto? Nivel { get; set; }

    public ModalidadeDto? Modalidade { get; set; }
}