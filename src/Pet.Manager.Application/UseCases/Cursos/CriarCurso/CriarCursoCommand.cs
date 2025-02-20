using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.UseCases.Cursos.CriarCurso;

public class CriarCursoCommand : ICommand<EntityKeyDto?>
{
    public string Nome { get; set; } = string.Empty;

    public string? NomeComercial { get; set; }

    public Guid ModalidadeKey { get; set; }

    public Guid TipoFormacaoKey { get; set; }

    public Guid NivelCursoKey { get; set; }

    public Guid InstituicaoKey { get; set; }

    public SistemaIntegracaoDto? Integracao { get; set; }
}
